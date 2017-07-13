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

namespace P6hh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void getTestButton_Click(object sender, EventArgs e)
        {
            // Clear all listBoxes to grade the next test.
            answersListBox.Items.Clear();
            studentAnsListBox.Items.Clear();
            gradeListBox.Items.Clear();

            // Create an array with the correct answers.
            string[] ansKey = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
            
            // Create an array to hold items read from the file.
            const int SIZE = 20;
            string[] studentAns = new string[SIZE];

            // Counter variables to use in the loop
            int index = 0;
            int correct = 0;
            int inCorrect = 0;

            // Declare StreamReader Variable.
            StreamReader inputFile;

            // Prompt the user to open a file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file.
                inputFile = File.OpenText(openFileDialog1.FileName);

                // Read the file's contents into the array.
                while (index < studentAns.Length && !inputFile.EndOfStream)
                {
                    studentAns[index] = (inputFile.ReadLine());

                    // Compare the values in the arrays
                    if (studentAns[index] == ansKey[index])
                    {
                        correct++;
                        gradeListBox.Items.Add("Correct");
                        correctTextLabel.Text = correct.ToString();
                        index++;
                    }
                    else
                    {
                        inCorrect++;
                        gradeListBox.Items.Add("Incorrect");
                        incorrectTextLabel.Text = inCorrect.ToString();
                        index++;
                    }
                    if (correct >= 15)
                    {
                        passOrFailTextLabel.Text = "Passed";
                    }
                    else
                    {
                        passOrFailTextLabel.Text = "Failed";
                    }
                }

                // Close the file.
                inputFile.Close();

                // Display the studentAns array elements in the list box.
                foreach (string value in studentAns)
                {
                    studentAnsListBox.Items.Add(value);
                }

                //Display the ansKey array elements in the listBox.
                foreach (string value in ansKey)
                {
                    answersListBox.Items.Add(value);
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
