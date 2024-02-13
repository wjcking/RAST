
    partial class carowlet
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carowlet));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxExtended1 = new textbox();
            this.textBox2 = new textbox();
            this.textBox1 = new textbox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(821, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 56);
            this.button1.TabIndex = 61;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(821, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 53);
            this.button2.TabIndex = 63;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxExtended1
            // 
            this.textBoxExtended1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtended1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxExtended1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxExtended1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxExtended1.Location = new System.Drawing.Point(754, 15);
            this.textBoxExtended1.Multiline = true;
            this.textBoxExtended1.Name = "textBoxExtended1";
            this.textBoxExtended1.Placeholder = "";
            this.textBoxExtended1.PlaceholderColor = System.Drawing.Color.Empty;
            this.textBoxExtended1.Size = new System.Drawing.Size(61, 484);
            this.textBoxExtended1.TabIndex = 62;
            this.textBoxExtended1.Text = resources.GetString("textBoxExtended1.Text");
            this.textBoxExtended1.UsePlaceholder = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(10, 15);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Placeholder = "";
            this.textBox2.PlaceholderColor = System.Drawing.Color.Empty;
            this.textBox2.Size = new System.Drawing.Size(61, 484);
            this.textBox2.TabIndex = 60;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.UsePlaceholder = false;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.AllowDrop = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(77, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Placeholder = "Please input as some text";
            this.textBox1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(671, 484);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.UsePlaceholder = false;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Komet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 511);
            this.Controls.Add(this.button2);
 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Komet";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Komet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private textbox textBox1;
        private textbox textBox2;
        private System.Windows.Forms.Button button1;
        private textbox textBoxExtended1;
        private System.Windows.Forms.Button button2;
    }

