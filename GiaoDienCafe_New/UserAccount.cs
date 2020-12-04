using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace GiaoDienCafe_New
{
    public partial class UserAccount : UserControl
    {
        string conString = @"Data Source=DESKTOP-4S463V3;Initial Catalog=coffee1;Integrated Security=True";
        public UserAccount()
        {
            InitializeComponent();
        }
        public DataTable ketNoi(string query)
        {
            DataTable data = new DataTable();
            SqlConnection sql = new SqlConnection(conString);
            sql.Open();
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            sql.Close();
            return data;
        }
        SqlConnection conn;

        MD5 md = MD5.Create();
        public void Hienthi()
        {
            string sqlSELECT = "select *from Account ";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgvTaikhoan.DataSource = dt;
        }

        public void loadDl()
        {

            string query = "select *from Account ";
            DataTable data = ketNoi(query);
            dtgvTaikhoan.DataSource = data;

        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-4S463V3;Initial Catalog=coffee1;Integrated Security=True";
            conn = new SqlConnection(conString);
            conn.Open();
            loadDl();
        }

        private void dtgvTaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            else
            {
                txtTaikhoan.Text = dtgvTaikhoan.Rows[row].Cells["UserName"].Value.ToString();
                txtMatkhau.Text = dtgvTaikhoan.Rows[row].Cells["PassWord"].Value.ToString();
                txtHienthi.Text = dtgvTaikhoan.Rows[row].Cells["DisplayName"].Value.ToString();
                cbVitri.Text = dtgvTaikhoan.Rows[row].Cells["Type"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "" || txtMatkhau.Text == "" || txtHienthi.Text == "" || cbVitri.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                string sqlINSERT = "INSERT INTO Account values(@UserName,@PassWord,@DisplayName,@Type)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                cmd.Parameters.AddWithValue("UserName", txtTaikhoan.Text);
                cmd.Parameters.AddWithValue("PassWord", txtMatkhau.Text);
                cmd.Parameters.AddWithValue("DisplayName", txtHienthi.Text);
                cmd.Parameters.AddWithValue("Type", cbVitri.GetItemText(this.cbVitri.SelectedItem));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công!");
                Hienthi();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "")
            {
                MessageBox.Show("Chọn dòng cần xóa :", "Thông báo");
            }
            else
            {
                string sqlDelete = "Delete Account  WHERE UserName='" + txtTaikhoan.Text + "'";
                DataTable data = ketNoi(sqlDelete);
                loadDl();
                MessageBox.Show("Đã Xóa Thành Công !", "Thông Báo:");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE Account SET PassWord='" + txtMatkhau.Text + "',DisplayName='" + txtHienthi.Text + "'," +
             "Type='" + cbVitri.Text + "' WHERE UserName='" + txtTaikhoan.Text + "'";

            DataTable data = ketNoi(sqlEdit);
            loadDl();
            MessageBox.Show("Đã sửa thông tin thành công !", "Thông báo");
        }

        private void btLammoi_Click(object sender, EventArgs e)
        {
            txtTaikhoan.Text = "";
            txtHienthi.Text = "";
            txtMatkhau.Text = "";
            cbVitri.Text = "";
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            byte[] inputStr = System.Text.Encoding.ASCII.GetBytes(txtMahoa.Text);
            byte[] hash = md.ComputeHash(inputStr);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            lbMahoa.Text = sb.ToString();
        }
    }
}
