namespace Pharmacy_System.Report_Files
{
    partial class Report_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wholeProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specificDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betweenDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpDates = new MetroFramework.Controls.MetroPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.DoT2 = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGet2 = new MetroFramework.Controls.MetroButton();
            this.DoF = new MetroFramework.Controls.MetroDateTime();
            this.DoT = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dpt = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRank = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mpDates.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.closeFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(849, 25);
            this.menuStrip1.TabIndex = 220;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.addProductToolStripMenuItem,
            this.wholeProductsToolStripMenuItem});
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.homeToolStripMenuItem.Text = "&Products";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.productsToolStripMenuItem.Text = "Products On S&helve";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addProductToolStripMenuItem.Text = "Products In &Store";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // wholeProductsToolStripMenuItem
            // 
            this.wholeProductsToolStripMenuItem.Name = "wholeProductsToolStripMenuItem";
            this.wholeProductsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.wholeProductsToolStripMenuItem.Text = "&Whole Products";
            this.wholeProductsToolStripMenuItem.Click += new System.EventHandler(this.wholeProductsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todayToolStripMenuItem,
            this.specificDateToolStripMenuItem,
            this.betweenDatesToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.salesToolStripMenuItem.Text = "&Sales";
            // 
            // todayToolStripMenuItem
            // 
            this.todayToolStripMenuItem.Name = "todayToolStripMenuItem";
            this.todayToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.todayToolStripMenuItem.Text = "&Today";
            this.todayToolStripMenuItem.Click += new System.EventHandler(this.todayToolStripMenuItem_Click);
            // 
            // specificDateToolStripMenuItem
            // 
            this.specificDateToolStripMenuItem.Name = "specificDateToolStripMenuItem";
            this.specificDateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.specificDateToolStripMenuItem.Text = "&Specific Date";
            this.specificDateToolStripMenuItem.Click += new System.EventHandler(this.specificDateToolStripMenuItem_Click);
            // 
            // betweenDatesToolStripMenuItem
            // 
            this.betweenDatesToolStripMenuItem.Name = "betweenDatesToolStripMenuItem";
            this.betweenDatesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.betweenDatesToolStripMenuItem.Text = "&Between Dates";
            this.betweenDatesToolStripMenuItem.Click += new System.EventHandler(this.betweenDatesToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.updateToolStripMenuItem.Text = "&Print";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.closeFormToolStripMenuItem.Text = "E&xit";
            this.closeFormToolStripMenuItem.ToolTipText = "Click To Close This Form";
            this.closeFormToolStripMenuItem.Click += new System.EventHandler(this.closeFormToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 512);
            this.dataGridView1.TabIndex = 226;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            // 
            // mpDates
            // 
            this.mpDates.BackColor = System.Drawing.SystemColors.Highlight;
            this.mpDates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mpDates.Controls.Add(this.groupBox2);
            this.mpDates.Controls.Add(this.groupBox1);
            this.mpDates.HorizontalScrollbarBarColor = true;
            this.mpDates.HorizontalScrollbarHighlightOnWheel = false;
            this.mpDates.HorizontalScrollbarSize = 10;
            this.mpDates.Location = new System.Drawing.Point(271, 180);
            this.mpDates.Name = "mpDates";
            this.mpDates.Size = new System.Drawing.Size(347, 257);
            this.mpDates.TabIndex = 227;
            this.mpDates.VerticalScrollbarBarColor = true;
            this.mpDates.VerticalScrollbarHighlightOnWheel = false;
            this.mpDates.VerticalScrollbarSize = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroButton2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DoT2);
            this.groupBox2.Location = new System.Drawing.Point(54, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 86);
            this.groupBox2.TabIndex = 233;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Specific Dates";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(159, 37);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(66, 23);
            this.metroButton2.TabIndex = 230;
            this.metroButton2.Text = "Get ";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 229;
            this.label4.Text = "Date:";
            // 
            // DoT2
            // 
            this.DoT2.CustomFormat = "yyyy-MM-dd";
            this.DoT2.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.DoT2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DoT2.Location = new System.Drawing.Point(54, 37);
            this.DoT2.MinimumSize = new System.Drawing.Size(0, 25);
            this.DoT2.Name = "DoT2";
            this.DoT2.Size = new System.Drawing.Size(94, 25);
            this.DoT2.TabIndex = 227;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGet2);
            this.groupBox1.Controls.Add(this.DoF);
            this.groupBox1.Controls.Add(this.DoT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(54, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 100);
            this.groupBox1.TabIndex = 232;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Between Dates";
            // 
            // btnGet2
            // 
            this.btnGet2.Location = new System.Drawing.Point(153, 68);
            this.btnGet2.Name = "btnGet2";
            this.btnGet2.Size = new System.Drawing.Size(66, 23);
            this.btnGet2.TabIndex = 233;
            this.btnGet2.Text = "Get";
            this.btnGet2.UseSelectable = true;
            this.btnGet2.Click += new System.EventHandler(this.btnGet2_Click);
            // 
            // DoF
            // 
            this.DoF.CustomFormat = "yyyy-MM-dd";
            this.DoF.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.DoF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DoF.Location = new System.Drawing.Point(48, 27);
            this.DoF.MinimumSize = new System.Drawing.Size(4, 25);
            this.DoF.Name = "DoF";
            this.DoF.Size = new System.Drawing.Size(100, 25);
            this.DoF.TabIndex = 232;
            // 
            // DoT
            // 
            this.DoT.CustomFormat = "yyyy-MM-dd";
            this.DoT.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.DoT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DoT.Location = new System.Drawing.Point(48, 68);
            this.DoT.MinimumSize = new System.Drawing.Size(4, 25);
            this.DoT.Name = "DoT";
            this.DoT.Size = new System.Drawing.Size(100, 25);
            this.DoT.TabIndex = 231;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 228;
            this.label3.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 229;
            this.label5.Text = "To:";
            // 
            // dpt
            // 
            this.dpt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dpt.CustomFormat = "yyyy-MM-dd";
            this.dpt.Enabled = false;
            this.dpt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpt.Location = new System.Drawing.Point(729, 32);
            this.dpt.Name = "dpt";
            this.dpt.Size = new System.Drawing.Size(78, 25);
            this.dpt.TabIndex = 229;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(809, 33);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 17);
            this.lblTime.TabIndex = 228;
            this.lblTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(357, 32);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(15, 17);
            this.lblRank.TabIndex = 230;
            this.lblRank.Text = "0";
            // 
            // Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 617);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.dpt);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.mpDates);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Report_Form";
            this.Text = "Products Reports Printing Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Report_Form_FormClosing);
            this.Load += new System.EventHandler(this.Report_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mpDates.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wholeProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specificDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betweenDatesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroPanel mpDates;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroDateTime DoT2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroDateTime DoF;
        private MetroFramework.Controls.MetroDateTime DoT;
        private MetroFramework.Controls.MetroButton btnGet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DateTimePicker dpt;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRank;
    }
}