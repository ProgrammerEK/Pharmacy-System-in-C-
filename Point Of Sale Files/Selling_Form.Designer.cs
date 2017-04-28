namespace Pharmacy_System.Point_Of_Sale_Files
{
    partial class Selling_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtQntyP = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQntyS = new System.Windows.Forms.TextBox();
            this.txtQntyR = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDosage = new MetroFramework.Controls.MetroTextBox();
            this.txtStrength = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DoE = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.DoT = new System.Windows.Forms.DateTimePicker();
            this.txtAlert = new System.Windows.Forms.TextBox();
            this.txtSTotal = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRank = new System.Windows.Forms.Label();
            this.pnInscription = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dpt = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.pnInscription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpt)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQntyP
            // 
            this.txtQntyP.Location = new System.Drawing.Point(565, 230);
            this.txtQntyP.Name = "txtQntyP";
            this.txtQntyP.Size = new System.Drawing.Size(174, 25);
            this.txtQntyP.TabIndex = 9;
            this.txtQntyP.Leave += new System.EventHandler(this.txtQntyP_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(616, 141);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(123, 25);
            this.txtPrice.TabIndex = 7;
            // 
            // txtQntyS
            // 
            this.txtQntyS.Enabled = false;
            this.txtQntyS.Location = new System.Drawing.Point(565, 108);
            this.txtQntyS.Name = "txtQntyS";
            this.txtQntyS.Size = new System.Drawing.Size(174, 25);
            this.txtQntyS.TabIndex = 6;
            // 
            // txtQntyR
            // 
            this.txtQntyR.Enabled = false;
            this.txtQntyR.Location = new System.Drawing.Point(565, 75);
            this.txtQntyR.Name = "txtQntyR";
            this.txtQntyR.Size = new System.Drawing.Size(174, 25);
            this.txtQntyR.TabIndex = 5;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(433, 232);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(120, 17);
            this.Label9.TabIndex = 164;
            this.Label9.Text = "Quantity Purchased";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 159;
            this.label6.Text = "Qnty Remaining";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(557, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 17);
            this.label18.TabIndex = 163;
            this.label18.Text = "Ksh";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(433, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 17);
            this.label17.TabIndex = 162;
            this.label17.Text = "Price Per Item";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(433, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 161;
            this.label16.Text = "Selling Qnty";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(382, 617);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(66, 17);
            this.Label12.TabIndex = 156;
            this.Label12.Text = "Total Cost";
            // 
            // btnSale
            // 
            this.btnSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSale.Image")));
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(600, 611);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(89, 27);
            this.btnSale.TabIndex = 155;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(541, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 31);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(428, 317);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 31);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnList
            // 
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(336, 317);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(61, 31);
            this.btnList.TabIndex = 10;
            this.btnList.Text = "Add ";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtID
            // 
            this.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(261, 151);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(154, 23);
            this.txtID.TabIndex = 2;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(141, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 225;
            this.label10.Text = "Product ID";
            // 
            // txtDosage
            // 
            this.txtDosage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDosage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtDosage.CustomButton.Image = null;
            this.txtDosage.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtDosage.CustomButton.Name = "";
            this.txtDosage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDosage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDosage.CustomButton.TabIndex = 1;
            this.txtDosage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDosage.CustomButton.UseSelectable = true;
            this.txtDosage.CustomButton.Visible = false;
            this.txtDosage.Lines = new string[0];
            this.txtDosage.Location = new System.Drawing.Point(261, 193);
            this.txtDosage.MaxLength = 32767;
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.PasswordChar = '\0';
            this.txtDosage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDosage.SelectedText = "";
            this.txtDosage.SelectionLength = 0;
            this.txtDosage.SelectionStart = 0;
            this.txtDosage.ShortcutsEnabled = true;
            this.txtDosage.Size = new System.Drawing.Size(154, 23);
            this.txtDosage.TabIndex = 3;
            this.txtDosage.UseSelectable = true;
            this.txtDosage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDosage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDosage.Leave += new System.EventHandler(this.txtDosage_Leave);
            // 
            // txtStrength
            // 
            this.txtStrength.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStrength.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtStrength.CustomButton.Image = null;
            this.txtStrength.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtStrength.CustomButton.Name = "";
            this.txtStrength.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStrength.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStrength.CustomButton.TabIndex = 1;
            this.txtStrength.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStrength.CustomButton.UseSelectable = true;
            this.txtStrength.CustomButton.Visible = false;
            this.txtStrength.Lines = new string[0];
            this.txtStrength.Location = new System.Drawing.Point(296, 232);
            this.txtStrength.MaxLength = 32767;
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.PasswordChar = '\0';
            this.txtStrength.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStrength.SelectedText = "";
            this.txtStrength.SelectionLength = 0;
            this.txtStrength.SelectionStart = 0;
            this.txtStrength.ShortcutsEnabled = true;
            this.txtStrength.Size = new System.Drawing.Size(119, 23);
            this.txtStrength.TabIndex = 4;
            this.txtStrength.UseSelectable = true;
            this.txtStrength.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStrength.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtStrength.Leave += new System.EventHandler(this.txtStrength_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 224;
            this.label8.Text = "Concentration/Strength";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 223;
            this.label1.Text = "Dosage Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 222;
            this.label2.Text = "Product Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 221;
            this.label5.Text = "Product Name";
            // 
            // DoE
            // 
            this.DoE.CustomFormat = "yyyy-MM-dd";
            this.DoE.Enabled = false;
            this.DoE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DoE.Location = new System.Drawing.Point(565, 183);
            this.DoE.MinimumSize = new System.Drawing.Size(0, 29);
            this.DoE.Name = "DoE";
            this.DoE.Size = new System.Drawing.Size(174, 29);
            this.DoE.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 227;
            this.label3.Text = "Expiry Date";
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(261, 115);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(154, 23);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // DoT
            // 
            this.DoT.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DoT.CustomFormat = "yyyy-MM-dd";
            this.DoT.Enabled = false;
            this.DoT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DoT.Location = new System.Drawing.Point(746, 29);
            this.DoT.Name = "DoT";
            this.DoT.Size = new System.Drawing.Size(88, 25);
            this.DoT.TabIndex = 230;
            // 
            // txtAlert
            // 
            this.txtAlert.Location = new System.Drawing.Point(773, 75);
            this.txtAlert.Name = "txtAlert";
            this.txtAlert.Size = new System.Drawing.Size(81, 25);
            this.txtAlert.TabIndex = 231;
            // 
            // txtSTotal
            // 
            this.txtSTotal.Location = new System.Drawing.Point(773, 106);
            this.txtSTotal.Name = "txtSTotal";
            this.txtSTotal.Size = new System.Drawing.Size(81, 25);
            this.txtSTotal.TabIndex = 232;
            // 
            // cboCategory
            // 
            this.cboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "<--Category-->"});
            this.cboCategory.Location = new System.Drawing.Point(261, 75);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(154, 25);
            this.cboCategory.TabIndex = 0;
            this.cboCategory.Leave += new System.EventHandler(this.cboCategory_Leave_1);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(773, 136);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(81, 25);
            this.txt.TabIndex = 233;
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Enabled = false;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(464, 615);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(110, 23);
            this.txtTotal.TabIndex = 234;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Location = new System.Drawing.Point(24, 355);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridView1.Size = new System.Drawing.Size(895, 249);
            this.DataGridView1.TabIndex = 235;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(496, 29);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(15, 17);
            this.lblRank.TabIndex = 236;
            this.lblRank.Text = "0";
            // 
            // pnInscription
            // 
            this.pnInscription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnInscription.Controls.Add(this.button2);
            this.pnInscription.Controls.Add(this.txtFirst);
            this.pnInscription.Controls.Add(this.label4);
            this.pnInscription.Controls.Add(this.dpt);
            this.pnInscription.Location = new System.Drawing.Point(141, 307);
            this.pnInscription.Name = "pnInscription";
            this.pnInscription.Size = new System.Drawing.Size(728, 286);
            this.pnInscription.TabIndex = 238;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(570, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 242;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(163, 21);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(283, 25);
            this.txtFirst.TabIndex = 241;
            this.txtFirst.TextChanged += new System.EventHandler(this.txtFirst_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 240;
            this.label4.Text = "Enter Inscription";
            // 
            // dpt
            // 
            this.dpt.AllowUserToAddRows = false;
            this.dpt.AllowUserToDeleteRows = false;
            this.dpt.AllowUserToResizeColumns = false;
            this.dpt.AllowUserToResizeRows = false;
            this.dpt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dpt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dpt.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dpt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dpt.EnableHeadersVisualStyles = false;
            this.dpt.GridColor = System.Drawing.SystemColors.Highlight;
            this.dpt.Location = new System.Drawing.Point(16, 61);
            this.dpt.Margin = new System.Windows.Forms.Padding(4);
            this.dpt.Name = "dpt";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dpt.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dpt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dpt.Size = new System.Drawing.Size(697, 222);
            this.dpt.TabIndex = 239;
            // 
            // btnView
            // 
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(390, 267);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(112, 30);
            this.btnView.TabIndex = 239;
            this.btnView.Text = "Search Drug";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Selling_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 660);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtSTotal);
            this.Controls.Add(this.txtAlert);
            this.Controls.Add(this.DoT);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoE);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQntyP);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQntyS);
            this.Controls.Add(this.txtQntyR);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.pnInscription);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Selling_Form";
            this.Resizable = false;
            this.Text = "Pharmacy System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Selling_Form_FormClosing);
            this.Load += new System.EventHandler(this.Selling_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.pnInscription.ResumeLayout(false);
            this.pnInscription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtQntyP;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQntyS;
        private System.Windows.Forms.TextBox txtQntyR;
        internal System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Button btnSale;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnList;
        private MetroFramework.Controls.MetroTextBox txtID;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTextBox txtDosage;
        private MetroFramework.Controls.MetroTextBox txtStrength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroDateTime DoE;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtName;
        private System.Windows.Forms.DateTimePicker DoT;
        private System.Windows.Forms.TextBox txtAlert;
        private System.Windows.Forms.TextBox txtSTotal;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txt;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Panel pnInscription;
        internal System.Windows.Forms.DataGridView dpt;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button2;
    }
}