using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SignIn;
using WindowsFormsApplication1;
using EAPOS_Project;
using System.Data.OleDb;
using System.IO;

namespace Ordering
{
    public partial class frmMain : Form
    {
        public int nextopenindex = 0;
        public int ordernumber;

        // Global double for cashing out
        public double runningtotal = 0.0;
        public double newtotal = 0.0;

        //Class for the order Items
        public class orderItem
        {
            public int quantity;
            public frmSignIn.FoodItem foodItem;
            public string[] strmessage = new string[5];
            public int nummessages;
            public bool message;
            public int myindex;
            public int localordernumber;
            public frmSignIn.Employee cashier;

            //Constructor
            public orderItem(frmSignIn.FoodItem inputFoodItem, int inindex)
            {
                localordernumber = FormProvider.orderForm.ordernumber;
                foodItem = inputFoodItem;
                quantity = 1;
                cashier = FormProvider.signInForm.activeEmplyee;
                message = false;
                for (int i = 0; i < 5; i++)
                {
                    strmessage[i] = "";
                }
                nummessages = 0;
                myindex = inindex;
            }

            public override string ToString()
            {
                string type = foodItem.name;
                string strPrice = string.Format("{0:C}", foodItem.price);

                string orderline = quantity.ToString().PadRight(5) + type.PadRight(21) + strPrice;
                return orderline;
            }

            public void incrementmessage()
            {
                nummessages++;
            }

            //Increments the quantity of oderItem
            public void incrementQuantity()
            {
                quantity++;
            }

            //Food Item accessor
            public string getFoodItemName()
            {
                return foodItem.name;
            }

            //Quantity accessor
            public int getQunatity()
            {
                return quantity;
            }

        }

        //Dynamic linked list of orderItems
        List<orderItem> Orders = new List<orderItem>();

        //Order history - a list of a list of order Items (where each node is an order)
        //Add to this list when payment is complete
        List<List<orderItem>> CurrentHistroy = new List<List<orderItem>>();

        public int getOrderNumber()
        {
            string path = Directory.GetCurrentDirectory();
            string newordernumber = System.IO.File.ReadAllText(@path + @"\OrderNumber.txt");
            ordernumber = Int32.Parse(newordernumber.ToString());
            Debug.Print("The order number is " + ordernumber.ToString());
            return ordernumber;
        }

        public void updateOrderNumbers()
        {
            string path = Directory.GetCurrentDirectory();
            ordernumber++;
            string updatednumber = ordernumber.ToString();
            System.IO.File.WriteAllText(@path + @"\OrderNumber.txt", updatednumber);
            Debug.Print("I updated order number to " + updatednumber);
        }


        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Orders.Count != 0)
            {
                button1.Enabled = false;
                MessageBox.Show("Must Complete or Cancel order before signing out!");
            }
            else
            {
                FormProvider.signInForm.resetColors();
                FormProvider.signInForm.Show();
                btnGoToManagerMode.Visible = false;
                this.Hide();
                FormProvider.signInForm.logOutTime(FormProvider.signInForm.activeUserID);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string width;
            string height;

            width = this.Width.ToString();
            height = this.Height.ToString();

            lblResolution.Text = "Height: " + height + " Width: " + width;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            calculateOrderTotal();
            OrderingTimer.Enabled = true;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            lstbOrders.Text = "";
            lblLabelReceipt.Text = "Qty".PadRight(5) + "Description".PadRight(21) + "Amount($)";
            getOrderNumber();
        }
        

        private void OrderingTimer_Tick(object sender, EventArgs e)
        {
            lblCurrentDate.Text = DateTime.Now.ToString();
        }

        //This function adds items to the current order
        private void addToOder(string buttonName)
        {
            bool found = false;
            int i = 0;
            frmSignIn.FoodItem foodItem;
            Debug.Print("You clicked on:" + buttonName);


            //Finds the associated food item
            while (found == false && i < FormProvider.signInForm.pushedInItems.Count)
            {
                if (FormProvider.signInForm.pushedInItems[i].btnName.Name == buttonName)
                {
                    found = true;
                    Debug.Print("Found the assigned button!");
                    bool doesItExistAlready = false;
                    foodItem = FormProvider.signInForm.pushedInItems[i];
                    Debug.Print("It is: " + FormProvider.signInForm.pushedInItems[i].name.ToString());

                    //Need to check if the item already exists in the Orders list, if so then increment the quantity of item..
                    for (int j = 0; j < Orders.Count; j++)
                    {
                        if (Orders[j].foodItem.name == foodItem.name)
                        {
                            Debug.Print("The item is already in the order! Incrementing the quantity");
                            doesItExistAlready = true;
                            Orders[j].incrementQuantity();
                        }

                    }

                    //Add the orderItem only if it does not exist!
                    if (!doesItExistAlready)
                    {
                        //Add the oderItem to the Orders list
                        Debug.Print("Item did not exist in order so I added it!");
                        Orders.Add(new orderItem(foodItem, nextopenindex));
                        nextopenindex++;
                    }
                    //Prints
                    PrintOrders();
                }
                i++;
                calculateOrderTotal();
            }
            if (found == false)
                Debug.Print("Could not find associated object!");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string objname = ((Button)sender).Name;
            addToOder(objname);
        }

        private void btnWholePizza_Click(object sender, EventArgs e)
        {
            string objname = ((Button)sender).Name;
            addToOder(objname);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete an OrderItem
            int index = lstbOrders.SelectedIndex;

            //Check to see if something is selected
            if (index != -1)
            {
                for (int i = 0; i < Orders.Count; i++)
                {
                    if (Orders[i] == lstbOrders.Items[index])
                    {
                        //Removes the item from the order
                        Orders.RemoveAt(i);
                    }
                }
            }
            calculateOrderTotal();
            PrintOrders();
        }



        private void btnHotDog_Click(object sender, EventArgs e)
        {
            string objname = ((Button)sender).Name;
            addToOder(objname);
        }

