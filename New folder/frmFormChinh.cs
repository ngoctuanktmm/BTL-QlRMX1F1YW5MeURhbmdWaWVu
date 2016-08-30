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
    public partial class frmFormChinh : Form
    {
        BUS_Login bus_Login = new BUS_Login();

        public delegate string SendMessage(string Message);
        public SendMessage Sender;
        private string _maDV;

        public frmFormChinh()
        {
            InitializeComponent();
            Sender = new SendMessage(getMessage);
        }

        private string getMessage(string Message)
        {
            _maDV = Message;
            return _maDV;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn muốn Thoát chương trình này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                Application.Exit();
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePass changePass = new frmChangePass();
            changePass.Sender(_maDV);
            changePass.Show();
            this.Visible = false;
        }

        private void xuấtDanhSáchĐảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSach danhSach = new frmDanhSach();
            danhSach.Show();
        }

        private void frmFormChinh_Load(object sender, EventArgs e)
        {
            if (_maDV != null)
                lblUser.Text = _maDV.ToUpper();
            label.ForeColor = Color.Red;
            lblUser.ForeColor = Color.Red;
        }

        private void frmFormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýĐảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSach frmDSach = new frmDanhSach();
            frmDSach.ShowDialog();
        }

        private void taoAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bus_Login.createAccount("DV002"))
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Không thành công");
        }

        private void thêmMớiĐảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemMoi frmThemMoi = new frmThemMoi();
            frmThemMoi.Show();
        }

        private void cậpNhậtDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
