using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAPOS_Project;
using Ordering;
using WindowsFormsApplication1;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Resources;

namespace SignIn
{
    public partial class frmSignIn : Form
    {
        // Copy the path of folder where database files are located
        // Do not delete the @ symbol!
        public string databasespath = @"C:\Users\jemathson\Desktop\EAPOS-Newest 3-26-18 7PM\EAPOS-Project";

        public class Employee
        {
            public int id;
            public string fName;
            public string lName;
            public string userStatus;
            public double wage;
            public bool leftHanded;
            public bool colorBlind;
            public double hours;

            //Constructor
            public Employee(int inID, string infName, string inlName, string inUserStats, double inWage, bool inLeft, bool inColor, double inHours)
            {
                id = inID;
                fName = infName;
                lName = inlName;
                userStatus = inUserStats;
                wage = inWage;
                leftHanded = inLeft;
                colorBlind = inColor;
                hours = inHours;
            }

            public void updateHours(double inhours)
            {
                hours += inhours;
            }

            //TO DO: Add more functions...
        }

        //Dynamic Linked list of POS Employees
        public List<Employee> POSEmployees = new List<Employee>();


        public class FoodItem
        {
            public int productid;
            public string filename;
            public string name;
            public double price;
            public string type;
            public Button btnName;

            public FoodItem()
            {
                filename = "";
                name = "";
                price = 0.00;
                type = "";
                btnName = null;
            }

            public FoodItem(string inName, double inPrice, string inType, Button inButton)
            {
                name = inName;
                price = inPrice;
                btnName = inButton;
                type = inType;
            }

            public FoodItem(int inProductID, string inName, double inPrice, string inType, Button inButton, string inputfilename)
            {
                filename = inputfilename;
                name = inName;
                price = inPrice;
                btnName = inButton;
                type = inType;
            }


        }

        //Dynamic Linked list of FoodItems
        public List<FoodItem> pushedInItems = new List<FoodItem>();

        //Dynamic Linked list of buttons
        public List<Button> orderButtons = new List<Button>();




        //----------------------------------------------------- Sign-In Form Load w/ Functions ---------------------------------------------------//
        private void assignButtons()
        {
            orderButtons.Add(null);
            orderButtons.Add(FormProvider.orderForm.btn1);
            orderButtons.Add(FormProvider.orderForm.btn2);
            orderButtons.Add(FormProvider.orderForm.btn3);
            orderButtons.Add(FormProvider.orderForm.btn4);
            orderButtons.Add(FormProvider.orderForm.btn5);
            orderButtons.Add(FormProvider.orderForm.btn6);
            orderButtons.Add(FormProvider.orderForm.btn7);
            orderButtons.Add(FormProvider.orderForm.btn8);
            orderButtons.Add(FormProvider.orderForm.btn9);
            orderButtons.Add(FormProvider.orderForm.btn10);
            orderButtons.Add(FormProvider.orderForm.btn11);
            orderButtons.Add(FormProvider.orderForm.btn12);
            orderButtons.Add(FormProvider.orderForm.btn13);
            orderButtons.Add(FormProvider.orderForm.btn14);
            orderButtons.Add(FormProvider.orderForm.btn15);
            orderButtons.Add(FormProvider.orderForm.btn16);
            orderButtons.Add(FormProvider.orderForm.btn17);
            orderButtons.Add(FormProvider.orderForm.btn18);
        }

        public void resetButtons()
        {
            for(int i=1; i < orderButtons.Count; i++)
            {
                orderButtons[i].Visible = false;
            }
        }