        private void btnPizzaSlice_Click(object sender, EventArgs e)
        {
            string objname = ((Button)sender).Name;
            addToOder(objname);
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            string objname = ((Button)sender).Name;
            addToOder(objname);
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            string objname = ((Button)sender).Name;
            addToOder(objname);
        }

        private void btnSode_Click(object sender, EventArgs e)
        {
            string objname = ((Button)sender).Name;
            addToOder(objname);
        }

        private void btnBagel_Click(object sender, EventArgs e)
        {
            string objname = ((Button)sender).Name;
            addToOder(objname);
        }

        private void btnIceCream_Click(object sender, EventArgs e)
        {
            string objname = ((Button)sender).Name;
            addToOder(objname);
        }

        void PrintOrders()
        {
            Debug.Print("I am printing the orders!");
            //Clears the listbox in the ordering form
            lstbOrders.Items.Clear();
            string messagelines;
            for (int i = 0; i < Orders.Count; i++)
            {
                lstbOrders.Items.Add(Orders[i]);
                if (Orders[i].message == true)
                {
                    for (int j = 0; j < Orders[i].nummessages; j++)
                    {
                        Debug.Print("Item : " + Orders[i].foodItem.name.ToString() + " has nummessages set to: " + Orders[i].nummessages.ToString());
                        Debug.Print("I see message: " + Orders[i].strmessage[j]);
                        messagelines = " - " + Orders[i].strmessage[j];
                        lstbOrders.Items.Add(messagelines);
                    }

                }
            }
            lstbOrders.Items.Add("");
            lstbOrders.Items.Add("Order # " + ordernumber.ToString());
        }

        void AddItemToOrder(ref int quantity, string name, double price)
        {

        }

        void calculateOrderTotal()
        {
            //Calculates the total price
            double totalPrice = 0.00;
            double taxRate = 0.0275;
            double taxTotal = 0;

            for (int i = 0; i < Orders.Count; i++)
            {
                totalPrice = totalPrice + (Orders[i].foodItem.price * Orders[i].getQunatity());
                
            }

            taxTotal = totalPrice * taxRate;

            

            rtxtbOrderFinal.Clear();
            rtxtbOrderFinal.AppendText(" Subtotal: ".PadRight(28) + string.Format("{0:C2}", (Convert.ToDecimal(totalPrice.ToString()) * 100) / 100)); 
            rtxtbOrderFinal.AppendText(Environment.NewLine);
            rtxtbOrderFinal.AppendText(" Discount: ".PadRight(28) + "$0.00");
            rtxtbOrderFinal.AppendText(Environment.NewLine);
            rtxtbOrderFinal.AppendText(" Tax: ".PadRight(28) + string.Format("{0:C2}", (Convert.ToDecimal(taxTotal.ToString()))));

            rtxtbOrderFinal.AppendText(Environment.NewLine);
            rtxtbOrderFinal.AppendText(Environment.NewLine);
            rtxtbOrderFinal.AppendText(Environment.NewLine);
            rtxtbOrderFinal.AppendText("------------------------------------");
            rtxtbOrderFinal.AppendText(Environment.NewLine);

            totalPrice += taxTotal;
            newtotal = totalPrice;
            runningtotal = totalPrice;

            rtxtbOrderFinal.AppendText(" Total: ".PadRight(28) + string.Format("{0:C2}", (Convert.ToDecimal(totalPrice.ToString()) * 100) / 100));
            rtxtbOrderFinal.AppendText(Environment.NewLine);
        }


