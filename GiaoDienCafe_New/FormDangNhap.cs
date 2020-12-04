using GiaoDienCafe_New.DAO;
using GiaoDienCafe_New.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienCafe_New
{
    public partial class FormDangNhap : Form
    {
        
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int move;
        int moveX;
        int moveY;

        private void FormDangNhap_MouseDown(object sender, MouseEventArgs e)
        {

            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void FormDangNhap_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void FormDangNhap_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
        public string userName ="";
        public string Type;

        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-4S463V3;Initial Catalog=coffee1;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Account WHERE UserName = N'" + txtbUserName.Text + "' and PassWord=N'"+txtbPassWord.Text+"'",cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                this.Hide();
                FormGiaodien f = new FormGiaodien(dt.Rows[0][0].ToString(),dt.Rows[0][1].ToString(),dt.Rows[0][2].ToString(),dt.Rows[0][3].ToString());
                f.Show();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại Thông tin đầy đủ", "Thông báo");
            }

            /*string userName = txtbUserName.Text;
            string passWord = txtbPassWord.Text;
            string Type = cbPhanquyen.Text;

            if (Login(userName, passWord, Type))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                FormGiaodien f = new FormGiaodien();
                this.Hide();
                f.ShowDialog();


            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }*/
        }
        bool Login(string username, string password ,string type)
        {
            return AccountDAO.Instance.Login(username, password , type);
        }
        private void checkboxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShow.Checked)
            {
                txtbPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtbPassWord.UseSystemPasswordChar = true;
            }
        }

        private void lbIncorrect_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtbPassWord_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
