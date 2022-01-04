using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyNhaThuoc;
using DTO_QuanLyNhaThuoc;

namespace QuanLyNhaThuoc
{
    public partial class frmQuanLyThuoc : Form
    {
        TreeNode nGoc = null;
        public frmQuanLyThuoc()
        {
            InitializeComponent();
            this.KeyPreview = true;
            btnThemNhomThuoc.Enabled = false;
            btnSuaThongTinThuoc.Enabled = false;
            txtTimKiem.Enabled = false;
            btnResetT.Enabled = false;
            btnSuaNhomThuoc.Enabled = false;
        }
        BUS_Thuoc lt = new BUS_Thuoc();
        BUS_NhomThuoc lnt = new BUS_NhomThuoc();
        bool tent = true;      
        bool tenlt = true;
       void TaoTreNode(TreeView tre)
        {
            tre.Nodes.Clear();
            List<DTO_NhomThuoc> dsnt = lnt.LayHetNhomThuoc();
            TreeNode pNode;
            foreach (var item in dsnt)
            {
                pNode = new TreeNode();
                pNode.Text = item.TenNhomThuoc;
                pNode.Tag = item.MaNhomThuoc;
                nGoc.Nodes.Add(pNode);
            }
            tre.Nodes.Add(nGoc);
            tre.ExpandAll();
        }
        
        private void ForMatThuoc()
        {

            dgvDanhSachThuoc.Columns["maThuoc"].HeaderText = "Mã Thuốc";
            dgvDanhSachThuoc.Columns["maThuoc"].Width = 180;
            dgvDanhSachThuoc.Columns["tenThuoc"].HeaderText = "Tên Thuốc";
            dgvDanhSachThuoc.Columns["tenThuoc"].Width = 120;
           // dgvDanhSachThuoc.Columns["maNhomThuoc"].HeaderText = "Mã Nhóm Thuốc";
           // dgvDanhSachThuoc.Columns["maNhomThuoc"].Width = 170;
            dgvDanhSachThuoc.Columns["tenNhomThuoc"].HeaderText = "Tên Nhóm Thuốc";
            dgvDanhSachThuoc.Columns["tenNhomThuoc"].Width = 160;
            dgvDanhSachThuoc.Columns["loaiThuoc"].HeaderText = "Loại Thuốc";
            dgvDanhSachThuoc.Columns["loaiThuoc"].Width = 160;
            dgvDanhSachThuoc.Columns["hoatChatChinh"].HeaderText = "Hoạt Chất Chính";
            dgvDanhSachThuoc.Columns["hoatChatChinh"].Width = 170;
           // dgvDanhSachThuoc.Columns["sLTL"].HeaderText = "Số Lượng Tồn Lẻ";
           // dgvDanhSachThuoc.Columns["sLTL"].Width = 190;
           // dgvDanhSachThuoc.Columns["giaBanLe"].HeaderText = "Giá Bán Lẻ";
           // dgvDanhSachThuoc.Columns["giaBanLe"].Width = 160;
           // dgvDanhSachThuoc.Columns["dVTL"].HeaderText = "Đơn Vị Quy Đổi";
           // dgvDanhSachThuoc.Columns["dVTL"].Width = 200;
            //dgvDanhSachThuoc.Columns["sLTC"].HeaderText = "Số Lượng Tồn Chẵn";
            //dgvDanhSachThuoc.Columns["sLTC"].Width = 200;
            //dgvDanhSachThuoc.Columns["giaBanChan"].HeaderText = "Giá Bán Chẵn";
           // dgvDanhSachThuoc.Columns["giaBanChan"].Width = 200;
           // dgvDanhSachThuoc.Columns["dVTC"].HeaderText = "Đơn Vị Tính";
           // dgvDanhSachThuoc.Columns["dVTC"].Width = 160;
           // dgvDanhSachThuoc.Columns["lieuLuongDung"].HeaderText = "Liều Lượng Dùng";
           // dgvDanhSachThuoc.Columns["lieuLuongDung"].Width = 180;;
            dgvDanhSachThuoc.Columns["trangThai"].HeaderText = "Trạng Thái";
            dgvDanhSachThuoc.Columns["trangThai"].Width = 180;
        }
        // Load mã nhóm thuốc
        
