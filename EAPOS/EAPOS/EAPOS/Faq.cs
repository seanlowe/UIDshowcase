using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SignIn;
using EAPOS_Project;
using Ordering;

namespace WindowsFormsApplication1
{
    public partial class frmQandA : Form
    {
        public static string faqPath= FormProvider.signInForm.databasespath + @"\EAPOS-Project\FaqQuestions.txt";
        System.IO.FileStream readFileStream = new System.IO.FileStream(faqPath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite);
        public static FileStream faqFile = new FileStream(faqPath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite);
        public class Questions
        {
            public string question;
            public string answer;
            public string keySearch;

            public Questions()
            {
                question = "";
                answer = "";
                keySearch = "";
            }
            static public List<Questions> addQuestion(string addQuestion, string addAnswer, string addKey, List<Questions> faq)
            {
                using (System.IO.FileStream fs1 = new System.IO.FileStream(faqPath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite))

                {
                    Questions temp = new Questions();
                    string faqOutput;
                    System.IO.StreamWriter output = new System.IO.StreamWriter(fs1);
                    faqOutput = addQuestion + " | " + addAnswer + "|" + addKey + Environment.NewLine;
                    temp.question = addQuestion;
                    temp.answer = addAnswer;
                    temp.keySearch = addKey;
                    string faqText = "";
                    if (faq.Contains(temp))
                        Console.Write("Its Already in the faq output");
                    else
                    {
                        faq.Add(temp);
                        faqText = "";
                        for (int i = 0; i < faq.Count; i++)
                        {
                            faqText = faqText + faq[i].question + "|" + faq[i].answer + "|" + faq[i].keySearch + Environment.NewLine;
                            Debug.Print(faqText);
                            output.Write(faq[i].question + "|" + faq[i].answer + "|" + faq[i].keySearch + Environment.NewLine);
                            output.Flush();
                        }
                    }
                    fs1.Close();
                    return faq;
                }
            }
            static public List<Questions> readQuestions(List<Questions> faq)
            {
                using(System.IO.FileStream fs = new System.IO.FileStream(faqPath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite))
                using (System.IO.StreamReader sr = new System.IO.StreamReader(fs))
                {

                    while (sr.Peek() >= 0)
                    {
                        Questions addToFaq = new Questions();
                        string str;
                        string[] strArray;
                        str = sr.ReadLine();
                        strArray = str.Split('|');
                        addToFaq.question= strArray[0];
                        addToFaq.answer = strArray[1];
                        addToFaq.keySearch = strArray[2];
                        if (!faq.Contains(addToFaq))
                        {
                            faq.Add(addToFaq);
                        }


                    }
                }
                // Console.WriteLine(faq[0].question, faq[0].answer);
                return faq;
            }

            static public List<Questions> deleteQuestion(string questionToRemove, List<Questions> faq)
            {
                using (System.IO.FileStream fs1 = new System.IO.FileStream(faqPath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite))

                {
                    Questions temp = new Questions();
                    System.IO.StreamWriter output = new System.IO.StreamWriter(fs1);
                    string faqText = "";
                    int indexofRemoval = faq.FindIndex(a => a.question == questionToRemove);
                    for (int i = 0; i < faq.Count; i++)
                    {
                        if (indexofRemoval == -11)
                        {
                            Console.Write("Not in the faq");
                        }
                        else
                        {
                            faq.Remove(faq[i]);
                            faqText = "";
                            for (int j = 0; j < faq.Count; j++)
                            {
                                faqText = faqText + faq[j].question + "|" + faq[j].answer + "|" + faq[j].keySearch + Environment.NewLine;
                                Debug.Print(faqText);
                                output.Write(faq[j].question + "|" + faq[j].answer + "|" + faq[j].keySearch + Environment.NewLine);
                                output.Flush();
                            }
                        }
                    }
                    fs1.Close();
                    return faq;
                }
            }

        }

        string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);




