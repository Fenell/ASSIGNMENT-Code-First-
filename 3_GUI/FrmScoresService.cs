using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL.DomianModels;
using _2_BUS.Service;
using _2_BUS.Utility;
using _2_BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace _3_GUI
{
    public partial class FrmScoresService : Form
    {
        private GradeService _gradeService;
        private StudentService _studentService;
        private ErrorProvider _errorProvider;
        private ScoresService _scoresService;
        private Guid _idGradeWhenClick;
        private Guid _idStudentWhenClick;
        private int _rowIndex;
        private bool _isExit;
        public FrmScoresService()
        {
            InitializeComponent();
            this.CenterToScreen();
            _studentService = new StudentService();
            _gradeService = new GradeService();
            _scoresService = new ScoresService();
            _errorProvider = new ErrorProvider();
            _isExit = true;
            _rowIndex = 0;
            LoadData();
        }

        private void FrmScoresService_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(_studentService.GetMaSvtoList().ToArray());
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoComplete;

        }

        private void LoadData()
        {
            DisableControls();
            dgvScores.ColumnCount = 8;
            dgvScores.Columns[0].Visible = false;
            dgvScores.Columns[1].Name = "Mã SV";
            dgvScores.Columns[2].Name = "Họ tên";
            dgvScores.Columns[2].Width = 120;
            dgvScores.Columns[3].Name = "C#3";
            dgvScores.Columns[4].Name = "Sql Server";
            dgvScores.Columns[5].Name = "Agile";
            dgvScores.Columns[6].Name = "Điểm TB";
            dgvScores.Columns[7].Visible = false;
            dgvScores.Rows.Clear();

            foreach (var x in _scoresService.GetScores())
            {
                //var student = _studentService.GetStudentByMaSv(x.MaSv);
                dgvScores.Rows.Add(x.Grade.Id, x.Grade.MaSv, x.Student.Name, x.Grade.CSharp3, x.Grade.SqlServer, x.Grade.Agile, x.Grade.AvgSores, x.Grade.IdStudent);
            }
        }

        private void dgvScores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _rowIndex = e.RowIndex;
            if (_rowIndex == -1 || _rowIndex == _gradeService.GetScores().Count)
            {
                ResetForm();
                return;
            }

            _idGradeWhenClick = Guid.Parse(dgvScores.Rows[_rowIndex].Cells[0].Value.ToString());
            _idStudentWhenClick = Guid.Parse(dgvScores.Rows[_rowIndex].Cells[7].Value.ToString());

            //var student = _studentService.GetStudentById(_idStudentWhenClick);
            var scores = _scoresService.GetScoresById(_idGradeWhenClick);
            lblName.Text = scores.Student.Name;
            lblMaSv.Text = scores.Grade.MaSv;
            txtCSharp.Text = scores.Grade.CSharp3.ToString();
            txtSqlServer.Text = scores.Grade.SqlServer.ToString();
            txtAgile.Text = scores.Grade.Agile.ToString();
            lblAvgScores.Text = scores.Grade.AvgSores.ToString();
        }

        public Scores GetDataFromGui()
        {
            try
            {
                Scores scores = new Scores();
                scores.Grade = new Grade()
                {
                    Id = Guid.Empty,
                    MaSv = lblMaSv.Text,
                    CSharp3 = double.Parse(txtCSharp.Text),
                    SqlServer = double.Parse(txtSqlServer.Text),
                    Agile = double.Parse(txtAgile.Text),
                    IdStudent = Guid.Empty
                };
                return scores;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableControls();
            ResetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var scores = GetDataFromGui();
            if (scores != null)
            {
                if (_gradeService.HasScores(scores.Grade.MaSv))
                {
                    scores.Grade.Id = _idGradeWhenClick;
                    scores.Grade.IdStudent = _idStudentWhenClick;
                    if (MessageBox.Show($"Bạn có muốn sửa điểm của sinh viên {lblName.Text} không?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show(_scoresService.EditScores(scores), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetForm();
                    }
                    return;
                }

                var student = _studentService.GetStudentByMaSv(lblMaSv.Text);

                if (student == null)
                {
                    MessageBox.Show("Bạn chưa chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                scores.Grade.IdStudent = student.Id;

                if (MessageBox.Show($"Bạn có muốn lưu điểm cho sinh viên {student.Name} không", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(_scoresService.AddScoes(scores), "Thông báo");
                    LoadData();
                    ResetForm();
                }
            }

            else
            {
                MessageBox.Show("Kiểm tra lại dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var scores = GetDataFromGui();

            if (scores == null)
            {
                MessageBox.Show("Kiểm tra lại dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            scores.Grade.Id = _idGradeWhenClick;
            if (MessageBox.Show($"Bạn có muốn xóa điểm của sinh viên {lblName.Text} này không?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(_scoresService.DeleteScores(scores), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var student = _studentService.GetStudentByMaSv(txtSearch.Text);

            if (student == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên", "Thông báo");
                return;
            }
            lblName.Text = student.Name;
            lblMaSv.Text = student.MaSv;

            var scores = _scoresService.GetScoresByMaSv(lblMaSv.Text);

            if (scores == null)
            {
                txtCSharp.Text = txtSqlServer.Text = txtAgile.Text = lblAvgScores.Text = "";
                return;
            }
            txtCSharp.Text = scores.Grade.CSharp3.ToString();
            txtSqlServer.Text = scores.Grade.SqlServer.ToString();
            txtAgile.Text = scores.Grade.Agile.ToString();

        }


        private void DisableControls()
        {
            foreach (Control crt in panScores.Controls)
            {
                if (crt is TextBox)
                {
                    crt.Enabled = false;
                }
            }
        }

        private void EnableControls()
        {
            foreach (Control crt in panScores.Controls)
            {
                if (crt is TextBox)
                {
                    crt.Enabled = true;
                }
            }
        }

        private void ResetForm()
        {
            foreach (Control crt in panScores.Controls)
            {
                if (crt is TextBox)
                {
                    crt.Text = string.Empty;
                }
            }
            lblAvgScores.Text = string.Empty;
            lblMaSv.Text = string.Empty;
            lblName.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }


        private void dgvScores_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            _rowIndex--;
            var lstScores = _scoresService.GetScores();
            if (_rowIndex < 0)
            {
                _rowIndex = lstScores.Count - 1;
            }
            var scores = lstScores[_rowIndex];
            PutDataFromObjToForm(scores);

        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            var lstScores = _scoresService.GetScores();
            var scores = lstScores[0];
            PutDataFromObjToForm(scores);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _rowIndex++;
            var lstScores = _scoresService.GetScores();

            if (_rowIndex > lstScores.Count - 1)
            {
                _rowIndex = 0;
            }

            var scores = lstScores[_rowIndex];
            PutDataFromObjToForm(scores);
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            var lstScores = _scoresService.GetScores();
            _rowIndex = lstScores.Count - 1;
            var scores = lstScores[_rowIndex];
            PutDataFromObjToForm(scores);
        }

        private void txtCSharp_Validating(object sender, CancelEventArgs e)
        {
            if (Utilities.IsScores(txtCSharp.Text))
            {
                if (double.Parse(txtCSharp.Text) < 0 || double.Parse(txtCSharp.Text) > 10)
                {
                    e.Cancel = true;
                    _errorProvider.SetError(txtCSharp, "Nhập điểm trong khoảng 0 - 10");
                }
            }
        }
        private void txtSqlServer_Validating(object sender, CancelEventArgs e)
        {
            if (Utilities.IsScores(txtSqlServer.Text))
            {
                if (double.Parse(txtSqlServer.Text) < 0 || double.Parse(txtSqlServer.Text) > 10)
                {
                    e.Cancel = true;
                    _errorProvider.SetError(txtSqlServer, "Nhập điểm trong khoảng 0 - 10");
                }
            }
        }

        private void txtAgile_Validating(object sender, CancelEventArgs e)
        {
            if (Utilities.IsScores(txtAgile.Text))
            {
                if (double.Parse(txtAgile.Text) < 0 || double.Parse(txtAgile.Text) > 10)
                {
                    e.Cancel = true;
                    _errorProvider.SetError(txtAgile, "Nhập điểm trong khoảng 0 - 10");
                }
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            foreach (Control crt in panScores.Controls)
            {
                if (crt is TextBox)
                {
                    _errorProvider.SetError(crt, null);
                }
            }
        }

        public void PutDataFromObjToForm(Scores scores)
        {
            lblMaSv.Text = scores.Grade.MaSv;
            lblName.Text = scores.Student.Name;
            lblAvgScores.Text = scores.Grade.AvgSores.ToString();
            txtCSharp.Text = scores.Grade.CSharp3.ToString();
            txtSqlServer.Text = scores.Grade.SqlServer.ToString();
            txtAgile.Text = scores.Grade.Agile.ToString();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            _isExit = false;
            if (MessageBox.Show("Bạn có muốn đăng xuất tài khoản không?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Close();
            }
        }



        private void FrmScoresService_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Hỏi", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void FrmScoresService_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_isExit)
                Application.Exit();
        }
    }
}