        private void frmQuanLyThuoc_Load(object sender, EventArgs e)
        {
            nGoc = new TreeNode("Tên Nhóm Thuốc");
            TaoTreNode(treNhomThuoc);
            // autocomplete
            /*txtTenNhomThuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenNhomThuoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenNhomThuoc.AutoCompleteCustomSource.Clear();
            AutoCompleteStringCollection collect = new AutoCompleteStringCollection();           
            List<DTO_NhomThuoc> dsnt = lnt.LayHetNhomThuoc();
            foreach (var item in dsnt)
            {
                collect.Add(item.TenNhomThuoc);
                txtTenNhomThuoc.AutoCompleteCustomSource = collect;
            }*/
        }
        // Tạo Mã thuốc tự Đông
        private void TaoMaThuocTuDong()
        {
            int value = lt.LaySoThuoc();            
            if (value + 1 < 10)
            {
                txtMaThuoc.Text = "T000000000" + (value + 1).ToString();
            }
            else if (value + 1 < 100)
            {
                txtMaThuoc.Text = "T00000000" + (value + 1).ToString();
            }
            else if (value + 1 < 1000)
            {
                txtMaThuoc.Text = "T0000000" + (value + 1).ToString();
            }
            else if (value + 1 < 10000)
            {
                txtMaThuoc.Text = "T000000" + (value + 1).ToString();
            }
            else if (value + 1 < 100000)
            {
                txtMaThuoc.Text = "T00000" + (value + 1).ToString();
            }
            else if (value + 1 < 1000000)
            {
                txtMaThuoc.Text = "T0000" + (value + 1).ToString();
            }
            else if (value + 1 < 10000000)
            {
                txtMaThuoc.Text = "T000" + (value + 1).ToString();
            }
            else if (value + 1 < 100000000)
            {
                txtMaThuoc.Text = "T00" + (value + 1).ToString();
            }
            else if (value + 1 < 1000000000)
            {
                txtMaThuoc.Text = "T0" + (value + 1).ToString();
            }
            else if (value + 1 == 1000000000)
            {
                txtMaThuoc.Text = "T" + (value + 1).ToString();
            }
        }


