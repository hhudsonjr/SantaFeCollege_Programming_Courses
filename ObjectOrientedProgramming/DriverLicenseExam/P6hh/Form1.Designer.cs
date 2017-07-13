namespace P6hh
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
            this.answersListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.correctTextLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.incorrectTextLabel = new System.Windows.Forms.Label();
            this.passOrFailTextLabel = new System.Windows.Forms.Label();
            this.getTestButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.studentAnsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gradeListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answersListBox
            // 
            this.answersListBox.BackColor = System.Drawing.Color.Lavender;
            this.answersListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answersListBox.FormattingEnabled = true;
            this.answersListBox.ItemHeight = 29;
            this.answersListBox.Location = new System.Drawing.Point(41, 170);
            this.answersListBox.Name = "answersListBox";
            this.answersListBox.Size = new System.Drawing.Size(78, 638);
            this.answersListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correct Total:\r\n";
            // 
            // correctTextLabel
            // 
            this.correctTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctTextLabel.Location = new System.Drawing.Point(579, 338);
            this.correctTextLabel.Name = "correctTextLabel";
            this.correctTextLabel.Size = new System.Drawing.Size(65, 29);
            this.correctTextLabel.TabIndex = 2;
            this.correctTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Incorrect Total:";
            // 
            // incorrectTextLabel
            // 
            this.incorrectTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectTextLabel.Location = new System.Drawing.Point(579, 378);
            this.incorrectTextLabel.Name = "incorrectTextLabel";
            this.incorrectTextLabel.Size = new System.Drawing.Size(65, 29);
            this.incorrectTextLabel.TabIndex = 4;
            this.incorrectTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passOrFailTextLabel
            // 
            this.passOrFailTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passOrFailTextLabel.Location = new System.Drawing.Point(579, 417);
            this.passOrFailTextLabel.Name = "passOrFailTextLabel";
            this.passOrFailTextLabel.Size = new System.Drawing.Size(110, 32);
            this.passOrFailTextLabel.TabIndex = 7;
            this.passOrFailTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getTestButton
            // 
            this.getTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getTestButton.Location = new System.Drawing.Point(462, 470);
            this.getTestButton.Name = "getTestButton";
            this.getTestButton.Size = new System.Drawing.Size(90, 38);
            this.getTestButton.TabIndex = 8;
            this.getTestButton.Text = "Grade";
            this.getTestButton.UseVisualStyleBackColor = true;
            this.getTestButton.Click += new System.EventHandler(this.getTestButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(579, 470);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 38);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // studentAnsListBox
            // 
            this.studentAnsListBox.BackColor = System.Drawing.Color.Lavender;
            this.studentAnsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentAnsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentAnsListBox.FormattingEnabled = true;
            this.studentAnsListBox.ItemHeight = 29;
            this.studentAnsListBox.Location = new System.Drawing.Point(186, 170);
            this.studentAnsListBox.Name = "studentAnsListBox";
            this.studentAnsListBox.Size = new System.Drawing.Size(75, 638);
            this.studentAnsListBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Result:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 42);
            this.label4.TabIndex = 12;
            this.label4.Text = "Driver\'s License Exam";
            // 
            // gradeListBox
            // 
            this.gradeListBox.BackColor = System.Drawing.Color.Lavender;
            this.gradeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeListBox.FormattingEnabled = true;
            this.gradeListBox.ItemHeight = 29;
            this.gradeListBox.Location = new System.Drawing.Point(267, 170);
            this.gradeListBox.Name = "gradeListBox";
            this.gradeListBox.Size = new System.Drawing.Size(112, 609);
            this.gradeListBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Answer Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Student\'s Answers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(711, 795);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gradeListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentAnsListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getTestButton);
            this.Controls.Add(this.passOrFailTextLabel);
            this.Controls.Add(this.incorrectTextLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.correctTextLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answersListBox);
            this.Name = "Form1";
            this.Text = "Driver\'s License Exam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox answersListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label correctTextLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label incorrectTextLabel;
        private System.Windows.Forms.Label passOrFailTextLabel;
        private System.Windows.Forms.Button getTestButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox studentAnsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox gradeListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

