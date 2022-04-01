using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//   Program Name:  Slot Machine
//      Developer:  Timmy Bell
//           Date:  04/29/2021
//        Purpose:  Entertainment purposes only!  This program 
//                  allows the user to enter a wager amount to
//                  generate random number in three columns and 
//                  then checks to see if there are any matches
//                  within the columns.  If a match appears the
//                  wager amount will be multiplied and returned
//                  the user as winnings.  Upon exit the amount 
//                  inserted will be subtracted from the total 
//                  winnings and inform the user if he/she is 
//                  walkin away +,-, or =.
//                
//

namespace Slot_Machine
{
    public partial class slotMachine : Form
    {
        public slotMachine()
        {
            InitializeComponent();
        }

        // declare variables

        int totalInserted = 0;
        int totalWon = 0;
        int walkAway = 0;

        private void spinButton_Click(object sender, EventArgs e)
        {

            try
            {
                // Begin try Block
                int totalInserted = Convert.ToInt32(amountTextBox.Text);
                // Convert amountTextBox.Text amount to int
                int amount = Convert.ToInt32(amountTextBox.Text);
                if (amount > 0)
               
                {

                    // Generate random number
                    Random rand = new Random();

                    // Populate slots with random numbers up to 9
                    int slotOne = rand.Next(0, 10);
                    int slotTwo = rand.Next(0, 10);
                    int slotThree = rand.Next(0, 10);



                    // add the totalInserted to the accumulated amount
                    totalInserted += amount;

                    // Check which random number is populated in first slot 
                    // apply image to pictureBox1.Image

                    if (slotOne == 0)
                    {
                        pictureBox1.Image = Image.FromFile("Images/Apple.bmp");
                    }
                    else if (slotOne == 1)
                    {
                        pictureBox1.Image = Image.FromFile("Images/Banana.bmp");
                    }
                    else if (slotOne == 2)
                    {
                        pictureBox1.Image = Image.FromFile("Images/Cherries.bmp");
                    }
                    else if (slotOne == 3)
                    {
                        pictureBox1.Image = Image.FromFile("Images/Grapes.bmp");
                    }
                    else if (slotOne == 4)
                    {
                        pictureBox1.Image = Image.FromFile("Images/Lemon.bmp");
                    }
                    else if (slotOne == 5)
                    {
                        pictureBox1.Image = Image.FromFile("Images/Lime.bmp");
                    }
                    else if (slotOne == 6)
                    {
                        pictureBox1.Image = Image.FromFile("Images/Orange.bmp");
                    }
                    else if (slotOne == 7)
                    {
                        pictureBox1.Image = Image.FromFile("Images/Pear.bmp");
                    }
                    else if (slotOne == 8)
                    {
                        pictureBox1.Image = Image.FromFile("Images/Strawberry.bmp");
                    }
                    else if (slotOne == 9)
                    {
                        pictureBox1.Image = Image.FromFile("Images/Watermelon.bmp");
                    }


                    // Check which random number is populated in second slot 
                    // apply image to pictureBox2.Image

                    if (slotTwo == 0)
                    {
                        pictureBox2.Image = Image.FromFile("Images/Apple.bmp");
                    }
                    else if (slotTwo == 1)
                    {
                        pictureBox2.Image = Image.FromFile("Images/Banana.bmp");
                    }
                    else if (slotTwo == 2)
                    {
                        pictureBox2.Image = Image.FromFile("Images/Cherries.bmp");
                    }
                    else if (slotTwo == 3)
                    {
                        pictureBox2.Image = Image.FromFile("Images/Grapes.bmp");
                    }
                    else if (slotTwo == 4)
                    {
                        pictureBox2.Image = Image.FromFile("Images/Lemon.bmp");
                    }
                    else if (slotTwo == 5)
                    {
                        pictureBox2.Image = Image.FromFile("Images/Lime.bmp");
                    }
                    else if (slotTwo == 6)
                    {
                        pictureBox2.Image = Image.FromFile("Images/Orange.bmp");
                    }
                    else if (slotTwo == 7)
                    {
                        pictureBox2.Image = Image.FromFile("Images/Pear.bmp");
                    }
                    else if (slotTwo == 8)
                    {
                        pictureBox2.Image = Image.FromFile("Images/Strawberry.bmp");
                    }
                    else if (slotTwo == 9)
                    {
                        pictureBox2.Image = Image.FromFile("Images/Watermelon.bmp");
                    }

                    // Check which random number is populated in third slot 
                    // apply image to pictureBox3.Image

                    if (slotThree == 0)
                    {
                        pictureBox3.Image = Image.FromFile("Images/Apple.bmp");
                    }
                    else if (slotThree == 1)
                    {
                        pictureBox3.Image = Image.FromFile("Images/Banana.bmp");
                    }
                    else if (slotThree == 2)
                    {
                        pictureBox3.Image = Image.FromFile("Images/Cherries.bmp");
                    }
                    else if (slotThree == 3)
                    {
                        pictureBox3.Image = Image.FromFile("Images/Grapes.bmp");
                    }
                    else if (slotThree == 4)
                    {
                        pictureBox3.Image = Image.FromFile("Images/Lemon.bmp");
                    }
                    else if (slotThree == 5)
                    {
                        pictureBox3.Image = Image.FromFile("Images/Lime.bmp");
                    }
                    else if (slotThree == 6)
                    {
                        pictureBox3.Image = Image.FromFile("Images/Orange.bmp");
                    }
                    else if (slotThree == 7)
                    {
                        pictureBox3.Image = Image.FromFile("Images/Pear.bmp");
                    }
                    else if (slotThree == 8)
                    {
                        pictureBox3.Image = Image.FromFile("Images/Strawberry.bmp");
                    }
                    else if (slotThree == 9)
                    {
                        pictureBox3.Image = Image.FromFile("Images/Watermelon.bmp");
                    }

                    // Check if all three slots are the same
                    if (slotOne == slotTwo && slotOne == slotThree)
                    {
                        // take amount times 3 for winnings
                        totalWon += amount * 3;
                        // Display winning message
                        MessageBox.Show("You Won ..." + (amount * 3).ToString("+ $#.##;- $#.##;(0)"));
                    }
                    else if (slotOne == slotTwo || slotOne == slotThree || slotTwo == slotThree)
                    {
                        // Check if two slots are the same
                        totalWon += amount * 2;
                        // Display winning message
                        MessageBox.Show("You Won ..." + (amount * 2).ToString(" $#.##;- $#.##;(0)"));
                    }
                    else
                    {
                        // Check revealed all slots are different
                        // Display Not a winner message
                        MessageBox.Show("Not a Winning Spin");
                    }

                    // Clear the amountTextBox

                    amountTextBox.Text = "";
                }

                 else
                 {
                    // Display message asking for Money
                    MessageBox.Show("Please Insert Money");
                    // Clear amountTextBox.Text
                    amountTextBox.Text = "";
                    // Set focus
                    amountTextBox.Focus();
                 }
         
            } // End of try Block

            catch (Exception ex)
            {
                // display the error message
                MessageBox.Show("Amount Inserted Must Be A Number Greater Than 0");
                amountTextBox.Text = "";
                // Set focus
                amountTextBox.Focus();
            } //end catch
        }

        private void exitBbutton_Click(object sender, EventArgs e)
           
        {
            // Calculate the walkAway amount
            walkAway = totalWon - totalInserted;

            // Display results of session 
            MessageBox.Show("Total inserted " + "amount was" + totalInserted.ToString(" $#.##;- $#.##;(0)"));
            MessageBox.Show("Total winnings were " + totalWon.ToString(" $#.##;- $#.##;(0)"));
            MessageBox.Show("You are walking away " + walkAway.ToString("+ $#.##;- $#.##;(0)"));
           
            // Close application
            this.Close();
        }


    }
}
