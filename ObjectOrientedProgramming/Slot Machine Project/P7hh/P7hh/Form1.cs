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

namespace P7hh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare variables
                decimal amount;         // Amount of money the player wants to gamble

                // Get the amount from the TextBox
                amount = decimal.Parse(amountTextBox.Text);

                // Create a Random object
                Random rand = new Random();

                // Get a random indexes
                int index1 = rand.Next(slotMachineImageList1.Images.Count);
                int index2 = rand.Next(slotMachineImageList2.Images.Count);
                int index3 = rand.Next(slotMachineImageList3.Images.Count);

                //Assign random objects/images to pictureBoxes
                pictureBox1.Image = slotMachineImageList1.Images[index1];
                pictureBox2.Image = slotMachineImageList2.Images[index2];
                pictureBox3.Image = slotMachineImageList3.Images[index3];

                // Compare the random objects
                if (index1 == index2 && index1 == index3 || index2 == index3 && index2 == index1)
                {
                    amount = amount * 3;
                    MessageBox.Show("JACKPOT!!! You have won $" + amount);
                }
                else
                {
                    if (index1 != index2 && index1 == index3 || index1 == index2 && index1 != index3 || index2 == index3 && index2 != index1)
                    {
                        amount = amount * 2;
                        MessageBox.Show("Congratulations! You have won $" + amount);
                    }
                    else
                    {
                        MessageBox.Show("Sorry. You Lose.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //CLose the form
            this.Close();
        }
    }
}
