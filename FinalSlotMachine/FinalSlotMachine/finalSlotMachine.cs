/*
AUTH:Brian Schmidt
DATE:12/13/23
DESC: Slot Machine Simulation
Create an application that simulates a slot machine. 
The application should let the user enter into a TextBox the amount of money he or she is inserting into the machine. 
When the user clicks the Spin button, the application should display three randomly selected symbols.
If two images are identical, the user should gain double their bid. 
If all three images are identical, then the user should gain triple their bid. 
    The images must be stored in an ImageList control.
If two or three of the images match, the program should inform the user that he or she has some winnings. 
    Show the user the amount won, the total winnings, the total spent, and the net winnings/losses. 
When the user clicks the Exit button to exit the application, the program should display the total
    amount of money entered into the slot machine, the total amount won, and the net winnings.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSlotMachine
{
    public partial class finalSlotMachine : Form
    {
        public finalSlotMachine()
        {
            InitializeComponent();
        }
            // variable totals
            decimal spent = 0;
            decimal winT = 0;
            int win = 0;
            int loss = 0;
        private void SpinButton_Click(object sender, EventArgs e)
        {
            // declare variables
            decimal bet = 0;
            decimal winS = 0;
            // check to see if they put a valid number in the bet box
            try
            {
                bet = decimal.Parse(betBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a dollar amount greater than 0.00.");
                return;
            }
            // create a random object
            Random rand = new Random();
            // create a random index
            int a = rand.Next(slotImageList.Images.Count);
            int b = rand.Next(slotImageList.Images.Count);
            int c = rand.Next(slotImageList.Images.Count);
            // Display the images
            slot1.Image = slotImageList.Images[a];
            slot2.Image = slotImageList.Images[b];
            slot3.Image = slotImageList.Images[c];
            // if half win
            if (a == b & a != c)
            {
                winS = bet * 2;
                win = win + 1;
                winOutputLabel.Text = (winS).ToString("c");
            }
            else if (a == c & a != b)
            {
                winS = bet * 2;
                win = win + 1;
                winOutputLabel.Text = (winS).ToString("c");
            }
            else if (b == c & b != a)
            {
                winS = bet * 2;
                win = win + 1;
                winOutputLabel.Text = (winS).ToString("c");
            }
            // if full win
            else if (a == b & a == c)
            {
                winS = bet * 3;
                win = win + 1;
                winOutputLabel.Text = (winS).ToString("c");
            }
            // if no win
            else
            {
                loss = loss + 1;
                winOutputLabel.Text = "$0.00";
            }
            // calculate totals
            winT = winT + winS;
            spent = spent + bet;
            // display totals
            totalWinOutputLabel.Text = winT.ToString("c");
            spentOutputLabel.Text = spent.ToString("c");
            winLossOutputLabel.Text = win.ToString();
            lossOutputLabel.Text = loss.ToString();
        }        
        private void exitButton_Click(object sender, EventArgs e)
        {
            // show results before close
            MessageBox.Show("You spent: " + spentOutputLabel.Text + " You won: " + totalWinOutputLabel.Text + "   Wins:  " 
                + winLossOutputLabel.Text + "  Losses:  " + lossOutputLabel.Text);

            // I dont know what this line does, but I know I need it
            this.Close();
        }
    }
}
