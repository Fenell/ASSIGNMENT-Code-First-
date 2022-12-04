using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.Service;

namespace _3_GUI
{
    public partial class FrmLogin : Form
    {
        private UserService _userService;
        public FrmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            _userService = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userService.GetUserByUserName(txtUserName.Text);
            if (user == null)
            {
                MessageBox.Show("Kiểm tra lại tên tài khoản", "Thông báo");
                return;
            }

            if (txtPassword.Text == user.Password)
            {
                if (user.Role == "Giảng viên")
                {
                    FrmScoresService scoresService = new FrmScoresService();
                    scoresService.Show();
                    this.Hide();
                }

                if (user.Role == "Cán bộ đào tạo")
                {
                    FrmStudentService studentService = new FrmStudentService();
                    studentService.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
