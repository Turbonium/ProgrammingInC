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

namespace Lesson6WindowsForms
{
    public partial class SodaVendingMachine : Form
    {
        public SodaVendingMachine()
        {
            InitializeComponent();
        }
        private CoinBox primaryCoinBox = new CoinBox(new List<Coin> {
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME),
                new Coin(Coin.Denomination.NICKEL), new Coin(Coin.Denomination.QUARTER),
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });

        private CoinBox tempCoinBox = new CoinBox();
        private PurchasePrice sodaPrice = new PurchasePrice(0.35M);

        private CanRack canRack = new CanRack();

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
            decimal amountInserted = tempCoinBox.ValueOf;
            if (tempCoinBox.ValueOf >= sodaPrice.PriceDecimal && !canRack.IsEmpty(dispenseFlavor))
            {
                tempCoinBox.Transfer(primaryCoinBox);
                updateInsertedTotal();
                canRack.RemoveACanOf(dispenseFlavor);
                MessageBox.Show(string.Format($"Thanks! Have a {dispenseFlavor} soda!"));
                ejectButtonsReset();
                decimal changeDue = amountInserted - sodaPrice.PriceDecimal;
                if (changeDue > 0M && primaryCoinBox.CanMakeChange)
                {
                    primaryCoinBox.Withdraw(changeDue);
                    MessageBox.Show(string.Format($"You Gave me too much money, here is your {changeDue:c} in change"));
                }
                labelInsertedDisplay.Visible = !primaryCoinBox.CanMakeChange;
            }
        }

        private void buttonCoinReturn_Click(object sender, EventArgs e)
        {
            decimal amountInserted = tempCoinBox.ValueOf;

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
            Coin nickel = new Coin(Coin.Denomination.NICKEL);
            insertCoinInTempBox(nickel);
        }

        private void buttonDime_Click(object sender, EventArgs e)
        {
            Coin dime = new Coin(Coin.Denomination.DIME);
            insertCoinInTempBox(dime);
        }

        private void buttonQuarter_Click(object sender, EventArgs e)
        {
            Coin quarter = new Coin(Coin.Denomination.QUARTER);
            insertCoinInTempBox(quarter);
        }

        private void buttonHalfDollar_Click(object sender, EventArgs e)
        {
            Coin halfDollar = new Coin(Coin.Denomination.HALFDOLLAR);
            insertCoinInTempBox(halfDollar);
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
    }
}
