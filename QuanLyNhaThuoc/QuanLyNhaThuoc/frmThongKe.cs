using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS_QuanLyNhaThuoc;
using DTO_QuanLyNhaThuoc;

namespace QuanLyNhaThuoc
{
    public partial class frmThongKe : Form
    {

        BUS_ThongKe ltk = new BUS_ThongKe();
        BUS_NhanVien lnv = new BUS_NhanVien();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            btnCTDoanhThu.PerformClick();
            LoadNhanVien();
            checkTuyChonThongKe();
            loadDuLieuThongKe();
            loadThongkeThuocHetHan();
            ForMatLoThuoc(dgvThuocTK);
            ForMatLoThuoc(dgvThuocBanChay);
            loadDuLieuData();

            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiBieuDoDT.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDTThang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDTNam.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnCTDoanhThu_Click(object sender, EventArgs e)
        {
            panelDuLieu.Visible = true;
            panelDuLieuThuoc.Visible = false;
            radDoanhThuBD.PerformClick();
        }

        private void btnCTDonThuoc_Click(object sender, EventArgs e)
        {
            panelDuLieu.Visible = true;
            panelDuLieuThuoc.Visible = false;
            radDonBieuDo.PerformClick();
        }

        private void btnCTThuoc_Click(object sender, EventArgs e)
        {
            panelDuLieu.Visible = false;
            panelDuLieuThuoc.Visible = true;
        }



        void loadDuLieuThongKe()
        {
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();

            lblDTNgay.Text = ltk.doanhThuTheoNgay(ngay, thang, nam).ToString("C0", CultureInfo.CurrentCulture);
            lblDTThang.Text = ltk.doanhThuTheoThang(thang, nam).ToString("C0", CultureInfo.CurrentCulture);
            lblDTNam.Text = ltk.doanhThuTheoNam(nam).ToString("C0", CultureInfo.CurrentCulture);

            lblDoTNgay.Text = String.Format("{0:##,####,####}", ltk.donThuocTheoNgay(ngay, thang, nam));
            lblDoTThang.Text = String.Format("{0:##,####,####}", ltk.donThuocTheoThang(thang, nam));
            lblDoTNam.Text = String.Format("{0:##,####,####}", ltk.donThuocTheoNam(nam));

            lblTHetHan.Text = String.Format("{0:##,####,####}", ltk.thongKeThuocHetHan().Count);
            lblTSapHetHan.Text = String.Format("{0:##,####,####}", ltk.thongKeThuocHetHanTrongSoNgay(15).Count);

        }



        private void radDTThang_CheckedChanged(object sender, EventArgs e)
        {
            cboDTThang.Visible = true;
            checkTuyChonThongKe();
        }

        private void radDTNam_CheckedChanged(object sender, EventArgs e)
        {
            cboDTThang.Visible = false;
            checkTuyChonThongKe();
        }

        void loadBieuDoDT()
        {
            if (cboNhanVien.Text == "Tất cả")
            {

                if (radDTNam.Checked == true)
                {

                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                    for (int i = 0; i < 12; i++)
                    {
                        chartDoanhThu.Series[a].Points.AddXY(i + 1, ltk.doanhThuTheoThang((i + 1).ToString(), cboDTNam.Text));

                    }
                }
                if (radDTThang.Checked == true)
                {
                    foreach (var series in chartDoanhThu.Series)
                    {
                        series.Points.Clear();
                    }
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 2;
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                    for (int i = 0; i < 31; i++)
                    {
                        chartDoanhThu.Series[a].Points.AddXY(i + 1, ltk.doanhThuTheoNgay((i + 1).ToString(), cboDTThang.Text, cboDTNam.Text));

                    }
                }
            }
            else
            {

                if (radDTNam.Checked == true)
                {

                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                    for (int i = 0; i < 12; i++)
                    {
                        chartDoanhThu.Series[a].Points.AddXY(i + 1, ltk.doanhThuTheoNhanVienThang(checkMaNhanVienCoTonTai(), (i + 1).ToString(), cboDTNam.Text));

                    }
                }
                if (radDTThang.Checked == true)
                {
                    foreach (var series in chartDoanhThu.Series)
                    {
                        series.Points.Clear();
                    }
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 2;
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                    for (int i = 0; i < 31; i++)
                    {
                        chartDoanhThu.Series[a].Points.AddXY(i + 1, ltk.doanhThuNhanVienTheoNgay(checkMaNhanVienCoTonTai(), (i + 1).ToString(), cboDTThang.Text, cboDTNam.Text));

                    }
                }
            }
        }

