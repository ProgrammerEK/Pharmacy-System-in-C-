namespace Pharmacy_System.Other_Files
{
    partial class AddToShop_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboDosage = new MetroFramework.Controls.MetroComboBox();
            this.cboCategory = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboStrength = new MetroFramework.Controls.MetroComboBox();
            this.txtQntyA = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.DoT = new MetroFramework.Controls.MetroDateTime();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(395, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantity Needed:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(211, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Category:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(310, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 26);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Location = new System.Drawing.Point(10, 253);
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
            this.DataGridView1.Size = new System.Drawing.Size(804, 343);
            this.DataGridView1.TabIndex = 86;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(643, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 25);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(704, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 25);
            this.textBox2.TabIndex = 10;
            // 
            // cboDosage
            // 
            this.cboDosage.FormattingEnabled = true;
            this.cboDosage.ItemHeight = 23;
            this.cboDosage.Items.AddRange(new object[] {
            "<--Select Option-->"});
            this.cboDosage.Location = new System.Drawing.Point(606, 82);
            this.cboDosage.Name = "cboDosage";
            this.cboDosage.Size = new System.Drawing.Size(143, 29);
            this.cboDosage.TabIndex = 3;
            this.cboDosage.UseSelectable = true;
            this.cboDosage.Leave += new System.EventHandler(this.cboDosage_Leave);
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.ItemHeight = 23;
            this.cboCategory.Items.AddRange(new object[] {
            "<--Select Option-->"});
            this.cboCategory.Location = new System.Drawing.Point(13, 84);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(163, 29);
            this.cboCategory.TabIndex = 0;
            this.cboCategory.UseSelectable = true;
            this.cboCategory.Leave += new System.EventHandler(this.cboCategory_Leave_1);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(606, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 91;
            this.label4.Text = "Dosage Form:";
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(205, 84);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(163, 23);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave_1);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 94;
            this.label5.Text = "Concentration/Strength:";
            // 
            // cboStrength
            // 
            this.cboStrength.FormattingEnabled = true;
            this.cboStrength.ItemHeight = 23;
            this.cboStrength.Items.AddRange(new object[] {
            "<--Select Option-->"});
            this.cboStrength.Location = new System.Drawing.Point(10, 153);
            this.cboStrength.Name = "cboStrength";
            this.cboStrength.Size = new System.Drawing.Size(166, 29);
            this.cboStrength.TabIndex = 4;
            this.cboStrength.UseSelectable = true;
            this.cboStrength.Leave += new System.EventHandler(this.cboStrength_Leave);
            // 
            // txtQntyA
            // 
            // 
            // 
            // 
            this.txtQntyA.CustomButton.Image = null;
            this.txtQntyA.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtQntyA.CustomButton.Name = "";
            this.txtQntyA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQntyA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQntyA.CustomButton.TabIndex = 1;
            this.txtQntyA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQntyA.CustomButton.UseSelectable = true;
            this.txtQntyA.CustomButton.Visible = false;
            this.txtQntyA.Lines = new string[0];
            this.txtQntyA.Location = new System.Drawing.Point(202, 153);
            this.txtQntyA.MaxLength = 32767;
            this.txtQntyA.Name = "txtQntyA";
            this.txtQntyA.PasswordChar = '\0';
            this.txtQntyA.ReadOnly = true;
            this.txtQntyA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQntyA.SelectedText = "";
            this.txtQntyA.SelectionLength = 0;
            this.txtQntyA.SelectionStart = 0;
            this.txtQntyA.ShortcutsEnabled = true;
            this.txtQntyA.Size = new System.Drawing.Size(166, 23);
            this.txtQntyA.TabIndex = 11;
            this.txtQntyA.UseSelectable = true;
            this.txtQntyA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQntyA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(199, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 95;
            this.label6.Text = "Quantity Available";
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(394, 153);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(154, 23);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // DoT
            // 
            this.DoT.CustomFormat = "yyyy-MM-dd";
            this.DoT.Enabled = false;
            this.DoT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DoT.Location = new System.Drawing.Point(606, 147);
            this.DoT.MinimumSize = new System.Drawing.Size(0, 29);
            this.DoT.Name = "DoT";
            this.DoT.Size = new System.Drawing.Size(147, 29);
            this.DoT.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(389, 83);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(163, 23);
            this.txtID.TabIndex = 2;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(395, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 99;
            this.label7.Text = "Product ID";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(342, 28);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(15, 17);
            this.lblRank.TabIndex = 100;
            this.lblRank.Text = "0";
            // 
            // AddToShop_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 606);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DoT);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtQntyA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboStrength);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboDosage);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddToShop_Form";
            this.Resizable = false;
            this.Text = "Shop Shelve Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddToShop_Form_FormClosing);
            this.Load += new System.EventHandler(this.AddToShop_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroComboBox cboDosage;
        private MetroFramework.Controls.MetroComboBox cboCategory;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtName;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cboStrength;
        private MetroFramework.Controls.MetroTextBox txtQntyA;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroDateTime DoT;
        private MetroFramework.Controls.MetroTextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRank;
    }
}