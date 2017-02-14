namespace Lesson7WindowsContainerControls
{
    partial class SodaVendingMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SodaVendingMachine));
            this.labelInsertCoins = new System.Windows.Forms.Label();
            this.labelSodaCost = new System.Windows.Forms.Label();
            this.labelTotalAmountInserted = new System.Windows.Forms.Label();
            this.buttonCoinReturn = new System.Windows.Forms.Button();
            this.buttonNickel = new System.Windows.Forms.Button();
            this.buttonRegular = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonDime = new System.Windows.Forms.Button();
            this.buttonQuarter = new System.Windows.Forms.Button();
            this.buttonHalfDollar = new System.Windows.Forms.Button();
            this.labelInsertedDisplay = new System.Windows.Forms.Label();
            this.pictureYellow = new System.Windows.Forms.PictureBox();
            this.pictureOrange = new System.Windows.Forms.PictureBox();
            this.pictureRegular = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVend = new System.Windows.Forms.TabPage();
            this.tabService = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegular)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabVend.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInsertCoins
            // 
            this.labelInsertCoins.AutoSize = true;
            this.labelInsertCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsertCoins.Location = new System.Drawing.Point(6, 16);
            this.labelInsertCoins.Name = "labelInsertCoins";
            this.labelInsertCoins.Size = new System.Drawing.Size(229, 16);
            this.labelInsertCoins.TabIndex = 0;
            this.labelInsertCoins.Text = "Please Insert Coins for a Can of Soda";
            this.labelInsertCoins.Click += new System.EventHandler(this.labelInsertCoins_Click);
            // 
            // labelSodaCost
            // 
            this.labelSodaCost.AutoSize = true;
            this.labelSodaCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSodaCost.Location = new System.Drawing.Point(262, 17);
            this.labelSodaCost.Name = "labelSodaCost";
            this.labelSodaCost.Size = new System.Drawing.Size(152, 15);
            this.labelSodaCost.TabIndex = 1;
            this.labelSodaCost.Text = "Cost of a Soda is 35 Cents.";
            this.labelSodaCost.Click += new System.EventHandler(this.labelSodaCost_Click);
            // 
            // labelTotalAmountInserted
            // 
            this.labelTotalAmountInserted.AutoSize = true;
            this.labelTotalAmountInserted.Location = new System.Drawing.Point(262, 42);
            this.labelTotalAmountInserted.Name = "labelTotalAmountInserted";
            this.labelTotalAmountInserted.Size = new System.Drawing.Size(114, 13);
            this.labelTotalAmountInserted.TabIndex = 2;
            this.labelTotalAmountInserted.Text = "Total Amount Inserted:";
            this.labelTotalAmountInserted.Click += new System.EventHandler(this.labelTotalAmountInserted_Click);
            // 
            // buttonCoinReturn
            // 
            this.buttonCoinReturn.Location = new System.Drawing.Point(437, 42);
            this.buttonCoinReturn.Name = "buttonCoinReturn";
            this.buttonCoinReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonCoinReturn.TabIndex = 6;
            this.buttonCoinReturn.Text = "Coin Return";
            this.buttonCoinReturn.UseVisualStyleBackColor = true;
            this.buttonCoinReturn.Click += new System.EventHandler(this.buttonCoinReturn_Click);
            // 
            // buttonNickel
            // 
            this.buttonNickel.Location = new System.Drawing.Point(9, 92);
            this.buttonNickel.Name = "buttonNickel";
            this.buttonNickel.Size = new System.Drawing.Size(75, 23);
            this.buttonNickel.TabIndex = 7;
            this.buttonNickel.Text = "Nickel";
            this.buttonNickel.UseVisualStyleBackColor = true;
            this.buttonNickel.Click += new System.EventHandler(this.buttonNickel_Click);
            // 
            // buttonRegular
            // 
            this.buttonRegular.Location = new System.Drawing.Point(130, 550);
            this.buttonRegular.Name = "buttonRegular";
            this.buttonRegular.Size = new System.Drawing.Size(75, 23);
            this.buttonRegular.TabIndex = 8;
            this.buttonRegular.Text = "Regular";
            this.buttonRegular.UseVisualStyleBackColor = true;
            this.buttonRegular.Click += new System.EventHandler(this.buttonRegular_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.Location = new System.Drawing.Point(393, 550);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(75, 23);
            this.buttonOrange.TabIndex = 9;
            this.buttonOrange.Text = "Orange";
            this.buttonOrange.UseVisualStyleBackColor = true;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.Location = new System.Drawing.Point(648, 550);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(75, 23);
            this.buttonYellow.TabIndex = 10;
            this.buttonYellow.Text = "Lemon";
            this.buttonYellow.UseVisualStyleBackColor = true;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonDime
            // 
            this.buttonDime.Location = new System.Drawing.Point(87, 92);
            this.buttonDime.Name = "buttonDime";
            this.buttonDime.Size = new System.Drawing.Size(75, 23);
            this.buttonDime.TabIndex = 11;
            this.buttonDime.Text = "Dime";
            this.buttonDime.UseVisualStyleBackColor = true;
            this.buttonDime.Click += new System.EventHandler(this.buttonDime_Click);
            // 
            // buttonQuarter
            // 
            this.buttonQuarter.Location = new System.Drawing.Point(168, 92);
            this.buttonQuarter.Name = "buttonQuarter";
            this.buttonQuarter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuarter.TabIndex = 12;
            this.buttonQuarter.Text = "Quarter";
            this.buttonQuarter.UseVisualStyleBackColor = true;
            this.buttonQuarter.Click += new System.EventHandler(this.buttonQuarter_Click);
            // 
            // buttonHalfDollar
            // 
            this.buttonHalfDollar.Location = new System.Drawing.Point(249, 92);
            this.buttonHalfDollar.Name = "buttonHalfDollar";
            this.buttonHalfDollar.Size = new System.Drawing.Size(75, 23);
            this.buttonHalfDollar.TabIndex = 13;
            this.buttonHalfDollar.Text = "Half Dollar";
            this.buttonHalfDollar.UseVisualStyleBackColor = true;
            this.buttonHalfDollar.Click += new System.EventHandler(this.buttonHalfDollar_Click);
            // 
            // labelInsertedDisplay
            // 
            this.labelInsertedDisplay.AutoSize = true;
            this.labelInsertedDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInsertedDisplay.Location = new System.Drawing.Point(399, 42);
            this.labelInsertedDisplay.Name = "labelInsertedDisplay";
            this.labelInsertedDisplay.Size = new System.Drawing.Size(15, 15);
            this.labelInsertedDisplay.TabIndex = 15;
            this.labelInsertedDisplay.Text = "0";
            this.labelInsertedDisplay.Click += new System.EventHandler(this.labelInsertedDisplay_Click);
            // 
            // pictureYellow
            // 
            this.pictureYellow.Image = global::Lesson7WindowsContainerControls.Properties.Resources.Lemon1;
            this.pictureYellow.InitialImage = null;
            this.pictureYellow.Location = new System.Drawing.Point(570, 183);
            this.pictureYellow.Name = "pictureYellow";
            this.pictureYellow.Size = new System.Drawing.Size(217, 361);
            this.pictureYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureYellow.TabIndex = 5;
            this.pictureYellow.TabStop = false;
            this.pictureYellow.Click += new System.EventHandler(this.pictureYellow_Click);
            // 
            // pictureOrange
            // 
            this.pictureOrange.Image = global::Lesson7WindowsContainerControls.Properties.Resources.Orange;
            this.pictureOrange.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureOrange.InitialImage")));
            this.pictureOrange.Location = new System.Drawing.Point(302, 183);
            this.pictureOrange.Name = "pictureOrange";
            this.pictureOrange.Size = new System.Drawing.Size(243, 361);
            this.pictureOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureOrange.TabIndex = 4;
            this.pictureOrange.TabStop = false;
            this.pictureOrange.Click += new System.EventHandler(this.pictureOrange_Click);
            // 
            // pictureRegular
            // 
            this.pictureRegular.Image = global::Lesson7WindowsContainerControls.Properties.Resources.Regular;
            this.pictureRegular.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureRegular.InitialImage")));
            this.pictureRegular.Location = new System.Drawing.Point(58, 183);
            this.pictureRegular.Name = "pictureRegular";
            this.pictureRegular.Size = new System.Drawing.Size(221, 361);
            this.pictureRegular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureRegular.TabIndex = 3;
            this.pictureRegular.TabStop = false;
            this.pictureRegular.Click += new System.EventHandler(this.pictureRegular_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVend);
            this.tabControl1.Controls.Add(this.tabService);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 654);
            this.tabControl1.TabIndex = 16;
            // 
            // tabVend
            // 
            this.tabVend.Controls.Add(this.labelInsertedDisplay);
            this.tabVend.Controls.Add(this.buttonCoinReturn);
            this.tabVend.Controls.Add(this.buttonRegular);
            this.tabVend.Controls.Add(this.labelInsertCoins);
            this.tabVend.Controls.Add(this.buttonNickel);
            this.tabVend.Controls.Add(this.buttonYellow);
            this.tabVend.Controls.Add(this.buttonOrange);
            this.tabVend.Controls.Add(this.buttonHalfDollar);
            this.tabVend.Controls.Add(this.pictureYellow);
            this.tabVend.Controls.Add(this.pictureRegular);
            this.tabVend.Controls.Add(this.labelSodaCost);
            this.tabVend.Controls.Add(this.pictureOrange);
            this.tabVend.Controls.Add(this.buttonDime);
            this.tabVend.Controls.Add(this.labelTotalAmountInserted);
            this.tabVend.Controls.Add(this.buttonQuarter);
            this.tabVend.Location = new System.Drawing.Point(4, 22);
            this.tabVend.Name = "tabVend";
            this.tabVend.Padding = new System.Windows.Forms.Padding(3);
            this.tabVend.Size = new System.Drawing.Size(914, 628);
            this.tabVend.TabIndex = 0;
            this.tabVend.Text = "Vend";
            this.tabVend.UseVisualStyleBackColor = true;
            // 
            // tabService
            // 
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(3);
            this.tabService.Size = new System.Drawing.Size(914, 628);
            this.tabService.TabIndex = 1;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // SodaVendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 678);
            this.Controls.Add(this.tabControl1);
            this.Name = "SodaVendingMachine";
            this.Text = "SodaVendingMachine";
            this.Load += new System.EventHandler(this.SodaVendingMachine_load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegular)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabVend.ResumeLayout(false);
            this.tabVend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInsertCoins;
        private System.Windows.Forms.Label labelSodaCost;
        private System.Windows.Forms.Label labelTotalAmountInserted;
        private System.Windows.Forms.PictureBox pictureRegular;
        private System.Windows.Forms.PictureBox pictureOrange;
        private System.Windows.Forms.PictureBox pictureYellow;
        private System.Windows.Forms.Button buttonCoinReturn;
        private System.Windows.Forms.Button buttonNickel;
        private System.Windows.Forms.Button buttonRegular;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonDime;
        private System.Windows.Forms.Button buttonQuarter;
        private System.Windows.Forms.Button buttonHalfDollar;
        private System.Windows.Forms.Label labelInsertedDisplay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVend;
        private System.Windows.Forms.TabPage tabService;
    }
}

