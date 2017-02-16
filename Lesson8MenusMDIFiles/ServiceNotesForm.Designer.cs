namespace Lesson8MenusMDIFiles
{
    partial class ServiceNotesForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNewNote = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNewNote,
            this.toolStripMenuItemFileOpen,
            this.toolStripMenuItemFileSave,
            this.toolStripMenuItemFileExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "&File";
            this.toolStripMenuItemFile.Click += new System.EventHandler(this.toolStripMenuItemFile_Click);
            // 
            // toolStripMenuItemNewNote
            // 
            this.toolStripMenuItemNewNote.Name = "toolStripMenuItemNewNote";
            this.toolStripMenuItemNewNote.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItemNewNote.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemNewNote.Text = "New &Note";
            this.toolStripMenuItemNewNote.Click += new System.EventHandler(this.toolStripMenuItemNewNote_Click);
            // 
            // toolStripMenuItemFileOpen
            // 
            this.toolStripMenuItemFileOpen.Name = "toolStripMenuItemFileOpen";
            this.toolStripMenuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItemFileOpen.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemFileOpen.Text = "&Open";
            this.toolStripMenuItemFileOpen.Click += new System.EventHandler(this.toolStripMenuItemFileOpen_Click);
            // 
            // toolStripMenuItemFileSave
            // 
            this.toolStripMenuItemFileSave.Name = "toolStripMenuItemFileSave";
            this.toolStripMenuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItemFileSave.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemFileSave.Text = "&Save";
            this.toolStripMenuItemFileSave.Click += new System.EventHandler(this.toolStripMenuItemFileSave_Click);
            // 
            // toolStripMenuItemFileExit
            // 
            this.toolStripMenuItemFileExit.Name = "toolStripMenuItemFileExit";
            this.toolStripMenuItemFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItemFileExit.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItemFileExit.Text = "E&xit";
            this.toolStripMenuItemFileExit.Click += new System.EventHandler(this.toolStripMenuItemFileExit_Click);
            // 
            // toolStripMenuItemSearch
            // 
            this.toolStripMenuItemSearch.Name = "toolStripMenuItemSearch";
            this.toolStripMenuItemSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItemSearch.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemSearch.Text = "S&earch";
            this.toolStripMenuItemSearch.Click += new System.EventHandler(this.toolStripMenuItemSearch_Click);
            // 
            // ServiceNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 487);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ServiceNotesForm";
            this.Text = "ServiceNotesForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewNote;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearch;
    }
}