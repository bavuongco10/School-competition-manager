using System.Drawing;
using DevExpress.XtraEditors;

namespace OOP
{
    public partial class CustomTileGroup : TileControl
    {
        public CustomTileGroup()
        {
            InitializeComponent();
        }

        protected override TileControlViewInfo CreateViewInfo()
        {
            return new TileControlViewInfoAce(this);
        }

        public void OnDropDownHeightChanged()
        {
        }

        public void OnDropDownOptionsChanged()
        {
        }
    }

    public class TileControlViewInfoAce : TileControlViewInfo
    {
        private const int TileHeight = 60;
        private const int TileWidth = 300;

        public TileControlViewInfoAce(ITileControl control)
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