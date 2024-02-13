
    partial class entrike
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxExtended1 = new textbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 150;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(22, 82);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 151);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxExtended1
            // 
            this.textBoxExtended1.Location = new System.Drawing.Point(22, 242);
            this.textBoxExtended1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxExtended1.Multiline = true;
            this.textBoxExtended1.Name = "textBoxExtended1";
            this.textBoxExtended1.Placeholder = "";
            this.textBoxExtended1.PlaceholderColor = System.Drawing.Color.Empty;
            this.textBoxExtended1.Size = new System.Drawing.Size(952, 540);
            this.textBoxExtended1.TabIndex = 4;
            this.textBoxExtended1.UsePlaceholder = false;
            // 
            // entrike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 1054);
            this.Controls.Add(this.textBoxExtended1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "entrike";
            this.Text = "Elyick";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Elyick_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private textbox textBoxExtended1;
    }