using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5hh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Module/method for when player selects rock.
        private void rockPictureBox_Click(object sender, EventArgs e)
        {
            // Declare an integer variable.
            int num1;

            // Create a Random Object
            Random rand = new Random();

            // Get the random integer and assign it to num1.
            num1 = rand.Next(3) + 1;

            // Declare and display each players' moves and the winner.
            switch (num1)
            {
                case 1:
                    computerTextLabel.Text = "Computer chooses rock";
                    playerTextLabel.Text = "You have choosen rock.";
                    winnerTextLabel.Text = "The computer and you have choosen rock. Therefore it is a tie.";
                    computerPictureBox1.Visible = false;
                    computerPictureBox2.Visible = true;
                    computerPictureBox3.Visible = false;
                    computerPictureBox4.Visible = false;
                    playerPictureBox1.Visible = false;
                    playerPictureBox2.Visible = true;
                    playerPictureBox3.Visible = false;
                    playerPictureBox4.Visible = false;
                    break;
                case 2:
                    computerTextLabel.Text = "Computer chooses paper";
                    playerTextLabel.Text = "You have choosen rock.";
                    winnerTextLabel.Text = "Paper can smoother a rock. Therefore the computer has won.";
                    computerPictureBox1.Visible = false;
                    computerPictureBox2.Visible = false;
                    computerPictureBox3.Visible = true;
                    computerPictureBox4.Visible = false;
                    playerPictureBox1.Visible = false;
                    playerPictureBox2.Visible = true;
                    playerPictureBox3.Visible = false;
                    playerPictureBox4.Visible = false;
                    break;
                case 3:
                    computerTextLabel.Text = "Computer Chooses scissors";
                    playerTextLabel.Text = "You have choosen rock.";
                    winnerTextLabel.Text = "A rock can crush scissors. Therefore, you have won.";
                    computerPictureBox1.Visible = false;
                    computerPictureBox2.Visible = false;
                    computerPictureBox3.Visible = false;
                    computerPictureBox4.Visible = true;
                    playerPictureBox1.Visible = false;
                    playerPictureBox2.Visible = true;
                    playerPictureBox3.Visible = false;
                    playerPictureBox4.Visible = false;
                    break;
            }
        }

        //Module/method for when player selects papaer.
        private void paperPictureBox_Click(object sender, EventArgs e)
        {
            // Declare an integer variable.
            int num1;

            // Create a Random Object
            Random rand = new Random();

            // Get the random integer and assign it to num1.
            num1 = rand.Next(3) + 1;

            // Declare and display each players' moves and the winner.
            switch (num1)
            {
                case 1:
                    computerTextLabel.Text = "Computer chooses rock.";
                    playerTextLabel.Text = "You have choosen paper.";
                    winnerTextLabel.Text = "Paper can smoother a rock. Therefore you have won.";
                    computerPictureBox1.Visible = false;
                    computerPictureBox2.Visible = true;
                    computerPictureBox3.Visible = false;
                    computerPictureBox4.Visible = false;
                    playerPictureBox1.Visible = false;
                    playerPictureBox2.Visible = false;
                    playerPictureBox3.Visible = true;
                    playerPictureBox4.Visible = false;
                    break;
                case 2:
                    computerTextLabel.Text = "Computer chooses paper.";
                    playerTextLabel.Text = "You have choosen paper.";
                    winnerTextLabel.Text = "The computer and you have choosen paper. Therefore, it is a tie.";
                    computerPictureBox1.Visible = false;
                    computerPictureBox2.Visible = false;
                    computerPictureBox3.Visible = true;
                    computerPictureBox4.Visible = false;
                    playerPictureBox1.Visible = false;
                    playerPictureBox2.Visible = false;
                    playerPictureBox3.Visible = true;
                    playerPictureBox4.Visible = false;
                    break;
                case 3:
                    computerTextLabel.Text = "Computer Chooses scissors.";
                    playerTextLabel.Text = "You have choosen paper.";
                    winnerTextLabel.Text = "Scissors can cut paper. Therefore, the computer has won.";
                    computerPictureBox1.Visible = false;
                    computerPictureBox2.Visible = false;
                    computerPictureBox3.Visible = false;
                    computerPictureBox4.Visible = true;
                    playerPictureBox1.Visible = false;
                    playerPictureBox2.Visible = false;
                    playerPictureBox3.Visible = true;
                    playerPictureBox4.Visible = false;
                    break;
            }
        }

        //Module/Method for when player selects scissors.
        private void scissorsPictureBox_Click(object sender, EventArgs e)
        {
            // Declare an integer variable.
            int num1;

            // Create a Random Object
            Random rand = new Random();

            // Get the random integer and assign it to num1.
            num1 = rand.Next(3) + 1;

            // Declare and display each players' moves and the winner.
            switch (num1)
            {
                case 1:
                    computerTextLabel.Text = "Computer chooses rock.";
                    playerTextLabel.Text = "You have choosen scissors.";
                    winnerTextLabel.Text = "A rock can crush scissors. Therefore, the computer has won.";
                    computerPictureBox1.Visible = false;
                    computerPictureBox2.Visible = true;
                    computerPictureBox3.Visible = false;
                    computerPictureBox4.Visible = false;
                    playerPictureBox1.Visible = false;
                    playerPictureBox2.Visible = false;
                    playerPictureBox3.Visible = false;
                    playerPictureBox4.Visible = true;
                    break;
                case 2:
                    computerTextLabel.Text = "Computer chooses paper.";
                    playerTextLabel.Text = "You have choosen scissors.";
                    winnerTextLabel.Text = "Scissors can cut paper. Therefore, you have won.";
                    computerPictureBox1.Visible = false;
                    computerPictureBox2.Visible = false;
                    computerPictureBox3.Visible = true;
                    computerPictureBox4.Visible = false;
                    playerPictureBox1.Visible = false;
                    playerPictureBox2.Visible = false;
                    playerPictureBox3.Visible = false;
                    playerPictureBox4.Visible = true;
                    break;
                case 3:
                    computerTextLabel.Text = "Computer Chooses scissors.";
                    playerTextLabel.Text = "You have choosen scissors.";
                    winnerTextLabel.Text = "The computer and you have choosen scissors. Therefore, it is a tie.";
                    computerPictureBox1.Visible = false;
                    computerPictureBox2.Visible = false;
                    computerPictureBox3.Visible = false;
                    computerPictureBox4.Visible = true;
                    playerPictureBox1.Visible = false;
                    playerPictureBox2.Visible = false;
                    playerPictureBox3.Visible = false;
                    playerPictureBox4.Visible = true;
                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
