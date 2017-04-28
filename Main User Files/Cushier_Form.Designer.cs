namespace Pharmacy_System.Main_User_Files
{
    partial class Cushier_Form
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRank = new System.Windows.Forms.Label();
            this.dpt = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnAddP = new System.Windows.Forms.Button();
            this.btnViewP = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnViewS = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Information Center";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.viewProductsToolStripMenuItem,
            this.viewSalesToolStripMenuItem,
            this.closeFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(23, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(500, 25);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logOutToolStripMenuItem});
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.homeToolStripMenuItem.Text = "&Home";
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.saleToolStripMenuItem.Text = "&Sale";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem2.Text = "Add &Products";
            this.toolStripMenuItem2.ToolTipText = "Click To Add New Product In The Store";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.logOutToolStripMenuItem.Text = "&Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
            this.viewProductsToolStripMenuItem.Text = "Vie&w Products";
            this.viewProductsToolStripMenuItem.ToolTipText = "Click To View Products In The Store";
            this.viewProductsToolStripMenuItem.Click += new System.EventHandler(this.viewProductsToolStripMenuItem_Click);
            // 
            // viewSalesToolStripMenuItem
            // 
            this.viewSalesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            this.viewSalesToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.viewSalesToolStripMenuItem.Text = "View S&ales";
            this.viewSalesToolStripMenuItem.ToolTipText = "Click To View Sale Records";
            this.viewSalesToolStripMenuItem.Click += new System.EventHandler(this.viewSalesToolStripMenuItem_Click);
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.closeFormToolStripMenuItem.Text = "&Log Out";
            this.closeFormToolStripMenuItem.ToolTipText = "Click To Log Out";
            this.closeFormToolStripMenuItem.Click += new System.EventHandler(this.closeFormToolStripMenuItem_Click);
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(254, 29);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(15, 17);
            this.lblRank.TabIndex = 41;
            this.lblRank.Text = "0";
            // 
            // dpt
            // 
            this.dpt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dpt.CustomFormat = "yyyy-MM-dd";
            this.dpt.Enabled = false;
            this.dpt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpt.Location = new System.Drawing.Point(384, 29);
            this.dpt.Name = "dpt";
            this.dpt.Size = new System.Drawing.Size(88, 25);
            this.dpt.TabIndex = 231;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(476, 30);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 17);
            this.lblTime.TabIndex = 230;
            this.lblTime.Text = "Time";
            // 
            // btnAddP
            // 
            this.btnAddP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddP.Location = new System.Drawing.Point(38, 214);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(102, 34);
            this.btnAddP.TabIndex = 232;
            this.btnAddP.Text = "Add Products";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // btnViewP
            // 
            this.btnViewP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewP.Location = new System.Drawing.Point(268, 214);
            this.btnViewP.Name = "btnViewP";
            this.btnViewP.Size = new System.Drawing.Size(102, 34);
            this.btnViewP.TabIndex = 233;
            this.btnViewP.Text = "View Products";
            this.btnViewP.UseVisualStyleBackColor = true;
            this.btnViewP.Click += new System.EventHandler(this.btnViewP_Click);
            // 
            // btnSale
            // 
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSale.Location = new System.Drawing.Point(38, 131);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(102, 34);
            this.btnSale.TabIndex = 234;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnViewS
            // 
            this.btnViewS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewS.Location = new System.Drawing.Point(268, 131);
            this.btnViewS.Name = "btnViewS";
            this.btnViewS.Size = new System.Drawing.Size(102, 34);
            this.btnViewS.TabIndex = 235;
            this.btnViewS.Text = "View Sales";
            this.btnViewS.UseVisualStyleBackColor = true;
            this.btnViewS.Click += new System.EventHandler(this.btnViewS_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(370, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 34);
            this.btnExit.TabIndex = 236;
            this.btnExit.Text = "Log Out";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cushier_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 364);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewS);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnViewP);
            this.Controls.Add(this.btnAddP);
            this.Controls.Add(this.dpt);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Cushier_Form";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.Text = "Cashier\'s Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cushier_Form_FormClosing);
            this.Load += new System.EventHandler(this.Cushier_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.DateTimePicker dpt;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Button btnViewP;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnViewS;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
    }
}