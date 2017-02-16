using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lesson6ConsoleAsLibrary;
using System.Diagnostics;

namespace Lesson8MenusMDIFiles
{
    public partial class SodaVendingMachine : Form
    {
        public SodaVendingMachine()
        {
            InitializeComponent();
        }

        private readonly CoinBox primaryCoinBox = new CoinBox(new List<Coin>
        {
            new Coin(Coin.Denomination.QUARTER),
            new Coin(Coin.Denomination.DIME),
            new Coin(Coin.Denomination.NICKEL),
            new Coin(Coin.Denomination.QUARTER),
            new Coin(Coin.Denomination.QUARTER),
            new Coin(Coin.Denomination.DIME)
        });

        private readonly CoinBox tempCoinBox = new CoinBox();
        private readonly PurchasePrice sodaPrice = new PurchasePrice(0.35M);

        private readonly CanRack canRack = new CanRack();

        private void updateInsertedTotal()
        {
            labelInsertedDisplay.Text =
                string.Format($"{tempCoinBox.ValueOf:c}");
            buttonCoinReturn.Enabled = tempCoinBox.ValueOf > 0M;
        }

        private void insertCoinInTempBox(Coin ACoin)
        {
            tempCoinBox.Deposit(ACoin);
            updateInsertedTotal();
            ejectButtonsReset();
        }

        private void ejectButtonsReset()
        {
            if (tempCoinBox.ValueOf >= sodaPrice.PriceDecimal)
            {
                buttonRegular.Enabled = !canRack.IsEmpty(Flavor.REGULAR);
                buttonOrange.Enabled = !canRack.IsEmpty(Flavor.ORANGE);
                buttonYellow.Enabled = !canRack.IsEmpty(Flavor.LEMON);
            }
            else
            {
                buttonRegular.Enabled = false;
                buttonOrange.Enabled = false;
                buttonYellow.Enabled = false;
            }
        }

        private void dispenseCan(Flavor dispenseFlavor)
        {
            var amountInserted = tempCoinBox.ValueOf;
            if (tempCoinBox.ValueOf >= sodaPrice.PriceDecimal && !canRack.IsEmpty(dispenseFlavor))
            {
                tempCoinBox.Transfer(primaryCoinBox);
                updateInsertedTotal();
                canRack.RemoveACanOf(dispenseFlavor);
                MessageBox.Show(string.Format($"Thanks! Have a {dispenseFlavor} soda!"));
                ejectButtonsReset();
                var changeDue = amountInserted - sodaPrice.PriceDecimal;
                if (changeDue > 0M && primaryCoinBox.CanMakeChange)
                {
                    primaryCoinBox.Withdraw(changeDue);
                    MessageBox.Show(string.Format($"You Gave me too much money, here is your {changeDue:c} in change"));
                }
                labelInsertedDisplay.Visible = !primaryCoinBox.CanMakeChange;
            }

            if (canRack.IsEmpty(dispenseFlavor))
            {
                switch (dispenseFlavor.ToString().ToUpper())
                {
                    case "REGULAR":
                        this.buttonRegular.Text = "SOLD OUT!";
                        break;
                    case "ORANGE":
                        this.buttonOrange.Text = "SOLD OUT!";
                        break;
                    case "LEMON":
                        this.buttonOrange.Text = "SOLD OUT!";
                        break;
                }
            }
        }

        private void SodaVendingMachine_load(object sender, EventArgs e)
        {
            buttonRegular.Enabled = false;
            buttonOrange.Enabled = false;
            buttonYellow.Enabled = false;
        }



        private void buttonCoinReturn_Click(object sender, EventArgs e)
        {
            var amountInserted = tempCoinBox.ValueOf;

            if (amountInserted > 0M)
            {
                tempCoinBox.Withdraw(tempCoinBox.ValueOf);
                updateInsertedTotal();
                MessageBox.Show(string.Format($"Have some money!  Here is your {amountInserted:c} back"));
            }

            ejectButtonsReset();
        }

        private void labelInsertCoins_Click(object sender, EventArgs e)
        {
        }

        private void labelSodaCost_Click(object sender, EventArgs e)
        {
        }