        public frmQandA()
        {
            InitializeComponent();
            List<Questions> updateText = new List<Questions>();
            updateText = Questions.readQuestions(updateText);
            lblQ1.MaximumSize = new Size(700, 0);
            lblQ1.Text = updateText[0].question;
            lblQ1.AutoSize = true;
            lblA1.Text = updateText[0].answer;
            lblA1.MaximumSize = new Size(700, 0);
            lblA1.AutoSize = true;
            lblQ2.Text = updateText[1].question;
            lblQ2.MaximumSize = new Size(700, 0);
            lblQ2.AutoSize = true;
            lblA2.Text = updateText[1].answer;
            lblA2.MaximumSize = new Size(700, 0);
            lblA2.AutoSize = true;
            lblQ3.Text = updateText[2].question;
            lblQ3.MaximumSize = new Size(700, 0);
            lblQ3.AutoSize = true;
            lblA3.Text = updateText[2].answer;
            lblA3.MaximumSize = new Size(700, 0);
            lblA3.AutoSize = true;
            lblQ4.Text = updateText[3].question;
            lblQ4.MaximumSize = new Size(700, 0);
            lblQ4.AutoSize = true;
            lblA4.Text = updateText[3].answer;
            lblA4.MaximumSize = new Size(700, 0);
            lblA4.AutoSize = true;
            lblA5.MaximumSize = new Size(700, 0);
           lblA5.AutoSize = true;
            lblQ5.MaximumSize = new Size(700, 0);
           lblQ5.AutoSize = true;
           lblQ6.MaximumSize = new Size(700, 0);
           lblQ6.AutoSize = true;
           lblA6.MaximumSize = new Size(700, 0);
            lblA6.AutoSize = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            if (FormProvider.signInForm.ativeUserStatus=="Manager")
            {
                btnAddQuestions.Visible = true;
            }







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
            flpQuestion.HorizontalScroll.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            flpQuestion.Visible=false;
            flpEditingDeletingQuestions.Visible = false;
            flpAddingQuestions.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFaqHome_Click(object sender, EventArgs e)
        {
            flpAddingQuestions.Visible = false;
            flpEditingDeletingQuestions.Visible = false;
            flpQuestion.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            rtbAddAnswer.Text = " ";
            rtbAddQuestion.Text = " ";
            lstbAddKey.ClearSelected();
        }

        private void btnExitFAQ_Click(object sender, EventArgs e)
        {
            FormProvider.orderForm.Enabled = true;
            this.Hide();
            
        }

        private void btnSubmitQuestion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add this question to the FAQ?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                MessageBox.Show("The question has succesfully been added to the faq");
                List<Questions> updatedFaq = new List<Questions>();
                StreamReader sr = new StreamReader(readFileStream);
                string faqText = sr.ReadToEnd();
                string addNewAnswer;
                string addNewQuestion;
                string addNewKey;
                addNewAnswer = rtbAddAnswer.Text;
                addNewQuestion = rtbAddQuestion.Text;
                addNewKey = lstbAddKey.GetItemText(lstbAddKey.SelectedItem);
                updatedFaq=Questions.readQuestions(updatedFaq);
                Questions.addQuestion(addNewQuestion, addNewAnswer, addNewKey,updatedFaq);
                if (lblQ5.Text=="a")
                {
                    lblQ5.Visible = true;
                    lblQ5.Text = addNewQuestion;
                    lblA5.Text = addNewAnswer;
                }
                else
                {
                    lblQ6.Visible = true;
                    lblQ6.Text = addNewQuestion;
                    lblA6.Text = addNewAnswer;
                }
            }

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRemoveEditQuestion_Click(object sender, EventArgs e)
        {
            flpAddingQuestions.Visible = false;
            StreamReader sr = new StreamReader(readFileStream);
            string faqText = sr.ReadToEnd();
            flpQuestion.Visible = false;
            flpEditingDeletingQuestions.Visible = true;
            List<Questions> editFaq = new List<Questions>();
            editFaq= Questions.readQuestions(editFaq);
            Debug.Print(editFaq.Count().ToString());
            for (int i =0; i<editFaq.Count; i++)
            {
                if(lsbQuestionsList.Items.Contains(editFaq[i].question))
                {
                    Debug.Print("Item already in listbox");
                }
                else
                {
                    lsbQuestionsList.Items.Add(editFaq[i].question);
                }
            }
        }
        
        private void btnnextPage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblQ5_Click(object sender, EventArgs e)
        {
            lblA5.Visible = true;
        }

        private void lblA5_Click(object sender, EventArgs e)
        {
            lblA5.Visible = false;
        }

        private void lblQ6_Click(object sender, EventArgs e)
        {
            lblA6.Visible = true;
        }

        private void lblA6_Click(object sender, EventArgs e)
        {
            lblA6.Visible=false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmQandA_Load(object sender, EventArgs e)
        {
            this.Location = new Point(400, 250);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
    }

