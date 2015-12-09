using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.WinExplorer;
using ItemCheckEventArgs = DevExpress.XtraEditors.Controls.ItemCheckEventArgs;

namespace OOP
{
    public partial class Filter : XtraUserControl
    {
        private HoatDongUEHEntities database;
        public EventHandler HoatDongDetailInvoke;

        public Filter()
        {
            InitializeComponent();
            InitDatabase();
            InitGrid();
            InitArcordion();
        }

        private void InitArcordion()
        {
            InitNhomHoatDong();
            InitDonVi();
            InitHocKi();
            InitSoLuongThamGia();
        }

        private void InitSoLuongThamGia()
        {
            trackbarSL.lbnMin.Text = (0).ToString();
            trackbarSL.lbnMax.Text = (10000).ToString();
            trackbarSL.trackBar.TickFrequency = 1000;
            trackbarSL.TrackBarValueChange += TrackBarValueChange;
        }

        private void TrackBarValueChange(object sender, EventArgs eventArgs)
        {
            var str = "[SL] >= " + trackbarSL.CurrentValue + " AND [SL] <= " + trackbarSL.MaxValue;
            winExplorerViewFilter.Columns["SL"].FilterInfo = new ColumnFilterInfo(str);
        }

        private int FindMinMax(bool isMin)
        {
            if (isMin)
            {
                var min = database.HoatDongs.Select(o => o.SLSV).Min();
                min = min.HasValue ? min.Value : 0;
                return 0;
            }
            var max = database.HoatDongs.Select(o => o.SLSV).Max();
            max = max.HasValue ? max.Value : 0;
            return 10000;
        }

        private void InitHocKi()
        {
            var hocKis = database.HoatDongs.Select(o => o.HocKi).Distinct().ToList();
            foreach (var hocKi in hocKis)
            {
                if (hocKi.HasValue)
                {
                    var _hocKi = (hocKi.Value ? "Đầu" : "Cuối");
                    radioHocKi.Properties.Items.Add(new RadioGroupItem(_hocKi, _hocKi));
                }
            }
        }

        private void InitDonVi()
        {
            var donVis =
                database.HoatDongs.Select(o => o.DonVi.TenDonVi).Distinct().ToList();
            foreach (var donVi in donVis)
            {
                clbDonVi.Items.Add(donVi);
            }
        }

        private void InitNhomHoatDong()
        {
            var nhomHoatDongs =
                database.HoatDongs.Select(o => o.NhomHoatDong.TenNhomHoatDong).Distinct().ToList();
            foreach (var nhomHoatDong in nhomHoatDongs)
            {
                clbNhomHoatDong.Items.Add(nhomHoatDong);
            }
        }


        private void InitGrid()
        {
            winExplorerViewFilter.Columns.Clear();
            winExplorerViewFilter.Columns.Add(new GridColumn {FieldName = "MaHoatDong"});
            winExplorerViewFilter.Columns.Add(new GridColumn {FieldName = "TenHoatDong"});
            winExplorerViewFilter.Columns.Add(new GridColumn {FieldName = "NgayToChuc"});
            winExplorerViewFilter.Columns.Add(new GridColumn {FieldName = "TenDonVi"});
            winExplorerViewFilter.Columns.Add(new GridColumn {FieldName = "TenNhomHoatDong"});
            winExplorerViewFilter.Columns.Add(new GridColumn {FieldName = "HocKi"});
            winExplorerViewFilter.Columns.Add(new GridColumn {FieldName = "SL"});
            winExplorerViewFilter.Columns.Add(new GridColumn {FieldName = "DiemDanhGia"});
            winExplorerViewFilter.Columns.Add(new GridColumn {FieldName = "GiaVe"});
            winExplorerViewFilter.Columns.Add(new GridColumn {FieldName = "Picture"});

            var item = new RepositoryItemTextEdit();
            winExplorerViewFilter.Columns["TenHoatDong"].ColumnEdit = item;
            gridControl1.RepositoryItems.Add(item);

            winExplorerViewFilter.ColumnSet.TextColumn = winExplorerViewFilter.Columns["TenHoatDong"];
            winExplorerViewFilter.ColumnSet.DescriptionColumn = winExplorerViewFilter.Columns["GiaVe"];
            winExplorerViewFilter.Columns["GiaVe"].DisplayFormat.FormatType = FormatType.Numeric;
            winExplorerViewFilter.Columns["GiaVe"].DisplayFormat.FormatString = "c";
            winExplorerViewFilter.ColumnSet.ExtraLargeImageColumn = winExplorerViewFilter.Columns["Picture"];
            winExplorerViewFilter.ColumnSet.MediumImageColumn = winExplorerViewFilter.Columns["Picture"];
        }

        private void InitDatabase()
        {
            database = new HoatDongUEHEntities();
            var dataSource = database.HoatDongs.Select(o => new
            {
                o.MaHoatDong
                ,
                o.TenHoatDong
                ,
                o.NgayToChuc
                ,
                o.DonVi.TenDonVi
                ,
                o.NhomHoatDong.TenNhomHoatDong
                ,
                HocKi = (o.HocKi.HasValue) ? o.HocKi.Value ? "Đầu" : "Cuối" : string.Empty
                ,
                SL = o.SLSV
                ,
                o.DiemDanhGia
                ,
                o.GiaVe
                ,
                o.Picture
            }).OrderByDescending(o => o.NgayToChuc).ToList();
            gridControl1.DataSource = dataSource;
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {
        }

        private void clbNhomHoatDong_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var str = GetFilterString("TenNhomHoatDong", clbNhomHoatDong.Items);
            winExplorerViewFilter.Columns["TenNhomHoatDong"].FilterInfo = new ColumnFilterInfo(str);
        }

        private string GetFilterString(string columnName, CheckedListBoxItemCollection checkedListBoxItemCollection)
        {
            var str = string.Empty;
            foreach (CheckedListBoxItem item in checkedListBoxItemCollection)
            {
                if (item.CheckState != CheckState.Checked) continue;
                if (str != string.Empty) str = str + "OR";
                str = str + "[" + columnName + "] = '" + item.Value + "' ";
            }
            return str;
        }

        private void clbDonVi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var str = GetFilterString("TenDonVi", clbDonVi.Items);
            winExplorerViewFilter.Columns["TenDonVi"].FilterInfo = new ColumnFilterInfo(str);
        }

        private void radioHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = radioHocKi.Properties.Items[radioHocKi.SelectedIndex].Value.ToString();
            str = "[HocKi] = '" + str + "'";
            winExplorerViewFilter.Columns["HocKi"].FilterInfo = new ColumnFilterInfo(str);
        }

        private void winExplorerViewFilter_ItemClick(object sender, WinExplorerViewItemClickEventArgs e)
        {
            var itemKey = e.ItemInfo.Row.RowKey.ToString();
            itemKey = itemKey.Replace("{", "").Replace("}", "").Split(',')[0].Split('=')[1].Trim();
            var maHoatDong = int.Parse(itemKey);
            var hoatDong = database.HoatDongs.Where(o => o.MaHoatDong == maHoatDong).FirstOrDefault();
            HoatDongDetailInvoke(hoatDong, EventArgs.Empty);
        }

        private void clbNhomHoatDong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}