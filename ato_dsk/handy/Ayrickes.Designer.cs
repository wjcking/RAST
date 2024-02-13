
    partial class ayrickes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_cease_enydex = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_enydex = new System.Windows.Forms.Button();
            this.loop_acquire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(638, 305);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(625, 340);
            this.dataGridView1.TabIndex = 85;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(20, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(605, 591);
            this.textBox1.TabIndex = 86;
            this.textBox1.Text = "\r\n\r\n\r\n";
            // 
            // button_cease_enydex
            // 
            this.button_cease_enydex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cease_enydex.Location = new System.Drawing.Point(1008, 687);
            this.button_cease_enydex.Margin = new System.Windows.Forms.Padding(4);
            this.button_cease_enydex.Name = "button_cease_enydex";
            this.button_cease_enydex.Size = new System.Drawing.Size(255, 58);
            this.button_cease_enydex.TabIndex = 87;
            this.button_cease_enydex.Text = "Cease Enydex";
            this.button_cease_enydex.UseVisualStyleBackColor = true;
            this.button_cease_enydex.Click += new System.EventHandler(this.button_cease_enydex_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(636, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 242);
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_enydex
            // 
            this.button_enydex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_enydex.Location = new System.Drawing.Point(733, 687);
            this.button_enydex.Margin = new System.Windows.Forms.Padding(4);
            this.button_enydex.Name = "button_enydex";
            this.button_enydex.Size = new System.Drawing.Size(255, 58);
            this.button_enydex.TabIndex = 89;
            this.button_enydex.Text = "Acquire Enydex";
            this.button_enydex.UseVisualStyleBackColor = true;
            this.button_enydex.Click += new System.EventHandler(this.button_enydex_Click);
            // 
            // loop_acquire
            // 
            this.loop_acquire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loop_acquire.Location = new System.Drawing.Point(396, 687);
            this.loop_acquire.Name = "loop_acquire";
            this.loop_acquire.Size = new System.Drawing.Size(330, 58);
            this.loop_acquire.TabIndex = 90;
            this.loop_acquire.Text = "Loop Acquire";
            this.loop_acquire.UseVisualStyleBackColor = true;
            this.loop_acquire.Click += new System.EventHandler(this.loop_acquire_Click);
            // 
            // Ayrickes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 775);
            this.Controls.Add(this.loop_acquire);
            this.Controls.Add(this.button_enydex);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_cease_enydex);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Ayrickes";
            this.Text = "Ayrickes";
            this.Load += new System.EventHandler(this.Grid_Load);
            this.Shown += new System.EventHandler(this.Ayrickes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_cease_enydex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_enydex;
        private System.Windows.Forms.Button loop_acquire;
    }
