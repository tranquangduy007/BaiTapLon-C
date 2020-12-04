using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienCafe_New
{
   
    public partial class FormGiaodien : Form
    {
        string tendangnhap = "", tennguoidung = "", matkhau = "", quyen = "";
        



        public FormGiaodien()
        {

            InitializeComponent();
        }
        public FormGiaodien(string tendangnhap, string tennguoidung,string matkhau,string quyen)
        {

            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.tennguoidung = tennguoidung;
            this.matkhau = matkhau;
            this.quyen = quyen;

        }

        private string userName;
        private string Type;
        private void FormGiaodien_Load(object sender, EventArgs e)
        {
            //Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

            /*  var fn = new FormDangNhap();
              fn.ShowDialog();

              userName = fn.userName;
              Type = fn.Type;
  */
           /* if (Type == "1")
            {
                gunaAdvenceButton2.Visible = false;
                gunaAdvenceButton5.Visible = false;
            }
*/

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            userBanhang11.BringToFront();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            userHoadon1.BringToFront();

        }

        private void gunaAdvenceButton10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát Chương Trình ?", "Thông báo",MessageBoxButtons.YesNo);

            Application.Exit();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            
            if (quyen == "1")
            {
                userDouong1.BringToFront();
            }
            else
            {
                MessageBox.Show("Nên nhớ bạn chỉ là nhân viên");
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (quyen == "1")
            {
                userAccount1.BringToFront();
            }
            else
            {
                MessageBox.Show("Nên nhớ bạn chỉ là nhân viên");
            }
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            FormPaint f = new FormPaint();
            this.Hide();
            f.ShowDialog();
        }


        int move;
        int moveX;
        int moveY;

        private void gunaPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn Đăng Xuất không ?", "Thông báo", MessageBoxButtons.YesNo);
            FormDangNhap dn = new FormDangNhap();
            this.Hide();
            dn.ShowDialog();
        }

        private void gunaPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX,MousePosition.Y -moveY);
            }
        }

        private void gunaPanel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            userGioiThieu1.BringToFront();
        }
    }
}
