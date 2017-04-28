namespace Pharmacy_System.Report_Files
{
    partial class DateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.DoT = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRcrdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nearExpiryProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nearDepletionDrugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFormToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(20, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(874, 479);
            this.dataGridView1.TabIndex = 227;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(239, 24);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(123, 25);
            this.btnPrint.TabIndex = 228;
            this.btnPrint.Text = "Print Document";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // DoT
            // 
            this.DoT.CustomFormat = "yyyy-MM-dd";
            this.DoT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DoT.Location = new System.Drawing.Point(790, 24);
            this.DoT.Name = "DoT";
            this.DoT.Size = new System.Drawing.Size(101, 25);
            this.DoT.TabIndex = 229;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.viewUsersToolStripMenuItem,
            this.updateRcrdToolStripMenuItem,
            this.exitFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(874, 25);
            this.menuStrip1.TabIndex = 230;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nearExpiryProductsToolStripMenuItem,
            this.nearDepletionDrugsToolStripMenuItem,
            this.exitFormToolStripMenuItem1});
            this.addNewUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.addNewUserToolStripMenuItem.Text = "&Home";
            this.addNewUserToolStripMenuItem.ToolTipText = "Click To Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(151, 21);
            this.viewUsersToolStripMenuItem.Text = "Near &Depletion Drugs";
            this.viewUsersToolStripMenuItem.ToolTipText = "Click To View User";
            this.viewUsersToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // updateRcrdToolStripMenuItem
            // 
            this.updateRcrdToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRcrdToolStripMenuItem.Name = "updateRcrdToolStripMenuItem";
            this.updateRcrdToolStripMenuItem.Size = new System.Drawing.Size(131, 21);
            this.updateRcrdToolStripMenuItem.Text = "Near &Expiry Drugs";
            this.updateRcrdToolStripMenuItem.ToolTipText = "Click To Update User Rcrd";
            this.updateRcrdToolStripMenuItem.Click += new System.EventHandler(this.updateRcrdToolStripMenuItem_Click);
            // 
            // exitFormToolStripMenuItem
            // 
            this.exitFormToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitFormToolStripMenuItem.Name = "exitFormToolStripMenuItem";
            this.exitFormToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.exitFormToolStripMenuItem.Text = "E&xit Form";
            this.exitFormToolStripMenuItem.ToolTipText = "Click To Exit Form";
            this.exitFormToolStripMenuItem.Click += new System.EventHandler(this.exitFormToolStripMenuItem_Click);
            // 
            // nearExpiryProductsToolStripMenuItem
            // 
            this.nearExpiryProductsToolStripMenuItem.Name = "nearExpiryProductsToolStripMenuItem";
            this.nearExpiryProductsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.nearExpiryProductsToolStripMenuItem.Text = "Near &Expiry Drugs";
            this.nearExpiryProductsToolStripMenuItem.Click += new System.EventHandler(this.nearExpiryProductsToolStripMenuItem_Click);
            // 
            // nearDepletionDrugsToolStripMenuItem
            // 
            this.nearDepletionDrugsToolStripMenuItem.Name = "nearDepletionDrugsToolStripMenuItem";
            this.nearDepletionDrugsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.nearDepletionDrugsToolStripMenuItem.Text = "Near &Depletion Drugs";
            this.nearDepletionDrugsToolStripMenuItem.Click += new System.EventHandler(this.nearDepletionDrugsToolStripMenuItem_Click);
            // 
            // exitFormToolStripMenuItem1
            // 
            this.exitFormToolStripMenuItem1.Name = "exitFormToolStripMenuItem1";
            this.exitFormToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.exitFormToolStripMenuItem1.Text = "E&xit Form";
            this.exitFormToolStripMenuItem1.Click += new System.EventHandler(this.exitFormToolStripMenuItem1_Click);
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 599);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DoT);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product State Form";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DateForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker DoT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRcrdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nearExpiryProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nearDepletionDrugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFormToolStripMenuItem1;
    }
}