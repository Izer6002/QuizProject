namespace QuizProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.RdoOne = new System.Windows.Forms.RadioButton();
            this.RdoFour = new System.Windows.Forms.RadioButton();
            this.RdoTwo = new System.Windows.Forms.RadioButton();
            this.RdoThree = new System.Windows.Forms.RadioButton();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.PrgQuestions = new System.Windows.Forms.ProgressBar();
            this.LblQuestionNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "C# Quiz";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question";
            // 
            // LblQuestion
            // 
            this.LblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuestion.Location = new System.Drawing.Point(22, 153);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(1137, 42);
            this.LblQuestion.TabIndex = 2;
            this.LblQuestion.Text = "question";
            // 
            // RdoOne
            // 
            this.RdoOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoOne.Location = new System.Drawing.Point(24, 215);
            this.RdoOne.Name = "RdoOne";
            this.RdoOne.Size = new System.Drawing.Size(245, 30);
            this.RdoOne.TabIndex = 3;
            this.RdoOne.Tag = "1";
            this.RdoOne.Text = "1";
            this.RdoOne.UseVisualStyleBackColor = true;
            // 
            // RdoFour
            // 
            this.RdoFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoFour.Location = new System.Drawing.Point(579, 270);
            this.RdoFour.Name = "RdoFour";
            this.RdoFour.Size = new System.Drawing.Size(456, 30);
            this.RdoFour.TabIndex = 5;
            this.RdoFour.Tag = "4";
            this.RdoFour.UseVisualStyleBackColor = true;
            // 
            // RdoTwo
            // 
            this.RdoTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoTwo.Location = new System.Drawing.Point(579, 215);
            this.RdoTwo.Name = "RdoTwo";
            this.RdoTwo.Size = new System.Drawing.Size(456, 30);
            this.RdoTwo.TabIndex = 5;
            this.RdoTwo.Tag = "2";
            this.RdoTwo.UseVisualStyleBackColor = true;
            // 
            // RdoThree
            // 
            this.RdoThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoThree.Location = new System.Drawing.Point(24, 270);
            this.RdoThree.Name = "RdoThree";
            this.RdoThree.Size = new System.Drawing.Size(460, 30);
            this.RdoThree.TabIndex = 6;
            this.RdoThree.Tag = "3";
            this.RdoThree.UseVisualStyleBackColor = true;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(391, 306);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(189, 65);
            this.BtnSubmit.TabIndex = 7;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // PrgQuestions
            // 
            this.PrgQuestions.Location = new System.Drawing.Point(25, 400);
            this.PrgQuestions.Maximum = 10;
            this.PrgQuestions.Name = "PrgQuestions";
            this.PrgQuestions.Size = new System.Drawing.Size(926, 50);
            this.PrgQuestions.TabIndex = 8;
            // 
            // LblQuestionNum
            // 
            this.LblQuestionNum.AutoSize = true;
            this.LblQuestionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuestionNum.Location = new System.Drawing.Point(191, 92);
            this.LblQuestionNum.Name = "LblQuestionNum";
            this.LblQuestionNum.Size = new System.Drawing.Size(42, 46);
            this.LblQuestionNum.TabIndex = 9;
            this.LblQuestionNum.Text = "1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "Of 10:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 463);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblQuestionNum);
            this.Controls.Add(this.PrgQuestions);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.RdoThree);
            this.Controls.Add(this.RdoTwo);
            this.Controls.Add(this.RdoFour);
            this.Controls.Add(this.RdoOne);
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " C# Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.RadioButton RdoOne;
        private System.Windows.Forms.RadioButton RdoFour;
        private System.Windows.Forms.RadioButton RdoTwo;
        private System.Windows.Forms.RadioButton RdoThree;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.ProgressBar PrgQuestions;
        private System.Windows.Forms.Label LblQuestionNum;
        private System.Windows.Forms.Label label4;
    }
}