        public void readInFoodItems()
        {
            int index = 1;
            int inputProductId;
            string inputName;
            double inputPrice;
            string inputfilename;
            string inputType;
            Button inButton;

            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasespath + @"\StoredItems.accdb"))
            using (OleDbCommand cmd = new OleDbCommand("select* from ButtonMainPanel ORDER BY ProductID", conn))
            {
                conn.Open();
                OleDbDataReader reader = null;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (index > 9)
                    {
                        FormProvider.orderForm.pnlMenuNavigation.Visible = true;
                    }
                    else
                    {
                        FormProvider.orderForm.pnlMenuNavigation.Visible = false;
                    }
                    inputProductId = Int32.Parse(reader["ProductID"].ToString());
                    inputName = reader["ItemName"].ToString();
                    inputPrice = Convert.ToDouble(reader["Price"].ToString());
                    inputType = reader["Type"].ToString();
                    inputfilename = reader["Filename"].ToString();
                    Debug.Print(inputfilename);
                    inButton = orderButtons[index];
                    inButton.Visible = true;
                    if (inputfilename != "")
                    {
                        inputfilename = databasespath + @"\FoodIcons\png\" + inputfilename;
                        Image buttonpic = Image.FromFile(inputfilename);
                        inButton.BackgroundImage = buttonpic;
                    }
                    else
                    {
                        inButton.Text = inputName;
                    }
                    inButton.Font = new Font("Consolas", 18, FontStyle.Bold);
                    pushedInItems.Add(new FoodItem(inputProductId, inputName, inputPrice, inputType, inButton, inputfilename));

                    index++;
                }
                conn.Close();
            }
        }

        public void readInEmployees()
        {
            int inputID;
            string inputFname;
            string inputLname;
            string inputStatus;
            double inputWage;
            bool inputLeftHanded;
            bool inputColorblind;
            double inputHours;

            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasespath + @"\CoffeeShopEmployees.accdb"))
            using (OleDbCommand cmd = new OleDbCommand("select* from Employees", conn))
            {
                conn.Open();
                OleDbDataReader reader = null;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    inputID = Int32.Parse(reader["ID"].ToString());
                    inputFname = reader["Fname"].ToString();
                    inputLname = reader["Lname"].ToString();
                    inputStatus = reader["Status"].ToString();
                    inputWage = Convert.ToDouble(reader["Wage"].ToString());
                    inputLeftHanded = Convert.ToBoolean(reader["LeftHanded"].ToString()); 
                    inputColorblind = Convert.ToBoolean(reader["Colorblind"].ToString());
                    inputHours = 0.00;         //FIX THIS!!!

                    POSEmployees.Add(new Employee(inputID, inputFname, inputLname, inputStatus, inputWage, inputLeftHanded, inputColorblind, inputHours));

                }
                conn.Close();
            }
        }
        public void frmSignIn_Load(object sender, EventArgs e)
        {
            FormProvider.orderForm.Hide();
            assignButtons();
            readInEmployees();
            readInFoodItems();
            //Image testimage = Image.FromFile(pushedInItems[0].filename);

            //picTest.BackgroundImage = testimage;

            //Test
            for (int i = 0; i < pushedInItems.Count; i++)
                Debug.Print("Item Name: " + pushedInItems[i].name.ToString() + " - Button: " + pushedInItems[i].btnName.Name.ToString());

            for (int i = 0; i < POSEmployees.Count; i++)
                Debug.Print(POSEmployees[i].userStatus);

            timerTime.Enabled = true;
            this.Location = new Point(0, 0);
            lblPassword.ResetText();
            pnlChooseScreen.Visible = false;
        }




        //----------------------------------------------------------- Log In --------------------------------------------------//
        public int activeUserID;
        public string ativeUserStatus;
        public Employee activeEmplyee;

        public frmSignIn()
        {
            InitializeComponent();
        }

        public bool checkLength()
        {
            if (lblPassword.Text.Length <= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void managerlogIn()
        {
            Debug.Print("I ran managerlogIn");
            pnlSignInScreen.Visible = false;
            pnlChooseScreen.Visible = true;
            lblPassword.ResetText();
        }

        public void employeelogin()
        {
            Debug.Print("I ran emplyeelogin");
            FormProvider.orderForm.Show();
            this.Hide();
            lblPassword.ResetText();
        }

        public void traineelogin()
        {
            FormProvider.orderForm.Show();
            this.Hide();
            lblPassword.ResetText();
            FormProvider.orderForm.pnlTrainingInfo.BringToFront();
            FormProvider.orderForm.pnlButtonSection.Visible = false;
            FormProvider.orderForm.pnlButtonSection.Enabled = false;
            FormProvider.orderForm.pnlToolbar.Visible = false;
            FormProvider.orderForm.pnlToolbar.Enabled = false;
            FormProvider.orderForm.btnTrainingNext.Visible = true;
            FormProvider.orderForm.button1.Enabled = false;
            FormProvider.orderForm.pnlTrainingInfo.Visible = true;
            FormProvider.orderForm.btnFAQ.Enabled = false;
            FormProvider.orderForm.pnlTrainingInfo.Location = new Point(502, 299);
            FormProvider.orderForm.rtxtbxTrainingSteps.Text = "This is the where the order will show up as you input the customers order. The bottom box will show a running total , including tax, and/or discounts.";
        }

        public bool goodID = false;

        public void checkID(string empID)
        {
            Debug.Print(empID);
            bool found = false;
            int i = 0;
            while (found == false && i < POSEmployees.Count)
            {
                if (empID == POSEmployees[i].id.ToString())
                {
                    Debug.Print(POSEmployees[i].userStatus.ToString());
                    activeUserID = POSEmployees[i].id;
                    ativeUserStatus = POSEmployees[i].userStatus;
                    activeEmplyee = POSEmployees[i];
                    goodID = true;
                    logInTime(POSEmployees[i].id);
                    found = true;        
                    FormProvider.orderForm.handedness(activeEmplyee.leftHanded);
                    FormProvider.orderForm.lblEmployeeName.Text = activeEmplyee.fName;
                }
                i++;
            }
            if (found == false)
            {
                activeUserID = -1;
                activeEmplyee = null;
            }
                
            checkstatus(ativeUserStatus);
        }

        private void activateColorblind()
        {
            FormProvider.orderForm.btnQuantity.BackColor = SystemColors.ControlLight;
            FormProvider.orderForm.btnMessage.BackColor = SystemColors.ControlLight;
            FormProvider.orderForm.btnDeleteItem.BackColor = SystemColors.ControlLight;
            FormProvider.orderForm.btnCancelOrder.BackColor = SystemColors.ControlLight;
            FormProvider.orderForm.btnPay.BackColor = SystemColors.ControlLight;
            FormProvider.orderForm.btnCashOption.BackColor = SystemColors.ControlLight;
            /*
            FormProvider.orderForm.btn1.BackgroundImage = null;
            FormProvider.orderForm.btn1.Text = "Burger";
            FormProvider.orderForm.btn2.BackgroundImage = null;
            FormProvider.orderForm.btn2.Text = "Hot Dog";
            FormProvider.orderForm.btn3.BackgroundImage = null;
            FormProvider.orderForm.btn3.Text = "Chicken";
            FormProvider.orderForm.btn4.BackgroundImage = null;
            FormProvider.orderForm.btn4.Text = "Pizza Slice";
            FormProvider.orderForm.btn5.BackgroundImage = null;
            FormProvider.orderForm.btn5.Text = "Whole Pizza";
            FormProvider.orderForm.btn6.BackgroundImage = null;
            FormProvider.orderForm.btn6.Text = "Ice Cream";
            FormProvider.orderForm.btn7.BackgroundImage = null;
            FormProvider.orderForm.btn7.Text = "Donut";
            FormProvider.orderForm.btn8.BackgroundImage = null;
            FormProvider.orderForm.btn8.Text = "Coffee";
            FormProvider.orderForm.btn9.BackgroundImage = null;
            */
        }

        public void resetColors()
        {
            FormProvider.orderForm.btnQuantity.BackColor = Color.PaleTurquoise;
            FormProvider.orderForm.btnMessage.BackColor = Color.PaleTurquoise;
            FormProvider.orderForm.btnDeleteItem.BackColor = Color.Orange;
            FormProvider.orderForm.btnCancelOrder.BackColor = Color.OrangeRed;
            FormProvider.orderForm.btnPay.BackColor = Color.LimeGreen;
            FormProvider.orderForm.btnCashOption.BackColor = Color.LimeGreen;
            FormProvider.orderForm.btn1.Text = "";
            FormProvider.orderForm.btn2.Text = "";
            FormProvider.orderForm.btn3.Text = "";
            FormProvider.orderForm.btn4.Text = "";
            FormProvider.orderForm.btn5.Text = "";
            FormProvider.orderForm.btn6.Text = "";
            FormProvider.orderForm.btn7.Text = "";
            FormProvider.orderForm.btn8.Text = "";
            FormProvider.orderForm.btn9.Text = "";
            readInFoodItems();
        }

        public void checkstatus(string status)
        {
            if (goodID == true)
            {
                if(activeEmplyee.colorBlind == true)
                {
                    activateColorblind();
                }
                if (status == "Manager")

                {
                    FormProvider.orderForm.btnGoToManagerMode.Visible = true;
                    managerlogIn();
                        
                }

                // --- Add the following code once we know how to run training mode ---

                
                else if (status == "Training")
                {
                    traineelogin();
                }
                

                else
                {
                    employeelogin();
                    return;
                }               
            }
            else
            {
                MessageBox.Show("Invalid Login Id");
                lblPassword.ResetText();
            }
        }
        public void updatelblPassword(string num)
        {
            if (checkLength() == true)
            {
                lblPassword.Text = lblPassword.Text + num;
                if (lblPassword.Text.Length == 4)
                {
                    checkID(lblPassword.Text);
                }
            }
        }


        public void logInTime(int id)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasespath + @"\CoffeeShopEmployees.accdb");
            conn.Open();
            
            string sqlQuery = "INSERT INTO Hours (EmpID, Today, ClockIn) values(@EmpID, Now(), Now())";
            OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("@EmpID", id);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void logOutTime(int id)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasespath + @"\CoffeeShopEmployees.accdb");
            conn.Open();

            string sqlQuery = "UPDATE Hours SET ClockOut = Now() WHERE TRIM(ClockOut) IS NULL";
            OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();
            conn.Close();
        }


        //---------------------------------------------- Button Panel ---------------------------------------------//
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
            }
            else
            {
                lblPassword.Text = lblPassword.Text.Remove(lblPassword.Text.Length - 1);
            }
        }


        private void btnBackToSignIn_Click(object sender, EventArgs e)
        {
            pnlChooseScreen.Visible = false;
            pnlSignInScreen.Visible = true;
        }

        private void btnOrderScreen_Click(object sender, EventArgs e)
        {
            /* go to the order menu (Ray's screen) */
            FormProvider.orderForm.Show();
            this.Hide();
            pnlChooseScreen.Visible = false;
            pnlSignInScreen.Visible = true;
        }

        private void btnAdminScreen_Click(object sender, EventArgs e)
        {
            /* go to the admin screen (JR's screen) */
            FormProvider.managerForm.Show();
            this.Hide();
            pnlChooseScreen.Visible = false;
            pnlSignInScreen.Visible = true;
        }

        private void pnlChooseScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblCurrentDate.Text = DateTime.Now.ToString();
        }

        private void picTest_Click(object sender, EventArgs e)
        {

        }
    }

    /*
    We do not want to create new instances of the forms. In order to
    show and hide one instance of the forms, we need to hold a reference to
    them. This static class below uses the singleton pattern to ensure only
    one instance of the form runs at runtime.
    */
    public class FormProvider
    {
        //These are the forms...
        private static frmMain _orderingForm;
        private static frmManagerMode _managerForm;
        private static frmSignIn _signInForm;
        private static frmQandA _FAQForm;

        //Returns a reference to the form
        public static frmMain orderForm
        {
            get
            {
                if (_orderingForm == null)
                {
                    _orderingForm = new frmMain();
                }
                return _orderingForm;
            }
        }

        //Returns a reference to the form
        public static frmManagerMode managerForm
        {
            get
            {
                if (_managerForm == null)
                {
                    _managerForm = new frmManagerMode();
                }
                return _managerForm;
            }
        }

        //Returns a reference to the form
        public static frmSignIn signInForm
        {
            get
            {
                if (_signInForm == null)
                {
                    _signInForm = new frmSignIn();
                }
                return _signInForm;
            }
        }

        //Returns a reference to the form
        public static frmQandA FAQForm
        {
            get
            {
                if (_FAQForm == null)
                {
                    _FAQForm = new frmQandA();
                }
                return _FAQForm;
            }
        }
    }
}
