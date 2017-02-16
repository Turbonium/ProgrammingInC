using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8MenusMDIFiles
{
    public partial class ServiceNoteForm : Form
    {
        public ServiceNoteForm()
        {
            InitializeComponent();
        }

        internal string noteText
        {
            get
            {
                return textBoxServiceNote.Text;
            }
            set
            {
                textBoxServiceNote.Text = value;
            }
        }
    }
}
