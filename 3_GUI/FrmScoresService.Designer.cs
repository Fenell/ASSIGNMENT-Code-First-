namespace _3_GUI
{
    partial class FrmScoresService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panScores = new System.Windows.Forms.Panel();
            this.txtAgile = new System.Windows.Forms.TextBox();
            this.txtSqlServer = new System.Windows.Forms.TextBox();
            this.txtCSharp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMaSv = new System.Windows.Forms.Label();
            this.lblAvgScores = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvScores = new System.Windows.Forms.DataGridView();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panScores.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(56, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã SV";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(122, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(363, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 35);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panScores
            // 
            this.panScores.Controls.Add(this.txtAgile);
            this.panScores.Controls.Add(this.txtSqlServer);
            this.panScores.Controls.Add(this.txtCSharp);
            this.panScores.Controls.Add(this.label4);
            this.panScores.Controls.Add(this.label3);
            this.panScores.Controls.Add(this.lblName);
            this.panScores.Controls.Add(this.lblMaSv);
            this.panScores.Controls.Add(this.lblAvgScores);
            this.panScores.Controls.Add(this.label7);
            this.panScores.Controls.Add(this.label6);
            this.panScores.Controls.Add(this.label5);
            this.panScores.Controls.Add(this.label2);
            this.panScores.Location = new System.Drawing.Point(12, 122);
            this.panScores.Name = "panScores";
            this.panScores.Size = new System.Drawing.Size(367, 215);
            this.panScores.TabIndex = 2;
            // 
            // txtAgile
            // 
            this.txtAgile.Location = new System.Drawing.Point(124, 174);
            this.txtAgile.Name = "txtAgile";
            this.txtAgile.Size = new System.Drawing.Size(100, 23);
            this.txtAgile.TabIndex = 1;
            this.txtAgile.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtAgile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtAgile.Validating += new System.ComponentModel.CancelEventHandler(this.txtAgile_Validating);
            // 
            // txtSqlServer
            // 
            this.txtSqlServer.Location = new System.Drawing.Point(124, 130);
            this.txtSqlServer.Name = "txtSqlServer";
            this.txtSqlServer.Size = new System.Drawing.Size(100, 23);
            this.txtSqlServer.TabIndex = 1;
            this.txtSqlServer.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtSqlServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtSqlServer.Validating += new System.ComponentModel.CancelEventHandler(this.txtSqlServer_Validating);
            // 
            // txtCSharp
            // 
            this.txtCSharp.Location = new System.Drawing.Point(124, 86);
            this.txtCSharp.Name = "txtCSharp";
            this.txtCSharp.Size = new System.Drawing.Size(100, 23);
            this.txtCSharp.TabIndex = 1;
            this.txtCSharp.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtCSharp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtCSharp.Validating += new System.ComponentModel.CancelEventHandler(this.txtCSharp_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Agile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "SqlServer";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(124, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblMaSv
            // 
            this.lblMaSv.AutoSize = true;
            this.lblMaSv.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaSv.ForeColor = System.Drawing.Color.Blue;
            this.lblMaSv.Location = new System.Drawing.Point(124, 55);
            this.lblMaSv.Name = "lblMaSv";
            this.lblMaSv.Size = new System.Drawing.Size(41, 17);
            this.lblMaSv.TabIndex = 0;
            this.lblMaSv.Text = "label1";
            // 
            // lblAvgScores
            // 
            this.lblAvgScores.AutoSize = true;
            this.lblAvgScores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvgScores.ForeColor = System.Drawing.Color.Red;
            this.lblAvgScores.Location = new System.Drawing.Point(279, 130);
            this.lblAvgScores.Name = "lblAvgScores";
            this.lblAvgScores.Size = new System.Drawing.Size(57, 21);
            this.lblAvgScores.TabIndex = 0;
            this.lblAvgScores.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(278, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điểm TB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "C#3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Location = new System.Drawing.Point(419, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 215);
            this.panel2.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::_3_GUI.Properties.Resources.update_icon;
            this.btnUpdate.Location = new System.Drawing.Point(25, 154);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 38);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::_3_GUI.Properties.Resources.delete_icon;
            this.btnDelete.Location = new System.Drawing.Point(25, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 38);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::_3_GUI.Properties.Resources.Save_icon__1_;
            this.btnSave.Location = new System.Drawing.Point(25, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::_3_GUI.Properties.Resources.Button_Add_icon__1_;
            this.btnNew.Location = new System.Drawing.Point(25, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 38);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvScores
            // 
            this.dgvScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScores.Location = new System.Drawing.Point(12, 389);
            this.dgvScores.Name = "dgvScores";
            this.dgvScores.ReadOnly = true;
            this.dgvScores.RowTemplate.Height = 25;
            this.dgvScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScores.Size = new System.Drawing.Size(602, 163);
            this.dgvScores.TabIndex = 3;
            this.dgvScores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScores_CellClick);
            this.dgvScores.SelectionChanged += new System.EventHandler(this.dgvScores_SelectionChanged);
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(27, 343);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(75, 23);
            this.btnTop.TabIndex = 4;
            this.btnTop.Text = "<<";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(102, 343);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "<";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(178, 343);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.Location = new System.Drawing.Point(259, 343);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(75, 23);
            this.btnBottom.TabIndex = 4;
            this.btnBottom.Text = ">>";
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(539, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmScoresService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 565);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.dgvScores);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panScores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmScoresService";
            this.Text = "FrmScoresService";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmScoresService_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmScoresService_FormClosed);
            this.Load += new System.EventHandler(this.FrmScoresService_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panScores.ResumeLayout(false);
            this.panScores.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Panel panScores;
        private TextBox txtAgile;
        private TextBox txtSqlServer;
        private TextBox txtCSharp;
        private Label label4;
        private Label label3;
        private Label lblMaSv;
        private Label lblAvgScores;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Panel panel2;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnNew;
        private DataGridView dgvScores;
        private Label lblName;
        private Label label9;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnTop;
        private Button btnPreview;
        private Button btnNext;
        private Button btnBottom;
        private Button btnLogout;
    }
}