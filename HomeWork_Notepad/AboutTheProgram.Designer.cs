namespace HomeWork_Notepad
{
    partial class AboutTheProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutTheProgram));
            this.buttonOK = new System.Windows.Forms.Button();
            this.notepad = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.windowsIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.AllowDrop = true;
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.AutoSize = true;
            this.buttonOK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOK.Location = new System.Drawing.Point(777, 689);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(143, 44);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOKClick);
            // 
            // notepad
            // 
            this.notepad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notepad.BackColor = System.Drawing.SystemColors.Control;
            this.notepad.Image = ((System.Drawing.Image)(resources.GetObject("notepad.Image")));
            this.notepad.Location = new System.Drawing.Point(83, 229);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(0, 0);
            this.notepad.TabIndex = 2;
            this.notepad.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 57);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 480);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(317, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 102);
            this.label2.TabIndex = 8;
            this.label2.Text = "Windows10";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(40, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 2);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // windowsIcon
            // 
            this.windowsIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsIcon.Image = ((System.Drawing.Image)(resources.GetObject("windowsIcon.Image")));
            this.windowsIcon.Location = new System.Drawing.Point(190, 37);
            this.windowsIcon.Name = "windowsIcon";
            this.windowsIcon.Size = new System.Drawing.Size(112, 107);
            this.windowsIcon.TabIndex = 4;
            this.windowsIcon.TabStop = false;
            this.windowsIcon.Click += new System.EventHandler(this.windowsIcon_Click);
            // 
            // AboutTheProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 755);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.windowsIcon);
            this.Controls.Add(this.notepad);
            this.MaximumSize = new System.Drawing.Size(968, 826);
            this.MinimumSize = new System.Drawing.Size(968, 826);
            this.Name = "AboutTheProgram";
            this.Text = "Блокнот: сведения";
            this.Click += new System.EventHandler(this.buttonOKClick);
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonOK;
        private PictureBox notepad;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        public PictureBox windowsIcon;
    }
}