namespace HomeWork_Notepad
{
    partial class FontSettings
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
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.inscription = new System.Windows.Forms.Label();
            this.font = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Label();
            this.ChangeColor = new System.Windows.Forms.Button();
            this.Fonts = new System.Windows.Forms.ListBox();
            this.select_font = new System.Windows.Forms.TextBox();
            this.Inscriptions = new System.Windows.Forms.ListBox();
            this.styles = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.ListBox();
            this.register_name = new System.Windows.Forms.TextBox();
            this.ExampleText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Location = new System.Drawing.Point(345, 356);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(115, 32);
            this.ExampleLabel.TabIndex = 0;
            this.ExampleLabel.Text = "Образец:";
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(695, 52);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(99, 32);
            this.Size.TabIndex = 3;
            this.Size.Text = "Размер:";
            // 
            // inscription
            // 
            this.inscription.AutoSize = true;
            this.inscription.Location = new System.Drawing.Point(311, 52);
            this.inscription.Name = "inscription";
            this.inscription.Size = new System.Drawing.Size(152, 32);
            this.inscription.TabIndex = 6;
            this.inscription.Text = "Начертание:";
            // 
            // font
            // 
            this.font.AutoSize = true;
            this.font.Location = new System.Drawing.Point(26, 52);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(96, 32);
            this.font.TabIndex = 7;
            this.font.Text = "Шрифт:";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(580, 669);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(145, 58);
            this.Save.TabIndex = 10;
            this.Save.Text = "OK";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(741, 669);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(145, 58);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(26, 369);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(73, 32);
            this.Color.TabIndex = 12;
            this.Color.Text = "Цвет:";
            // 
            // ChangeColor
            // 
            this.ChangeColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeColor.Location = new System.Drawing.Point(26, 416);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(272, 43);
            this.ChangeColor.TabIndex = 13;
            this.ChangeColor.Text = "Выбрать цвет";
            this.ChangeColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeColor.UseVisualStyleBackColor = true;
            this.ChangeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // Fonts
            // 
            this.Fonts.FormattingEnabled = true;
            this.Fonts.ItemHeight = 32;
            this.Fonts.Items.AddRange(new object[] {
            "Arial",
            "Arial Black",
            "Comic Sans MS",
            "Courier New",
            "Georgia1\t",
            "Impact",
            "Lucida Console",
            "Lucida Sans Unicode",
            "Tahoma",
            "Times New Roman",
            "Trebuchet MS1",
            "Verdana",
            "Symbol2",
            "Webdings2"});
            this.Fonts.Location = new System.Drawing.Point(26, 138);
            this.Fonts.Name = "Fonts";
            this.Fonts.Size = new System.Drawing.Size(240, 164);
            this.Fonts.TabIndex = 14;
            this.Fonts.SelectedIndexChanged += new System.EventHandler(this.Fonts_SelectedIndexChanged_1);
            // 
            // select_font
            // 
            this.select_font.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.select_font.Location = new System.Drawing.Point(26, 88);
            this.select_font.Name = "select_font";
            this.select_font.Size = new System.Drawing.Size(240, 39);
            this.select_font.TabIndex = 15;
            // 
            // Inscriptions
            // 
            this.Inscriptions.FormattingEnabled = true;
            this.Inscriptions.ItemHeight = 32;
            this.Inscriptions.Items.AddRange(new object[] {
            "обычный",
            "курсив",
            "полужирный",
            "подчеркивание"});
            this.Inscriptions.Location = new System.Drawing.Point(311, 138);
            this.Inscriptions.Name = "Inscriptions";
            this.Inscriptions.Size = new System.Drawing.Size(346, 164);
            this.Inscriptions.TabIndex = 16;
            this.Inscriptions.SelectedIndexChanged += new System.EventHandler(this.inscriptions_SelectedIndexChanged);
            // 
            // styles
            // 
            this.styles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.styles.Location = new System.Drawing.Point(311, 87);
            this.styles.Name = "styles";
            this.styles.Size = new System.Drawing.Size(346, 39);
            this.styles.TabIndex = 17;
            // 
            // Register
            // 
            this.Register.FormattingEnabled = true;
            this.Register.ItemHeight = 32;
            this.Register.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "26",
            "28",
            "30",
            "32"});
            this.Register.Location = new System.Drawing.Point(695, 138);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(151, 164);
            this.Register.TabIndex = 18;
            this.Register.SelectedIndexChanged += new System.EventHandler(this.Register_SelectedIndexChanged);
            // 
            // register_name
            // 
            this.register_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_name.Location = new System.Drawing.Point(695, 87);
            this.register_name.Name = "register_name";
            this.register_name.Size = new System.Drawing.Size(151, 39);
            this.register_name.TabIndex = 19;
            // 
            // ExampleText
            // 
            this.ExampleText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExampleText.BackColor = System.Drawing.SystemColors.Control;
            this.ExampleText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExampleText.Font = new System.Drawing.Font("Segoe UI", 25.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExampleText.Location = new System.Drawing.Point(345, 391);
            this.ExampleText.Name = "ExampleText";
            this.ExampleText.Size = new System.Drawing.Size(519, 248);
            this.ExampleText.TabIndex = 0;
            this.ExampleText.Text = "AaBbYyZz";
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 739);
            this.Controls.Add(this.register_name);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.styles);
            this.Controls.Add(this.Inscriptions);
            this.Controls.Add(this.select_font);
            this.Controls.Add(this.Fonts);
            this.Controls.Add(this.ChangeColor);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.ExampleText);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.font);
            this.Controls.Add(this.inscription);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.ExampleLabel);
            this.Name = "FontSettings";
            this.Text = "Шрифт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ExampleLabel;
        private Label Size;
        private Label inscription;
        private Label font;
        private Button Save;
        private Button Cancel;
        private Button ColorSelect;
        private Label Color;
        private Button ChangeColor;
        private ListBox Fonts;
        private TextBox select_font;
        private ListBox Inscriptions;
        private TextBox styles;
        private ListBox Register;
        private TextBox register_name;
        private RichTextBox ExampleText;
    }
}