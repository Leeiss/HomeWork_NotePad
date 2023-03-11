using System.Drawing.Printing;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeWork_Notepad
{
    public partial class Notepad : Form
    {
        public int fontSize = 8;
        public FontStyle fs = FontStyle.Regular;
        public string text_font = "Segoe UI";
        public string filename;
        public bool isFileChanged;
        public bool ToSave;
        public FontSettings fontset;
        public System.Drawing.Color FontColor;
        public Notepad()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
            fontset = new FontSettings();
        }
        public void CreateNewDocument(object sender, EventArgs e)
        {
            YesNoSaveFile();
            textBox1.Text = "";
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }
        public void OpenFile(object sender, EventArgs e)
        {
            YesNoSaveFile();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog.FileName;
                    isFileChanged = false;

                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл!");
                }
            }
            UpdateTextWithTitle();
        }
        public void SaveFile(string _filename)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (_filename == "")
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_filename);
                sw.Write(textBox1.Text);
                sw.Close();
                filename = _filename;
                isFileChanged = false;

            }
            catch
            {
                MessageBox.Show("Невозможно сохранить данный файл");
            }
            UpdateTextWithTitle();
        }
        public void Save(object sender, EventArgs e)
        {
            SaveFile(filename);
        }
        public void SaveAs(object sender, EventArgs e)
        {
            SaveFile(filename);
        }

       private void OnTextChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                this.Text = this.Text.Replace('*', ' ');
                isFileChanged = true;
                this.Text = "*" + this.Text;
            }

        }
        public void UpdateTextWithTitle()
        {
            if (filename != "")
            {
                this.Text = filename + " - Блокнот";
            }
            else
            {
                this.Text = "Безымянный - Блокнот";
            }
        }
        public void YesNoSaveFile()
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Cохранить изменения в файле?", "Cохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }

        }
        
        public void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

       public void CopyText()
        {
            if (textBox1.SelectedText.Length != 0)
            {
                Clipboard.SetText(textBox1.SelectedText);
            }
            else
            {
                MessageBox.Show("Выделите текст, который хотите скопировать");
            }
            
        }
        public void CutText()
        {
            if (textBox1.SelectedText.Length != 0)
            {
                Clipboard.SetText(textBox1.Text.Substring(textBox1.SelectionStart, textBox1.SelectionLength));
                textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
            }
            else
            {
                MessageBox.Show("Выделите текст, который хотите вырезать");
            }
                
            
        }
        public void PasteText()
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart) + Clipboard.GetText() + textBox1.Text.Substring(textBox1.SelectionStart, textBox1.Text.Length - textBox1.SelectionStart);
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            CopyText();
        }

        private void OnCutClick(object sender, EventArgs e)
        {
            CutText();
        }

        private void OnPasteClick(object sender, EventArgs e)
        {
            PasteText();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            YesNoSaveFile();
        }


        private void OnButtonFontClicked(object sender, EventArgs e)
        {
            fontset = new FontSettings();
            fontset.Show();
        }
        protected virtual void OnButtonInfoAboutProgramClicked(object sender, System.EventArgs e)
        {
            
            AboutTheProgram open_form = new AboutTheProgram();
            open_form.Show();
        }
       private void OnFocus(object sender, EventArgs e)
        {
            if (fontset != null && fontset.ToSave == true)
            {
                fontSize = fontset.fontSize;
                fs = fontset.fs;
                text_font = fontset.text_font;
                FontColor= fontset.FontColor;
                if (textBox1.SelectedText.Length == 0)
                {
                    textBox1.Font = new Font(text_font, fontSize, fs);
                    textBox1.ForeColor = FontColor;
                }
                else
                {
                    textBox1.SelectionFont = new Font(text_font, fontSize, fs);
                    textBox1.SelectionColor = FontColor;
                }
            }
        }
        private void Printer_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); 
        }
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, new Font(text_font, fontSize, fs), Brushes.Black, 0, 0);
        }

        
    }
}
    

