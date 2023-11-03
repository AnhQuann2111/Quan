using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_3
{
    public partial class Form1 : Form
    {
        int rowindex = -1;
        String[] listSP = { "Áo nam", "Áo nữ"};
        String[] listdonvi = { "Áo nam", "Áo nữ" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = listSP;
            cbDonVi.DataSource = listdonvi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double soluong;
            double gia;
            try
            {
                if (!mtxtMaSP.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sản phẩm 10 ký tự");
                }
                if (this.checkMaSP(mtxtMaSP.Text) == false)
                {
                    throw new Exception("Mã sản phẩm đã tồn tại");
                }
                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Tên SP khong được đe trong");
                }
                if (!double.TryParse(txtSoluong.Text, out soluong))
                {
                    throw new Exception("Số lượng khong phải số");
                }
                if (!double.TryParse(txtGia.Text, out gia))
                {
                    throw new Exception("Giá khong phải số");
                }

                string masp = mtxtMaSP.Text;
                string tensp = txtTenSP.Text;
                string loai = cbLoaiSP.Text;
                string giatri = txtGia.Text;
                string donvi = cbDonVi.Text;
                string so = txtSoluong.Text;
                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaSP"].Value = masp;
                dgvDanhSach.Rows[row].Cells["TenSP"].Value = tensp;
                dgvDanhSach.Rows[row].Cells["Gia"].Value = giatri;
                dgvDanhSach.Rows[row].Cells["Loai"].Value = loai;
                dgvDanhSach.Rows[row].Cells["DonVi"].Value = donvi;
                dgvDanhSach.Rows[row].Cells["SoLuong"].Value = so;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông bao");
            }
        }
            public bool checkMaSP(string masp)
            {
                if (dgvDanhSach.Rows.Count == 0)
                {
                    return true;
                }
                for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
                {
                    if (dgvDanhSach.Rows[row].Cells["MaSV"].Value.ToString() == masp)
                    {
                        return false;
                    }
                }
                return true;

            }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {
                mtxtMaSP.Text = dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value.ToString();
                txtGia.Text = dgvDanhSach.Rows[rowindex].Cells["Gia"].Value.ToString();
                txtSoluong.Text = dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value.ToString();
                string tenloai = dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value.ToString();
                int i = 0;
                while (i < listSP.Length && listSP[i] != tenloai)
                {
                    i++;
                }
                {
                    cbLoaiSP.SelectedIndex = i;
                }
                string tendonvi = dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value.ToString();
                int i = 0;
                while (i < listSP.Length && listSP[i] != tenloai)
                {
                    i++;
                }
                {
                    cbLoaiSP.SelectedIndex = i;
                }

            }
        }
    }
    }
}
