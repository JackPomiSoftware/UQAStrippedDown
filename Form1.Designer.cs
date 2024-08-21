namespace UAC_Fast_Access
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.warn = new System.Windows.Forms.PictureBox();
            this.labelL3T = new System.Windows.Forms.Label();
            this.labelL3 = new System.Windows.Forms.Label();
            this.labelL2T = new System.Windows.Forms.Label();
            this.labelL2 = new System.Windows.Forms.Label();
            this.labelL1T = new System.Windows.Forms.Label();
            this.labelL1 = new System.Windows.Forms.Label();
            this.labelL0T = new System.Windows.Forms.Label();
            this.labelL0 = new System.Windows.Forms.Label();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.Slider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.warn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // warn
            // 
            this.warn.Image = ((System.Drawing.Image)(resources.GetObject("warn.Image")));
            this.warn.Location = new System.Drawing.Point(66, 61);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(16, 16);
            this.warn.TabIndex = 27;
            this.warn.TabStop = false;
            this.warn.Visible = false;
            // 
            // labelL3T
            // 
            this.labelL3T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelL3T.AutoSize = true;
            this.labelL3T.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL3T.Location = new System.Drawing.Point(82, 36);
            this.labelL3T.Name = "labelL3T";
            this.labelL3T.Size = new System.Drawing.Size(316, 65);
            this.labelL3T.TabIndex = 26;
            this.labelL3T.Text = resources.GetString("labelL3T.Text");
            this.labelL3T.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelL3
            // 
            this.labelL3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelL3.AutoSize = true;
            this.labelL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL3.Location = new System.Drawing.Point(82, 13);
            this.labelL3.Name = "labelL3";
            this.labelL3.Size = new System.Drawing.Size(171, 13);
            this.labelL3.TabIndex = 25;
            this.labelL3.Text = "Level 3: UAC is fully enabled";
            this.labelL3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelL2T
            // 
            this.labelL2T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelL2T.AutoSize = true;
            this.labelL2T.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL2T.Location = new System.Drawing.Point(82, 36);
            this.labelL2T.Name = "labelL2T";
            this.labelL2T.Size = new System.Drawing.Size(312, 52);
            this.labelL2T.TabIndex = 24;
            this.labelL2T.Text = "User Account Control will trigger only for programs that require its \r\npermission" +
    ". The screen will become dark when UAC is triggered.\r\n\r\nThis is the default sett" +
    "ing in Windows 7 and later.";
            this.labelL2T.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelL2
            // 
            this.labelL2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelL2.AutoSize = true;
            this.labelL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL2.Location = new System.Drawing.Point(82, 13);
            this.labelL2.Name = "labelL2";
            this.labelL2.Size = new System.Drawing.Size(136, 13);
            this.labelL2.TabIndex = 23;
            this.labelL2.Text = "Level 2: Programs only";
            this.labelL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelL1T
            // 
            this.labelL1T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelL1T.AutoSize = true;
            this.labelL1T.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL1T.Location = new System.Drawing.Point(82, 36);
            this.labelL1T.Name = "labelL1T";
            this.labelL1T.Size = new System.Drawing.Size(312, 26);
            this.labelL1T.TabIndex = 22;
            this.labelL1T.Text = "User Account Control will trigger only for programs that require its \r\npermission" +
    ". In this level, there is no screen darkening.";
            this.labelL1T.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelL1
            // 
            this.labelL1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelL1.AutoSize = true;
            this.labelL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL1.Location = new System.Drawing.Point(82, 13);
            this.labelL1.Name = "labelL1";
            this.labelL1.Size = new System.Drawing.Size(260, 13);
            this.labelL1.TabIndex = 21;
            this.labelL1.Text = "Level 1: Programs only, no screen darkening";
            this.labelL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelL0T
            // 
            this.labelL0T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelL0T.AutoSize = true;
            this.labelL0T.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL0T.Location = new System.Drawing.Point(82, 36);
            this.labelL0T.Name = "labelL0T";
            this.labelL0T.Size = new System.Drawing.Size(313, 65);
            this.labelL0T.TabIndex = 19;
            this.labelL0T.Text = "User Account Control won\'t bother you at all.\r\n\r\nBut be aware that your computer " +
    "may become vunerable to \r\nmalware and viruses. Jack Pomi Software is NOT respons" +
    "ible for \r\nany of your actions.";
            this.labelL0T.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelL0
            // 
            this.labelL0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelL0.AutoSize = true;
            this.labelL0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL0.Location = new System.Drawing.Point(82, 13);
            this.labelL0.Name = "labelL0";
            this.labelL0.Size = new System.Drawing.Size(237, 13);
            this.labelL0.TabIndex = 18;
            this.labelL0.Text = "Level 0: User Account Control turned off";
            this.labelL0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.BackColor = System.Drawing.Color.Transparent;
            this.linkHelp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkHelp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.linkHelp.Location = new System.Drawing.Point(81, 109);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(153, 13);
            this.linkHelp.TabIndex = 17;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "What is User Account Control?";
            this.linkHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // buttonApply
            // 
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(240, 104);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(321, 104);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Slider
            // 
            this.Slider.BackColor = System.Drawing.Color.White;
            this.Slider.LargeChange = 1;
            this.Slider.Location = new System.Drawing.Point(12, 12);
            this.Slider.Maximum = 3;
            this.Slider.Name = "Slider";
            this.Slider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Slider.Size = new System.Drawing.Size(45, 111);
            this.Slider.TabIndex = 0;
            this.Slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Slider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(408, 135);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.labelL0T);
            this.Controls.Add(this.labelL1T);
            this.Controls.Add(this.labelL2T);
            this.Controls.Add(this.labelL3T);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelL3);
            this.Controls.Add(this.labelL2);
            this.Controls.Add(this.labelL1);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelL0);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.Slider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UQA StrippedDown";
            ((System.ComponentModel.ISupportInitialize)(this.warn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TrackBar Slider;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.Label labelL0;
        private System.Windows.Forms.Label labelL0T;
        private System.Windows.Forms.Label labelL1T;
        private System.Windows.Forms.Label labelL1;
        private System.Windows.Forms.Label labelL2T;
        private System.Windows.Forms.Label labelL2;
        private System.Windows.Forms.Label labelL3T;
        private System.Windows.Forms.Label labelL3;
        private System.Windows.Forms.PictureBox warn;
    }
}

