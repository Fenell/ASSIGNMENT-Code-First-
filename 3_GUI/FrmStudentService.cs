using System.Drawing.Imaging;
using _1_DAL.DomianModels;
using _2_BUS.Service;
using _2_BUS.Utility;

namespace _3_GUI
{
    public partial class FrmStudentService : Form
    {
        private StudentService _studentService;
        ErrorProvider _errorProvider;
        private Guid _idWhenClick;
        private bool isExit;
        public FrmStudentService()
        {
            InitializeComponent();
            this.CenterToScreen();
            _errorProvider = new ErrorProvider();
            _studentService = new StudentService();
            isExit = true;
            LoadData();
        }

        private void LoadData()
        {
            DisableControls();
            dgvStudent.ColumnCount = 7;
            dgvStudent.Columns[0].Visible = false;
            dgvStudent.Columns[1].Name = "Mã SV";
            dgvStudent.Columns[1].Width = 70;
            dgvStudent.Columns[2].Name = "Họ và tên";
            dgvStudent.Columns[2].Width = 120;
            dgvStudent.Columns[3].Name = "Email";
            dgvStudent.Columns[3].Width = 120;
            dgvStudent.Columns[4].Name = "Số ĐT";
            dgvStudent.Columns[5].Name = "Giới tính";
            dgvStudent.Columns[6].Name = "Địa chỉ";
            dgvStudent.Rows.Clear();
            foreach (var x in _studentService.GetAllStudents())
            {
                dgvStudent.Rows.Add(x.Id, x.MaSv, x.Name, x.Email, x.Phone, x.Sex ? "Nam" : "Nữ", x.Address);
            }
        }

        private Student GetDataFromGui()
        {
            try
            {
                return new Student()
                {
                    Id = Guid.Empty,
                    MaSv = _studentService.AutoGenerateMaSv(),
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    Picture = ImageToBytes(ptboxImage.Image),
                    Sex = (rbtnMale.Checked ? true : false)
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index == -1 || index == _studentService.GetAllStudents().Count)
                return;
            _idWhenClick = Guid.Parse(dgvStudent.Rows[index].Cells[0].Value.ToString());
            var student = _studentService.GetStudentById(_idWhenClick);
            lblMaSv.Text = student.MaSv;
            txtName.Text = student.Name;
            txtPhone.Text = student.Phone;
            txtEmail.Text = student.Email;
            txtAddress.Text = student.Address;
            ptboxImage.Image = ByteToImage(student.Picture);
            if (student.Sex)
            {
                rbtnMale.Checked = true;
                return;
            }
            rbtnFemale.Checked = true;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableControls();
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Kiểm tra lại dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var student = GetDataFromGui();

            if (student == null)
            {
                MessageBox.Show("Kiểm tra lại dữ liệu nhập vào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_studentService.HasStudentByMaSv(lblMaSv.Text))
            {
                student.Id = _idWhenClick;
                student.MaSv = lblMaSv.Text;

                if (MessageBox.Show($"Bạn có muốn sửa thông tin sinh viên {student.Name} có mã {student.MaSv} không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(_studentService.EditStudent(student), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }

                return;
            }

            if (MessageBox.Show($"Bạn có muốn thêm mới sinh viên {student.Name} có mã {student.MaSv} không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(_studentService.AddStudent(student), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var student = GetDataFromGui();
            if (student == null)
            {
                MessageBox.Show("Kiểm tra lại dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            student.Id = _idWhenClick;
            student.MaSv = lblMaSv.Text;
            if (MessageBox.Show($"Bạn có muốn xóa sinh viên {student.Name} có mã {student.MaSv} không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_studentService.DeleteStudent(student), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void ptboxImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "*.PNG, *.JPG | *.png; *.jpg";
            dlg.Title = "Chọn ảnh đại diện";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileLocaton = dlg.FileName;
                ptboxImage.Image = Image.FromFile(fileLocaton);
            }
        }

        private void DisableControls()
        {
            foreach (Control crt in panInfo.Controls)
            {
                if (crt is TextBox)
                {
                    crt.Enabled = false;
                }
            }
        }

        private void EnableControls()
        {
            foreach (Control crt in panInfo.Controls)
            {
                crt.Enabled = true;
            }
        }

        private void ClearForm()
        {
            foreach (Control crt in panInfo.Controls)
            {
                if (crt is TextBox)
                {
                    crt.Text = "";
                }

                if (crt is RadioButton)
                {
                    ((RadioButton)crt).Checked = false;
                }

                if (crt.Name == "lblMaSv")
                {
                    crt.Text = "";
                }
            }
            ptboxImage.Image = null;
        }

        private byte[]? ImageToBytes(Image img)
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                byte[] bytes = (byte[])converter.ConvertTo(img, typeof(byte[]));
                return bytes;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private Image? ByteToImage(byte[] bytes)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    Image img = Image.FromStream(ms);
                    return img;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool ValidateForm()
        {
            bool isTrue = true;
            foreach (Control crt in panInfo.Controls)
            {
                if (crt is TextBox)
                {
                    switch (crt.Name)
                    {
                        case "txtName":
                            if (!Utilities.Alphabectic(crt.Text))
                            {
                                _errorProvider.SetError(crt, "Không nhập ký tự đặc biệt và số");
                                isTrue = false;
                            }
                            break;
                        case "txtPhone":
                            if (!Utilities.IsPhoneNumber(crt.Text))
                            {
                                _errorProvider.SetError(crt, "Chỉ được nhập ký tự số và có 10-12 số");
                                isTrue = false;
                            }
                            break;
                        case "txtEmail":
                            if (!Utilities.IsEmail(crt.Text))
                            {
                                _errorProvider.SetError(crt, "Sai định dạng Email");
                                isTrue = false;
                            }
                            break;
                    }

                    if (string.IsNullOrEmpty(crt.Text))
                    {
                        _errorProvider.SetError(crt, "Không để trống dữ liệu");
                        isTrue = false;
                    }
                }

            }

            return isTrue;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            _errorProvider.SetError((TextBox)sender, null);
        }


        private void FrmStudentService_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình không", "Hỏi", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void FrmStudentService_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isExit) 
                Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            isExit = false;
            if (MessageBox.Show("Bạn có muốn đăng xuất tài khoản không?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Close();
            }
        }
    }
}