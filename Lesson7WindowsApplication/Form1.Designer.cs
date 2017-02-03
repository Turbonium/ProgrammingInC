namespace Lesson7WindowsApplication
{
    partial class Form1
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
            this.buttonMyFirstButton = new System.Windows.Forms.Button();
            this.textboxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textboxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMyFirstButton
            // 
            this.buttonMyFirstButton.Location = new System.Drawing.Point(0, 0);
            this.buttonMyFirstButton.Name = "buttonMyFirstButton";
            this.buttonMyFirstButton.Size = new System.Drawing.Size(203, 96);
            this.buttonMyFirstButton.TabIndex = 0;
            this.buttonMyFirstButton.Text = "My First Button";
            this.buttonMyFirstButton.UseVisualStyleBackColor = true;
            this.buttonMyFirstButton.Click += new System.EventHandler(this.buttonMyFirstButton_Click);
            // 
            // textboxFirstName
            // 
            this.textboxFirstName.Location = new System.Drawing.Point(258, 152);
            this.textboxFirstName.Name = "textboxFirstName";
            this.textboxFirstName.Size = new System.Drawing.Size(218, 29);
            this.textboxFirstName.TabIndex = 1;
            this.textboxFirstName.Text = "(Enter First Name)";
            this.textboxFirstName.Click += new System.EventHandler(this.textboxFirstName_Click);
            this.textboxFirstName.TextChanged += new System.EventHandler(this.textboxFirstName_TextChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(130, 152);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(106, 25);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name";
            this.labelFirstName.Click += new System.EventHandler(this.labelFirstName_Click);
            // 
            // textboxLastName
            // 
            this.textboxLastName.Location = new System.Drawing.Point(258, 212);
            this.textboxLastName.Name = "textboxLastName";
            this.textboxLastName.Size = new System.Drawing.Size(218, 29);
            this.textboxLastName.TabIndex = 3;
            this.textboxLastName.Text = "(Enter Last Name)";
            this.textboxLastName.Click += new System.EventHandler(this.textboxLastName_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(130, 212);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(106, 25);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonMyFirstButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 432);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textboxLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textboxFirstName);
            this.Controls.Add(this.buttonMyFirstButton);
            this.Name = "Form1";
            this.Text = "Hello!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMyFirstButton;
        private System.Windows.Forms.TextBox textboxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textboxLastName;
        private System.Windows.Forms.Label labelLastName;
    }
}

