using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace HomeWork_Notepad
{
    public partial class AboutTheProgram : Form
    {
        
        public AboutTheProgram()
        {
            InitializeComponent();
        }

        private void AboutTheProgram_Load(object sender, EventArgs e)
        {
            buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
        }

        private void buttonOKClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutTheProgram_Load_1(object sender, EventArgs e)
        {

        }

        private void windowsIcon_Click(object sender, EventArgs e)
        {

        }
    }

}