        void loadBieuDoDon()
        {
            if (cboNhanVien.Text == "Tất cả")
            {
                if (radDTNam.Checked == true)
                {

                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                    for (int i = 0; i < 12; i++)
                    {
                        chartDoanhThu.Series[a].Points.AddXY(i + 1, ltk.donThuocTheoThang((i + 1).ToString(), cboDTNam.Text));

                    }
                }
                if (radDTThang.Checked == true)
                {
                    foreach (var series in chartDoanhThu.Series)
                    {
                        series.Points.Clear();
                    }
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 2;
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                    for (int i = 0; i < 31; i++)
                    {
                        chartDoanhThu.Series[a].Points.AddXY(i + 1, ltk.donThuocTheoNgay((i + 1).ToString(), cboDTThang.Text, cboDTNam.Text));

                    }
                }
            }
            else
            {
                if (radDTNam.Checked == true)
                {

                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                    for (int i = 0; i < 12; i++)
                    {
                        chartDoanhThu.Series[a].Points.AddXY(i + 1, ltk.donThuocNhanVienTheoThang(checkMaNhanVienCoTonTai(), (i + 1).ToString(), cboDTNam.Text));

                    }
                }
                if (radDTThang.Checked == true)
                {
                    foreach (var series in chartDoanhThu.Series)
                    {
                        series.Points.Clear();
                    }
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 2;
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                    for (int i = 0; i < 31; i++)
                    {
                        chartDoanhThu.Series[a].Points.AddXY(i + 1, ltk.donThuocNhanVienTheoNgay(checkMaNhanVienCoTonTai(), (i + 1).ToString(), cboDTThang.Text, cboDTNam.Text));

                    }
                }
            }

        }
        private void cboLoaiBieuDoDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkTuyChonThongKe();
        }


