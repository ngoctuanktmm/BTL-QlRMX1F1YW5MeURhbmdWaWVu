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
    public partial class frmChangePass : Form
    {
        BUS_Update bus_Update = new BUS_Update();

        public delegate string SendMessage(string Message);
        public SendMessage Sender;
        private string _maDV;

        public frmChangePass()
        {
            InitializeComponent();
            Sender = new SendMessage(getMessage);
        }

        private string getMessage(string Message)
        {
            _maDV = Message;
            return _maDV;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmFormChinh().Visible = true;
            this.Close();
        }

        private void btnThaydoi_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtRePass.Text)
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới");
                txtNewPass.Text = "";
                txtRePass.Text = "";
            }
            else
            {
                int count = bus_Update.Update_Password(_maDV, txtPassword.Text, txtNewPass.Text);

                if (count == 1)
                {
                    MessageBox.Show("Thay đổi Mật khẩu thành công!\nVui lòng đăng nhập lại để Tiếp tục sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công!\nMật khẩu bạn nhập vào không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtNewPass.Text = "";
                    txtRePass.Text = "";
                }
            }
        }
    }
}