        // Tạo Một Thuốc
        private DTO_Thuoc TaoMotThuoc()
        {
            DTO_Thuoc t = new DTO_Thuoc();
            t.MaThuoc = txtMaThuoc.Text;
            t.TenThuoc = txtTenThuoc.Text;
            t.MaNhomThuoc = txtTenNhomThuoc.Text;
            t.TenNhomThuoc = null;
            if (radThuocKeDon.Checked == true)
            {
                t.LoaiThuoc = "Thuốc Kê Đơn";
            }
            else t.LoaiThuoc = "Không Kê Đơn";
            t.HoatChatChinh = txtHoatChatChinh.Text;
            if (radDangKinhDoanh.Checked == true)
            {
                t.TrangThai = "Đang Hoạt Động";
            }
            else t.TrangThai = "Ngưng Hoạt Động";
            return t;
        }
        // lấy thuốc theo mã nhóm thuốc
        private void LayTheoMa()
        {
            //string mant = Convert.ToString(treNhomThuoc.SelectedNode.Tag);
            List<DTO_Thuoc> dst = lt.LayThuocTheoMaT(txtTenNhomThuoc.Text);
            dgvDanhSachThuoc.DataSource = dst;
            if (dst != null)
            {
                ForMatThuoc();
            }
        }
        private void treNhomThuoc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnSuaNhomThuoc.Enabled = true;
            txtMaThuoc.Text = "";
            txtHoatChatChinh.Text = "";
            txtTimKiem.Enabled = true;
            btnResetT.Enabled = true;
            string mant = Convert.ToString(treNhomThuoc.SelectedNode.Tag);
            txtTenNhomThuoc.Text = mant;
            List<DTO_Thuoc> dst = lt.LayThuocTheoMaT(mant);
            dgvDanhSachThuoc.DataSource = dst;
            if (dst != null)
            {
                ForMatThuoc();
            }
            txtMaNhomThuoc.Text = mant;
            // sửa nhóm thuốc
            List<DTO_NhomThuoc> dsnt = lnt.LayHetNhomThuoc();
            foreach (var item in dsnt)
            {
                if (item.MaNhomThuoc==mant)
                {
                    txtTenLoaiThuoc.Text = item.TenNhomThuoc;
                    btnThemNhomThuoc.Enabled = false;
                }
            }
        }
        private void LoadTheoMaNhomThuoc()
        {
            /*List<DTO_QuanLyThuoc> dst = lt.LayHetThuocTheoMa(txtTenNhomThuoc.Text);
            dgvDanhSachThuoc.DataSource = dst;
            ForMatThuoc();*/
        }
        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            
            bool checkTen = true;
            List<DTO_Thuoc> dst = lt.LayHetThuocT();
            if (txtTenThuoc.Text=="" || txtTenNhomThuoc.Text=="")
            {
                MessageBox.Show("Không được để rỗng tên thuốc hoặc mã nhóm thuốc hoặc cả hai!","Thông báo");
            }
            else if (tent==false )
            {
                MessageBox.Show("Kiểm tra lại định dạng hoặc có thể thuốc đã tồn tại!", "Thông báo");
            }           
            else
            {
                foreach (var item in dst)
                {
                    if (item.TenThuoc==txtTenThuoc.Text)                  
                    {
                        MessageBox.Show("Thuốc này đã tồn tại trong danh sách thuốc, lưu ý hãy gõ đúng thuốc!");
                        checkTen = false;
                    }
                }
                if (checkTen==true)
                {
                    TaoMaThuocTuDong();
                    if (lt.ThemThuoc(TaoMotThuoc()) == true)
                    {
                        LayTheoMa();
                        MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                        btnSuaThongTinThuoc.Enabled = true;
                    }
                    else MessageBox.Show("Thêm Thất Bại!", "Thông Báo");
                }
            }
        }
              
        private void dgvThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int h = dgvDanhSachThuoc.CurrentRow.Index;
            txtMaThuoc.Text = dgvDanhSachThuoc.Rows[h].Cells[0].Value.ToString();
            txtTenThuoc.Text = dgvDanhSachThuoc.Rows[h].Cells[1].Value.ToString();
            txtTenNhomThuoc.Text = dgvDanhSachThuoc.Rows[h].Cells[2].Value.ToString();
            txtHoatChatChinh.Text = dgvDanhSachThuoc.Rows[h].Cells[5].Value.ToString();
            if (dgvDanhSachThuoc.Rows[h].Cells[4].Value.ToString() == "Thuốc Kê Đơn")
            {
                radThuocKeDon.Checked = true;
            }
            else
            {
                radThuocKhongKeDon.Checked = true;
            }
            if (dgvDanhSachThuoc.Rows[h].Cells[6].Value.ToString() == "Đang Hoạt Động")
            {
                radDangKinhDoanh.Checked = true;
            }
            else
            {
                radNgungKinhDoanh.Checked = true;
            }
            btnSuaThongTinThuoc.Enabled = true;
            btnXemLoThuoc.Enabled = true;
            btnThemThuoc.Enabled = false;
        }

        private void btnSuaThongTinThuoc_Click(object sender, EventArgs e)
        {
            if (txtTenThuoc.Text == "" || txtTenNhomThuoc.Text == "")
            {
                MessageBox.Show("Không được để rỗng tên thuốc hoặc mã nhóm thuốc hoặc cả hai!", "Thông báo");
            }
            else if (tent == false)
            {
                MessageBox.Show("Kiểm tra lại định dạng hoặc có thể thuốc đã tồn tại!", "Thông báo");
            }
            else
            {
                if (lt.SuaThuoc(TaoMotThuoc()) == true)
                {
                    LayTheoMa();
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                }
                else MessageBox.Show("Sửa Thất Bại", "Thông Báo");
            }
        }
        // Tìm kiếm nhân viên theo mã và tên

        void assistant_Idled11(object sender, EventArgs e)
        {
            this.Invoke(
            new MethodInvoker(() =>
            {
                string mant = "";
                mant = Convert.ToString(treNhomThuoc.SelectedNode.Tag);
                dgvDanhSachThuoc.DataSource = lt.TimKiemTheoMaTenT(txtTimKiem.Text,mant);
                if (dgvDanhSachThuoc.RowCount != 0)
                {
                    ForMatThuoc();
                }
            }));
        }
        TypeAssistant assistant;

        // Thay Đổi Theo Thời Gian
        public class TypeAssistant
        {
            public event EventHandler Idled = delegate { };
            public int WaitingMilliSeconds { get; set; }
            System.Threading.Timer waitingTimer;

            public TypeAssistant(int waitingMilliSeconds = 300)
            {
                WaitingMilliSeconds = waitingMilliSeconds;
                waitingTimer = new System.Threading.Timer(p =>
                {
                    Idled(this, EventArgs.Empty);
                });
            }
            public void TextChanged()
            {
                waitingTimer.Change(WaitingMilliSeconds, System.Threading.Timeout.Infinite);
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            int delay = 1000;
            assistant = new TypeAssistant(delay);
            assistant.Idled += assistant_Idled11;
            assistant.TextChanged();
        }
        // Tạo mã nhóm tự động
        private void TaoMaNhomTuDong()
        {
            int count = 0;
           
            count = lnt.SoNhomThuoc();
            if (count +1 <10)
            {
                txtMaNhomThuoc.Text = "NT00" + (count + 1).ToString();
            }
            else if (count +1 <100)
            {
                txtMaNhomThuoc.Text = "NT0" + (count + 1).ToString();
            }
            else if (count +1 == 100)
            {
                txtMaNhomThuoc.Text = "NT" + (count + 1).ToString();
            }
        }
        // Tạo Một Nhóm Thuốc
        private DTO_NhomThuoc TaoMotNhomThuoc()
        {           
            DTO_NhomThuoc nt = new DTO_NhomThuoc();
            nt.MaNhomThuoc = txtMaNhomThuoc.Text;
            nt.TenNhomThuoc = txtTenLoaiThuoc.Text;
            return nt;
        }
        // Thêm nhóm thuốc
        private void btnThemNhomThuoc_Click(object sender, EventArgs e)
        {
            TaoMaNhomTuDong();
            if (tenlt==false)
            {
                MessageBox.Show("Định dạng không đúng!","Thông báo");
            }
            else
            {
                int test1 = 1;
                List<DTO_NhomThuoc> dsnt = lnt.LayHetNhomThuoc();
                foreach (var item in dsnt)
                {
                    if (item.TenNhomThuoc == txtTenLoaiThuoc.Text)
                    {
                        test1 = 0;
                    }
                }
                if (test1==1)
                {
                    if (lnt.ThemNhomThuoc(TaoMotNhomThuoc()) == true)
                    {
                        frmQuanLyThuoc_Load(sender, e);
                        MessageBox.Show("Thêm Thuốc Thành Công", "Thông Báo");
                        txtTenLoaiThuoc.ResetText();
                        btnSuaNhomThuoc.Enabled = true;
                    }
                    else MessageBox.Show("Thêm Không Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Nhóm thuốc này đã tồn tại!","Thông báo");
                }
            }
        
        }
      
        public static string maT;
        public static string tenT;
        private void btnXemLoThuoc_Click(object sender, EventArgs e)
        {
            maT = txtMaThuoc.Text;
            tenT = txtTenThuoc.Text;
            frmLoThuoc lt = new frmLoThuoc();
            lt.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            lt.StartPosition = FormStartPosition.CenterScreen;
            //this.Hide();
            lt.ShowDialog();
            this.Show();
        }

        private void frmQuanLyThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode==Keys.A)
            {
                btnThemThuoc_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                btnSuaThongTinThuoc_Click(sender,e);
            }
            if (e.Control && e.KeyCode == Keys.G)
            {
                btnThemNhomThuoc_Click(sender,e);
            }
            if (e.Control && e.KeyCode == Keys.W)
            {
                btnXemLoThuoc_Click(sender, e);
            }
        }

        private void txtTenLoaiThuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtTenLoaiThuoc.Text != "")
            {
                btnThemNhomThuoc.Enabled = true;
            }
            else btnThemNhomThuoc.Enabled = false;
        }
        ToolTip tip = new ToolTip();
        private void btnThemThuoc_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnThemThuoc,"Để thêm thuốc bấm Ctrl+A");
        }

        private void btnSuaThongTinThuoc_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnSuaThongTinThuoc, "Để sửa thuốc bấm Ctrl+R");
        }

        private void btnThemNhomThuoc_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnThemNhomThuoc, "Để thêm nhóm thuốc bấm Ctrl+G");
        }

        private void btnXemLoThuoc_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnXemLoThuoc, "Để xem lô thuốc bấm Ctrl+W");
        }

        private void txtTenThuoc_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txtTenThuoc.Text))
            //{
            //    e.Cancel = true;
            //    txtTenThuoc.Focus();
            //    err.SetError(txtTenThuoc,"Không được để trống tên!");
            //    tent = false;
            //}
            //else if (txtTenThuoc.Text.NameCheck() == false)
            //{
            //    e.Cancel = true;
            //    txtTenThuoc.Focus();
            //    err.SetError(txtTenThuoc, "Không chứa chữ cái đặt biệt, chữ cái đầu không là số hoặc định dạng không đúng!");
            //    tent = false;
            //}
            //else
            //{
            //    e.Cancel = false;
            //    err.SetError(txtTenThuoc,null);
            //    tent = true;
            //}
        }

        private void txtTenLoaiThuoc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLoaiThuoc.Text))
            {
                e.Cancel = false;
                err.SetError(txtTenLoaiThuoc, null);
                tenlt = true;
            }
            else if (txtTenLoaiThuoc.Text.NameCheck() == false)
            {
                e.Cancel = true;
                txtTenLoaiThuoc.Focus();
                err.SetError(txtTenLoaiThuoc, "Chữ cái đầu không được là số!");
                tenlt = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTenLoaiThuoc, null);
                btnThemNhomThuoc.Enabled = true;
                tenlt = true;
            }
        }

        private void txtTenNhomThuoc_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtTenNhomThuoc_Click(object sender, EventArgs e)
        {
           // txtTenNhomThuoc.AutoCompleteCustomSource.Clear();
           // List<DTO_NhomThuoc> dsnt = lnt.LayHetNhomThuoc();
           // foreach (var item in dsnt)
            //{
             //   txtTenNhomThuoc.AutoCompleteCustomSource.Add(item.TenNhomThuoc);
               
            //}
        }

        private void txtTenNhomThuoc_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnResetT_Click(object sender, EventArgs e)
        {
            string mant = Convert.ToString(treNhomThuoc.SelectedNode.Tag);
            txtTenNhomThuoc.Text = mant;
            List<DTO_Thuoc> dst = lt.LayThuocTheoMaT(mant);
            dgvDanhSachThuoc.DataSource = dst;
            if (dst != null)
            {
                ForMatThuoc();
            }
            txtTimKiem.ResetText();
            txtTenLoaiThuoc.ResetText();
            txtMaNhomThuoc.ResetText();
            txtTenNhomThuoc.ResetText();
            txtTenThuoc.ResetText();
            txtMaThuoc.ResetText();
            txtHoatChatChinh.ResetText();
            btnThemNhomThuoc.Enabled = true;
            btnSuaNhomThuoc.Enabled = false;
            btnThemThuoc.Enabled = true;

        }
        // Sửa nhóm thuốc
        private void btnSuaNhomThuoc_Click(object sender, EventArgs e)
        {
            if (tenlt == false)
            {
                MessageBox.Show("Định dạng không đúng!", "Thông báo");
            }
            else
            {
                if (txtTenLoaiThuoc.Text !=null)
                {
                    if (lnt.SuaNhomThuoc(TaoMotNhomThuoc()) == true)
                    {
                        frmQuanLyThuoc_Load(sender, e);
                        MessageBox.Show("Sửa Nhóm Thuốc Thành Công", "Thông Báo");
                        txtTenLoaiThuoc.ResetText();
                        txtMaNhomThuoc.ResetText();
                        btnSuaNhomThuoc.Enabled = false;
                    }
                    else MessageBox.Show("Sửa Nhóm Thuốc Không Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Muốn sửa nhóm thuốc, không được để trống tên!");
                }
            }
        }
    }
    
}
