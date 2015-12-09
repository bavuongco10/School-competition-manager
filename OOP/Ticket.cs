using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using DevExpress.XtraEditors;

namespace OOP
{
    public partial class Ticket : DevExpress.XtraEditors.XtraForm
    {
        HoatDongUEHEntities _database = new HoatDongUEHEntities();
        private ReportDocument reportDocument = new ReportDocument();
        private int _maHoatDong;
        public Ticket(int maHoatDong)
        {
            InitializeComponent();
            _maHoatDong = maHoatDong;
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            reportDocument.Load(@"C:\Users\Anomyous\Documents\Visual Studio 2013\Projects\OOP\OOP\CrystalReport2.rpt");
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable("DataTable1");
            var query = _database.HoatDongs.Where(o => o.MaHoatDong == _maHoatDong).Select(o => new {o.DonVi.TenDonVi,o.TenHoatDong,o.NgayToChuc,o.GiaVe,o.Picture}).FirstOrDefault();
            dataTable.Columns.Add("TenDonVi");
            dataTable.Columns.Add("TenHoatDong");
            dataTable.Columns.Add("NgayToChuc");
            dataTable.Columns.Add("GiaVe");
            dataTable.Columns.Add("Pic");
            dataTable.Columns.Add("QRCode");

            dataTable.Rows.Add(query.TenDonVi, query.TenHoatDong, query.NgayToChuc, query.GiaVe, query.Picture,
                query.Picture);

            dataSet.Tables.Add(dataTable);
            reportDocument.SetDataSource(dataSet);
            crystalReportViewer1.ReportSource = reportDocument;}
    }
}