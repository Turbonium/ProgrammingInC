using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8MenusMDIFiles
{
    public partial class ServiceNotesForm : Form
    {
        public ServiceNotesForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemFile_Click(object sender, EventArgs e)
        {
            enableSaveMenuItemIfNoteExists();
        }

        private void toolStripMenuItemFileOpen_Click(object sender, EventArgs e)
        {
            ServiceNoteForm serviceNoteForm = new ServiceNoteForm();
            serviceNoteForm.MdiParent = this;

            OpenFileDialog openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog(this) == DialogResult.OK)
            {
                StreamReader fileReader = new System.IO.StreamReader(openDialog.FileName);
                serviceNoteForm.Text = openDialog.FileName;
                serviceNoteForm.noteText = fileReader.ReadToEnd();
                serviceNoteForm.Show();
                enableSaveMenuItemIfNoteExists();
            }
        }

        private void toolStripMenuItemFileSave_Click(object sender, EventArgs e)
        {
            if (!enableSaveMenuItemIfNoteExists()) return;
            SaveFileDialog saveDialog = new SaveFileDialog();

            if (saveDialog.ShowDialog(this) == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveDialog.FileName);
                if (this.ActiveMdiChild != null)
                {
                    sw.Write((this.ActiveMdiChild as ServiceNoteForm).noteText);
                    sw.Close();
                }
            }
        }

        private void toolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemSearch_Click(object sender, EventArgs e)
        {
            string rawText = null;
            foreach (ServiceNoteForm nf in this.MdiChildren)
            {
                rawText += nf.Text + Environment.NewLine;
            }

            Regex findFilenames = new Regex(@"([a-zA-Z]:)?(\\[.a-zA-Z0-9_-]+)+\\?");

            string result = null;
            if (rawText != null)
            {
                foreach (var fileMatch in findFilenames.Matches(rawText))
                {
                    result += fileMatch + Environment.NewLine;
                }
                MessageBox.Show(result, "Service Notes Found -");
            }

            if (rawText == null) MessageBox.Show("Please Open a service note prior to searching...");
        }

        private void toolStripMenuItemNewNote_Click(object sender, EventArgs e)
        {
            ServiceNoteForm noteForm = new ServiceNoteForm();
            noteForm.MdiParent = this;
            noteForm.Show();
            enableSaveMenuItemIfNoteExists();
        }

        private bool enableSaveMenuItemIfNoteExists()
        {
            toolStripMenuItemFileSave.Enabled = this.ActiveMdiChild != null;
            return toolStripMenuItemFileSave.Enabled;
        }
    }
}
