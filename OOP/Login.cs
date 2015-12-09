using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OOP
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public HoatDongUEHEntities Database;

        public Login()
        {
            InitializeComponent();
            Database = new HoatDongUEHEntities();
            txtUserName.Text = "31121021254";
            txtPassword.Text = "123";}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckLogin())
            {
                MainForm mainForm = new MainForm(txtUserName.Text);
                mainForm.Show();this.Hide();
            }
        }
        private bool CheckLogin()
        {
            try
            {
                var user = Database.DangNhaps.Where(
                    o => o.MaSinhVien.Equals(txtUserName.Text) && o.Password.Equals(txtPassword.Text)).FirstOrDefault();
                if (user != null)
                {
                     return true;
                }
                else
                {
                    MessageBox.Show("Alert", "Wrong password or username!");}
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return false;}
    }
}