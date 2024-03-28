namespace AngelLayout
{
    partial class Symbolics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Display = new System.Windows.Forms.Button();
            this.list_method = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // text_input
            // 
            this.text_input.Location = new System.Drawing.Point(61, 40);
            this.text_input.Multiline = true;
            this.text_input.Name = "text_input";
            this.text_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_input.Size = new System.Drawing.Size(425, 69);
            this.text_input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "letters:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "displayed:";
            // 
            // Btn_Display
            // 
            this.Btn_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Display.Location = new System.Drawing.Point(411, 173);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(75, 23);
            this.Btn_Display.TabIndex = 4;
            this.Btn_Display.Text = "display";
            this.Btn_Display.UseVisualStyleBackColor = true;
            this.Btn_Display.Click += new System.EventHandler(this.Btn_Display_Click);
            // 
            // list_method
            // 
            this.list_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_method.FormattingEnabled = true;
            this.list_method.Location = new System.Drawing.Point(264, 126);
            this.list_method.Name = "list_method";
            this.list_method.Size = new System.Drawing.Size(222, 20);
            this.list_method.TabIndex = 5;
            // 
            // Symbolics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 208);
            this.Controls.Add(this.list_method);
            this.Controls.Add(this.Btn_Display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_input);
            this.Name = "Symbolics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symbolics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Display;
        private System.Windows.Forms.ComboBox list_method;
    }
}