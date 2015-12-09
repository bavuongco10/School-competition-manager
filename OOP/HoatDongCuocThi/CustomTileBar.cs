using System.Drawing;
using DevExpress.XtraEditors;

namespace OOP
{
    public partial class CustomTileBar : TileControl
    {
        public CustomTileBar()
        {
            InitializeComponent();
        }

        protected override TileControlViewInfo CreateViewInfo()
        {
            return new TileControlViewInfoAce1(this);
        }
    }

    public class TileControlViewInfoAce1 : TileControlViewInfo
    {
        private const int TileHeight = 60;
        private readonly int TileWidth = 300;

        public TileControlViewInfoAce1(ITileControl control)
            : base(control)
        {
        }

        protected override int GetItemHeight()
        {
            return TileHeight;
        }

        public override Size GetItemSize(TileItemViewInfo itemInfo)
        {
            return new Size(TileWidth, TileHeight);
        }
    }
}