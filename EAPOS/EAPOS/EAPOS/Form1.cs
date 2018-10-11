using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Ordering;
using SignIn;
using System.Data.OleDb;

namespace EAPOS_Project
{
    public partial class frmManagerMode : Form
    {

        public frmManagerMode()
        {
            InitializeComponent();
        }
        private void frmManagerMode_Load(object sender, EventArgs e)
        {
            txtbID.Text = "";
            txtbFirstName.Text = "";
            txtbLastName.Text = "";
            txtbStatus.Text = "";
            txtbWage.Text = "";
            pnlMessageKeyboard.Visible = false;
            this.Location = new Point(0, 0);
            timerTime.Enabled = true;
        }
        private void frmManagerMode_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storedItemsDataSet2.ButtonMainPanel' table. You can move, or remove it, as needed.
            this.buttonMainPanelTableAdapter2.Fill(this.storedItemsDataSet2.ButtonMainPanel);
            // TODO: This line of code loads data into the 'storedItemsDataSet1.ButtonMainPanel' table. You can move, or remove it, as needed.
            this.buttonMainPanelTableAdapter1.Fill(this.storedItemsDataSet1.ButtonMainPanel);
            // TODO: This line of code loads data into the 'coffeeShopEmployeesDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter1.Fill(this.coffeeShopEmployeesDataSet1.Employees);
            // TODO: This line of code loads data into the 'coffeeShopEmployeesDataSet1.Hours' table. You can move, or remove it, as needed.
            //this.hoursTableAdapter.Fill(this.coffeeShopEmployeesDataSet1.Hours);
            // TODO: This line of code loads data into the 'storedItemsDataSet.ButtonMainPanel' table. You can move, or remove it, as needed.
            //this.buttonMainPanelTableAdapter.Fill(this.storedItemsDataSet.ButtonMainPanel);

            // TODO: This line of code loads data into the 'coffeeShopEmployeesDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.coffeeShopEmployeesDataSet.Employees);
        }




        //||------------------------------------- Manager Home Page ------------------------------------||\\

        private void btnSignOutManagerMode_Click(object sender, EventArgs e)
        {
            // Manager Sign Out Button - Go To LogIn Screen
            FormProvider.signInForm.Show();
            FormProvider.signInForm.logOutTime(FormProvider.signInForm.activeUserID);
            FormProvider.orderForm.btnGoToManagerMode.Visible = false;
            this.Visible = false;
        }
        private void btnOrderMode_Click(object sender, EventArgs e)
        {
            // Go To Order Mode Button 
            FormProvider.orderForm.Show();
            this.Visible = false;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            // Employee Button
            pnlEmployees.Visible = true;
            pnlManagerMode.Visible = false;
            
            colorblindCheckBox.Checked = false;
            leftHandedCheckBox.Checked = false;
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            // Product Management Button
            pnlProductMgmt.Visible = true;
            pnlManagerMode.Visible = false;
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            // Sales Report Button
            pnlSalesReport.Visible = true;
            pnlManagerMode.Visible = false;
            showSalesReport();
        }

        private void btnCreateTrainingTests_Click(object sender, EventArgs e)
        {
            // Create Tests Button
            pnlCreateTest.Visible = true;
            pnlManagerMode.Visible = false;
        }



        //||--------------------------------------- Employees Page -------------------------------------||//

        public bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            bool nameOK = true; 
            bool idOK = true;
            if (!IsNumeric(txtbID.Text))
            {
                MessageBox.Show("ID Must Be A Number", "Error!");
                idOK = false;
            }

            if (Regex.IsMatch(txtbFirstName.Text, @"^[a-zA-Z]+$") == false || Regex.IsMatch(txtbLastName.Text, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("Name cannot contain numbers", "Error");
                nameOK = false;
            }

            if (idOK && nameOK)
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FormProvider.signInForm.databasespath + @"\CoffeeShopEmployees.accdb");
                conn.Open();

