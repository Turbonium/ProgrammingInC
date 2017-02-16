namespace Lesson8MenusMDIFiles
{
    partial class ServiceNoteForm
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
            this.textBoxServiceNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxServiceNote
            // 
            this.textBoxServiceNote.AcceptsReturn = true;
            this.textBoxServiceNote.AcceptsTab = true;
            this.textBoxServiceNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxServiceNote.Location = new System.Drawing.Point(0, 0);
            this.textBoxServiceNote.Multiline = true;
            this.textBoxServiceNote.Name = "textBoxServiceNote";
            this.textBoxServiceNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxServiceNote.Size = new System.Drawing.Size(284, 261);
            this.textBoxServiceNote.TabIndex = 0;
            // 
            // ServiceNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxServiceNote);
            this.Name = "ServiceNoteForm";
            this.Text = "Service Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServiceNote;
    }
}