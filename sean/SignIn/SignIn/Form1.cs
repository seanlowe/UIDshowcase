using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        public bool checkLength()
        {
            if (lblPassword.Text.Length <= 4)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void logIn()
        {
            lblPassword.ResetText();
            pnlSignInScreen.Visible = false;
            pnlChooseScreen.Visible = true;
        }

        public void updatelblPassword(string num)
        {
            if (checkLength() == true)
            {
                lblPassword.Text = lblPassword.Text + num;
                if (lblPassword.Text.Length == 5)
                {
                    logIn();
                }
            } else
            {
                return;
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            updatelblPassword("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            updatelblPassword("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            updatelblPassword("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            updatelblPassword("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            updatelblPassword("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            updatelblPassword("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            updatelblPassword("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            updatelblPassword("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            updatelblPassword("9");
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            updatelblPassword("0");
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (lblPassword.Text.Length == 0)
            {
                return;
            } else
            {
                lblPassword.Text = lblPassword.Text.Remove(lblPassword.Text.Length - 1);
            }
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            lblPassword.ResetText();
            pnlChooseScreen.Visible = false;
        }

        private void btnBackToSignIn_Click(object sender, EventArgs e)
        {
            pnlChooseScreen.Visible = false;
            pnlSignInScreen.Visible = true;
        }

        private void btnOrderScreen_Click(object sender, EventArgs e)
        {
            /* go to the order menu (Ray's screen) */
        }

        private void btnAdminScreen_Click(object sender, EventArgs e)
        {
            /* go to the admin screen (JR's screen) */
        }
    }
}