                string sqlQuery = "UPDATE Employees SET Fname = @FName, Lname = @Lname, Status = @Status,  Wage = @Wage, LeftHanded = @LeftHanded, Colorblind = @Colorblind WHERE ID = @ID";
                OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@ID", txtbID.Text);
                cmd.Parameters.AddWithValue("@Fname", txtbFirstName.Text);
                cmd.Parameters.AddWithValue("@Lname", txtbLastName.Text);
                cmd.Parameters.AddWithValue("@Status", txtbStatus.Text);
                cmd.Parameters.AddWithValue("@Wage", txtbWage.Text);
                cmd.Parameters.AddWithValue("@LeftHanded", leftHandedCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Colorblind", colorblindCheckBox.Checked);


                cmd.ExecuteNonQuery();
                conn.Close();

                // Refreshes the datagrid
                this.employeesTableAdapter1.Fill(this.coffeeShopEmployeesDataSet1.Employees);
                FormProvider.signInForm.readInEmployees();
            }
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeShopEmployeesDataSet);

        }
        public bool found;
        public void IdExists(string Id)
        {

            for(int i=0; i<FormProvider.signInForm.POSEmployees.Count; i++)
            {
                if (Id == FormProvider.signInForm.POSEmployees[i].id.ToString())
                {
                    found = true;
                }
                else
                {
                    found = false;
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            IdExists(txtbID.Text);
            if (found == true)
            {
                MessageBox.Show("UserID already exists. Please select another.");
            }
            else
            {
                // Opens connection to CoffeeShopEmployees database
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FormProvider.signInForm.databasespath + @"\CoffeeShopEmployees.accdb");
                conn.Open();

                // Sends sql query and adds records into StoredItems database
                string sqlQuery = "INSERT INTO Employees (ID, Fname, Lname, Status, Wage, LeftHanded, Colorblind) values(@ID, @FName, @Lname, @Status, @Wage, @LeftHanded, @Colorblind)";
                OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@ID", txtbID.Text);
                cmd.Parameters.AddWithValue("@Fname", txtbFirstName.Text);
                cmd.Parameters.AddWithValue("@Lname", txtbLastName.Text);
                cmd.Parameters.AddWithValue("@Status", txtbStatus.Text);
                cmd.Parameters.AddWithValue("@Wage", txtbWage.Text);
                cmd.Parameters.AddWithValue("@LeftHanded", leftHandedCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Colorblind", colorblindCheckBox.Checked);

                // Executes query and saves then closes StoredItems database
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added To Records");
                conn.Close();

                // Refreshes the datagrid
                this.employeesTableAdapter1.Fill(this.coffeeShopEmployeesDataSet1.Employees);
                FormProvider.signInForm.readInEmployees();
            }
            
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            // Opens connection to Employees database
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FormProvider.signInForm.databasespath + @"\CoffeeShopEmployees.accdb");
            conn.Open();

            // Sends sql query to Employees database
            string sqlQuery = "DELETE * FROM Employees WHERE ID = @ID";
            OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("@ID", txtbID.Text);

            // Executes query and saves then closes StoredItems database
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee, " + txtbFirstName.Text + ", has been Deleted From Records");
            conn.Close();

            // Refreshes the datagrid
            this.employeesTableAdapter1.Fill(this.coffeeShopEmployeesDataSet1.Employees);
            FormProvider.signInForm.readInEmployees();
        }

        private void btnManageHours_Click(object sender, EventArgs e)
        {
            // Opens the hour manager
            //this.hoursTableAdapter.Fill(this.coffeeShopEmployeesDataSet1.Hours);
            pnlManageHours.Visible = true;
            pnlManageHours.BringToFront();
            pnlEmployees.Enabled = false;
        }

        private void btnQuitEmployees_Click(object sender, EventArgs e)
        {
            pnlEmployees.Visible = false;
            pnlManagerMode.Visible = true;
        }



        //||----------------------------------- Product Management Page -----------------------------------||\\

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnlConfirmDeletion.Visible = false;
            pnlProductMgmt.Enabled = true;

            // Opens connection to StoredItems database
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FormProvider.signInForm.databasespath + @"\StoredItems.accdb");
            conn.Open();

            // Sends sql query to StoredItems database
            string sqlQuery = "DELETE * FROM ButtonMainPanel WHERE ItemName = '" + txtbItemName.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);

            // Executes query and saves then closes StoredItems database
            cmd.ExecuteNonQuery();
            conn.Close();

            // Refreshes the datagrid
            this.buttonMainPanelTableAdapter2.Fill(this.storedItemsDataSet2.ButtonMainPanel);
            MessageBox.Show("Item permanently deleted from database");
            pictureBoxSelectedImage.BackgroundImage = null;
            pictureBoxSelectedImage.Refresh();
            FormProvider.signInForm.resetButtons();
            FormProvider.signInForm.pushedInItems.Clear();
            FormProvider.signInForm.readInFoodItems();
            pictureBoxSelectedImage.InitialImage = null;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            pnlConfirmDeletion.Visible = true;
            pnlConfirmDeletion.BringToFront();
            pnlProductMgmt.Enabled = false;
        }
        private void btnQuitProductMgmt_Click(object sender, EventArgs e)
        {
            pnlProductMgmt.Visible = false;
            pnlManagerMode.Visible = true;
        }

        private void btnCancelDeleteItem_Click(object sender, EventArgs e)
        {
            pnlConfirmDeletion.Visible = false;
            pnlProductMgmt.Enabled = true;
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            // Opens connection to StoredItems database
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FormProvider.signInForm.databasespath + @"\StoredItems.accdb");
            conn.Open();

            string sqlQuery = "UPDATE ButtonMainPanel SET ProductID = @ID, ItemName = @Name, Price = @Price, Type = @Type  WHERE ProductID = @ID";
            OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("@ID", productIDTextBox.Text);
            cmd.Parameters.AddWithValue("@ItemName", txtbItemName.Text);
            cmd.Parameters.AddWithValue("@Price", txtbItemPrice.Text);
            cmd.Parameters.AddWithValue("@Type", txtbProductType.Text);


            cmd.ExecuteNonQuery();
            conn.Close();

            // Refreshes the datagrid
            this.buttonMainPanelTableAdapter2.Fill(this.storedItemsDataSet2.ButtonMainPanel);
            FormProvider.signInForm.pushedInItems.Clear();
            FormProvider.signInForm.readInFoodItems();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            string file = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = FormProvider.signInForm.databasespath + @"\FoodIcons\png";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    file = openFileDialog1.FileName;
                    Debug.Print("This is the selected file: " + file);

                    string imageFile = file.Replace(FormProvider.signInForm.databasespath + @"\FoodIcons\png\", "");
                    Debug.Print("This is just the image name now: " + imageFile);

                    //Show the image in the picturebox
                    pictureBoxSelectedImage.BackgroundImage = Image.FromFile(FormProvider.signInForm.databasespath + @"\FoodIcons\png\" + imageFile);
                    filenameTextBox.Text = imageFile;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        public bool itemExists(string Item)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FormProvider.signInForm.databasespath + @"\StoredItems.accdb");
            conn.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT COUNT(*) FROM [ButtonMainPanel] WHERE ([ItemName] = '" + Item + "')", conn);
            int UserExist = (int)myCommand.ExecuteScalar();
            if (UserExist > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public bool productidExists;
        private void idExists(int id)
        {
            for (int i = 0; i < FormProvider.signInForm.pushedInItems.Count; i++)
            {
                if (id == FormProvider.signInForm.pushedInItems[i].productid)
                {
                    productidExists = true;
                }
                else
                {
                    productidExists = false;
                }
            }
        }
        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            itemExists(txtbNewItemName.Text);
            if (itemExists(txtbNewItemName.Text) == true)
            {
                MessageBox.Show("Item Name \" " + txtbNewItemName.Text + " \" already exists", "ERROR!");
                txtbNewItemName.Clear();
                txtbNewItemID.Clear();
                txtbNewItemPrice.Clear();
                txtbProductType.Clear();
            }
            else if (productidExists == true)
            {
                MessageBox.Show("Product Id \" " + txtbNewItemID.Text + " \" already exists", "ERROR!");
                txtbNewItemName.Clear();
                txtbNewItemID.Clear();
                txtbNewItemPrice.Clear();
                txtbProductType.Clear();
            }
            else
            {
                // Opens connection to StoredItems database
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FormProvider.signInForm.databasespath + @"\StoredItems.accdb");
                conn.Open();

                // Sends sql query and adds records into StoredItems database
                string sqlQuery = "INSERT INTO ButtonMainPanel (ProductID, ItemName, Price, Type, Filename) values(@ProductID, @ItemName, @Price, @Type, @Filename)";
                OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@ProductID", Int32.Parse(txtbNewItemID.Text));
                cmd.Parameters.AddWithValue("@ItemName", txtbNewItemName.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtbNewItemPrice.Text));
                cmd.Parameters.AddWithValue("@Type", txtbNewItemType.Text);
                if (txtbNewItemFilename.Text == "")
                {
                    cmd.Parameters.AddWithValue("@Filename", "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Filename", txtbNewItemFilename.Text);
                }


                // Executes query and saves then closes StoredItems database
                cmd.ExecuteNonQuery();
                conn.Close();

                // Refreshes the datagrid
                this.buttonMainPanelTableAdapter2.Fill(this.storedItemsDataSet2.ButtonMainPanel);
                MessageBox.Show("Item added to database!");
                FormProvider.signInForm.pushedInItems.Clear();
                FormProvider.signInForm.readInFoodItems();
                pnlNewItem.Visible = false;
                pnlProductMgmt.Enabled = true;
            }
        }

        private void btnCancelNewItem_Click(object sender, EventArgs e)
        {
            pnlNewItem.Visible = false;
            pnlProductMgmt.Enabled = true;
        }

        private void btnAddNewItemPic_Click(object sender, EventArgs e)
        {
            string file = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = FormProvider.signInForm.databasespath + @"\FoodIcons\png";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    file = openFileDialog1.FileName;
                    Debug.Print("This is the selected file: " + file);

                    string imageFile = file.Replace(FormProvider.signInForm.databasespath + @"\FoodIcons\png\", "");
                    Debug.Print("This is just the image name now: " + imageFile);

                    //Show the image in the picturebox
                    pictureBox6.BackgroundImage = Image.FromFile(FormProvider.signInForm.databasespath + @"\FoodIcons\png\" + imageFile);
                    txtbNewItemFilename.Text = imageFile;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            pnlNewItem.Visible = true;
            pnlNewItem.BringToFront();
            pnlProductMgmt.Enabled = false;
            pictureBox6.BackgroundImage = null;
            txtbNewItemID.Text = "";
            txtbNewItemName.Text = "";
            txtbNewItemPrice.Text = "";
            txtbNewItemType.Text = "";
            txtbNewItemFilename.Text = "";
        }




        //||------------------------------------ Sales Report Page ---------------------------------------||\\
        private void btnQuitSalesReport_Click(object sender, EventArgs e)
        {
            pnlSalesReport.Visible = false;
            pnlManagerMode.Visible = true;
        }

        void showSalesReport()
        {
            DateTime time = DateTime.Now;
            rtxtbSalesReport.Clear();
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.SelectionAlignment = HorizontalAlignment.Center;
            rtxtbSalesReport.SelectionFont = new Font("Consolas", 20, FontStyle.Bold);
            rtxtbSalesReport.SelectedText = "Food Truck";
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.SelectionAlignment = HorizontalAlignment.Center;
            rtxtbSalesReport.SelectedText = "Report: Department Sales";
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.SelectedText = time.ToLongDateString();
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.SelectedText = "Gross Sales Report";
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.SelectionAlignment = HorizontalAlignment.Left;
            rtxtbSalesReport.SelectionFont = new Font("Consolas", 16, FontStyle.Bold);
            rtxtbSalesReport.AppendText("    SALES TOTAL");
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText("    Type".PadRight(28));
            rtxtbSalesReport.AppendText("    Quantity".PadRight(29));
            rtxtbSalesReport.AppendText("    Amount".PadRight(10));
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText("    --------------------------------------------------------------------");
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText("    Burgers".PadRight(31));
            rtxtbSalesReport.AppendText("    35".PadRight(25));
            rtxtbSalesReport.AppendText("    $197.79".PadRight(10));
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText("    Chicken".PadRight(32));
            rtxtbSalesReport.AppendText("    9".PadRight(25));
            rtxtbSalesReport.AppendText("    $41.61".PadRight(10));
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText("    Donuts".PadRight(31));
            rtxtbSalesReport.AppendText("    17".PadRight(26));
            rtxtbSalesReport.AppendText("    $61.14".PadRight(10));
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText("    Drinks".PadRight(31));
            rtxtbSalesReport.AppendText("    55".PadRight(25));
            rtxtbSalesReport.AppendText("    $127.15".PadRight(10));
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText("    Hot Dogs".PadRight(31));
            rtxtbSalesReport.AppendText("    23".PadRight(26));
            rtxtbSalesReport.AppendText("    $76.81".PadRight(10));
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText("    Ice Cream".PadRight(31));
            rtxtbSalesReport.AppendText("    26".PadRight(26));
            rtxtbSalesReport.AppendText("    $93.50".PadRight(10));
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText("    Pizza".PadRight(31));
            rtxtbSalesReport.AppendText("    32".PadRight(25));
            rtxtbSalesReport.AppendText("    $195.48".PadRight(10));
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText("    ====================================================================");
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.SelectionFont = new Font("Consolas", 16, FontStyle.Bold);
            rtxtbSalesReport.AppendText("    TOTALS".PadRight(30));
            rtxtbSalesReport.AppendText("    197".PadRight(26));
            rtxtbSalesReport.AppendText("    $793.48".PadRight(10));
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText("    --------------------------------------------------------------------");
            rtxtbSalesReport.AppendText(Environment.NewLine);
            rtxtbSalesReport.AppendText("    GOAL");
            rtxtbSalesReport.AppendText(Environment.NewLine);
        }




        //||------------------------------------- Create Test Page --------------------------------------||\\

        private void btnCreateNewTest_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitCreateTest_Click(object sender, EventArgs e)
        {
            pnlCreateTest.Visible = false;
            pnlManagerMode.Visible = true;
        }













        //!!!--------------------------------------!!! DO NOT DELETE !!!-------------------------------------------!!!\\

        private void colorblindCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }
        
        private void leftHandedLabel_Click(object sender, EventArgs e)
        {
        }
        private void colorblindLabel_Click(object sender, EventArgs e)
        {
        }
        private void leftHandedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void pnlManagerMode_Paint(object sender, PaintEventArgs e)
        {
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }
        private void pnlEmployees_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FormProvider.signInForm.POSEmployees.Count; i++)
            {
                Debug.Print(FormProvider.signInForm.POSEmployees[i].fName);
            }
        }

        private void txtbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlProductMgmt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {

        }

        private void txtbID_TextChanged_1(object sender, EventArgs e)
        {
            //pnlMessageKeyboard.Visible = true;
            //pnlMessageKeyboard.BringToFront();
        }

        private void btnEnterMessage_Click(object sender, EventArgs e)
        {
            pnlMessageKeyboard.Visible = false;

        }

        private void btnQuitManageHours_Click(object sender, EventArgs e)
        {
            pnlManageHours.Visible = false;
            pnlEmployees.Enabled = true;
        }

        private void buttonMainPanelDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string inputfilename;
            string imagename;
            DataGridViewRow row = buttonMainPanelDataGridView1.Rows[rowIndex];
            imagename = row.Cells[4].Value.ToString();
            if (imagename == "")
            {
                inputfilename = FormProvider.signInForm.databasespath + @"\NotAvailable.png" ;
                pictureBoxSelectedImage.Image = Image.FromFile(inputfilename);
                pictureBoxSelectedImage.Refresh();
            }
            else
            {
                inputfilename = FormProvider.signInForm.databasespath + @"\FoodIcons\png\" + imagename;
                pictureBoxSelectedImage.Image = Image.FromFile(inputfilename);
                pictureBoxSelectedImage.Refresh();  
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblCurrentDate.Text = DateTime.Now.ToString();
        }

      
        
    }
}
