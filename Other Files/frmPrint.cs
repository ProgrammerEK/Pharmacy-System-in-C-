using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pharmacy_System.Other_Files
{
    public partial class frmPrint : Form
    {
        List<ReceptForm> _list;
        string _total, _cash, _change, _date;
        public frmPrint(List<ReceptForm> dataSource, string total, string cash, string change, string date)
        {
            InitializeComponent();
            _list = dataSource;
            _total = total;
            _cash = cash;
            _change = change;
            _date = date;
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            ReceiptBindingSource.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
new Microsoft.Reporting.WinForms.ReportParameter("pTotal",_total),
new Microsoft.Reporting.WinForms.ReportParameter("pCash",_cash),
new Microsoft.Reporting.WinForms.ReportParameter("pChange",_change),
new Microsoft.Reporting.WinForms.ReportParameter("pDate",_date),
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
