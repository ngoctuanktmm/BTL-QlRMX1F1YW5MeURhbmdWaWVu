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
    public partial class frmDanhSach : Form
    {
        BUS_ThongTin bus_ThongTin = new BUS_ThongTin();
        public frmDanhSach()
        {
            InitializeComponent();
        }

        private void frmDanhSach_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = bus_ThongTin.Get_DanhSach();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView.CurrentRow.Selected = true;
                loadToTextBox();
            }
            catch { }
        }

        private void loadToTextBox()
        {
            txtMaDV.DataBindings.Clear();
            txtMaDV.DataBindings.Add("Text", dataGridView.DataSource, "MADV");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", dataGridView.DataSource, "HOTEN");
            txtNgaysinh.DataBindings.Clear();
            txtNgaysinh.DataBindings.Add("Text", dataGridView.DataSource, "NGAYSINH");
            txtGioitinh.DataBindings.Clear();
            txtGioitinh.DataBindings.Add("Text", dataGridView.DataSource, "GIOITINH");
            txtQuequan.DataBindings.Clear();
            txtQuequan.DataBindings.Add("Text", dataGridView.DataSource, "QUEQUAN");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dataGridView.DataSource, "SDT");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGridView.DataSource, "EMAIL");
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = bus_ThongTin.ClearDataGridView();
            if (txtSearch.Text == "")
                MessageBox.Show("Vui lòng nhập thông tin Họ tên hoặc Mã ĐV cần Tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int count = bus_ThongTin.Search_DanhSach(txtSearch.Text).Rows.Count;
                if (count >= 1)
                {
                    dataGridView.DataSource = bus_ThongTin.Search_DanhSach(txtSearch.Text);
                    txtSearch.Text = "";
                }
                else
                    MessageBox.Show("Không có Đảng viên nào có Họ tên hoặc Mã ĐV như vừa nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            
            if (txtSearch.Text == "")
            {
                ShowChiTiet(txtMaDV.Text);
                return;
            }
                
            else
            {
                dataGridView.DataSource = bus_ThongTin.ClearDataGridView();
                int count = bus_ThongTin.Search_DanhSach(txtSearch.Text).Rows.Count;
                if (count == 1)
                {
                    dataGridView.DataSource = bus_ThongTin.Search_DanhSach(txtSearch.Text);
                    ShowChiTiet(txtMaDV.Text);
                    txtSearch.Text = "";
                }
                else if (count >= 2)
                {
                    dataGridView.DataSource = bus_ThongTin.Search_DanhSach(txtSearch.Text);
                    txtSearch.Text = "";
                    MessageBox.Show("Họ tên vừa nhập cần xem Chi tiết có nhiều hơn 1 Đảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Không có Đảng viên nào có Họ tên hoặc Mã ĐV như vừa nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ShowChiTiet(string str)
        {
            frmChiTiet chiTiet = new frmChiTiet();
            chiTiet.Sender(str);
            chiTiet.Show();
        }
    }
}
