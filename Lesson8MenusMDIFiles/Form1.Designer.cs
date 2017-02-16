namespace Lesson8MenusMDIFiles
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
            this.groupCoinBox = new System.Windows.Forms.GroupBox();
            this.buttonEmptyTempCoins = new System.Windows.Forms.Button();
            this.listViewTempCoinBox = new System.Windows.Forms.ListView();
            this.chTempCoins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTempCoinsCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTempCoinAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPrimaryCoinEmpty = new System.Windows.Forms.Button();
            this.labelMainCoinBox = new System.Windows.Forms.Label();
            this.listViewPrimaryCoinBox = new System.Windows.Forms.ListView();
            this.chPrimaryCoins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrimaryCoinCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrimaryCoinValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupRack = new System.Windows.Forms.GroupBox();
            this.buttonFillRack = new System.Windows.Forms.Button();
            this.listViewRack = new System.Windows.Forms.ListView();
            this.chRackFlavor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRackRemaining = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonServiceNotes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegular)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabVend.SuspendLayout();
            this.tabService.SuspendLayout();
            this.groupCoinBox.SuspendLayout();
            this.groupRack.SuspendLayout();
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
            this.pictureYellow.Image = ((System.Drawing.Image)(resources.GetObject("pictureYellow.Image")));
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
            this.pictureOrange.Image = ((System.Drawing.Image)(resources.GetObject("pictureOrange.Image")));
            this.pictureOrange.InitialImage = null;
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
            this.pictureRegular.Image = ((System.Drawing.Image)(resources.GetObject("pictureRegular.Image")));
            this.pictureRegular.InitialImage = null;
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
            this.tabControl1.Click += new System.EventHandler(this.tabService_Click);
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
            this.tabService.Controls.Add(this.buttonServiceNotes);
            this.tabService.Controls.Add(this.groupCoinBox);
            this.tabService.Controls.Add(this.groupRack);
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(3);
            this.tabService.Size = new System.Drawing.Size(914, 628);
            this.tabService.TabIndex = 1;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // groupCoinBox
            // 
            this.groupCoinBox.Controls.Add(this.buttonEmptyTempCoins);
            this.groupCoinBox.Controls.Add(this.listViewTempCoinBox);
            this.groupCoinBox.Controls.Add(this.buttonPrimaryCoinEmpty);
            this.groupCoinBox.Controls.Add(this.labelMainCoinBox);
            this.groupCoinBox.Controls.Add(this.listViewPrimaryCoinBox);
            this.groupCoinBox.Location = new System.Drawing.Point(460, 33);
            this.groupCoinBox.Name = "groupCoinBox";
            this.groupCoinBox.Size = new System.Drawing.Size(383, 507);
            this.groupCoinBox.TabIndex = 1;
            this.groupCoinBox.TabStop = false;
            this.groupCoinBox.Text = "Coin Box Controls";
            // 
            // buttonEmptyTempCoins
            // 
            this.buttonEmptyTempCoins.Location = new System.Drawing.Point(58, 456);
            this.buttonEmptyTempCoins.Name = "buttonEmptyTempCoins";
            this.buttonEmptyTempCoins.Size = new System.Drawing.Size(214, 40);
            this.buttonEmptyTempCoins.TabIndex = 4;
            this.buttonEmptyTempCoins.Text = "Empty Customer Coin Box";
            this.buttonEmptyTempCoins.UseVisualStyleBackColor = true;
            this.buttonEmptyTempCoins.Click += new System.EventHandler(this.buttonEmptyTempCoins_Click);
            // 
            // listViewTempCoinBox
            // 
            this.listViewTempCoinBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTempCoins,
            this.chTempCoinsCount,
            this.chTempCoinAmount});
            this.listViewTempCoinBox.GridLines = true;
            this.listViewTempCoinBox.Location = new System.Drawing.Point(25, 297);
            this.listViewTempCoinBox.Name = "listViewTempCoinBox";
            this.listViewTempCoinBox.Size = new System.Drawing.Size(275, 153);
            this.listViewTempCoinBox.TabIndex = 3;
            this.listViewTempCoinBox.UseCompatibleStateImageBehavior = false;
            this.listViewTempCoinBox.View = System.Windows.Forms.View.Details;
            // 
            // chTempCoins
            // 
            this.chTempCoins.Text = "Coins";
            this.chTempCoins.Width = 101;
            // 
            // chTempCoinsCount
            // 
            this.chTempCoinsCount.Text = "# Of Coins";
            this.chTempCoinsCount.Width = 92;
            // 
            // chTempCoinAmount
            // 
            this.chTempCoinAmount.Text = "Amount";
            this.chTempCoinAmount.Width = 88;
            // 
            // buttonPrimaryCoinEmpty
            // 
            this.buttonPrimaryCoinEmpty.Location = new System.Drawing.Point(58, 225);
            this.buttonPrimaryCoinEmpty.Name = "buttonPrimaryCoinEmpty";
            this.buttonPrimaryCoinEmpty.Size = new System.Drawing.Size(214, 40);
            this.buttonPrimaryCoinEmpty.TabIndex = 2;
            this.buttonPrimaryCoinEmpty.Text = "Empty Vending Machine Coin Box";
            this.buttonPrimaryCoinEmpty.UseVisualStyleBackColor = true;
            this.buttonPrimaryCoinEmpty.Click += new System.EventHandler(this.buttonPrimaryCoinEmpty_Click);
            // 
            // labelMainCoinBox
            // 
            this.labelMainCoinBox.AutoSize = true;
            this.labelMainCoinBox.Location = new System.Drawing.Point(25, 47);
            this.labelMainCoinBox.Name = "labelMainCoinBox";
            this.labelMainCoinBox.Size = new System.Drawing.Size(135, 13);
            this.labelMainCoinBox.TabIndex = 1;
            this.labelMainCoinBox.Text = "Vending Machine Coin Box";
            // 
            // listViewPrimaryCoinBox
            // 
            this.listViewPrimaryCoinBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPrimaryCoins,
            this.chPrimaryCoinCount,
            this.chPrimaryCoinValue});
            this.listViewPrimaryCoinBox.GridLines = true;
            this.listViewPrimaryCoinBox.Location = new System.Drawing.Point(25, 66);
            this.listViewPrimaryCoinBox.Name = "listViewPrimaryCoinBox";
            this.listViewPrimaryCoinBox.Size = new System.Drawing.Size(275, 153);
            this.listViewPrimaryCoinBox.TabIndex = 0;
            this.listViewPrimaryCoinBox.UseCompatibleStateImageBehavior = false;
            this.listViewPrimaryCoinBox.View = System.Windows.Forms.View.Details;
            this.listViewPrimaryCoinBox.SelectedIndexChanged += new System.EventHandler(this.listViewPrimaryCoinBox_SelectedIndexChanged);
            // 
            // chPrimaryCoins
            // 
            this.chPrimaryCoins.Text = "Coins";
            this.chPrimaryCoins.Width = 101;
            // 
            // chPrimaryCoinCount
            // 
            this.chPrimaryCoinCount.Text = "# Of Coins";
            this.chPrimaryCoinCount.Width = 92;
            // 
            // chPrimaryCoinValue
            // 
            this.chPrimaryCoinValue.Text = "Amount";
            this.chPrimaryCoinValue.Width = 88;
            // 
            // groupRack
            // 
            this.groupRack.Controls.Add(this.buttonFillRack);
            this.groupRack.Controls.Add(this.listViewRack);
            this.groupRack.Location = new System.Drawing.Point(25, 23);
            this.groupRack.Name = "groupRack";
            this.groupRack.Size = new System.Drawing.Size(255, 193);
            this.groupRack.TabIndex = 0;
            this.groupRack.TabStop = false;
            this.groupRack.Text = "Rack";
            // 
            // buttonFillRack
            // 
            this.buttonFillRack.Location = new System.Drawing.Point(44, 135);
            this.buttonFillRack.Name = "buttonFillRack";
            this.buttonFillRack.Size = new System.Drawing.Size(149, 23);
            this.buttonFillRack.TabIndex = 1;
            this.buttonFillRack.Text = "Fill The Rack";
            this.buttonFillRack.UseVisualStyleBackColor = true;
            this.buttonFillRack.Click += new System.EventHandler(this.buttonFillRack_Click);
            // 
            // listViewRack
            // 
            this.listViewRack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRackFlavor,
            this.chRackRemaining});
            this.listViewRack.GridLines = true;
            this.listViewRack.Location = new System.Drawing.Point(7, 20);
            this.listViewRack.Name = "listViewRack";
            this.listViewRack.Size = new System.Drawing.Size(242, 108);
            this.listViewRack.TabIndex = 0;
            this.listViewRack.UseCompatibleStateImageBehavior = false;
            this.listViewRack.View = System.Windows.Forms.View.Details;
            // 
            // chRackFlavor
            // 
            this.chRackFlavor.Text = "Flavor";
            this.chRackFlavor.Width = 119;
            // 
            // chRackRemaining
            // 
            this.chRackRemaining.Text = "Remaining Cans";
            this.chRackRemaining.Width = 118;
            // 
            // buttonServiceNotes
            // 
            this.buttonServiceNotes.Location = new System.Drawing.Point(88, 315);
            this.buttonServiceNotes.Name = "buttonServiceNotes";
            this.buttonServiceNotes.Size = new System.Drawing.Size(249, 23);
            this.buttonServiceNotes.TabIndex = 2;
            this.buttonServiceNotes.Text = "Service Notes";
            this.buttonServiceNotes.UseVisualStyleBackColor = true;
            this.buttonServiceNotes.Click += new System.EventHandler(this.buttonServiceNotes_Click);
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
            this.tabService.ResumeLayout(false);
            this.groupCoinBox.ResumeLayout(false);
            this.groupCoinBox.PerformLayout();
            this.groupRack.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupRack;
        private System.Windows.Forms.Button buttonFillRack;
        private System.Windows.Forms.ListView listViewRack;
        private System.Windows.Forms.ColumnHeader chRackFlavor;
        private System.Windows.Forms.ColumnHeader chRackRemaining;
        private System.Windows.Forms.GroupBox groupCoinBox;
        private System.Windows.Forms.Button buttonEmptyTempCoins;
        private System.Windows.Forms.ListView listViewTempCoinBox;
        private System.Windows.Forms.ColumnHeader chTempCoins;
        private System.Windows.Forms.ColumnHeader chTempCoinsCount;
        private System.Windows.Forms.ColumnHeader chTempCoinAmount;
        private System.Windows.Forms.Button buttonPrimaryCoinEmpty;
        private System.Windows.Forms.Label labelMainCoinBox;
        private System.Windows.Forms.ListView listViewPrimaryCoinBox;
        private System.Windows.Forms.ColumnHeader chPrimaryCoins;
        private System.Windows.Forms.ColumnHeader chPrimaryCoinCount;
        private System.Windows.Forms.ColumnHeader chPrimaryCoinValue;
        private System.Windows.Forms.Button buttonServiceNotes;
    }
}

