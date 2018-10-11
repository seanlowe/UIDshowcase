namespace EAPOS_Project
{
    partial class frmManagerMode
    {

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblEmployeeId;
            System.Windows.Forms.Label lblFirstName;
            System.Windows.Forms.Label lblLastName;
            System.Windows.Forms.Label lblStatus;
            System.Windows.Forms.Label lblWage;
            System.Windows.Forms.Label colorblindLabel;
            System.Windows.Forms.Label leftHandedLabel;
            System.Windows.Forms.Label lblUpdateItemName;
            System.Windows.Forms.Label lblUpdatePrice;
            System.Windows.Forms.Label lblProductType;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label filenameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerMode));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlManagerMode = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignOutManagerMode = new System.Windows.Forms.Button();
            this.lblManagerMode = new System.Windows.Forms.Label();
            this.btnOrderMode = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnCreateTrainingTests = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.employeesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopEmployeesDataSet1 = new EAPOS_Project.CoffeeShopEmployeesDataSet1();
            this.gpbEmployee = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.leftHandedCheckBox = new System.Windows.Forms.CheckBox();
            this.colorblindCheckBox = new System.Windows.Forms.CheckBox();
            this.btnManageHours = new System.Windows.Forms.Button();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.txtbStatus = new System.Windows.Forms.TextBox();
            this.txtbWage = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnQuitEmployees = new System.Windows.Forms.Button();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.pnlManageHours = new System.Windows.Forms.Panel();
            this.btnQuitManageHours = new System.Windows.Forms.Button();
            this.hoursDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlProductMgmt = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gpbxUpdateItems = new System.Windows.Forms.GroupBox();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.buttonMainPanelBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.storedItemsDataSet2 = new EAPOS_Project.StoredItemsDataSet2();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.txtbItemName = new System.Windows.Forms.TextBox();
            this.txtbItemPrice = new System.Windows.Forms.TextBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.txtbProductType = new System.Windows.Forms.TextBox();
            this.gpbxSelectedImage = new System.Windows.Forms.GroupBox();
            this.pictureBoxSelectedImage = new System.Windows.Forms.PictureBox();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.grpbProducts = new System.Windows.Forms.GroupBox();
            this.buttonMainPanelDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitProductMgmt = new System.Windows.Forms.Button();
            this.lblProductManagement = new System.Windows.Forms.Label();
            this.buttonMainPanelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.storedItemsDataSet1 = new EAPOS_Project.StoredItemsDataSet1();
            this.buttonMainPanelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.storedItemsDataSet = new EAPOS_Project.StoredItemsDataSet();
            this.pnlConfirmDeletion = new System.Windows.Forms.Panel();
            this.lblConfirmDeletionWarning = new System.Windows.Forms.Label();
            this.btnCancelDeleteItem = new System.Windows.Forms.Button();
            this.lblDeleteWarningInfo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblConfirmDeletion = new System.Windows.Forms.Label();
            this.buttonMainPanelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlCreateTest = new System.Windows.Forms.Panel();
            this.btnCreateNewTest = new System.Windows.Forms.Button();
            this.txtbNewTestName = new System.Windows.Forms.TextBox();
            this.lblNewTestName = new System.Windows.Forms.Label();
            this.btnQuitCreateTest = new System.Windows.Forms.Button();
            this.lblCreatePracticeTest = new System.Windows.Forms.Label();
            this.pnlSalesReport = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rtxtbSalesReport = new System.Windows.Forms.RichTextBox();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.btnQuitSalesReport = new System.Windows.Forms.Button();
            this.buttonMainPanelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.employeesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopEmployeesDataSet = new EAPOS_Project.CoffeeShopEmployeesDataSet();
            this.pnlMessageKeyboard = new System.Windows.Forms.Panel();
            this.btnEnterMessage = new System.Windows.Forms.Button();
            this.btnClearMessageDisplay = new System.Windows.Forms.Button();
            this.btnCancelMessage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExclamationPoint = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnForwardSlash = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnSpaceBar = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn7Keyboard = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn0Keyboard = new System.Windows.Forms.Button();
            this.btn3Keyboard = new System.Windows.Forms.Button();
            this.btn2Keyboard = new System.Windows.Forms.Button();
            this.btn1Keyboard = new System.Windows.Forms.Button();
            this.btn6Keyboard = new System.Windows.Forms.Button();
            this.btn5Keyboard = new System.Windows.Forms.Button();
            this.btn4Keyboard = new System.Windows.Forms.Button();
            this.btn9Keyboard = new System.Windows.Forms.Button();
            this.btn8Keyboard = new System.Windows.Forms.Button();
            this.txtbMessageDisplay = new System.Windows.Forms.TextBox();
            this.hoursTableAdapter = new EAPOS_Project.CoffeeShopEmployeesDataSet1TableAdapters.HoursTableAdapter();
            this.tableAdapterManager2 = new EAPOS_Project.CoffeeShopEmployeesDataSet1TableAdapters.TableAdapterManager();
            this.employeesTableAdapter1 = new EAPOS_Project.CoffeeShopEmployeesDataSet1TableAdapters.EmployeesTableAdapter();
            this.employeesTableAdapter = new EAPOS_Project.CoffeeShopEmployeesDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new EAPOS_Project.CoffeeShopEmployeesDataSetTableAdapters.TableAdapterManager();
            this.buttonMainPanelTableAdapter = new EAPOS_Project.StoredItemsDataSetTableAdapters.ButtonMainPanelTableAdapter();
            this.tableAdapterManager1 = new EAPOS_Project.StoredItemsDataSetTableAdapters.TableAdapterManager();
            this.buttonMainPanelTableAdapter1 = new EAPOS_Project.StoredItemsDataSet1TableAdapters.ButtonMainPanelTableAdapter();
            this.tableAdapterManager3 = new EAPOS_Project.StoredItemsDataSet1TableAdapters.TableAdapterManager();
            this.buttonMainPanelTableAdapter2 = new EAPOS_Project.StoredItemsDataSet2TableAdapters.ButtonMainPanelTableAdapter();
            this.tableAdapterManager4 = new EAPOS_Project.StoredItemsDataSet2TableAdapters.TableAdapterManager();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlNewItem = new System.Windows.Forms.Panel();
            this.gpbxNewItem = new System.Windows.Forms.GroupBox();
            this.txtbNewItemFilename = new System.Windows.Forms.TextBox();
            this.txtbNewItemType = new System.Windows.Forms.TextBox();
            this.txtbNewItemPrice = new System.Windows.Forms.TextBox();
            this.txtbNewItemName = new System.Windows.Forms.TextBox();
            this.txtbNewItemID = new System.Windows.Forms.TextBox();
            this.btnCancelNewItem = new System.Windows.Forms.Button();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.gpbxNewItemPic = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnAddNewItemPic = new System.Windows.Forms.Button();
            lblEmployeeId = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblWage = new System.Windows.Forms.Label();
            colorblindLabel = new System.Windows.Forms.Label();
            leftHandedLabel = new System.Windows.Forms.Label();
            lblUpdateItemName = new System.Windows.Forms.Label();
            lblUpdatePrice = new System.Windows.Forms.Label();
            lblProductType = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            filenameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.pnlManagerMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopEmployeesDataSet1)).BeginInit();
            this.gpbEmployee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlManageHours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursBindingSource)).BeginInit();
            this.pnlProductMgmt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gpbxUpdateItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMainPanelBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedItemsDataSet2)).BeginInit();
            this.gpbxSelectedImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).BeginInit();
            this.grpbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMainPanelDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMainPanelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedItemsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMainPanelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedItemsDataSet)).BeginInit();
            this.pnlConfirmDeletion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMainPanelBindingSource1)).BeginInit();
            this.pnlCreateTest.SuspendLayout();
            this.pnlSalesReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMainPanelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).BeginInit();
            this.employeesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopEmployeesDataSet)).BeginInit();
            this.pnlMessageKeyboard.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlNewItem.SuspendLayout();
            this.gpbxNewItem.SuspendLayout();
            this.gpbxNewItemPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEmployeeId.Location = new System.Drawing.Point(30, 49);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new System.Drawing.Size(59, 31);
            lblEmployeeId.TabIndex = 13;
            lblEmployeeId.Text = "Id #";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFirstName.Location = new System.Drawing.Point(26, 116);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(147, 31);
            lblFirstName.TabIndex = 15;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLastName.Location = new System.Drawing.Point(26, 182);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(145, 31);
            lblLastName.TabIndex = 17;
            lblLastName.Text = "Last Name";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStatus.Location = new System.Drawing.Point(26, 256);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(92, 31);
            lblStatus.TabIndex = 19;
            lblStatus.Text = "Status";
            // 
            // lblWage
            // 
            lblWage.AutoSize = true;
            lblWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblWage.Location = new System.Drawing.Point(30, 331);
            lblWage.Name = "lblWage";
            lblWage.Size = new System.Drawing.Size(84, 31);
            lblWage.TabIndex = 21;
            lblWage.Text = "Wage";
            // 
            // colorblindLabel
            // 
            colorblindLabel.AutoSize = true;
            colorblindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorblindLabel.Location = new System.Drawing.Point(173, 13);
            colorblindLabel.Name = "colorblindLabel";
            colorblindLabel.Size = new System.Drawing.Size(115, 25);
            colorblindLabel.TabIndex = 25;
            colorblindLabel.Text = "Colorblind:";
            colorblindLabel.Click += new System.EventHandler(this.colorblindLabel_Click);
            // 
            // leftHandedLabel
            // 
            leftHandedLabel.AutoSize = true;
            leftHandedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            leftHandedLabel.Location = new System.Drawing.Point(10, 13);
            leftHandedLabel.Name = "leftHandedLabel";
            leftHandedLabel.Size = new System.Drawing.Size(135, 25);
            leftHandedLabel.TabIndex = 23;
            leftHandedLabel.Text = "Left Handed:";
            leftHandedLabel.Click += new System.EventHandler(this.leftHandedLabel_Click);
            // 
            // lblUpdateItemName
            // 
            lblUpdateItemName.AutoSize = true;
            lblUpdateItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUpdateItemName.Location = new System.Drawing.Point(25, 97);
            lblUpdateItemName.Name = "lblUpdateItemName";
            lblUpdateItemName.Size = new System.Drawing.Size(155, 31);
            lblUpdateItemName.TabIndex = 19;
            lblUpdateItemName.Text = "Item Name";
            // 
            // lblUpdatePrice
            // 
            lblUpdatePrice.AutoSize = true;
            lblUpdatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUpdatePrice.Location = new System.Drawing.Point(25, 167);
            lblUpdatePrice.Name = "lblUpdatePrice";
            lblUpdatePrice.Size = new System.Drawing.Size(81, 31);
            lblUpdatePrice.TabIndex = 20;
            lblUpdatePrice.Text = "Price";
            // 
            // lblProductType
            // 
            lblProductType.AutoSize = true;
            lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProductType.Location = new System.Drawing.Point(25, 233);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new System.Drawing.Size(79, 31);
            lblProductType.TabIndex = 23;
            lblProductType.Text = "Type";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productIDLabel.Location = new System.Drawing.Point(25, 40);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(153, 31);
            productIDLabel.TabIndex = 20;
            productIDLabel.Text = "Product ID";
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            filenameLabel.Location = new System.Drawing.Point(28, 295);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new System.Drawing.Size(133, 31);
            filenameLabel.TabIndex = 28;
            filenameLabel.Text = "Filename";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(32, 270);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(133, 31);
            label1.TabIndex = 40;
            label1.Text = "Filename";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(28, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(153, 31);
            label2.TabIndex = 32;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(28, 225);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 31);
            label3.TabIndex = 36;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(28, 159);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 31);
            label4.TabIndex = 34;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(28, 89);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(155, 31);
            label5.TabIndex = 31;
            label5.Text = "Item Name";
            // 
            // pnlManagerMode
            // 
            this.pnlManagerMode.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlManagerMode.Controls.Add(this.pictureBox2);
            this.pnlManagerMode.Controls.Add(this.lblCurrentDate);
            this.pnlManagerMode.Controls.Add(this.pictureBox1);
            this.pnlManagerMode.Controls.Add(this.btnSignOutManagerMode);
            this.pnlManagerMode.Controls.Add(this.lblManagerMode);
            this.pnlManagerMode.Controls.Add(this.btnOrderMode);
            this.pnlManagerMode.Controls.Add(this.btnSalesReport);
            this.pnlManagerMode.Controls.Add(this.btnCreateTrainingTests);
            this.pnlManagerMode.Controls.Add(this.btnProductManagement);
            this.pnlManagerMode.Controls.Add(this.btnEmployees);
            this.pnlManagerMode.Location = new System.Drawing.Point(0, 0);
            this.pnlManagerMode.Name = "pnlManagerMode";
            this.pnlManagerMode.Size = new System.Drawing.Size(1545, 1002);
            this.pnlManagerMode.TabIndex = 0;
            this.pnlManagerMode.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlManagerMode_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 907);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.BackColor = System.Drawing.Color.OrangeRed;
            this.lblCurrentDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(1286, 0);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(259, 52);
            this.lblCurrentDate.TabIndex = 18;
            this.lblCurrentDate.Text = "Current Date";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSignOutManagerMode
            // 
            this.btnSignOutManagerMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOutManagerMode.Location = new System.Drawing.Point(1336, 920);
            this.btnSignOutManagerMode.Name = "btnSignOutManagerMode";
            this.btnSignOutManagerMode.Size = new System.Drawing.Size(182, 60);
            this.btnSignOutManagerMode.TabIndex = 5;
            this.btnSignOutManagerMode.Text = "Sign Out";
            this.btnSignOutManagerMode.UseVisualStyleBackColor = true;
            this.btnSignOutManagerMode.Click += new System.EventHandler(this.btnSignOutManagerMode_Click);
            // 
            // lblManagerMode
            // 
            this.lblManagerMode.AutoSize = true;
            this.lblManagerMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerMode.Location = new System.Drawing.Point(638, 23);
            this.lblManagerMode.Name = "lblManagerMode";
            this.lblManagerMode.Size = new System.Drawing.Size(268, 55);
            this.lblManagerMode.TabIndex = 4;
            this.lblManagerMode.Text = "Back Office";
            // 
            // btnOrderMode
            // 
            this.btnOrderMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrderMode.BackgroundImage")));
            this.btnOrderMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrderMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMode.Location = new System.Drawing.Point(660, 789);
            this.btnOrderMode.Name = "btnOrderMode";
            this.btnOrderMode.Size = new System.Drawing.Size(246, 115);
            this.btnOrderMode.TabIndex = 2;
            this.btnOrderMode.UseVisualStyleBackColor = true;
            this.btnOrderMode.Click += new System.EventHandler(this.btnOrderMode_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalesReport.BackgroundImage")));
            this.btnSalesReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.Location = new System.Drawing.Point(1020, 236);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(400, 450);
            this.btnSalesReport.TabIndex = 3;
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnCreateTrainingTests
            // 
            this.btnCreateTrainingTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTrainingTests.Location = new System.Drawing.Point(126, 718);
            this.btnCreateTrainingTests.Name = "btnCreateTrainingTests";
            this.btnCreateTrainingTests.Size = new System.Drawing.Size(360, 115);
            this.btnCreateTrainingTests.TabIndex = 2;
            this.btnCreateTrainingTests.Text = "Create Training Tests";
            this.btnCreateTrainingTests.UseVisualStyleBackColor = true;
            this.btnCreateTrainingTests.Visible = false;
            this.btnCreateTrainingTests.Click += new System.EventHandler(this.btnCreateTrainingTests_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductManagement.BackgroundImage")));
            this.btnProductManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductManagement.Location = new System.Drawing.Point(572, 236);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(400, 450);
            this.btnProductManagement.TabIndex = 1;
            this.btnProductManagement.UseVisualStyleBackColor = true;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployees.BackgroundImage")));
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Location = new System.Drawing.Point(124, 235);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(400, 450);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlEmployees.Controls.Add(this.pictureBox5);
            this.pnlEmployees.Controls.Add(this.employeesDataGridView1);
            this.pnlEmployees.Controls.Add(this.gpbEmployee);
            this.pnlEmployees.Controls.Add(this.btnQuitEmployees);
            this.pnlEmployees.Controls.Add(this.lblEmployees);
            this.pnlEmployees.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1545, 996);
            this.pnlEmployees.TabIndex = 4;
            this.pnlEmployees.Visible = false;
            this.pnlEmployees.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmployees_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(14, 907);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(299, 83);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // employeesDataGridView1
            // 
            this.employeesDataGridView1.AutoGenerateColumns = false;
            this.employeesDataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.employeesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewCheckBoxColumn9,
            this.dataGridViewCheckBoxColumn10});
            this.employeesDataGridView1.DataSource = this.employeesBindingSource1;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeesDataGridView1.DefaultCellStyle = dataGridViewCellStyle25;
            this.employeesDataGridView1.Location = new System.Drawing.Point(198, 100);
            this.employeesDataGridView1.Name = "employeesDataGridView1";
            this.employeesDataGridView1.RowTemplate.Height = 32;
            this.employeesDataGridView1.Size = new System.Drawing.Size(1148, 271);
            this.employeesDataGridView1.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ID";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Fname";
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn11.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn11.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Lname";
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn12.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn12.Width = 220;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Status";
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn13.HeaderText = "Status";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn13.Width = 180;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Wage";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.Format = "C2";
            dataGridViewCellStyle22.NullValue = null;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn14.HeaderText = "Wage";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn14.Width = 130;
            // 
            // dataGridViewCheckBoxColumn9
            // 
            this.dataGridViewCheckBoxColumn9.DataPropertyName = "LeftHanded";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.NullValue = false;
            this.dataGridViewCheckBoxColumn9.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewCheckBoxColumn9.HeaderText = "Left-Handed";
            this.dataGridViewCheckBoxColumn9.Name = "dataGridViewCheckBoxColumn9";
            this.dataGridViewCheckBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn9.Width = 150;
            // 
            // dataGridViewCheckBoxColumn10
            // 
            this.dataGridViewCheckBoxColumn10.DataPropertyName = "Colorblind";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.NullValue = false;
            this.dataGridViewCheckBoxColumn10.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewCheckBoxColumn10.HeaderText = "Colorblind";
            this.dataGridViewCheckBoxColumn10.Name = "dataGridViewCheckBoxColumn10";
            this.dataGridViewCheckBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn10.Width = 130;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.coffeeShopEmployeesDataSet1;
            // 
            // coffeeShopEmployeesDataSet1
            // 
            this.coffeeShopEmployeesDataSet1.DataSetName = "CoffeeShopEmployeesDataSet1";
            this.coffeeShopEmployeesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gpbEmployee
            // 
            this.gpbEmployee.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gpbEmployee.Controls.Add(this.groupBox1);
            this.gpbEmployee.Controls.Add(this.btnManageHours);
            this.gpbEmployee.Controls.Add(this.txtbID);
            this.gpbEmployee.Controls.Add(this.txtbFirstName);
            this.gpbEmployee.Controls.Add(this.txtbLastName);
            this.gpbEmployee.Controls.Add(this.txtbStatus);
            this.gpbEmployee.Controls.Add(this.txtbWage);
            this.gpbEmployee.Controls.Add(this.btnAddEmployee);
            this.gpbEmployee.Controls.Add(this.btnUpdateEmployee);
            this.gpbEmployee.Controls.Add(this.btnDeleteEmployee);
            this.gpbEmployee.Controls.Add(lblWage);
            this.gpbEmployee.Controls.Add(lblStatus);
            this.gpbEmployee.Controls.Add(lblLastName);
            this.gpbEmployee.Controls.Add(lblFirstName);
            this.gpbEmployee.Controls.Add(lblEmployeeId);
            this.gpbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEmployee.Location = new System.Drawing.Point(357, 405);
            this.gpbEmployee.Name = "gpbEmployee";
            this.gpbEmployee.Size = new System.Drawing.Size(830, 515);
            this.gpbEmployee.TabIndex = 12;
            this.gpbEmployee.TabStop = false;
            this.gpbEmployee.Text = "Employee Info/Update";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(leftHandedLabel);
            this.groupBox1.Controls.Add(this.leftHandedCheckBox);
            this.groupBox1.Controls.Add(this.colorblindCheckBox);
            this.groupBox1.Controls.Add(colorblindLabel);
            this.groupBox1.Location = new System.Drawing.Point(500, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 105);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // leftHandedCheckBox
            // 
            this.leftHandedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeesBindingSource1, "LeftHanded", true));
            this.leftHandedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftHandedCheckBox.Location = new System.Drawing.Point(29, 54);
            this.leftHandedCheckBox.Name = "leftHandedCheckBox";
            this.leftHandedCheckBox.Size = new System.Drawing.Size(82, 31);
            this.leftHandedCheckBox.TabIndex = 27;
            this.leftHandedCheckBox.Text = "Yes";
            this.leftHandedCheckBox.UseVisualStyleBackColor = true;
            // 
            // colorblindCheckBox
            // 
            this.colorblindCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeesBindingSource1, "Colorblind", true));
            this.colorblindCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorblindCheckBox.Location = new System.Drawing.Point(192, 54);
            this.colorblindCheckBox.Name = "colorblindCheckBox";
            this.colorblindCheckBox.Size = new System.Drawing.Size(82, 33);
            this.colorblindCheckBox.TabIndex = 29;
            this.colorblindCheckBox.Text = "Yes";
            this.colorblindCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnManageHours
            // 
            this.btnManageHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageHours.Location = new System.Drawing.Point(552, 171);
            this.btnManageHours.Name = "btnManageHours";
            this.btnManageHours.Size = new System.Drawing.Size(193, 158);
            this.btnManageHours.TabIndex = 15;
            this.btnManageHours.Text = "Manage Employee Hours";
            this.btnManageHours.UseVisualStyleBackColor = true;
            this.btnManageHours.Visible = false;
            this.btnManageHours.Click += new System.EventHandler(this.btnManageHours_Click);
            // 
            // txtbID
            // 
            this.txtbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource1, "ID", true));
            this.txtbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbID.Location = new System.Drawing.Point(218, 46);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(104, 38);
            this.txtbID.TabIndex = 17;
            this.txtbID.TextChanged += new System.EventHandler(this.txtbID_TextChanged_1);
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource1, "Fname", true));
            this.txtbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFirstName.Location = new System.Drawing.Point(218, 113);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(214, 38);
            this.txtbFirstName.TabIndex = 19;
            // 
            // txtbLastName
            // 
            this.txtbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource1, "Lname", true));
            this.txtbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLastName.Location = new System.Drawing.Point(218, 179);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(214, 38);
            this.txtbLastName.TabIndex = 21;
            // 
            // txtbStatus
            // 
            this.txtbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource1, "Status", true));
            this.txtbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbStatus.Location = new System.Drawing.Point(218, 253);
            this.txtbStatus.Name = "txtbStatus";
            this.txtbStatus.Size = new System.Drawing.Size(214, 38);
            this.txtbStatus.TabIndex = 23;
            // 
            // txtbWage
            // 
            this.txtbWage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource1, "Wage", true));
            this.txtbWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbWage.Location = new System.Drawing.Point(218, 328);
            this.txtbWage.Name = "txtbWage";
            this.txtbWage.Size = new System.Drawing.Size(214, 38);
            this.txtbWage.TabIndex = 25;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(59, 400);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(181, 83);
            this.btnAddEmployee.TabIndex = 28;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployee.Location = new System.Drawing.Point(552, 358);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(193, 125);
            this.btnUpdateEmployee.TabIndex = 13;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(278, 400);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(181, 83);
            this.btnDeleteEmployee.TabIndex = 27;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnQuitEmployees
            // 
            this.btnQuitEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitEmployees.Location = new System.Drawing.Point(1295, 834);
            this.btnQuitEmployees.Name = "btnQuitEmployees";
            this.btnQuitEmployees.Size = new System.Drawing.Size(201, 87);
            this.btnQuitEmployees.TabIndex = 11;
            this.btnQuitEmployees.Text = "Back";
            this.btnQuitEmployees.UseVisualStyleBackColor = true;
            this.btnQuitEmployees.Click += new System.EventHandler(this.btnQuitEmployees_Click);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.Location = new System.Drawing.Point(641, 23);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(262, 55);
            this.lblEmployees.TabIndex = 3;
            this.lblEmployees.Text = "Employees";
            // 
            // pnlManageHours
            // 
            this.pnlManageHours.Controls.Add(this.btnQuitManageHours);
            this.pnlManageHours.Controls.Add(this.hoursDataGridView);
            this.pnlManageHours.Location = new System.Drawing.Point(168, 417);
            this.pnlManageHours.Name = "pnlManageHours";
            this.pnlManageHours.Size = new System.Drawing.Size(1168, 393);
            this.pnlManageHours.TabIndex = 16;
            this.pnlManageHours.Visible = false;
            // 
            // btnQuitManageHours
            // 
            this.btnQuitManageHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitManageHours.Location = new System.Drawing.Point(1010, 291);
            this.btnQuitManageHours.Name = "btnQuitManageHours";
            this.btnQuitManageHours.Size = new System.Drawing.Size(126, 63);
            this.btnQuitManageHours.TabIndex = 1;
            this.btnQuitManageHours.Text = "Quit";
            this.btnQuitManageHours.UseVisualStyleBackColor = true;
            this.btnQuitManageHours.Click += new System.EventHandler(this.btnQuitManageHours_Click);
            // 
            // hoursDataGridView
            // 
            this.hoursDataGridView.AutoGenerateColumns = false;
            this.hoursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoursDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.hoursDataGridView.DataSource = this.hoursBindingSource;
            this.hoursDataGridView.Location = new System.Drawing.Point(301, 54);
            this.hoursDataGridView.Name = "hoursDataGridView";
            this.hoursDataGridView.Size = new System.Drawing.Size(621, 220);
            this.hoursDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmpID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmpID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClockIn";
            this.dataGridViewTextBoxColumn2.HeaderText = "ClockIn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClockOut";
            this.dataGridViewTextBoxColumn3.HeaderText = "ClockOut";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HoursWorked";
            this.dataGridViewTextBoxColumn4.HeaderText = "HoursWorked";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // hoursBindingSource
            // 
            this.hoursBindingSource.DataMember = "Hours";
            this.hoursBindingSource.DataSource = this.coffeeShopEmployeesDataSet1;
            // 
            // pnlProductMgmt
            // 
            this.pnlProductMgmt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlProductMgmt.Controls.Add(this.pictureBox4);
            this.pnlProductMgmt.Controls.Add(this.gpbxUpdateItems);
            this.pnlProductMgmt.Controls.Add(this.grpbProducts);
            this.pnlProductMgmt.Controls.Add(this.btnQuitProductMgmt);
            this.pnlProductMgmt.Controls.Add(this.lblProductManagement);
            this.pnlProductMgmt.Location = new System.Drawing.Point(0, 0);
            this.pnlProductMgmt.Name = "pnlProductMgmt";
            this.pnlProductMgmt.Size = new System.Drawing.Size(1556, 999);
            this.pnlProductMgmt.TabIndex = 11;
            this.pnlProductMgmt.Visible = false;
            this.pnlProductMgmt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProductMgmt_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(14, 907);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(299, 83);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // gpbxUpdateItems
            // 
            this.gpbxUpdateItems.BackColor = System.Drawing.SystemColors.Info;
            this.gpbxUpdateItems.Controls.Add(filenameLabel);
            this.gpbxUpdateItems.Controls.Add(this.filenameTextBox);
            this.gpbxUpdateItems.Controls.Add(productIDLabel);
            this.gpbxUpdateItems.Controls.Add(this.productIDTextBox);
            this.gpbxUpdateItems.Controls.Add(lblProductType);
            this.gpbxUpdateItems.Controls.Add(this.btnAddImage);
            this.gpbxUpdateItems.Controls.Add(this.txtbItemName);
            this.gpbxUpdateItems.Controls.Add(this.txtbItemPrice);
            this.gpbxUpdateItems.Controls.Add(this.btnDeleteItem);
            this.gpbxUpdateItems.Controls.Add(this.txtbProductType);
            this.gpbxUpdateItems.Controls.Add(this.gpbxSelectedImage);
            this.gpbxUpdateItems.Controls.Add(this.btnUpdateItem);
            this.gpbxUpdateItems.Controls.Add(lblUpdatePrice);
            this.gpbxUpdateItems.Controls.Add(lblUpdateItemName);
            this.gpbxUpdateItems.Controls.Add(this.btnAddItem);
            this.gpbxUpdateItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxUpdateItems.Location = new System.Drawing.Point(416, 487);
            this.gpbxUpdateItems.Name = "gpbxUpdateItems";
            this.gpbxUpdateItems.Size = new System.Drawing.Size(726, 434);
            this.gpbxUpdateItems.TabIndex = 20;
            this.gpbxUpdateItems.TabStop = false;
            this.gpbxUpdateItems.Text = "Selected Item Info";
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buttonMainPanelBindingSource4, "Filename", true));
            this.filenameTextBox.Enabled = false;
            this.filenameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameTextBox.Location = new System.Drawing.Point(186, 292);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(246, 38);
            this.filenameTextBox.TabIndex = 29;
            // 
            // buttonMainPanelBindingSource4
            // 
            this.buttonMainPanelBindingSource4.DataMember = "ButtonMainPanel";
            this.buttonMainPanelBindingSource4.DataSource = this.storedItemsDataSet2;
            // 
            // storedItemsDataSet2
            // 
            this.storedItemsDataSet2.DataSetName = "StoredItemsDataSet2";
            this.storedItemsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buttonMainPanelBindingSource4, "ProductID", true));
            this.productIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDTextBox.Location = new System.Drawing.Point(186, 37);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(246, 38);
            this.productIDTextBox.TabIndex = 21;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.Location = new System.Drawing.Point(530, 253);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(118, 53);
            this.btnAddImage.TabIndex = 20;
            this.btnAddImage.Text = "Add/Update Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // txtbItemName
            // 
            this.txtbItemName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buttonMainPanelBindingSource4, "ItemName", true));
            this.txtbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbItemName.Location = new System.Drawing.Point(186, 94);
            this.txtbItemName.Name = "txtbItemName";
            this.txtbItemName.Size = new System.Drawing.Size(246, 38);
            this.txtbItemName.TabIndex = 23;
            // 
            // txtbItemPrice
            // 
            this.txtbItemPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buttonMainPanelBindingSource4, "Price", true));
            this.txtbItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbItemPrice.Location = new System.Drawing.Point(186, 164);
            this.txtbItemPrice.Name = "txtbItemPrice";
            this.txtbItemPrice.Size = new System.Drawing.Size(246, 38);
            this.txtbItemPrice.TabIndex = 25;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(37, 353);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(199, 60);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // txtbProductType
            // 
            this.txtbProductType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buttonMainPanelBindingSource4, "Type", true));
            this.txtbProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbProductType.Location = new System.Drawing.Point(186, 230);
            this.txtbProductType.Name = "txtbProductType";
            this.txtbProductType.Size = new System.Drawing.Size(246, 38);
            this.txtbProductType.TabIndex = 27;
            // 
            // gpbxSelectedImage
            // 
            this.gpbxSelectedImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbxSelectedImage.Controls.Add(this.pictureBoxSelectedImage);
            this.gpbxSelectedImage.Location = new System.Drawing.Point(477, 37);
            this.gpbxSelectedImage.Name = "gpbxSelectedImage";
            this.gpbxSelectedImage.Size = new System.Drawing.Size(204, 206);
            this.gpbxSelectedImage.TabIndex = 19;
            this.gpbxSelectedImage.TabStop = false;
            this.gpbxSelectedImage.Text = "Selected Image";
            // 
            // pictureBoxSelectedImage
            // 
            this.pictureBoxSelectedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSelectedImage.Location = new System.Drawing.Point(15, 29);
            this.pictureBoxSelectedImage.Name = "pictureBoxSelectedImage";
            this.pictureBoxSelectedImage.Size = new System.Drawing.Size(176, 163);
            this.pictureBoxSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedImage.TabIndex = 0;
            this.pictureBoxSelectedImage.TabStop = false;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.Location = new System.Drawing.Point(493, 353);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(199, 60);
            this.btnUpdateItem.TabIndex = 21;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(264, 353);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(199, 60);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // grpbProducts
            // 
            this.grpbProducts.Controls.Add(this.buttonMainPanelDataGridView1);
            this.grpbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbProducts.Location = new System.Drawing.Point(390, 81);
            this.grpbProducts.Name = "grpbProducts";
            this.grpbProducts.Size = new System.Drawing.Size(777, 396);
            this.grpbProducts.TabIndex = 19;
            this.grpbProducts.TabStop = false;
            this.grpbProducts.Text = "Products";
            // 
            // buttonMainPanelDataGridView1
            // 
            this.buttonMainPanelDataGridView1.AllowUserToResizeColumns = false;
            this.buttonMainPanelDataGridView1.AllowUserToResizeRows = false;
            this.buttonMainPanelDataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buttonMainPanelDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.buttonMainPanelDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buttonMainPanelDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.buttonMainPanelDataGridView1.DataSource = this.buttonMainPanelBindingSource4;
            this.buttonMainPanelDataGridView1.Location = new System.Drawing.Point(17, 25);
            this.buttonMainPanelDataGridView1.Name = "buttonMainPanelDataGridView1";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buttonMainPanelDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.buttonMainPanelDataGridView1.RowTemplate.Height = 30;
            this.buttonMainPanelDataGridView1.Size = new System.Drawing.Size(740, 324);
            this.buttonMainPanelDataGridView1.TabIndex = 0;
            this.buttonMainPanelDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buttonMainPanelDataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ProductID";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn15.HeaderText = "Product Id";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn15.Width = 110;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ItemName";
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTextBoxColumn16.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn16.Width = 180;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Price";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle29.Format = "C2";
            dataGridViewCellStyle29.NullValue = null;
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewTextBoxColumn17.HeaderText = "Price";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Type";
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewTextBoxColumn18.HeaderText = "Type";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 120;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Filename";
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridViewTextBoxColumn19.HeaderText = "Pic Filename";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn19.Width = 150;
            // 
            // btnQuitProductMgmt
            // 
            this.btnQuitProductMgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitProductMgmt.Location = new System.Drawing.Point(1295, 834);
            this.btnQuitProductMgmt.Name = "btnQuitProductMgmt";
            this.btnQuitProductMgmt.Size = new System.Drawing.Size(201, 87);
            this.btnQuitProductMgmt.TabIndex = 5;
            this.btnQuitProductMgmt.Text = "Back";
            this.btnQuitProductMgmt.UseVisualStyleBackColor = true;
            this.btnQuitProductMgmt.Click += new System.EventHandler(this.btnQuitProductMgmt_Click);
            // 
            // lblProductManagement
            // 
            this.lblProductManagement.AutoSize = true;
            this.lblProductManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductManagement.Location = new System.Drawing.Point(530, 23);
            this.lblProductManagement.Name = "lblProductManagement";
            this.lblProductManagement.Size = new System.Drawing.Size(485, 55);
            this.lblProductManagement.TabIndex = 3;
            this.lblProductManagement.Text = "Product Management";
            // 
            // buttonMainPanelBindingSource3
            // 
            this.buttonMainPanelBindingSource3.DataMember = "ButtonMainPanel";
            this.buttonMainPanelBindingSource3.DataSource = this.storedItemsDataSet1;
            // 
            // storedItemsDataSet1
            // 
            this.storedItemsDataSet1.DataSetName = "StoredItemsDataSet1";
            this.storedItemsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonMainPanelBindingSource2
            // 
            this.buttonMainPanelBindingSource2.DataMember = "ButtonMainPanel";
            this.buttonMainPanelBindingSource2.DataSource = this.storedItemsDataSet;
            // 
            // storedItemsDataSet
            // 
            this.storedItemsDataSet.DataSetName = "StoredItemsDataSet";
            this.storedItemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlConfirmDeletion
            // 
            this.pnlConfirmDeletion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlConfirmDeletion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfirmDeletion.Controls.Add(this.lblConfirmDeletionWarning);
            this.pnlConfirmDeletion.Controls.Add(this.btnCancelDeleteItem);
            this.pnlConfirmDeletion.Controls.Add(this.lblDeleteWarningInfo);
            this.pnlConfirmDeletion.Controls.Add(this.btnDelete);
            this.pnlConfirmDeletion.Controls.Add(this.lblConfirmDeletion);
            this.pnlConfirmDeletion.Location = new System.Drawing.Point(635, 217);
            this.pnlConfirmDeletion.Name = "pnlConfirmDeletion";
            this.pnlConfirmDeletion.Size = new System.Drawing.Size(540, 309);
            this.pnlConfirmDeletion.TabIndex = 10;
            this.pnlConfirmDeletion.Visible = false;
            // 
            // lblConfirmDeletionWarning
            // 
            this.lblConfirmDeletionWarning.AutoSize = true;
            this.lblConfirmDeletionWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmDeletionWarning.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmDeletionWarning.Location = new System.Drawing.Point(161, 74);
            this.lblConfirmDeletionWarning.Name = "lblConfirmDeletionWarning";
            this.lblConfirmDeletionWarning.Size = new System.Drawing.Size(216, 33);
            this.lblConfirmDeletionWarning.TabIndex = 4;
            this.lblConfirmDeletionWarning.Text = "!!!WARNING!!!";
            // 
            // btnCancelDeleteItem
            // 
            this.btnCancelDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDeleteItem.Location = new System.Drawing.Point(277, 211);
            this.btnCancelDeleteItem.Name = "btnCancelDeleteItem";
            this.btnCancelDeleteItem.Size = new System.Drawing.Size(136, 54);
            this.btnCancelDeleteItem.TabIndex = 3;
            this.btnCancelDeleteItem.Text = "Cancel";
            this.btnCancelDeleteItem.UseVisualStyleBackColor = true;
            this.btnCancelDeleteItem.Click += new System.EventHandler(this.btnCancelDeleteItem_Click);
            // 
            // lblDeleteWarningInfo
            // 
            this.lblDeleteWarningInfo.AutoSize = true;
            this.lblDeleteWarningInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteWarningInfo.Location = new System.Drawing.Point(63, 126);
            this.lblDeleteWarningInfo.Name = "lblDeleteWarningInfo";
            this.lblDeleteWarningInfo.Size = new System.Drawing.Size(409, 58);
            this.lblDeleteWarningInfo.TabIndex = 2;
            this.lblDeleteWarningInfo.Text = "All data will be permanently erased. *\r\nClick \'Delete\' to continue :";
            this.lblDeleteWarningInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(123, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 54);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblConfirmDeletion
            // 
            this.lblConfirmDeletion.AutoSize = true;
            this.lblConfirmDeletion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmDeletion.Location = new System.Drawing.Point(121, 25);
            this.lblConfirmDeletion.Name = "lblConfirmDeletion";
            this.lblConfirmDeletion.Size = new System.Drawing.Size(297, 37);
            this.lblConfirmDeletion.TabIndex = 0;
            this.lblConfirmDeletion.Text = "* Confirm Deletion *";
            // 
            // pnlCreateTest
            // 
            this.pnlCreateTest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlCreateTest.Controls.Add(this.btnCreateNewTest);
            this.pnlCreateTest.Controls.Add(this.txtbNewTestName);
            this.pnlCreateTest.Controls.Add(this.lblNewTestName);
            this.pnlCreateTest.Controls.Add(this.btnQuitCreateTest);
            this.pnlCreateTest.Controls.Add(this.lblCreatePracticeTest);
            this.pnlCreateTest.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateTest.Name = "pnlCreateTest";
            this.pnlCreateTest.Size = new System.Drawing.Size(1545, 960);
            this.pnlCreateTest.TabIndex = 5;
            this.pnlCreateTest.Visible = false;
            // 
            // btnCreateNewTest
            // 
            this.btnCreateNewTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewTest.Location = new System.Drawing.Point(655, 429);
            this.btnCreateNewTest.Name = "btnCreateNewTest";
            this.btnCreateNewTest.Size = new System.Drawing.Size(271, 127);
            this.btnCreateNewTest.TabIndex = 4;
            this.btnCreateNewTest.Text = "Create Test";
            this.btnCreateNewTest.UseVisualStyleBackColor = true;
            this.btnCreateNewTest.Click += new System.EventHandler(this.btnCreateNewTest_Click);
            // 
            // txtbNewTestName
            // 
            this.txtbNewTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNewTestName.Location = new System.Drawing.Point(723, 260);
            this.txtbNewTestName.Name = "txtbNewTestName";
            this.txtbNewTestName.Size = new System.Drawing.Size(367, 40);
            this.txtbNewTestName.TabIndex = 3;
            // 
            // lblNewTestName
            // 
            this.lblNewTestName.AutoSize = true;
            this.lblNewTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTestName.Location = new System.Drawing.Point(455, 263);
            this.lblNewTestName.Name = "lblNewTestName";
            this.lblNewTestName.Size = new System.Drawing.Size(224, 33);
            this.lblNewTestName.TabIndex = 2;
            this.lblNewTestName.Text = "New Test Name";
            this.lblNewTestName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnQuitCreateTest
            // 
            this.btnQuitCreateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitCreateTest.Location = new System.Drawing.Point(1295, 834);
            this.btnQuitCreateTest.Name = "btnQuitCreateTest";
            this.btnQuitCreateTest.Size = new System.Drawing.Size(201, 87);
            this.btnQuitCreateTest.TabIndex = 1;
            this.btnQuitCreateTest.Text = "Quit";
            this.btnQuitCreateTest.UseVisualStyleBackColor = true;
            this.btnQuitCreateTest.Click += new System.EventHandler(this.btnQuitCreateTest_Click);
            // 
            // lblCreatePracticeTest
            // 
            this.lblCreatePracticeTest.AutoSize = true;
            this.lblCreatePracticeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatePracticeTest.Location = new System.Drawing.Point(530, 42);
            this.lblCreatePracticeTest.Name = "lblCreatePracticeTest";
            this.lblCreatePracticeTest.Size = new System.Drawing.Size(485, 55);
            this.lblCreatePracticeTest.TabIndex = 0;
            this.lblCreatePracticeTest.Text = "Create Practice Tests";
            // 
            // pnlSalesReport
            // 
            this.pnlSalesReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlSalesReport.Controls.Add(this.pictureBox3);
            this.pnlSalesReport.Controls.Add(this.rtxtbSalesReport);
            this.pnlSalesReport.Controls.Add(this.lblSalesReport);
            this.pnlSalesReport.Controls.Add(this.btnQuitSalesReport);
            this.pnlSalesReport.Location = new System.Drawing.Point(0, 0);
            this.pnlSalesReport.Name = "pnlSalesReport";
            this.pnlSalesReport.Size = new System.Drawing.Size(1545, 1011);
            this.pnlSalesReport.TabIndex = 5;
            this.pnlSalesReport.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 907);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(299, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // rtxtbSalesReport
            // 
            this.rtxtbSalesReport.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtbSalesReport.Location = new System.Drawing.Point(314, 140);
            this.rtxtbSalesReport.Name = "rtxtbSalesReport";
            this.rtxtbSalesReport.Size = new System.Drawing.Size(916, 781);
            this.rtxtbSalesReport.TabIndex = 2;
            this.rtxtbSalesReport.Text = "";
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.Location = new System.Drawing.Point(621, 23);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(302, 55);
            this.lblSalesReport.TabIndex = 1;
            this.lblSalesReport.Text = "Sales Report";
            // 
            // btnQuitSalesReport
            // 
            this.btnQuitSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitSalesReport.Location = new System.Drawing.Point(1295, 834);
            this.btnQuitSalesReport.Name = "btnQuitSalesReport";
            this.btnQuitSalesReport.Size = new System.Drawing.Size(201, 87);
            this.btnQuitSalesReport.TabIndex = 0;
            this.btnQuitSalesReport.Text = "Back";
            this.btnQuitSalesReport.UseVisualStyleBackColor = true;
            this.btnQuitSalesReport.Click += new System.EventHandler(this.btnQuitSalesReport_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // employeesBindingNavigatorSaveItem
            // 
            this.employeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeesBindingNavigatorSaveItem.Image")));
            this.employeesBindingNavigatorSaveItem.Name = "employeesBindingNavigatorSaveItem";
            this.employeesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeesBindingNavigatorSaveItem.Text = "Save Data";
            this.employeesBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeesBindingNavigatorSaveItem_Click);
            // 
            // employeesBindingNavigator
            // 
            this.employeesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeesBindingNavigator.BindingSource = this.employeesBindingSource;
            this.employeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.employeesBindingNavigatorSaveItem});
            this.employeesBindingNavigator.Location = new System.Drawing.Point(0, 977);
            this.employeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeesBindingNavigator.Name = "employeesBindingNavigator";
            this.employeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeesBindingNavigator.Size = new System.Drawing.Size(1563, 25);
            this.employeesBindingNavigator.TabIndex = 12;
            this.employeesBindingNavigator.Text = "bindingNavigator1";
            this.employeesBindingNavigator.Visible = false;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.coffeeShopEmployeesDataSet;
            // 
            // coffeeShopEmployeesDataSet
            // 
            this.coffeeShopEmployeesDataSet.DataSetName = "CoffeeShopEmployeesDataSet";
            this.coffeeShopEmployeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlMessageKeyboard
            // 
            this.pnlMessageKeyboard.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMessageKeyboard.Controls.Add(this.btnEnterMessage);
            this.pnlMessageKeyboard.Controls.Add(this.btnClearMessageDisplay);
            this.pnlMessageKeyboard.Controls.Add(this.btnCancelMessage);
            this.pnlMessageKeyboard.Controls.Add(this.groupBox2);
            this.pnlMessageKeyboard.Controls.Add(this.groupBox3);
            this.pnlMessageKeyboard.Controls.Add(this.txtbMessageDisplay);
            this.pnlMessageKeyboard.Location = new System.Drawing.Point(25, 218);
            this.pnlMessageKeyboard.Name = "pnlMessageKeyboard";
            this.pnlMessageKeyboard.Size = new System.Drawing.Size(1463, 478);
            this.pnlMessageKeyboard.TabIndex = 17;
            this.pnlMessageKeyboard.Visible = false;
            // 
            // btnEnterMessage
            // 
            this.btnEnterMessage.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterMessage.Location = new System.Drawing.Point(954, 24);
            this.btnEnterMessage.Name = "btnEnterMessage";
            this.btnEnterMessage.Size = new System.Drawing.Size(156, 61);
            this.btnEnterMessage.TabIndex = 51;
            this.btnEnterMessage.Text = "Enter";
            this.btnEnterMessage.UseVisualStyleBackColor = true;
            this.btnEnterMessage.Click += new System.EventHandler(this.btnEnterMessage_Click);
            // 
            // btnClearMessageDisplay
            // 
            this.btnClearMessageDisplay.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMessageDisplay.Location = new System.Drawing.Point(1130, 24);
            this.btnClearMessageDisplay.Name = "btnClearMessageDisplay";
            this.btnClearMessageDisplay.Size = new System.Drawing.Size(149, 61);
            this.btnClearMessageDisplay.TabIndex = 50;
            this.btnClearMessageDisplay.Text = "Clear";
            this.btnClearMessageDisplay.UseVisualStyleBackColor = true;
            // 
            // btnCancelMessage
            // 
            this.btnCancelMessage.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelMessage.Location = new System.Drawing.Point(1292, 24);
            this.btnCancelMessage.Name = "btnCancelMessage";
            this.btnCancelMessage.Size = new System.Drawing.Size(149, 61);
            this.btnCancelMessage.TabIndex = 49;
            this.btnCancelMessage.Text = "Cancel";
            this.btnCancelMessage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.btnExclamationPoint);
            this.groupBox2.Controls.Add(this.btnComma);
            this.groupBox2.Controls.Add(this.btnPeriod);
            this.groupBox2.Controls.Add(this.btnForwardSlash);
            this.groupBox2.Controls.Add(this.btnBackspace);
            this.groupBox2.Controls.Add(this.btnSpaceBar);
            this.groupBox2.Controls.Add(this.btnZ);
            this.groupBox2.Controls.Add(this.btnB);
            this.groupBox2.Controls.Add(this.btnV);
            this.groupBox2.Controls.Add(this.btnC);
            this.groupBox2.Controls.Add(this.btnX);
            this.groupBox2.Controls.Add(this.btnN);
            this.groupBox2.Controls.Add(this.btnM);
            this.groupBox2.Controls.Add(this.btnA);
            this.groupBox2.Controls.Add(this.btnG);
            this.groupBox2.Controls.Add(this.btnF);
            this.groupBox2.Controls.Add(this.btnD);
            this.groupBox2.Controls.Add(this.btnS);
            this.groupBox2.Controls.Add(this.btnH);
            this.groupBox2.Controls.Add(this.btnL);
            this.groupBox2.Controls.Add(this.btnJ);
            this.groupBox2.Controls.Add(this.btnK);
            this.groupBox2.Controls.Add(this.btnQ);
            this.groupBox2.Controls.Add(this.btnT);
            this.groupBox2.Controls.Add(this.btnR);
            this.groupBox2.Controls.Add(this.btnP);
            this.groupBox2.Controls.Add(this.btnE);
            this.groupBox2.Controls.Add(this.btnW);
            this.groupBox2.Controls.Add(this.btnY);
            this.groupBox2.Controls.Add(this.btnO);
            this.groupBox2.Controls.Add(this.btnU);
            this.groupBox2.Controls.Add(this.btnI);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1101, 348);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            // 
            // btnExclamationPoint
            // 
            this.btnExclamationPoint.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExclamationPoint.Location = new System.Drawing.Point(981, 106);
            this.btnExclamationPoint.Name = "btnExclamationPoint";
            this.btnExclamationPoint.Size = new System.Drawing.Size(75, 61);
            this.btnExclamationPoint.TabIndex = 55;
            this.btnExclamationPoint.Text = "!";
            this.btnExclamationPoint.UseVisualStyleBackColor = true;
            // 
            // btnComma
            // 
            this.btnComma.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.Location = new System.Drawing.Point(742, 184);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(75, 61);
            this.btnComma.TabIndex = 54;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = true;
            // 
            // btnPeriod
            // 
            this.btnPeriod.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriod.Location = new System.Drawing.Point(836, 184);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(75, 61);
            this.btnPeriod.TabIndex = 53;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = true;
            // 
            // btnForwardSlash
            // 
            this.btnForwardSlash.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForwardSlash.Location = new System.Drawing.Point(886, 107);
            this.btnForwardSlash.Name = "btnForwardSlash";
            this.btnForwardSlash.Size = new System.Drawing.Size(75, 61);
            this.btnForwardSlash.TabIndex = 52;
            this.btnForwardSlash.Text = "/";
            this.btnForwardSlash.UseVisualStyleBackColor = true;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(928, 32);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(150, 61);
            this.btnBackspace.TabIndex = 51;
            this.btnBackspace.Text = "Backspace";
            this.btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnSpaceBar
            // 
            this.btnSpaceBar.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaceBar.Location = new System.Drawing.Point(286, 263);
            this.btnSpaceBar.Name = "btnSpaceBar";
            this.btnSpaceBar.Size = new System.Drawing.Size(439, 61);
            this.btnSpaceBar.TabIndex = 50;
            this.btnSpaceBar.Text = "Space";
            this.btnSpaceBar.UseVisualStyleBackColor = true;
            // 
            // btnZ
            // 
            this.btnZ.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.Location = new System.Drawing.Point(104, 184);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(75, 61);
            this.btnZ.TabIndex = 42;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(468, 184);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 61);
            this.btnB.TabIndex = 43;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnV
            // 
            this.btnV.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(377, 184);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(75, 61);
            this.btnV.TabIndex = 44;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(286, 184);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 61);
            this.btnC.TabIndex = 45;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(195, 184);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 61);
            this.btnX.TabIndex = 46;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(559, 184);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(75, 61);
            this.btnN.TabIndex = 48;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(650, 184);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(75, 61);
            this.btnM.TabIndex = 47;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(61, 107);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 61);
            this.btnA.TabIndex = 33;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(425, 107);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(75, 61);
            this.btnG.TabIndex = 34;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(334, 107);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(75, 61);
            this.btnF.TabIndex = 35;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(243, 107);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 61);
            this.btnD.TabIndex = 36;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(152, 107);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 61);
            this.btnS.TabIndex = 37;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // btnH
            // 
            this.btnH.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(516, 107);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(75, 61);
            this.btnH.TabIndex = 41;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(789, 107);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 61);
            this.btnL.TabIndex = 38;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            // 
            // btnJ
            // 
            this.btnJ.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(607, 107);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(75, 61);
            this.btnJ.TabIndex = 40;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            // 
            // btnK
            // 
            this.btnK.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(698, 107);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(75, 61);
            this.btnK.TabIndex = 39;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            // 
            // btnQ
            // 
            this.btnQ.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(22, 32);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(75, 61);
            this.btnQ.TabIndex = 23;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            this.btnT.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(386, 32);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(75, 61);
            this.btnT.TabIndex = 24;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            this.btnR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(295, 32);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 61);
            this.btnR.TabIndex = 25;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(841, 32);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 61);
            this.btnP.TabIndex = 32;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(204, 32);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 61);
            this.btnE.TabIndex = 26;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            this.btnW.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(113, 32);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(75, 61);
            this.btnW.TabIndex = 27;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            this.btnY.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(477, 32);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(75, 61);
            this.btnY.TabIndex = 31;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            // 
            // btnO
            // 
            this.btnO.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(750, 32);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(75, 61);
            this.btnO.TabIndex = 28;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            this.btnU.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(568, 32);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 61);
            this.btnU.TabIndex = 30;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            // 
            // btnI
            // 
            this.btnI.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(659, 32);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(75, 61);
            this.btnI.TabIndex = 29;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.btn7Keyboard);
            this.groupBox3.Controls.Add(this.btnMinus);
            this.groupBox3.Controls.Add(this.btnPlus);
            this.groupBox3.Controls.Add(this.btn0Keyboard);
            this.groupBox3.Controls.Add(this.btn3Keyboard);
            this.groupBox3.Controls.Add(this.btn2Keyboard);
            this.groupBox3.Controls.Add(this.btn1Keyboard);
            this.groupBox3.Controls.Add(this.btn6Keyboard);
            this.groupBox3.Controls.Add(this.btn5Keyboard);
            this.groupBox3.Controls.Add(this.btn4Keyboard);
            this.groupBox3.Controls.Add(this.btn9Keyboard);
            this.groupBox3.Controls.Add(this.btn8Keyboard);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1130, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 348);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // btn7Keyboard
            // 
            this.btn7Keyboard.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7Keyboard.Location = new System.Drawing.Point(41, 35);
            this.btn7Keyboard.Name = "btn7Keyboard";
            this.btn7Keyboard.Size = new System.Drawing.Size(75, 61);
            this.btn7Keyboard.TabIndex = 48;
            this.btn7Keyboard.Text = "7";
            this.btn7Keyboard.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(207, 255);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 61);
            this.btnMinus.TabIndex = 47;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(43, 255);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 61);
            this.btnPlus.TabIndex = 46;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btn0Keyboard
            // 
            this.btn0Keyboard.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0Keyboard.Location = new System.Drawing.Point(126, 255);
            this.btn0Keyboard.Name = "btn0Keyboard";
            this.btn0Keyboard.Size = new System.Drawing.Size(75, 61);
            this.btn0Keyboard.TabIndex = 45;
            this.btn0Keyboard.Text = "0";
            this.btn0Keyboard.UseVisualStyleBackColor = true;
            // 
            // btn3Keyboard
            // 
            this.btn3Keyboard.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Keyboard.Location = new System.Drawing.Point(207, 184);
            this.btn3Keyboard.Name = "btn3Keyboard";
            this.btn3Keyboard.Size = new System.Drawing.Size(75, 61);
            this.btn3Keyboard.TabIndex = 43;
            this.btn3Keyboard.Text = "3";
            this.btn3Keyboard.UseVisualStyleBackColor = true;
            // 
            // btn2Keyboard
            // 
            this.btn2Keyboard.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Keyboard.Location = new System.Drawing.Point(126, 184);
            this.btn2Keyboard.Name = "btn2Keyboard";
            this.btn2Keyboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn2Keyboard.Size = new System.Drawing.Size(75, 61);
            this.btn2Keyboard.TabIndex = 42;
            this.btn2Keyboard.Text = "2";
            this.btn2Keyboard.UseVisualStyleBackColor = true;
            // 
            // btn1Keyboard
            // 
            this.btn1Keyboard.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Keyboard.Location = new System.Drawing.Point(43, 184);
            this.btn1Keyboard.Name = "btn1Keyboard";
            this.btn1Keyboard.Size = new System.Drawing.Size(75, 61);
            this.btn1Keyboard.TabIndex = 41;
            this.btn1Keyboard.Text = "1";
            this.btn1Keyboard.UseVisualStyleBackColor = true;
            // 
            // btn6Keyboard
            // 
            this.btn6Keyboard.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6Keyboard.Location = new System.Drawing.Point(207, 107);
            this.btn6Keyboard.Name = "btn6Keyboard";
            this.btn6Keyboard.Size = new System.Drawing.Size(75, 61);
            this.btn6Keyboard.TabIndex = 40;
            this.btn6Keyboard.Text = "6";
            this.btn6Keyboard.UseVisualStyleBackColor = true;
            // 
            // btn5Keyboard
            // 
            this.btn5Keyboard.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Keyboard.Location = new System.Drawing.Point(126, 107);
            this.btn5Keyboard.Name = "btn5Keyboard";
            this.btn5Keyboard.Size = new System.Drawing.Size(75, 61);
            this.btn5Keyboard.TabIndex = 39;
            this.btn5Keyboard.Text = "5";
            this.btn5Keyboard.UseVisualStyleBackColor = true;
            // 
            // btn4Keyboard
            // 
            this.btn4Keyboard.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Keyboard.Location = new System.Drawing.Point(43, 107);
            this.btn4Keyboard.Name = "btn4Keyboard";
            this.btn4Keyboard.Size = new System.Drawing.Size(75, 61);
            this.btn4Keyboard.TabIndex = 38;
            this.btn4Keyboard.Text = "4";
            this.btn4Keyboard.UseVisualStyleBackColor = true;
            // 
            // btn9Keyboard
            // 
            this.btn9Keyboard.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9Keyboard.Location = new System.Drawing.Point(207, 35);
            this.btn9Keyboard.Name = "btn9Keyboard";
            this.btn9Keyboard.Size = new System.Drawing.Size(75, 61);
            this.btn9Keyboard.TabIndex = 37;
            this.btn9Keyboard.Text = "9";
            this.btn9Keyboard.UseVisualStyleBackColor = true;
            // 
            // btn8Keyboard
            // 
            this.btn8Keyboard.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8Keyboard.Location = new System.Drawing.Point(124, 35);
            this.btn8Keyboard.Name = "btn8Keyboard";
            this.btn8Keyboard.Size = new System.Drawing.Size(75, 61);
            this.btn8Keyboard.TabIndex = 36;
            this.btn8Keyboard.Text = "8";
            this.btn8Keyboard.UseVisualStyleBackColor = true;
            // 
            // txtbMessageDisplay
            // 
            this.txtbMessageDisplay.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMessageDisplay.Location = new System.Drawing.Point(31, 24);
            this.txtbMessageDisplay.Multiline = true;
            this.txtbMessageDisplay.Name = "txtbMessageDisplay";
            this.txtbMessageDisplay.ReadOnly = true;
            this.txtbMessageDisplay.Size = new System.Drawing.Size(894, 61);
            this.txtbMessageDisplay.TabIndex = 44;
            this.txtbMessageDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoursTableAdapter
            // 
            this.hoursTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.EmployeesTableAdapter = null;
            this.tableAdapterManager2.HoursTableAdapter = this.hoursTableAdapter;
            this.tableAdapterManager2.UpdateOrder = EAPOS_Project.CoffeeShopEmployeesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.UpdateOrder = EAPOS_Project.CoffeeShopEmployeesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buttonMainPanelTableAdapter
            // 
            this.buttonMainPanelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AddOnsTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ButtonMainPanelTableAdapter = this.buttonMainPanelTableAdapter;
            this.tableAdapterManager1.IceCreamFlavorsPanelTableAdapter = null;
            this.tableAdapterManager1.SizeOptionsPanelTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = EAPOS_Project.StoredItemsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buttonMainPanelTableAdapter1
            // 
            this.buttonMainPanelTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.AddOnsTableAdapter = null;
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.ButtonMainPanelTableAdapter = this.buttonMainPanelTableAdapter1;
            this.tableAdapterManager3.IceCreamFlavorsPanelTableAdapter = null;
            this.tableAdapterManager3.SizeOptionsPanelTableAdapter = null;
            this.tableAdapterManager3.UpdateOrder = EAPOS_Project.StoredItemsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buttonMainPanelTableAdapter2
            // 
            this.buttonMainPanelTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager4
            // 
            this.tableAdapterManager4.AddOnsTableAdapter = null;
            this.tableAdapterManager4.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager4.ButtonMainPanelTableAdapter = this.buttonMainPanelTableAdapter2;
            this.tableAdapterManager4.IceCreamFlavorsPanelTableAdapter = null;
            this.tableAdapterManager4.SizeOptionsPanelTableAdapter = null;
            this.tableAdapterManager4.UpdateOrder = EAPOS_Project.StoredItemsDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlNewItem
            // 
            this.pnlNewItem.Controls.Add(this.gpbxNewItem);
            this.pnlNewItem.Location = new System.Drawing.Point(374, 367);
            this.pnlNewItem.Name = "pnlNewItem";
            this.pnlNewItem.Size = new System.Drawing.Size(813, 416);
            this.pnlNewItem.TabIndex = 22;
            this.pnlNewItem.Visible = false;
            // 
            // gpbxNewItem
            // 
            this.gpbxNewItem.BackColor = System.Drawing.SystemColors.Info;
            this.gpbxNewItem.Controls.Add(this.txtbNewItemFilename);
            this.gpbxNewItem.Controls.Add(this.txtbNewItemType);
            this.gpbxNewItem.Controls.Add(this.txtbNewItemPrice);
            this.gpbxNewItem.Controls.Add(this.txtbNewItemName);
            this.gpbxNewItem.Controls.Add(this.txtbNewItemID);
            this.gpbxNewItem.Controls.Add(this.btnCancelNewItem);
            this.gpbxNewItem.Controls.Add(this.btnAddNewItem);
            this.gpbxNewItem.Controls.Add(label2);
            this.gpbxNewItem.Controls.Add(label1);
            this.gpbxNewItem.Controls.Add(label5);
            this.gpbxNewItem.Controls.Add(label4);
            this.gpbxNewItem.Controls.Add(this.gpbxNewItemPic);
            this.gpbxNewItem.Controls.Add(label3);
            this.gpbxNewItem.Controls.Add(this.btnAddNewItemPic);
            this.gpbxNewItem.Location = new System.Drawing.Point(30, 18);
            this.gpbxNewItem.Name = "gpbxNewItem";
            this.gpbxNewItem.Size = new System.Drawing.Size(753, 382);
            this.gpbxNewItem.TabIndex = 42;
            this.gpbxNewItem.TabStop = false;
            this.gpbxNewItem.Text = "Add New Item";
            // 
            // txtbNewItemFilename
            // 
            this.txtbNewItemFilename.Enabled = false;
            this.txtbNewItemFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNewItemFilename.Location = new System.Drawing.Point(189, 269);
            this.txtbNewItemFilename.Name = "txtbNewItemFilename";
            this.txtbNewItemFilename.Size = new System.Drawing.Size(246, 38);
            this.txtbNewItemFilename.TabIndex = 48;
            // 
            // txtbNewItemType
            // 
            this.txtbNewItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNewItemType.Location = new System.Drawing.Point(189, 218);
            this.txtbNewItemType.Name = "txtbNewItemType";
            this.txtbNewItemType.Size = new System.Drawing.Size(246, 38);
            this.txtbNewItemType.TabIndex = 47;
            // 
            // txtbNewItemPrice
            // 
            this.txtbNewItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNewItemPrice.Location = new System.Drawing.Point(189, 159);
            this.txtbNewItemPrice.Name = "txtbNewItemPrice";
            this.txtbNewItemPrice.Size = new System.Drawing.Size(246, 38);
            this.txtbNewItemPrice.TabIndex = 46;
            // 
            // txtbNewItemName
            // 
            this.txtbNewItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNewItemName.Location = new System.Drawing.Point(189, 89);
            this.txtbNewItemName.Name = "txtbNewItemName";
            this.txtbNewItemName.Size = new System.Drawing.Size(246, 38);
            this.txtbNewItemName.TabIndex = 45;
            // 
            // txtbNewItemID
            // 
            this.txtbNewItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNewItemID.Location = new System.Drawing.Point(189, 29);
            this.txtbNewItemID.Name = "txtbNewItemID";
            this.txtbNewItemID.Size = new System.Drawing.Size(246, 38);
            this.txtbNewItemID.TabIndex = 44;
            // 
            // btnCancelNewItem
            // 
            this.btnCancelNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNewItem.Location = new System.Drawing.Point(437, 312);
            this.btnCancelNewItem.Name = "btnCancelNewItem";
            this.btnCancelNewItem.Size = new System.Drawing.Size(199, 60);
            this.btnCancelNewItem.TabIndex = 43;
            this.btnCancelNewItem.Text = "Cancel";
            this.btnCancelNewItem.UseVisualStyleBackColor = true;
            this.btnCancelNewItem.Click += new System.EventHandler(this.btnCancelNewItem_Click);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewItem.Location = new System.Drawing.Point(190, 311);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(199, 60);
            this.btnAddNewItem.TabIndex = 42;
            this.btnAddNewItem.Text = "Add Item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // gpbxNewItemPic
            // 
            this.gpbxNewItemPic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbxNewItemPic.Controls.Add(this.pictureBox6);
            this.gpbxNewItemPic.Location = new System.Drawing.Point(482, 29);
            this.gpbxNewItemPic.Name = "gpbxNewItemPic";
            this.gpbxNewItemPic.Size = new System.Drawing.Size(204, 206);
            this.gpbxNewItemPic.TabIndex = 30;
            this.gpbxNewItemPic.TabStop = false;
            this.gpbxNewItemPic.Text = "Selected Image";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(15, 29);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(176, 163);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // btnAddNewItemPic
            // 
            this.btnAddNewItemPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewItemPic.Location = new System.Drawing.Point(535, 245);
            this.btnAddNewItemPic.Name = "btnAddNewItemPic";
            this.btnAddNewItemPic.Size = new System.Drawing.Size(118, 53);
            this.btnAddNewItemPic.TabIndex = 33;
            this.btnAddNewItemPic.Text = "Add Image";
            this.btnAddNewItemPic.UseVisualStyleBackColor = true;
            this.btnAddNewItemPic.Click += new System.EventHandler(this.btnAddNewItemPic_Click);
            // 
            // frmManagerMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1563, 1002);
            this.Controls.Add(this.pnlNewItem);
            this.Controls.Add(this.pnlProductMgmt);
            this.Controls.Add(this.pnlEmployees);
            this.Controls.Add(this.pnlManagerMode);
            this.Controls.Add(this.pnlSalesReport);
            this.Controls.Add(this.pnlManageHours);
            this.Controls.Add(this.pnlMessageKeyboard);
            this.Controls.Add(this.pnlCreateTest);
            this.Controls.Add(this.pnlConfirmDeletion);
            this.Controls.Add(this.employeesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagerMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manager Mode";
            this.Load += new System.EventHandler(this.frmManagerMode_Load_1);
            this.pnlManagerMode.ResumeLayout(false);
            this.pnlManagerMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopEmployeesDataSet1)).EndInit();
            this.gpbEmployee.ResumeLayout(false);
            this.gpbEmployee.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlManageHours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hoursDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursBindingSource)).EndInit();
            this.pnlProductMgmt.ResumeLayout(false);
            this.pnlProductMgmt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gpbxUpdateItems.ResumeLayout(false);
            this.gpbxUpdateItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMainPanelBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedItemsDataSet2)).EndInit();
            this.gpbxSelectedImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).EndInit();
            this.grpbProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonMainPanelDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMainPanelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedItemsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMainPanelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedItemsDataSet)).EndInit();
            this.pnlConfirmDeletion.ResumeLayout(false);
            this.pnlConfirmDeletion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMainPanelBindingSource1)).EndInit();
            this.pnlCreateTest.ResumeLayout(false);
            this.pnlCreateTest.PerformLayout();
            this.pnlSalesReport.ResumeLayout(false);
            this.pnlSalesReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMainPanelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).EndInit();
            this.employeesBindingNavigator.ResumeLayout(false);
            this.employeesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopEmployeesDataSet)).EndInit();
            this.pnlMessageKeyboard.ResumeLayout(false);
            this.pnlMessageKeyboard.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.pnlNewItem.ResumeLayout(false);
            this.gpbxNewItem.ResumeLayout(false);
            this.gpbxNewItem.PerformLayout();
            this.gpbxNewItemPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlManagerMode;
        public System.Windows.Forms.Button btnOrderMode;
        public System.Windows.Forms.Button btnSalesReport;
        public System.Windows.Forms.Button btnCreateTrainingTests;
        public System.Windows.Forms.Button btnProductManagement;
        public System.Windows.Forms.Button btnEmployees;
        public System.Windows.Forms.Panel pnlEmployees;
        public System.Windows.Forms.Label lblEmployees;
        public System.Windows.Forms.Label lblManagerMode;
        public System.Windows.Forms.Panel pnlProductMgmt;
        public System.Windows.Forms.Label lblProductManagement;
        public System.Windows.Forms.Button btnQuitProductMgmt;
        public System.Windows.Forms.Button btnQuitEmployees;
        public System.Windows.Forms.Button btnUpdateEmployee;
        public System.Windows.Forms.GroupBox gpbEmployee;
        public System.Windows.Forms.Panel pnlConfirmDeletion;
        public System.Windows.Forms.Label lblDeleteWarningInfo;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lblConfirmDeletion;
        public System.Windows.Forms.Button btnDeleteItem;
        public System.Windows.Forms.Panel pnlCreateTest;
        public System.Windows.Forms.Button btnQuitCreateTest;
        public System.Windows.Forms.Label lblCreatePracticeTest;
        public System.Windows.Forms.Panel pnlSalesReport;
        public System.Windows.Forms.Button btnQuitSalesReport;
        public System.Windows.Forms.Label lblSalesReport;
        public System.Windows.Forms.Button btnCreateNewTest;
        public System.Windows.Forms.TextBox txtbNewTestName;
        public System.Windows.Forms.Label lblNewTestName;
        public System.Windows.Forms.Button btnAddItem;
        public System.Windows.Forms.RichTextBox rtxtbSalesReport;
        public CoffeeShopEmployeesDataSet coffeeShopEmployeesDataSet;
        public System.Windows.Forms.BindingSource employeesBindingSource;
        public CoffeeShopEmployeesDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        public CoffeeShopEmployeesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.Button btnSignOutManagerMode;
        public System.Windows.Forms.Button btnDeleteEmployee;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnAddEmployee;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.BindingSource buttonMainPanelBindingSource;
        private System.Windows.Forms.BindingSource buttonMainPanelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private StoredItemsDataSet storedItemsDataSet;
        private System.Windows.Forms.BindingSource buttonMainPanelBindingSource2;
        private StoredItemsDataSetTableAdapters.ButtonMainPanelTableAdapter buttonMainPanelTableAdapter;
        private StoredItemsDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label lblConfirmDeletionWarning;
        private System.Windows.Forms.Button btnCancelDeleteItem;
        private System.Windows.Forms.GroupBox grpbProducts;
        private System.Windows.Forms.GroupBox gpbxUpdateItems;
        public System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnManageHours;
        private System.Windows.Forms.Panel pnlManageHours;
        private CoffeeShopEmployeesDataSet1 coffeeShopEmployeesDataSet1;
        private System.Windows.Forms.BindingSource hoursBindingSource;
        private CoffeeShopEmployeesDataSet1TableAdapters.HoursTableAdapter hoursTableAdapter;
        private CoffeeShopEmployeesDataSet1TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.GroupBox gpbxSelectedImage;
        private System.Windows.Forms.PictureBox pictureBoxSelectedImage;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private CoffeeShopEmployeesDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private System.Windows.Forms.DataGridView employeesDataGridView1;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.TextBox txtbStatus;
        private System.Windows.Forms.TextBox txtbWage;
        private System.Windows.Forms.CheckBox leftHandedCheckBox;
        private System.Windows.Forms.CheckBox colorblindCheckBox;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        public System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        public System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        public System.Windows.Forms.ToolStripButton employeesBindingNavigatorSaveItem;
        public System.Windows.Forms.BindingNavigator employeesBindingNavigator;
        private System.Windows.Forms.Panel pnlMessageKeyboard;
        public System.Windows.Forms.Button btnEnterMessage;
        public System.Windows.Forms.Button btnClearMessageDisplay;
        public System.Windows.Forms.Button btnCancelMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnExclamationPoint;
        public System.Windows.Forms.Button btnComma;
        public System.Windows.Forms.Button btnPeriod;
        public System.Windows.Forms.Button btnForwardSlash;
        public System.Windows.Forms.Button btnBackspace;
        public System.Windows.Forms.Button btnSpaceBar;
        public System.Windows.Forms.Button btnZ;
        public System.Windows.Forms.Button btnB;
        public System.Windows.Forms.Button btnV;
        public System.Windows.Forms.Button btnC;
        public System.Windows.Forms.Button btnX;
        public System.Windows.Forms.Button btnN;
        public System.Windows.Forms.Button btnM;
        public System.Windows.Forms.Button btnA;
        public System.Windows.Forms.Button btnG;
        public System.Windows.Forms.Button btnF;
        public System.Windows.Forms.Button btnD;
        public System.Windows.Forms.Button btnS;
        public System.Windows.Forms.Button btnH;
        public System.Windows.Forms.Button btnL;
        public System.Windows.Forms.Button btnJ;
        public System.Windows.Forms.Button btnK;
        public System.Windows.Forms.Button btnQ;
        public System.Windows.Forms.Button btnT;
        public System.Windows.Forms.Button btnR;
        public System.Windows.Forms.Button btnP;
        public System.Windows.Forms.Button btnE;
        public System.Windows.Forms.Button btnW;
        public System.Windows.Forms.Button btnY;
        public System.Windows.Forms.Button btnO;
        public System.Windows.Forms.Button btnU;
        public System.Windows.Forms.Button btnI;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btn7Keyboard;
        public System.Windows.Forms.Button btnMinus;
        public System.Windows.Forms.Button btnPlus;
        public System.Windows.Forms.Button btn0Keyboard;
        public System.Windows.Forms.Button btn3Keyboard;
        public System.Windows.Forms.Button btn2Keyboard;
        public System.Windows.Forms.Button btn1Keyboard;
        public System.Windows.Forms.Button btn6Keyboard;
        public System.Windows.Forms.Button btn5Keyboard;
        public System.Windows.Forms.Button btn4Keyboard;
        public System.Windows.Forms.Button btn9Keyboard;
        public System.Windows.Forms.Button btn8Keyboard;
        public System.Windows.Forms.TextBox txtbMessageDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10;
        private System.Windows.Forms.Button btnQuitManageHours;
        private System.Windows.Forms.DataGridView hoursDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private StoredItemsDataSet1 storedItemsDataSet1;
        private System.Windows.Forms.BindingSource buttonMainPanelBindingSource3;
        private StoredItemsDataSet1TableAdapters.ButtonMainPanelTableAdapter buttonMainPanelTableAdapter1;
        private StoredItemsDataSet1TableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private StoredItemsDataSet2 storedItemsDataSet2;
        private System.Windows.Forms.BindingSource buttonMainPanelBindingSource4;
        private StoredItemsDataSet2TableAdapters.ButtonMainPanelTableAdapter buttonMainPanelTableAdapter2;
        private StoredItemsDataSet2TableAdapters.TableAdapterManager tableAdapterManager4;
        private System.Windows.Forms.DataGridView buttonMainPanelDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox txtbItemName;
        private System.Windows.Forms.TextBox txtbItemPrice;
        private System.Windows.Forms.TextBox txtbProductType;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlNewItem;
        private System.Windows.Forms.GroupBox gpbxNewItem;
        public System.Windows.Forms.Button btnCancelNewItem;
        public System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.GroupBox gpbxNewItemPic;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnAddNewItemPic;
        private System.Windows.Forms.TextBox txtbNewItemPrice;
        private System.Windows.Forms.TextBox txtbNewItemName;
        private System.Windows.Forms.TextBox txtbNewItemID;
        private System.Windows.Forms.TextBox txtbNewItemFilename;
        private System.Windows.Forms.TextBox txtbNewItemType;
    }
}