        private void cboDTThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkTuyChonThongKe();
        }

        private void cboDTNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkTuyChonThongKe();
        }

        private void radDoanhThuBD_CheckedChanged(object sender, EventArgs e)
        {

            checkTuyChonThongKe();
        }

        private void radDonBieuDo_CheckedChanged(object sender, EventArgs e)
        {

            checkTuyChonThongKe();
        }

        int a = 0;
        void checkTuyChonThongKe()
        {
            //format du lieu bieu do
            foreach (var series in chartDoanhThu.Series)
            {
                //series.IsValueShownAsLabel = true;
                series.ToolTip = "#VAL{##,####,####}";
                series.Points.Clear();
            }

            if (radDoanhThuBD.Checked)
            {
                if (cboLoaiBieuDoDT.Text == "Biểu đồ đường")
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }
                loadBieuDoDT();
            }
            if (radDonBieuDo.Checked)
            {
                if (cboLoaiBieuDoDT.Text == "Biểu đồ đường")
                {
                    a = 2;
                }
                else
                {
                    a = 3;
                }
                loadBieuDoDon();
            }
            loadDuLieuData();

        }

        void loadDuLieuData()
        {

            dgvDoanhThuDonThuoc.Rows.Clear();

            dgvDoanhThuDonThuoc.ColumnCount = 3;
            dgvDoanhThuDonThuoc.Columns[0].Name = "STT";
            dgvDoanhThuDonThuoc.Columns[1].Name = "Doanh thu";
            dgvDoanhThuDonThuoc.Columns[1].Width = 130;
            dgvDoanhThuDonThuoc.Columns[2].Name = "Số đơn";
            dgvDoanhThuDonThuoc.Columns[2].Width = 130;


            int h;
            h = dgvDoanhThuDonThuoc.RowCount + 1;
            string[] row1;
            if (radDTThang.Checked == true)
            {
                if (cboNhanVien.Text == "Tất cả")
                {
                    for (int i = 1; i <= 31; i++)
                    {

                        row1 = new string[] { "Ngày " + i.ToString(), String.Format("{0:##,####,####}", ltk.doanhThuTheoNgay(i.ToString(), cboDTThang.Text, cboDTNam.Text)), String.Format("{0:##,####,####}", ltk.donThuocTheoNgay(i.ToString(), cboDTThang.Text, cboDTNam.Text)) };
                        dgvDoanhThuDonThuoc.Rows.Add(row1);
                    }

                }
                else
                {
                    for (int i = 1; i <= 31; i++)
                    {

                        row1 = new string[] { "Ngày " + i.ToString(), String.Format("{0:##,####,####}", ltk.doanhThuNhanVienTheoNgay(cboNhanVien.Text.Substring(0,6), i.ToString(), cboDTThang.Text, cboDTNam.Text)), String.Format("{0:##,####,####}", ltk.donThuocNhanVienTheoNgay(cboNhanVien.Text.Substring(0, 6), i.ToString(), cboDTThang.Text, cboDTNam.Text)) };
                        dgvDoanhThuDonThuoc.Rows.Add(row1);
                    }
                }
            }
            if (radDTNam.Checked == true)
            {
                if (cboNhanVien.Text == "Tất cả")
                {
                    for (int i = 1; i <= 12; i++)
                    {

                        row1 = new string[] { "Tháng " + i.ToString(), String.Format("{0:##,####,####}", ltk.doanhThuTheoThang(i.ToString(), cboDTNam.Text)), String.Format("{0:##,####,####}", ltk.donThuocTheoThang(i.ToString(), cboDTNam.Text)) };
                        dgvDoanhThuDonThuoc.Rows.Add(row1);
                    }

                }
                else
                {
                    for (int i = 1; i <= 12; i++)
                    {

                        row1 = new string[] { "Tháng " + i.ToString(), String.Format("{0:##,####,####}", ltk.doanhThuTheoNhanVienThang(cboNhanVien.Text.Substring(0, 6), i.ToString(), cboDTNam.Text)), String.Format("{0:##,####,####}", ltk.donThuocNhanVienTheoNgay(cboNhanVien.Text.Substring(0, 6), i.ToString(), cboDTThang.Text, cboDTNam.Text)) };
                        dgvDoanhThuDonThuoc.Rows.Add(row1);
                    }
                }
            }

            //dgvThuocBanChay.DataSource = ltk.thongKeThuocHetHanTrongSoNgay(30);
        }
        private void LoadNhanVien()
        {
            List<DTO_NhanVien> dsnv = lnv.LayHetNhanVien();
            foreach (var item in dsnv)
            {
                if (item.TrangThai == "Đang Hoạt Động")
                {
                    cboNhanVien.Items.Add(item.MaNV + " - " + item.TenNV);
                }
            }
        }

        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkTuyChonThongKe();
        }
        string checkMaNhanVienCoTonTai()
        {
            List<DTO_NhanVien> dsnv = lnv.LayHetNhanVien();
            foreach (var item in dsnv)
            {
                if (item.TrangThai == "Đang Hoạt Động" && cboNhanVien.Text == (item.MaNV + " - " + item.TenNV))
                {
                    return item.MaNV;
                }
            }
            return "Tất cả";
        }


        void loadThongkeThuocHetHan()
        {
            dgvThuocTK.Rows.Clear();
            dgvThuocBanChay.Rows.Clear();
            // if(ltk.thongKeThuocHetHan()!=null)
            dgvThuocTK.DataSource = ltk.thongKeThuocHetHan();
            //if (ltk.thongKeThuocHetHanTrongSoNgay(30) != null)
            dgvThuocBanChay.DataSource = ltk.thongKeThuocHetHanTrongSoNgay(30);
        }
        private void ForMatLoThuoc(DataGridView dgv)
        {
            if (dgv != null)
            {
                dgv.Columns["maLoThuoc"].HeaderText = "Mã Lô Thuốc";
                dgv.Columns["maLoThuoc"].Width = 180;
                dgv.Columns["maThuoc"].HeaderText = "Mã Thuốc";
                dgv.Columns["maThuoc"].Width = 180;
                dgv.Columns["tenThuoc"].HeaderText = "Tên Thuốc";
                dgv.Columns["tenThuoc"].Width = 180;
                dgv.Columns["maNCC"].Visible = false;
                dgv.Columns["tenNCC"].HeaderText = "Nhà Cung Cấp";
                dgv.Columns["tenNCC"].Width = 180;
                dgv.Columns["xuatXu"].HeaderText = "Xuất Xứ";
                dgv.Columns["xuatXu"].Width = 150;
                dgv.Columns["ngaySanXuat"].HeaderText = "Ngày Sản Xuất";
                dgv.Columns["ngaySanXuat"].Width = 180;
                dgv.Columns["hanSuDung"].HeaderText = "Hạn Sử Dụng";
                dgv.Columns["hanSuDung"].Width = 180;
                dgv.Columns["donViTinh"].HeaderText = "Đơn Vị Tính";
                dgv.Columns["donViTinh"].Width = 180;
                dgv.Columns["donViQuyDoi"].HeaderText = "Đơn Vị Quy Đổi";
                dgv.Columns["donViQuyDoi"].Width = 200;
                dgv.Columns["tyLeQuyDoi"].HeaderText = "Tỷ Lệ Quy Đổi";
                dgv.Columns["tyLeQuyDoi"].Width = 200;
                dgv.Columns["giaBanChan"].HeaderText = "Giá Bán Chẵn";
                dgv.Columns["giaBanChan"].Width = 180;
                dgv.Columns["giaBanLe"].HeaderText = "Giá Bán Lẻ";
                dgv.Columns["giaBanLe"].Width = 180;
                dgv.Columns["lieuLuongDung"].HeaderText = "Liều Lượng Dùng";
                dgv.Columns["lieuLuongDung"].Width = 180;
                dgv.Columns["moTa"].HeaderText = "Mô Tả";
                dgv.Columns["moTa"].Width = 180;
                dgv.Columns["vAT"].HeaderText = "VAT";
                dgv.Columns["vAT"].Width = 180;
                dgv.Columns["soLuongTon"].HeaderText = "Số Lượng Tồn";
                dgv.Columns["soLuongTon"].Width = 180;
            }
        }

    }
}