        //Prints the list of items in this order!
        void debugTest()
        {
            for (int i = 0; i < Orders.Count; i++)
            {
                Debug.Print(Orders[i].foodItem.name);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Hides main ordering screen
            pnlOrderFunctions.Visible = false;

            // Shows cash out screen 
            pnlFullCashoutSection.Visible = true;
            pnlFullCashoutSection.BringToFront();
            pnlCashOutTools.Visible = true;
            pnlCashOutTools.BringToFront();
            gpbxPaymentType.Visible = true;
            gpbxPaymentType.BringToFront();
            cashpayment = true;
            lblCurrentAmountDue.Text = string.Format("{0:#.00}", (Convert.ToDecimal(runningtotal.ToString()) * 100) / 100);
            if(FormProvider.signInForm.activeEmplyee.colorBlind != true)
            {
                btnCashOption.BackColor = Color.LimeGreen;
            }
            else
            {
                btnCashOption.BackColor = SystemColors.ControlLight;
            }
            if(runningtotal == 0.0)
            {
                pnlButtonSection.Enabled = false;
            }
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {           
            if(FormProvider.signInForm.activeEmplyee.userStatus=="Manager")
            {
                FormProvider.FAQForm.btnAddQuestions.Visible = true;
                FormProvider.FAQForm.btnFaqHome.Visible = true;

            }
            FormProvider.FAQForm.Show();
            this.Enabled = false;
        }

        private void btnPage2_Click(object sender, EventArgs e)
        {
            this.pnlMenuPage1.Visible = false;
            this.pnlMenuPage2.Visible = true;
        }

        private void btnPage1_Click(object sender, EventArgs e)
        {
            this.pnlMenuPage1.Visible = true;
            this.pnlMenuPage2.Visible = false;
        }

        public void btn10_Click(object sender, EventArgs e)
        {
            string objname = ((Button)sender).Name;
            addToOder(objname);
        }

        private void pnlOrdering_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btnGoToManagerMode_Click(object sender, EventArgs e)
        {
            if (Orders.Count != 0)
            {
                button1.Enabled = false;
                MessageBox.Show("Must Complete or Cancel order before going to Back Office!");
            }
            else
            {
                FormProvider.managerForm.Show();
                this.Hide();
            }
                
        }

        private void lblEmployeeName_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            pnlConfirmCancelOrder.Visible = true;
            pnlConfirmCancelOrder.BringToFront();
            pnlOrdering.Enabled = false;
        }



        //--------------------------------------------------------- Numeric Keypad ----------------------------------------------//

        public void updateKeypadDisplay(string num)
        {
            txtbKeypad.Text = txtbKeypad.Text + num;
        }

        private void btn1Keypad_Click(object sender, EventArgs e)
        {
            updateKeypadDisplay("1");
        }
        private void btn2Keypad_Click(object sender, EventArgs e)
        {
            updateKeypadDisplay("2");
        }

        private void btn3Keypad_Click(object sender, EventArgs e)
        {
            updateKeypadDisplay("3");
        }

        private void btn4Keypad_Click(object sender, EventArgs e)
        {
            updateKeypadDisplay("4");
        }

        private void btn5Kepad_Click(object sender, EventArgs e)
        {
            updateKeypadDisplay("5");
        }

        private void btn6Keypad_Click(object sender, EventArgs e)
        {
            updateKeypadDisplay("6");
        }

        private void btn7Keypad_Click(object sender, EventArgs e)
        {
            updateKeypadDisplay("7");
        }

        private void btn8Keypad_Click(object sender, EventArgs e)
        {
            updateKeypadDisplay("8");
        }

        private void btn9Keypad_Click(object sender, EventArgs e)
        {
            updateKeypadDisplay("9");
        }

        private void btn0Keypad_Click(object sender, EventArgs e)
        {
            updateKeypadDisplay("0");
        }

        private void btnPeriodKeypad_Click(object sender, EventArgs e)
        {
            updateKeypadDisplay(".");
        }

        private void btnDoubleZerosKeypad_Click(object sender, EventArgs e)
        {
            updateKeypadDisplay(".00");
        }

        private void btnCancelKeypad_Click(object sender, EventArgs e)
        {
            txtbKeypad.ResetText();
            pnlKeypad.Visible = false;
            pnlOrdering.Enabled = true;
        }
        private void btnClearKeypad_Click(object sender, EventArgs e)
        {
            txtbKeypad.ResetText();
        }

        private void btnKeypadEnter_Click(object sender, EventArgs e)
        {
            if(txtbKeypad.Text != "")
            {
                Debug.Print("The Keypad label is " + lblKeypadTitle.Text);
                if (lblKeypadTitle.Text == "Enter New Quantity")
                {
                    int index = lstbOrders.SelectedIndex;
                    int newQuantity = Int32.Parse(txtbKeypad.Text.ToString());
                    if (newQuantity != 0)
                    {
                        for (int i = 0; i < Orders.Count; i++)
                        {
                            if (Orders[i] == lstbOrders.Items[index])
                            {
                                Orders[i].quantity = newQuantity;
                                break;
                            }
                        }
                    }
                    else
                    {
                        //Check to see if something is selected
                        if (index != -1)
                        {
                            for (int i = 0; i < Orders.Count; i++)
                            {
                                if (Orders[i] == lstbOrders.Items[index])
                                {
                                    //Removes the item from the order
                                    Orders.RemoveAt(i);
                                }
                            }
                        }                      
                    }
                    lblKeypadTitle.Text = "";
                    calculateOrderTotal();
                    PrintOrders();
                    pnlOrdering.BringToFront();
                    pnlOrdering.Enabled = true;
                }
                else if (lblKeypadTitle.Text == "Enter Override Code")
                {
                    int id = Int32.Parse(txtbKeypad.Text.ToString());
                    if (checkStatus(id) == true)
                    {

                        if (purpose == "labor")
                        {
                            Debug.Print("the purpose of override is to check " + purpose);
                            showLaborReport();
                            pnlLaborReport.Visible = true;
                            pnlLaborReport.BringToFront();
                            pnlKeypad.Visible = false;
                        }
                        else if (purpose == "refund")
                        {
                            Debug.Print("the purpose of override is to check " + purpose);
                            lblKeypadTitle.Text = "Enter Refund Amount";
                            pnlKeypad.Visible = true;
                            pnlKeypad.BringToFront();
                        }
                        else if(purpose == "house charge")
                        {
                            Debug.Print("the purpose of override is to check " + purpose);
                            lblKeypadTitle.Text = "Enter House Charge Amount";
                            pnlKeypad.Visible = true;
                            pnlKeypad.BringToFront();
                        }
                        else if(purpose == "paid out")
                        {
                            Debug.Print("the purpose of override is to check " + purpose);
                            lblKeypadTitle.Text = "Enter Paid Out Amount";
                            pnlKeypad.Visible = true;
                            pnlKeypad.BringToFront();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                        txtbKeypad.Text = "";
                    }

                }
                else if (lblKeypadTitle.Text == "Enter Paid Out Amount")
                {
                    pnlPOHC.Visible = true;
                    pnlPOHC.BringToFront();
                    lblTypeMgmt.Text = "Paid Out";
                    lblPOHCTotal.Text = "$" + string.Format("{0:#.00}", (Convert.ToDecimal(txtbKeypad.Text) * 100) / 100);
                    txtbKeypad.Text = "";
                    pnlKeypad.Visible = false;
                }
                else if (lblKeypadTitle.Text == "Enter House Charge Amount")
                {
                    pnlPOHC.Visible = true;
                    pnlPOHC.BringToFront();
                    lblTypeMgmt.Text = "House Charge";
                    lblPOHCTotal.Text = "$" + string.Format("{0:#.00}", (Convert.ToDecimal(txtbKeypad.Text) * 100) / 100);
                    txtbKeypad.Text = "";
                    pnlKeypad.Visible = false;
                }
                else if (lblKeypadTitle.Text == "Enter Refund Amount")
                {
                    pnlPOHC.Visible = true;
                    pnlPOHC.BringToFront();
                    lblTypeMgmt.Text = "Refund";
                    lblPOHCTotal.Text = "$" + string.Format("{0:#.00}", (Convert.ToDecimal(txtbKeypad.Text) * 100) / 100);
                    txtbKeypad.Text = "";
                    pnlKeypad.Visible = false;
                    pnlOrderHistory.Visible = false;
                }
            }
            txtbKeypad.Text = "";
        }

        public string purpose;
        private void showKeypad(string buttonName)
        {
            txtbKeypad.Text = "";
            pnlOrdering.Enabled = false;
            if (buttonName == "btnLabor")
            {
                Debug.Print("I pressed the " + buttonName + " button.");
                if (FormProvider.signInForm.activeEmplyee.userStatus == "Manager")
                {
                    showLaborReport();
                    pnlLaborReport.Visible = true;
                    pnlLaborReport.BringToFront();
                }
                else
                {
                    lblKeypadTitle.Text = "Enter Override Code";
                    purpose = "labor";
                    pnlKeypad.Visible = true;
                    pnlKeypad.BringToFront();
                }
            }
            else if(buttonName == "btnQuantity")
            {
                Debug.Print("I pressed the " + buttonName + " button.");
                
                    //Makes the keypad show up
                    lblKeypadTitle.Text = "Enter New Quantity";
                    pnlKeypad.Visible = true;
                    pnlKeypad.BringToFront();
                
            }
            else if (buttonName == "btnRefund")
            {
                Debug.Print("I pressed the " + buttonName + " button.");
                if (FormProvider.signInForm.activeEmplyee.userStatus == "Manager")
                {
                    //Makes the keypad show up
                    lblKeypadTitle.Text = "Enter Refund Amount";
                    pnlKeypad.Visible = true;
                    pnlKeypad.BringToFront();
                }
                else
                {
                    lblKeypadTitle.Text = "Enter Override Code";
                    purpose = "refund";
                    pnlKeypad.Visible = true;
                    pnlKeypad.BringToFront();
                }
            }
            else if (buttonName == "btnHouseCharge")
            {
                Debug.Print("I pressed the " + buttonName + " button.");
                if (FormProvider.signInForm.activeEmplyee.userStatus == "Manager")
                {
                    lblKeypadTitle.Text = "Enter House Charge Amount";
                    pnlKeypad.Visible = true;
                    pnlKeypad.BringToFront();
                    //showFinalScreen();
                }
                else
                {
                    lblKeypadTitle.Text = "Enter Override Code";
                    purpose = "house charge";
                    pnlKeypad.Visible = true;
                    pnlKeypad.BringToFront();
                }
            }
            else if (buttonName == "btnPaidOut")
            {
                Debug.Print("I pressed the " + buttonName + " button.");
                if (FormProvider.signInForm.activeEmplyee.userStatus == "Manager")
                {
                    lblKeypadTitle.Text = "Enter Paid Out Amount";
                    pnlKeypad.Visible = true;
                    pnlKeypad.BringToFront();
                }
                else
                {
                    lblKeypadTitle.Text = "Enter Override Code";
                    purpose = "paid out";
                    pnlKeypad.Visible = true;
                    pnlKeypad.BringToFront();
                }
            }
        }

        public bool idVerified;
        private bool checkStatus(int id)
        {
            Debug.Print("Input id is " + id.ToString());
            for(int i = 0; i < FormProvider.signInForm.POSEmployees.Count; i++)
            {
                if(FormProvider.signInForm.POSEmployees[i].id == id)
                {
                    if(FormProvider.signInForm.POSEmployees[i].userStatus == "Manager")
                    {
                        Debug.Print("Managers name is " + FormProvider.signInForm.POSEmployees[i].fName);
                        idVerified = true;
                    }
                    else
                    {
                        idVerified = false;
                    }
                }
            }

            if(idVerified == true)
            {
                return true;
            }
            else 
                return false;
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            if (lstbOrders.SelectedIndex != -1)
            {
                string objname = ((Button)sender).Name;
                showKeypad(objname);
            }
                //Checks to see if an item is selected in the order listbox
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            txtbMessageDisplay.Text = "";
            pnlMessageKeyboard.Visible = true;
            pnlMessageKeyboard.BringToFront();
            pnlOrdering.Enabled = false;
        }

        private void btnEnterMessage_Click(object sender, EventArgs e)
        {
            int index = lstbOrders.SelectedIndex;

            //Check to see if something is selected
            if (index != -1)
            {
                for (int i = 0; i < Orders.Count; i++)
                {
                    if (Orders[i] == lstbOrders.Items[index])
                    {
                        if (Orders[i].message == false)
                        {
                            Orders[i].message = true;
                            Orders[i].strmessage[Orders[i].nummessages] = txtbMessageDisplay.Text;
                            Orders[i].nummessages++;

                            Debug.Print("This is my message " + Orders[i].strmessage[0].ToString() + "I am a " + Orders[i].foodItem.name.ToString());
                        }
                        else
                        {
                            if (Orders[i].nummessages < 5)
                            {
                                Orders[i].strmessage[Orders[i].nummessages] = txtbMessageDisplay.Text;
                                Orders[i].nummessages++;

                                Debug.Print("This is my message " + Orders[i].strmessage[0].ToString() + "I am a " + Orders[i].foodItem.name.ToString());
                            }
                        }
                    }
                }
            }
            PrintOrders();
            pnlMessageKeyboard.Visible = false;
            pnlOrdering.Enabled = true;
        }

        private void btnCancelMessage_Click(object sender, EventArgs e)
        {
            pnlMessageKeyboard.Visible = false;
            pnlOrdering.Enabled = true;
        }

        public void handedness(bool lefthanded)
        {
            if (lefthanded)
            {
                pnlButtonSection.Location = new Point(26, 135);
                pnlToolbar.Location = new Point(826, 186);
                pnlCurrentOrder.Location = new Point(1082, 186);
            }
            else
            {
                pnlButtonSection.Location = new Point(746, 139);
                pnlToolbar.Location = new Point(505, 186);
                pnlCurrentOrder.Location = new Point(35, 186);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        //------------------------------------------------- Message Keyboard and Keypad ------------------------------------------//

        public void updateMessageDisplay(string num)
        {
            txtbMessageDisplay.Text = txtbMessageDisplay.Text + num;
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("A");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("B");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("C");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("D");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("E");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("F");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("G");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("H");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("I");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("J");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("K");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("L");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("M");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("N");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("O");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("P");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("Q");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("R");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("S");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("T");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("U");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("V");
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("W");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("X");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("Y");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("Z");
        }

        private void btnSpaceBar_Click(object sender, EventArgs e)
        {
            updateMessageDisplay(" ");
        }

        private void btnForwardSlash_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("/");
        }

        private void btnExclamationPoint_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("!");
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            updateMessageDisplay(",");
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            updateMessageDisplay(".");
        }

        private void btn0Keyboard_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("0");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("-");
        }

        private void btn1Keyboard_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("1");
        }

