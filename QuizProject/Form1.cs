using System;
using System.Windows.Forms;

namespace QuizProject
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        public int score = 0;
        public Form1()
        {
            InitializeComponent();
            question(1);
        }



        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int questionNum = Convert.ToInt32(LblQuestionNum.Text);
            
            RadioButton checkedAnwer = new RadioButton();
            if (questionNum != 10)
            {
                questionNum = questionNum + 1;
            }
            LblQuestionNum.Text = questionNum.ToString();
            PrgQuestions.Value = PrgQuestions.Value + 1;
            if (RdoOne.Checked == true)
            {
                checkedAnwer = RdoOne;
                if (Convert.ToInt32(checkedAnwer.Tag) == correctAnswer)
                {
                    score++;
                    //MessageBox.Show(score.ToString());
                }
            }
            if (RdoTwo.Checked == true)
            {
                checkedAnwer = RdoTwo;
                if (Convert.ToInt32(checkedAnwer.Tag) == correctAnswer)
                {
                    score++;
                }
            }
            if (RdoThree.Checked == true)
            {
                checkedAnwer = RdoThree;
                if (Convert.ToInt32(checkedAnwer.Tag) == correctAnswer)
                {
                    score++;       
                } 
            }
            if (RdoFour.Checked == true)
            {
                checkedAnwer = RdoFour;
                if (Convert.ToInt32(checkedAnwer.Tag) == correctAnswer)
                {
                    score++;
                }               
            }
            if (PrgQuestions.Value == 10)
            {
                TestIsOver testIsOver = new TestIsOver(score);
                testIsOver.Show();
                this.Hide();
                
            }
            questionNumber++;
            question(questionNumber);

        }

        private void question(int num)
        {
            switch (num)
            {
                case 1:
                    LblQuestion.Text = "What is a correct syntax to output ''Hello World'' in C#?";
                    RdoOne.Text = "Print(''Hello World'')";
                    RdoTwo.Text = "cout<<''Hello World''";
                    RdoThree.Text = "Console.Writeline(''Hello World'')";
                    RdoFour.Text = "System.out.println(''Hello world'')";
                    correctAnswer = 3;

                    break;

                case 2:
                    LblQuestion.Text = "Which data type is used to create a variable that should store text?";
                    RdoOne.Text = "string";
                    RdoTwo.Text = "int";
                    RdoThree.Text = "double";
                    RdoFour.Text = "txt";

                    correctAnswer = 1;

                    break;
                case 3:
                    LblQuestion.Text = "Which property can be used to find the length of a string?";
                    RdoOne.Text = "getLength()";
                    RdoTwo.Text = "length()";
                    RdoThree.Text = "count";
                    RdoFour.Text = "Length";
                    correctAnswer = 4;
                    break;


                case 4:
                    LblQuestion.Text = "Which operator can be used to compare two values?";
                    RdoOne.Text = "== ";
                    RdoTwo.Text = "<>";
                    RdoThree.Text = "><";
                    RdoFour.Text = "=";
                    correctAnswer = 1;

                    break;

                case 5:
                    LblQuestion.Text = "Which operator is used to multiply numbers?";
                    RdoOne.Text = "/";
                    RdoTwo.Text = "%";
                    RdoThree.Text = "X";
                    RdoFour.Text = "*";
                    correctAnswer = 4;

                    break;

                case 6:
                    LblQuestion.Text = "Which access modifier makes the code only accessible within the same class?";
                    RdoOne.Text = "private";
                    RdoTwo.Text = "abstract";
                    RdoThree.Text = "delegat";
                    RdoFour.Text = "public";
                    correctAnswer = 1;

                    break;

                case 7:
                    LblQuestion.Text = "Which statement is used to stop a loop?";
                    RdoOne.Text = "stop";
                    RdoTwo.Text = "break";
                    RdoThree.Text = "return";
                    RdoFour.Text = "exit";
                    correctAnswer = 2;

                    break;

                case 8:
                    LblQuestion.Text = "How do you start writing an if statement in C#?";
                    RdoOne.Text = "if x > y then:";
                    RdoTwo.Text = "if (x > y)";
                    RdoThree.Text = "if x > y:";
                    RdoFour.Text = "if {x}>{y}:";
                    correctAnswer = 2;

                    break;

                case 9:
                    LblQuestion.Text = "How do you start writing a while loop in C#?";
                    RdoOne.Text = "while (x > y)";
                    RdoTwo.Text = "while x > y {";
                    RdoThree.Text = "while x > y:";
                    RdoFour.Text = "x > y while {";
                    correctAnswer = 1;

                    break;

                case 10:
                    LblQuestion.Text = "Which of the following is true about try block in C#?";
                    RdoOne.Text = "A try block identifies a block of code for which particular exceptions is activated.";
                    RdoTwo.Text = "It is followed by one or more catch blocks.";
                    RdoThree.Text = "Both of the above.";
                    RdoFour.Text = "None of the above";
                    correctAnswer = 3;

                    break;

            }
        }

    }
}
