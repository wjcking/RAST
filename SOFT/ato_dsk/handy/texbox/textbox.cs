using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


/// <summary>
/// Extension of TextBox that has placeholder functionality and allows for retrieving and setting the caret position.
/// </summary>
public class textbox : TextBox
{

[DllImport("User32.dll", CharSet = CharSet.Auto)]
private static extern IntPtr SendMessage(IntPtr h, int msg, int wParam, uint[] lParam);
private const int EM_SETTABSTOPS = 0x00CB;

private void InitialiseTabStops()
{
    // Declare relative tab stops in character widths
    var tabs = new uint[] { 2, 2, 4, 8, 2, 32 };

    // Convert from character width to 1/4 character width
    for (int position = 0; position < tabs.Length; position++)
        tabs[position] *= 4;

    // Convert from relative to absolute positions
    for (int position = 1; position < tabs.Length; position++)
        tabs[position] += tabs[position - 1];

    SendMessage(Handle, EM_SETTABSTOPS, tabs.Length, tabs);
}

    private EventHandler mGotFocus;
    private EventHandler mLostFocus;
    private EventHandler mTextChanged;
    private bool mPlaceholderActive = true;
    private bool mFromOwnTextChange = false;
    private string mPlaceholder = string.Empty;
    private Color mPlaceholderColor = Color.Empty;
    private Color mOriginalForeColor = Color.Empty;

    public textbox() : base() { }

    #region Designer
    private bool IsDesignerHosted
    {
        get
        {
            if (DesignMode) return DesignMode;
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return true;
            return Process.GetCurrentProcess().ProcessName == "devenv";
        }
    }
    #endregion

    #region Caret setting
    public void MoveCaret(int line, int column)
    {
        if (line < 0 || column < 0 || Lines.Length < line || Text.Length < column)
        {
            return;
        }
        SelectionStart = GetFirstCharIndexFromLine(line) + column;
        SelectionLength = 0;
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int CaretColumn
    {
        get { return SelectionStart - GetFirstCharIndexOfCurrentLine(); }
        set
        {
            SelectionStart = CaretLine + value;
            SelectionLength = 0;
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int CaretLine
    {
        get { return GetLineFromCharIndex(SelectionStart); }
        set
        {
            SelectionStart = GetFirstCharIndexFromLine(value);
            SelectionLength = 0;
        }
    }
    #endregion

    #region Placeholder
    public new event EventHandler GotFocus
    {
        add { mGotFocus += value; }
        remove { mGotFocus -= value; }
    }

    public new event EventHandler LostFocus
    {
        add { mLostFocus += value; }
        remove { mLostFocus -= value; }
    }

    public new event EventHandler TextChanged
    {
        add { mTextChanged += value; }
        remove { mTextChanged -= value; }
    }

    private bool PreventPlaceholderUse
    {
        get { return IsDesignerHosted || !UsePlaceholder; }
    }

    public new string Text
    {
        get
        {
            if (PreventPlaceholderUse) return base.Text;
            if (mPlaceholderActive) return string.Empty;
            return base.Text;
        }
        set
        {
            if (PreventPlaceholderUse)
            {
                base.Text = value;
                return;
            }

            if (UsePlaceholder)
            {
                mPlaceholderActive = string.IsNullOrEmpty(value);
                if (mPlaceholderActive) UpdateBox(mPlaceholderColor, Placeholder);
                else UpdateBox(mOriginalForeColor, value);
            }
            base.Text = value;
        }
    }

    [Description("The text of the control's placeholder.")]
    [Category("Appearance")]
    public string Placeholder
    {
        get { return mPlaceholder; }
        set
        {
            mPlaceholder = value;
            if (!PreventPlaceholderUse && mPlaceholderActive && !Focused) base.Text = mPlaceholder;
        }
    }

    [Description("The color of the control's placeholder.")]
    [Category("Appearance")]
    public Color PlaceholderColor
    {
        get { return mPlaceholderColor; }
        set
        {
            mPlaceholderColor = value;
            if (!PreventPlaceholderUse && mPlaceholderActive && !Focused) base.ForeColor = mPlaceholderColor;
        }
    }

    [Description("Indicates if the control should use a placeholder.")]
    [Category("Appearance")]
    public bool UsePlaceholder { get; set; }

    private void CaptureGotFocus(object sender, EventArgs e)
    {
        if (mGotFocus != null) mGotFocus(sender, e);
    }

    private void CaptureLostFocus(object sender, EventArgs e)
    {
        if (mLostFocus != null) mLostFocus(sender, e);
    }

    private void CaptureTextChanged(object sender, EventArgs e)
    {
        if (mTextChanged != null) mTextChanged(sender, e);
    }

    private void OnFocus(object sender, EventArgs e)
    {
        if (mPlaceholderActive) UpdateBox(mOriginalForeColor, string.Empty);
    }

    private void OnBlur(object sender, EventArgs e)
    {
        mPlaceholderActive = string.IsNullOrEmpty(base.Text);
        if (mPlaceholderActive) UpdateBox(mPlaceholderColor, Placeholder);
    }

    private void OnTextChanged(object sender, EventArgs e)
    {
        if (mFromOwnTextChange) return;
        mPlaceholderActive = string.IsNullOrEmpty(base.Text);
    }

    private void UpdateBox(Color foregroundColor, string text)
    {
        base.ForeColor = foregroundColor;
        mFromOwnTextChange = true;
        base.Text = text;
        mFromOwnTextChange = false;
    }
    #endregion

    protected override void InitLayout()
    {

        InitialiseTabStops();
        base.GotFocus += new EventHandler(CaptureGotFocus);
        base.LostFocus += new EventHandler(CaptureLostFocus);
        base.TextChanged += new EventHandler(CaptureTextChanged);

        if (PreventPlaceholderUse)
        {
            mPlaceholderActive = false;
            return;
        }

        mOriginalForeColor = ForeColor;
        ForeColor = PlaceholderColor;
        base.Text = Placeholder;
        GotFocus += new EventHandler(OnFocus);
        LostFocus += new EventHandler(OnBlur);
        TextChanged += new EventHandler(OnTextChanged);

        drag_event();
        base.InitLayout(); 
    }

    private void InitializeComponent()
    {
        this.SuspendLayout();
        this.ResumeLayout(false);

    }
    public void drag_event()
    {
        base.AllowDrop = true;
        base.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxExtended_DragDrop);
        base.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxExtended_DragEnter);
    }
    public void TextBoxExtended_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.All;
    }

    public void TextBoxExtended_DragDrop(object sender, DragEventArgs e)
    {
        Text = (e.Data.GetData(DataFormats.UnicodeText)).ToString();
    }
    //public static int spaces = 4;
    //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    //{
    //    //if (keyData == Keys.Tab)
    //    //{
    //    //    this.SelectionLength = 0;
    //    //    this.SelectedText = new string(' ', spaces);
    //    //    return true;
    //    //}

    //    if (keyData == Keys.Enter)
    //    {
    //        this.AppendText(new string('\n', 1));
    //        this.AppendText(new string(' ', spaces));

    //        return true;
    //    }
    //    return base.ProcessCmdKey(ref msg, keyData); 
    //}
    //protected override void OnKeyDown(KeyEventArgs e)
    //{

    //    if (e.KeyCode == Keys.Enter)
    //    {
    //        this.Text += Environment.NewLine;
    //        this.Text += new string(' ', spaces);
    //        this.SelectionStart = this.Text.Length;
    //    }

    //    base.OnKeyDown(e);
    //}
}
