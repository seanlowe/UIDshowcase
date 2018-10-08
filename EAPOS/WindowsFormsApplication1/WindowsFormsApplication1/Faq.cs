using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmQandA : Form
    {
        public class Questions
        {
            public string question;
            public string answer;
            public string keySearch;

            public Questions()
            {
                question = " ";
                answer = " ";
                keySearch = " ";
            }

            List<Questions> faq = new List<Questions>();
            public void addQuestion(string addQuestion,string addAnswer, string addKey)
            {
                Questions temp = new Questions();
                temp.answer = addAnswer;
                temp.question = addQuestion;
                temp.keySearch = addKey;
                faq.Add(temp);

            }

            public void readQuestions()
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\dataist.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        string str;
                        string[] strArray;
                        str = sr.ReadLine();

                        strArray = str.Split(',');
                        addQuestion(strArray[0], strArray[1], strArray[2]);

                    }
                }

            }

        }
        string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);




        public frmQandA()
        {
            InitializeComponent();
            lblQ1.MaximumSize = new Size(700, 0);
            lblQ1.AutoSize = true;
            lblA1.MaximumSize = new Size(700, 0);
            lblA1.AutoSize = true;
            lblQ2.MaximumSize = new Size(700, 0);
            lblQ2.AutoSize = true;
            lblA2.MaximumSize = new Size(700, 0);
            lblA2.AutoSize = true;
            lblQ3.MaximumSize = new Size(700, 0);
            lblQ3.AutoSize = true;
            lblA3.MaximumSize = new Size(700, 0);
            lblA3.AutoSize = true;
            lblQ4.MaximumSize = new Size(700, 0);
            lblQ4.AutoSize = true;
            lblA4.MaximumSize = new Size(700, 0);
            lblA4.AutoSize = true;


        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            lblA1.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            lblA1.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label4_Click_1(object sender, EventArgs e)
        {
            lblA2.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            lblA2.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            lblA3.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            lblA3.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            lblA4.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            lblA4.Visible = false;
        }
    }
}
