using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace BTL_QuanLyDangVien
{
    public partial class frmLogin : Form
    {
        BUS_Login bus_Login = new BUS_Login();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int count = bus_Login.getLogin(txtUser.Text, txtPasswd.Text);

            if (count == 1)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmFormChinh frmFormChinh = new frmFormChinh();
                frmFormChinh.Sender(txtUser.Text);
                frmFormChinh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!\nSai thông Username hoặc Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasswd.Text = "";
            }
        }
    }
}
