using System.Windows.Forms;

namespace QuizProject
{
    public partial class TestIsOver : Form
    {
        public TestIsOver(int s)
        {
            InitializeComponent();
            int score = s;
            label2.Text = "You Answered " + score + " Questions Correctly From 10 ";
            label3.Text = "You Answered " + score * 10 + " % Correctly";
            score = 0;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
