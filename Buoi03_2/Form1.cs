using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_2
{
    public partial class Form1 : Form
    {
        private string stt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (jhg.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên sinh viên không để rỗng");

                }
                //Lấy thông tin
                string hoten = txtHoTen.Text;
                string masv = txtMaSV.Text;
                string ngaysinh = mtxtNgaySinh.Text;
                string gioitinh = (rbNam.Checked) ? "Nam" : "Nữ";
                string sothich = null;
                if (chbDuLich.Checked)
                {
                }
                sothich += "Du Lich";
                if (chbTheThao.Checked)
                {
                    sothich += "Thể Thao";
                }
                if (chbMuaSam.Checked)
                {
                    sothich += "Mua Sắm";
                }
                if (sothich != null)
                {
                    sothich = " Sở thích: " + sothich;

                }
                //Xuất thông tin ra TextBox txtDanhSach
                txtDanhsach.Text += stt + "MSV:" + masv + ". Họ tên: " + hoten + "Ngày sinh:" + ngaysinh + "Giới tính: " + gioitinh + sothich + "\r\n";

            }
            catch (Exception ex)
            {
                lb1ThongBao.Text = ex.Message;
            }
        }
    }
}