        private void btn2Keyboard_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("2");
        }

        private void btn3Keyboard_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("3");
        }

        private void btn4Keyboard_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("4");
        }

        private void btn5Keyboard_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("5");
        }

        private void btn6Keyboard_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("6");
        }

        private void btn7Keyboard_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("7");
        }

        private void btn8Keyboard_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("8");
        }

        private void btn9Keyboard_Click(object sender, EventArgs e)
        {
            updateMessageDisplay("9");
        }

        private void btnClearMessageDisplay_Click(object sender, EventArgs e)
        {
            txtbMessageDisplay.Text = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtbMessageDisplay.Text.Length == 0)
            {
                return;
            }
            else
            {
                txtbMessageDisplay.Text = txtbMessageDisplay.Text.Remove(txtbMessageDisplay.Text.Length - 1);
            }
        }

        // FUnction to calculate new total for cashing out
        public void newTotal(double payment)
        {
            newtotal = payment - newtotal; 
        }
        
        private void btnEnterPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbPaymentAmount.Text) == false && cashpayment == true)
            {
                double payment = Double.Parse(txtbPaymentAmount.Text);
                newTotal(payment);
                Debug.Print("The new total is " + newtotal.ToString());
                if (newtotal > 0.0)
                {
                    // Payment is greater than the total
                    // Prompts final cash due panel then returns to order screen
                    lblCustomerPayment.Text = string.Format("{0:#.00}", (Convert.ToDecimal(payment.ToString()) * 100) / 100);
                    lblCashDueAmount.Text = string.Format("{0:#.00}", (Convert.ToDecimal(newtotal.ToString()) * 100) / 100);

                    showFinalScreen();
                }
                else if (newtotal < 0.0)
                {
                    // 
                    newtotal = newtotal * (-1.0);
                    lblCurrentAmountDue.Text = string.Format("{0:#.00}", (Convert.ToDecimal(newtotal.ToString()) * 100) / 100);
                    txtbPaymentAmount.Clear();
                }
                else
                {
                    MessageBox.Show("Nothing to cash out");
                }
            }
            else if (string.IsNullOrWhiteSpace(txtbPaymentAmount.Text) == true && cashpayment == false)
            {
                lblCustomerPayment.Text = "Credit";
                lblCashDueAmount.Text = "$0.00";
                showFinalScreen();
            }
        }

        private void showFinalScreen()
        {
            lblTotalFinalAmount.Text = string.Format("{0:#.00}", (Convert.ToDecimal(runningtotal.ToString()) * 100) / 100);
            lblOrderNumberFinalPage.Text = ordernumber.ToString();
            pnlTransactionComplete.Visible = true;
            pnlTransactionComplete.BringToFront();
            txtbPaymentAmount.Clear();
            pnlOrdering.Enabled = false;
            
        }

        //-------------------------------------------------------- Cash-Out Button Panel --------------------------------------------//
        public void updatePaymentDisplay(string num)
        {
            txtbPaymentAmount.Text = txtbPaymentAmount.Text + num;
        }

        private void btn1Payment_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay("1");
        }

        private void btn2Payment_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay("2");
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void btnZeroPayment_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay("0");
        }

        private void btn3Payment_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay("3");
        }

        private void btn4Payment_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay("4");
        }

        private void btn5Payment_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay("5");
        }

        private void btn6Payment_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay("6");
        }

        private void btn7Payment_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay("7");
        }

        private void btn8Payment_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay("8");
        }

        private void btn9Payment_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay("9");
        }

        private void btnPeriodPayment_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay(".");
        }

        private void btnDoubleZeros_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay("00");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            updatePaymentDisplay(".00");
        }

        private void btnBackspacePayment_Click(object sender, EventArgs e)
        {
            if (txtbPaymentAmount.Text.Length == 0)
            {
                return;
            }
            else
            {
                txtbPaymentAmount.Text = txtbPaymentAmount.Text.Remove(txtbPaymentAmount.Text.Length - 1);
            }
        }

        private void btnClearPayment_Click(object sender, EventArgs e)
        {
            txtbPaymentAmount.Clear();
        }

        private void btnBackToOrder_Click(object sender, EventArgs e)
        {
            pnlFullCashoutSection.Visible = false;
            pnlCashOutTools.Visible = false;
            pnlOrderFunctions.Visible = true;
            gpbxPaymentType.Visible = false;
            pnlButtonSection.Enabled = true;
        }

        private void btnFiveDollars_Click(object sender, EventArgs e)
        {
            newTotal(5.0);
            Debug.Print("The new total is " + newtotal.ToString());
            if ( newtotal > 0.0)
            {
                lblCustomerPayment.Text = "$5.00";
                lblCashDueAmount.Text = string.Format("{0:#.00}", (Convert.ToDecimal(newtotal.ToString()) * 100) / 100);
                showFinalScreen();
            }
            else
            {
                newtotal = newtotal * (-1.0);
                lblCurrentAmountDue.Text = string.Format("{0:#.00}", (Convert.ToDecimal(newtotal.ToString()) * 100) / 100);
                txtbPaymentAmount.Clear();
            }
        }

        private void btnTenDollars_Click(object sender, EventArgs e)
        {
            newTotal(10.0);
            Debug.Print("The new total is " + newtotal.ToString());
            if (newtotal > 0.0)
            {
                lblCustomerPayment.Text = "$10.00";
                lblCashDueAmount.Text = string.Format("{0:#.00}", (Convert.ToDecimal(newtotal.ToString()) * 100) / 100);
                showFinalScreen();
            }
            else
            {
                newtotal = newtotal * (-1.0);
                lblCurrentAmountDue.Text = string.Format("{0:#.00}", (Convert.ToDecimal(newtotal.ToString()) * 100) / 100);
                txtbPaymentAmount.Clear();
            }
        }

        public bool cashpayment;
        public void btnCashOption_Click(object sender, EventArgs e)
        {
            cashpayment = true;
            if(FormProvider.signInForm.activeEmplyee.colorBlind != true)
            {
                btnCashOption.BackColor = Color.LimeGreen;
                btnCredit.BackColor = SystemColors.ControlLight;
            }
            else
            {
                btnCashOption.BackColor = SystemColors.ControlLight;

            }
        }

        public void btnCredit_Click(object sender, EventArgs e)
        {
            cashpayment = false;
            if(FormProvider.signInForm.activeEmplyee.colorBlind != true)
            {
                btnCredit.BackColor = Color.LimeGreen;
                btnCashOption.BackColor = SystemColors.ControlLight;
            }
            else
            {
                btnCredit.BackColor = SystemColors.ControlLight;
            }
        }

        private void btnTransactionDone_Click(object sender, EventArgs e)
        {
            if(FormProvider.signInForm.activeEmplyee.userStatus != "Training")
            {
                double totalPaid = 0;
                DateTime checkoutTime = DateTime.Now;
                Debug.Print("This is the time " + checkoutTime.ToString());
                newtotal = runningtotal;
                updateOrderNumbers();

                string path = Directory.GetCurrentDirectory();
                string orderEntry = ordernumber.ToString() + "|" + checkoutTime.ToString() + "|" + FormProvider.signInForm.activeEmplyee.fName.ToString() + "|" + string.Format("{0:C2}", (Convert.ToDecimal(newtotal.ToString())));
                Debug.Print("delimited string is " + orderEntry);
                Debug.Print("Path is " + path);
                using (StreamWriter file = File.AppendText(@path + @"\OrderHistory.txt"))
                {
                    file.WriteLine(orderEntry);
                }
                //Add order to history
                CurrentHistroy.Add(new List<orderItem>(Orders));

                //Calculates the bill of previous order
                for (int i = 0; i < Orders.Count; i++)
                {
                    totalPaid = totalPaid + (Orders[i].quantity * Orders[i].foodItem.price);
                }

                lstbxOrderHistory.Items.Clear();
                Debug.Print("CurrentHistory Count: " + CurrentHistroy.Count.ToString());



                //Adds the order number to the order history list
                for (int i = 0; i < CurrentHistroy.Count; i++)
                {
                    //Calculates the bill of previous order
                    for (int j = 0; j < CurrentHistroy[i].Count; j++)
                    {
                        totalPaid = totalPaid + (CurrentHistroy[i][j].quantity * CurrentHistroy[i][j].foodItem.price);
                    }

                    //Prints to the order history listbox
                    lstbxOrderHistory.Items.Add(CurrentHistroy[i][0].localordernumber.ToString().PadLeft(5) + string.Format("{0:C2}", (Convert.ToDecimal(totalPaid.ToString()))).PadLeft(29));

                    //Reset totalPaid
                    totalPaid = 0;
                }

            }


            // Clears orders and resets the main page
            Orders.Clear();
            PrintOrders();
            calculateOrderTotal();


            // Hides panels and resets layout to initial state
            pnlOrdering.Enabled = true;

            pnlTransactionComplete.Visible = false;
            pnlFullCashoutSection.Visible = false;
            pnlCashOutTools.Visible = false;
            pnlOrderFunctions.Visible = true;
            pnlMenuPage1.BringToFront();
            gpbxPaymentType.Visible = false;
            btnCredit.BackColor = SystemColors.ControlLight;
        }

        private void btnTwentyDollars_Click(object sender, EventArgs e)
        {
            newTotal(20.0);
            Debug.Print("The new total is " + newtotal.ToString());
            if (newtotal > 0.0)
            {
                lblCustomerPayment.Text = "$20.00";
                lblCashDueAmount.Text = string.Format("{0:#.00}", (Convert.ToDecimal(newtotal.ToString()) * 100) / 100);
                showFinalScreen();
            }
            else
            {
                newtotal = newtotal * (-1.0);
                lblCurrentAmountDue.Text = string.Format("{0:#.00}", (Convert.ToDecimal(newtotal.ToString()) * 100) / 100); 
                txtbPaymentAmount.Clear();
            }
        }

        private void btn40Dollars_Click(object sender, EventArgs e)
        {
            newTotal(50.0);
            Debug.Print("The new total is " + newtotal.ToString());
            if (newtotal > 0.0)
            {
                lblCustomerPayment.Text = "$50.00";
                lblCashDueAmount.Text = string.Format("{0:#.00}", (Convert.ToDecimal(newtotal.ToString()) * 100) / 100);
                showFinalScreen();
            }
            else
            {
                newtotal = newtotal * (-1.0);
                lblCurrentAmountDue.Text = string.Format("{0:#.00}", (Convert.ToDecimal(newtotal.ToString()) * 100) / 100);
                txtbPaymentAmount.Clear();
            }
        }

        private void btnFiftyDollars_Click(object sender, EventArgs e)
        {
            newTotal(100.0);
            Debug.Print("The new total is " + newtotal.ToString());
            if (newtotal > 0.0)
            {
                lblCustomerPayment.Text = "$100.00";
                lblCashDueAmount.Text = string.Format("{0:#.00}", (Convert.ToDecimal(newtotal.ToString()) * 100) / 100);
                showFinalScreen();
            }
            else
            {
                newtotal = newtotal * (-1.0);
                lblCurrentAmountDue.Text = string.Format("{0:#.00}", (Convert.ToDecimal(newtotal.ToString()) * 100) / 100);
                txtbPaymentAmount.Clear();
            }
        }

        private void btnQuantityLastPage_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteItemFinal_Click(object sender, EventArgs e)
        {

        }

        private void pnlFullCashoutSection_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void pnlOrderItems_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void lstbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtxtbOrderFinal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pnlCurrentOrder_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void pnlToolbar_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.OrangeRed, ButtonBorderStyle.Solid);
        }

        private void pnlOrderFunctions_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void gpbxPaymentType_Enter(object sender, EventArgs e)
        {

        }

        

        int trainingsteps = 1;
        private void btnTrainingNext_Click(object sender, EventArgs e)
        {
            if(trainingsteps == 1)
            {
                pnlTrainingInfo.Location = new Point(746, 8);
                rtxtbxTrainingSteps.Text = "Here is a Frequently Asked Questions button in case you need reminders of how to do certain tasks.";
            }
            if(trainingsteps == 2)
            {
                pictureBoxLeft.Visible = false;
                pictureBoxRight.Visible = true;
                pnlTrainingInfo.Location = new Point(314, 168);
                pnlButtonSection.Visible = true;
                pnlManagerFunctions.Visible = false;
                rtxtbxTrainingSteps.Text = "This is the button keypad to add items to the order.";
            }
            else if(trainingsteps == 3)
            {
                pnlTrainingInfo.Location = new Point(410,651);
                pnlManagerFunctions.Visible = true;
                rtxtbxTrainingSteps.Text = "These buttons require a managers code to use and may often be needed.";
            }
            else if(trainingsteps == 4)
            {
                pictureBoxLeft.Visible = true;
                pictureBoxRight.Visible = false;
                pnlTrainingInfo.Location = new Point(733, 93);
                pnlToolbar.Visible = true;
                grpbxDeleteCancel.Visible = false;
                btnOrderHistory.Visible = false;
                btnPay.Visible = false;
                rtxtbxTrainingSteps.Text = "These are common tools that can either adjust the quantity of an item or to add a special request message to an item. For these to work you must select an item from the existing order.";
            }
            else if (trainingsteps == 5)
            {
                pnlTrainingInfo.Location = new Point(733, 351);
                grpbxDeleteCancel.Visible = true;
                rtxtbxTrainingSteps.Text = "These are the buttons to delete an item from the existing order or to cancel the entire order. To delete an item you must first click on the desired item you want to remove and input the amount you want to delete if there is more than 1 item added to the order.";
            }
            else if (trainingsteps == 6)
            {
                pnlTrainingInfo.Location = new Point(726, 522);
                btnOrderHistory.Visible = true;
                rtxtbxTrainingSteps.Text = "This button is to view order history and to give refunds or re-open orders if needed.";
            }
            else if (trainingsteps == 7)
            {
                pnlTrainingInfo.Location = new Point(726, 632);
                btnPay.Visible = true;
                rtxtbxTrainingSteps.Text = "This is the button you press when you are ready to cash-out the order.";
            }
            else if (trainingsteps == 8)
            {
                pnlTrainingInfo.Location = new Point(726, 105);
                pnlCashOutTools.Visible = true;
                gpbxPaymentType.Visible = true;
                pnlOrderFunctions.Visible = false;
                btnBackToOrder.Visible = false;
                pnlOrderItems.Visible = false;
                pnlManagerFunctions.Visible = false;
                rtxtbxTrainingSteps.Text = "Once at the cash out screen you can select either cash or credit.";
            }
            else if (trainingsteps == 9)
            {
                pnlTrainingInfo.Location = new Point(726, 356);
                btnBackToOrder.Visible = true;
                rtxtbxTrainingSteps.Text = "This button will take you back to the order if the customer makes any sudden last changes.";
            }
            else if(trainingsteps == 10)
            {
                pictureBoxLeft.Visible = false;
                pictureBoxRight.Visible = true;
                pnlTrainingInfo.Location = new Point(312, 88);
                pnlFullCashoutSection.Visible = true;
                rtxtbxTrainingSteps.Text = "If the customer gave you cash, this is where you enter the amount that they give you and press enter to complete the transaction. There are also 'Quick Cash' buttons for common bills." +
                    "If they chose credit, just press enter.";
            }
            else if(trainingsteps == 11)
            {
                pictureBoxLeft.Visible = true;
                pnlTrainingInfo.Location = new Point(569, 364);
                Image check = Image.FromFile(FormProvider.signInForm.databasespath + @"\MiscIcons\Check.png");
                Image thumbsUp = Image.FromFile(FormProvider.signInForm.databasespath + @"\MiscIcons\ThumbsUp.png");
                pictureBoxLeft.BackgroundImage = check;
                pictureBoxRight.BackgroundImage = thumbsUp;
                rtxtbxTrainingSteps.Text = "And finally you can explore the options in free-explore mode! Press this button when you are ready to begin taking orders.";
            }
            else if (trainingsteps == 12)
            {
                //  Final step code to finalize the training mode!
                pnlTrainingInfo.Visible = false;
                pnlFullCashoutSection.Visible = false;
                pnlOrderItems.Visible = true;
                pnlManagerFunctions.Visible = true;
                pnlCashOutTools.Visible = false;
                pnlOrderFunctions.Visible = true;
                pnlToolbar.Enabled = true;
                btnFAQ.Enabled = true;
                pnlButtonSection.Enabled = true;
                btnTrainingNext.Visible = false;
                btnTrainingExit.Visible = true;
                MessageBox.Show("Congratulations, You have completed the training course.  Click enter to begin taking orders!");
            }
            trainingsteps++;
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (runningtotal > 0)
            {
                MessageBox.Show("Must clear order before giving refund.");
            }
            else
            {
                string objname = ((Button)sender).Name;
                showKeypad(objname);
            }
        }

        private void btnLabor_Click(object sender, EventArgs e)
        {
            string objname = ((Button)sender).Name;
            showKeypad(objname);
        }

        private void showLaborReport()
        {
            DateTime time = DateTime.Now;
            rtxtbLaborReport.Clear();
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.SelectionAlignment = HorizontalAlignment.Center;
            rtxtbLaborReport.SelectionFont = new Font("Consolas", 18, FontStyle.Bold);
            rtxtbLaborReport.SelectedText = "Food Truck";
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.SelectionAlignment = HorizontalAlignment.Center;
            rtxtbLaborReport.SelectedText = "Report: Labor Sales";
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.SelectedText = time.ToString();
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.SelectionAlignment = HorizontalAlignment.Left;
            rtxtbLaborReport.AppendText("  ----------------------------------------------------");
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.SelectionFont = new Font("Consolas", 16, FontStyle.Bold);
            rtxtbLaborReport.AppendText("  NET SALES");
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.AppendText("  Item  Order#   Type".PadRight(45));
            rtxtbLaborReport.AppendText("Amount");
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.AppendText("  ----------------------------------------------------");
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.AppendText("  232   167      Cashier".PadRight(47));
            rtxtbLaborReport.AppendText("$563.25");
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.AppendText("==========".PadLeft(54));
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.SelectionFont = new Font("Consolas", 16, FontStyle.Bold);
            rtxtbLaborReport.SelectedText = "                     NET SALES TOTAL:          $563.25";
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.AppendText("  LABOR COST");
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.SelectionFont = new Font("Consolas", 16, FontStyle.Regular);
            rtxtbLaborReport.AppendText("  Job Name                                   Total Pay");
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.AppendText("  ----------------------------------------------------");
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.AppendText("  Cashier                                       $35.42");
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.AppendText("  Cook                                          $46.72");
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.AppendText("==========".PadLeft(54));
            rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.AppendText("                     Labor Cost Total:          $82.14");
            rtxtbLaborReport.AppendText(Environment.NewLine); rtxtbLaborReport.AppendText(Environment.NewLine);
            rtxtbLaborReport.AppendText("                     Labor Cost %:              14.58%");
        }
        private void btnCloseLaborReport_Click(object sender, EventArgs e)
        {
            pnlLaborReport.Visible = false;
            pnlOrdering.Enabled = true;
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            pnlOrderHistory.Visible = true;
            pnlOrderHistory.BringToFront();
            pnlOrdering.Enabled = false;
        }

        private void btnExitOrderHistory_Click(object sender, EventArgs e)
        {
            pnlOrderHistory.Visible = false;
            pnlOrdering.Enabled = true;
        }

        private void btnReOpenOrder_Click(object sender, EventArgs e)
        {
            int sindex = lstbxOrderHistory.SelectedIndex;
            int orderNum = CurrentHistroy[sindex][0].localordernumber;

            for (int i = 0; i < CurrentHistroy.Count; i++)
            {
                if (orderNum == CurrentHistroy[i][0].localordernumber)
                {
                    //Replace current Orders list with the found one
                    Orders.Clear();
                    Orders = CurrentHistroy[i];
                    Orders[0].localordernumber = ordernumber;
                    CurrentHistroy.RemoveAt(i);
                    lstbxOrderHistory.Items.RemoveAt(i);
                   
                    PrintOrders();
                    calculateOrderTotal();

                    //Dismiss the history screen
                    pnlOrderHistory.Visible = false;
                    pnlOrdering.Enabled = true;
                }
            }
        }

        private void btnPaidOut_Click(object sender, EventArgs e)
        {
            if(runningtotal > 0.00)
            {
                MessageBox.Show("Must finish order before doing paid out.");
            }
            else
            {
                string objname = ((Button)sender).Name;
                showKeypad(objname);
            }
        }

        private void btnHouseCharge_Click(object sender, EventArgs e)
        {
            string objname = ((Button)sender).Name;
            showKeypad(objname);
        }

        private void grpbxMngrOverrideTools_Enter(object sender, EventArgs e)
        {

        }

        private void btnClosePOHC_Click(object sender, EventArgs e)
        {
            pnlPOHC.Visible = false;
            pnlOrdering.Enabled = true;
        }

        private void rtxtbxTrainingSteps_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTrainingExit_Click(object sender, EventArgs e)
        {
            if(runningtotal > 0)
            {
                MessageBox.Show("Must clear order before taking real orders.");
            }
            else
            {
                button1.Enabled = true;
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FormProvider.signInForm.databasespath + @"\CoffeeShopEmployees.accdb");
                conn.Open();
                string newStatus = "Employee";
                int id = Int32.Parse(FormProvider.signInForm.activeEmplyee.id.ToString());
                string sqlQuery = "UPDATE Employees SET Status  = @Status WHERE ID = @ID";
                OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@ID", id);
                

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your status is now upgraded to Employee!");
            }
            btnTrainingExit.Visible = false;
            FormProvider.signInForm.readInEmployees();
            FormProvider.signInForm.activeEmplyee.userStatus = "Employee";
            Debug.Print("Users status is " + FormProvider.signInForm.activeEmplyee.userStatus);
        }

        private void btnYES_Click(object sender, EventArgs e)
        {
            pnlConfirmCancelOrder.Visible = false;
            pnlOrdering.Enabled = true;
            // Erases all elements from the Orders list
            Orders.Clear();
            nextopenindex = 0;
            calculateOrderTotal();
            PrintOrders();
            pnlMenuPage1.Visible = true;
            pnlMenuPage2.Visible = false;
            button1.Enabled = true;
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            pnlConfirmCancelOrder.Visible = false;
            pnlOrdering.Enabled = true;
        }



        //Partial Class frmMain
    }   

    //Namespace Ordering
}
