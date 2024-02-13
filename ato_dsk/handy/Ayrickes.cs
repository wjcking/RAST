using System;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

public partial class ayrickes : Form
{

    public ayrickes()
    {
        InitializeComponent();

        var dpx = erick_screen.dpx;
        var dpy = erick_screen.dpy;

        var desktop_height = erick_screen.desktop.Height;
        var desktop_width = erick_screen.desktop.Width;
        var workarea_height = erick_screen.work_area.Height;
        var workarea_width = erick_screen.work_area.Width;
        var bound_height = erick_screen.bound_height;
        var bound_width = erick_screen.bound_width;
        var name = SystemFonts.DefaultFont.Name;
        var size = SystemFonts.DefaultFont.Size;
        var monitor = desktop_width / dpx;

        textBox1.AppendText("dpx" + Environment.NewLine);
        textBox1.AppendText(dpx + Environment.NewLine);
        textBox1.AppendText(dpy + Environment.NewLine);

        textBox1.AppendText("scale" + Environment.NewLine);
        textBox1.AppendText("scale_x" + erick_screen.scale_x.ToString() + Environment.NewLine);
        textBox1.AppendText("scale_y" + erick_screen.scale_y.ToString() + Environment.NewLine);

        textBox1.AppendText("desktop" + Environment.NewLine);
        textBox1.AppendText(desktop_height + " ");
        textBox1.AppendText(desktop_width + Environment.NewLine);

        textBox1.AppendText("workarea" + Environment.NewLine);
        textBox1.AppendText(workarea_height + " ");
        textBox1.AppendText(workarea_width + Environment.NewLine);

        textBox1.AppendText("bound" + Environment.NewLine);
        textBox1.AppendText(bound_height + " ");
        textBox1.AppendText(bound_width + Environment.NewLine);
        //1 pt = px * 96/72 = px * 4/3
        //Convert.ToString(aryic_screen.bound_width / fontSize));
        //Convert.ToString(aryic_screen.bound_height / fontSize)); 

    }

    public void Draw()
    {
        DoubleBuffered = true;
        var properInfo = dataGridView1.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
        properInfo.SetValue(dataGridView1, true, null);

        for (int t = 0; t < 1920 / 14; t++)
        {
            var header = new DataGridViewTextBoxColumn();
            header.Width = 14 + t.ToString().Length;
            //header.CellTemplate =
            //header.Width = 2 + 14 + 2;
            dataGridView1.Columns.Add(header);

            var row = new DataGridViewRow();
            row.Height = 14 + t.ToString().Length;

            var cell = new DataGridViewLinkCell();
            cell.Value = t;
            row.Cells.Add(cell);

            dataGridView1.Rows.Add(row);
            //dataGridView1.Columns[t]
        }
        dataGridView1.AutoGenerateColumns = true;

    }

    private void Grid_Load(object sender, EventArgs e)
    {
    }

    private void Ayrickes_Shown(object sender, EventArgs e)
    {
        timer1.Enabled = true;
        //fusion_parameter.kondet = auf.reck();
        //auf_green.kolor();
        //auf_blue.kolor();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        //var auv1 = auf.erick.eydix.ToString() + cybert.ace.ToString();
        //var auv2= auf.erick.kondet.ToString() + cybert.ace.ToString();
        //    textBox1.AppendText("notice: " + ayric_cursive.notice+Environment.NewLine);

    }

    private void button_cease_enydex_Click(object sender, EventArgs e)
    {
    }

    private void button_enydex_Click(object sender, EventArgs e)
    {
        //    timer1.Enabled = true;
        //fusion_parameter.kondet = auf.kolor();
    }

    private void loop_acquire_Click(object sender, EventArgs e)
    {
        var span = new Random();
        // fusion_parameter.kondet = 0;
        //do
        //{ 
        //var kaler = auf.kaler(span.Next(16));
        //var reck = auf.reck(span.Next(16));
        //var random =    (span.Next(20)) ;
        //var factorial = auf.factorial(random);
        //textBox1.AppendText("random:" + random      );
        //textBox1.AppendText(" factorial:" + factorial + Environment.NewLine);
        //textBox1.AppendText(" kaler:"+kaler)  ;
        //textBox1.AppendText(" reck:"+reck + Environment.NewLine);
        //}
        //while (fusion_parameter.kondet != 0);
    }
}
