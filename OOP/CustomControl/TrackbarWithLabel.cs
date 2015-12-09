using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OOP
{
    public partial class TrackbarWithLabel : XtraUserControl
    {
        public EventHandler TrackBarValueChange;

        public TrackbarWithLabel()
        {
            InitializeComponent();
        }

        public int MinValue
        {
            get { return int.Parse(lbnMin.Text); }
        }

        public int MaxValue
        {
            get { return int.Parse(lbnMax.Text); }
        }

        public int CurrentValue
        {
            get { return int.Parse(lbnCurrentValue.Text); }
        }


        private void trackBar_Scroll(object sender, EventArgs e)
        {
            lbnCurrentValue.Text = trackBar.Value.ToString();
            TrackBarValueChange(sender, e);
        }

        private void lbnMin_Click(object sender, EventArgs e)
        {
        }

        private void lbnMin_TextChanged(object sender, EventArgs e)
        {
            var min = sender as Label;
            trackBar.Minimum = int.Parse(min.Text);
        }

        private void lbnMax_TextChanged(object sender, EventArgs e)
        {
            var max = sender as Label;
            trackBar.Maximum = int.Parse(max.Text);
        }
    }
}