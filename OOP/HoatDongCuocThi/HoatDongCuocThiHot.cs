﻿using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OOP
{
    public partial class HoatDongCuocThiHot : XtraUserControl
    {
        public HoatDongCuocThiHot()
        {
            InitializeComponent(); // This line of code is generated by Data Source Configuration Wizard

            // This line of code is generated by Data Source Configuration Wizard
            pLinqServerModeSource1.Source = new OOP.HoatDongUEHEntities().HoatDongCuocThiHots;
        }
        private void tileView1_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            

        }
    }
}