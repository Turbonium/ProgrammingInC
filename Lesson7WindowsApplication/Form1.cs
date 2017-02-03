using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7WindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Event Procedure, aka Event handler
        private void buttonMyFirstButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format($"Hello {textboxFirstName.Text} {textboxLastName.Text}"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textboxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }
        private void textboxFirstName_Click(object sender, EventArgs e)
        {
            textboxFirstName.SelectAll();
        }
        private void textboxLastName_Click(object sender, EventArgs e)
        {
            textboxLastName.SelectAll();
        }
    }
}