        private void labelTotalAmountInserted_Click(object sender, EventArgs e)
        {
        }

        private void pictureRegular_Click(object sender, EventArgs e)
        {
        }

        private void pictureOrange_Click(object sender, EventArgs e)
        {
        }

        private void pictureYellow_Click(object sender, EventArgs e)
        {
        }

        private void buttonNickel_Click(object sender, EventArgs e)
        {
            var nickel = new Coin(Coin.Denomination.NICKEL);
            insertCoinInTempBox(nickel);
            updateInsertedTotal();
        }

        private void buttonDime_Click(object sender, EventArgs e)
        {
            var dime = new Coin(Coin.Denomination.DIME);
            insertCoinInTempBox(dime);
            updateInsertedTotal();
        }

        private void buttonQuarter_Click(object sender, EventArgs e)
        {
            var quarter = new Coin(Coin.Denomination.QUARTER);
            insertCoinInTempBox(quarter);
            updateInsertedTotal();
        }

        private void buttonHalfDollar_Click(object sender, EventArgs e)
        {
            var halfDollar = new Coin(Coin.Denomination.HALFDOLLAR);
            insertCoinInTempBox(halfDollar);
            updateInsertedTotal();
        }

        private void buttonRegular_Click(object sender, EventArgs e)
        {
            dispenseCan(Flavor.REGULAR);
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            dispenseCan(Flavor.ORANGE);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            dispenseCan(Flavor.LEMON);
        }

        private void labelInsertedDisplay_Click(object sender, EventArgs e)
        {
        }

        //Service Layer
        private void constructRackDisplay()
        {

            listViewRack.Items.Clear();

            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                ListViewItem row = new ListViewItem(aFlavor.ToString());
                row.SubItems.Add(canRack[aFlavor].ToString());
                listViewRack.Items.Add(row);
            }
        }

        private void constructCoinBoxDisplay(ListView CoinBoxDisplay, CoinBox CoinBoxToDisplay)
        {
            CoinBoxDisplay.Items.Clear();
            List<Coin.Denomination> reverseCoinList = new List<Coin.Denomination>(Coin.AllDenominations);
            reverseCoinList.Reverse();

            foreach (Coin.Denomination coinDenomination in reverseCoinList)
            {
                int coinCount = CoinBoxToDisplay.coinCount(coinDenomination);
                decimal coinsValue = coinCount * Coin.ValueOfCoin(coinDenomination);
                ListViewItem coinRow = new ListViewItem(coinDenomination.ToString());
                coinRow.SubItems.Add(coinCount.ToString());
                coinRow.SubItems.Add(string.Format("{0:c}", coinsValue));
                CoinBoxDisplay.Items.Add(coinRow);
            }

            ListViewItem totalRow = new ListViewItem("Total");
            totalRow.SubItems.Add(string.Empty);
            totalRow.SubItems.Add(string.Format("{0:c}",
                CoinBoxToDisplay.ValueOf));
            CoinBoxDisplay.Items.Add(totalRow);
        }



        private void buttonFillRack_Click(object sender, EventArgs e)
        {
            canRack.FillTheCanRack();
            constructRackDisplay();
        }

        private void tabService_Click(object sender, EventArgs e)
        {
            constructRackDisplay();
            constructCoinBoxDisplay(listViewPrimaryCoinBox, primaryCoinBox);
            constructCoinBoxDisplay(listViewTempCoinBox, tempCoinBox);
        }

        private void buttonPrimaryCoinEmpty_Click(object sender, EventArgs e)
        {
            primaryCoinBox.Withdraw(primaryCoinBox.ValueOf);
            constructCoinBoxDisplay(listViewPrimaryCoinBox, primaryCoinBox);
        }

        private void buttonEmptyTempCoins_Click(object sender, EventArgs e)
        {
            tempCoinBox.Withdraw(tempCoinBox.ValueOf);
            constructCoinBoxDisplay(listViewTempCoinBox, tempCoinBox);
            updateInsertedTotal();

        }

        private void listViewPrimaryCoinBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonServiceNotes_Click(object sender, EventArgs e)
        {
            ServiceNotesForm serviceNotes = new ServiceNotesForm();
            serviceNotes.Show();
        }
    }
}
