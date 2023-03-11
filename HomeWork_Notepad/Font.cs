using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeWork_Notepad
{
    public partial class FontSettings : Form
    {
        public int fontSize = 8;
        public string text_font = "Segoe UI";
        public FontStyle fs = FontStyle.Regular;
        public FontSettings fontset;
        public bool ToSave;
        public System.Drawing.Color FontColor;


        public FontSettings()
        {
            InitializeComponent();
            Register.SelectedItem = Register.Items[0];
            Inscriptions.SelectedItem = Inscriptions.Items[0];
            Fonts.SelectedItem = Fonts.Items[0];
        }
        private void Save_Click(object sender, EventArgs e)
        {
            ToSave = true;
            Close(); 

        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            ToSave = false;
            Hide();
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            col.ShowDialog();
            ExampleText.SelectionColor = col.Color;
            FontColor = col.Color;
            ExampleText.ForeColor = FontColor;
        }

        private void Fonts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            select_font.Text = Fonts.SelectedItem.ToString();
            ExampleText.Font = new Font(Fonts.SelectedItem.ToString(), int.Parse(Register.SelectedItem.ToString()), ExampleText.Font.Style);
            text_font = Fonts.SelectedItem.ToString();
        }

       private void inscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            styles.Text = Inscriptions.SelectedItem.ToString();
            Inscriptions.SelectedIndex = Inscriptions.FindString(styles.Text);
            switch (Inscriptions.SelectedItem.ToString())
            {
                case "обычный":
                    {
                        ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(Register.SelectedItem.ToString()), FontStyle.Regular); 
                        break;
                    }
                case "курсив":
                    {
                        ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(Register.SelectedItem.ToString()), FontStyle.Italic);
                        break;
                    }
                case "полужирный":
                    {
                        ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(Register.SelectedItem.ToString()), FontStyle.Bold);
                        break;
                    }
                case "подчеркивание":
                    {
                        ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(Register.SelectedItem.ToString()), FontStyle.Underline);
                        break;
                    }
            }
            fs = ExampleText.Font.Style;
        }
       
        private void Register_SelectedIndexChanged(object sender, EventArgs e)
        {
            register_name.Text = Register.SelectedItem.ToString();
            ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(Register.SelectedItem.ToString()), ExampleText.Font.Style);
            fontSize = int.Parse(Register.SelectedItem.ToString());
                
        }
                
    }
                
    
}


