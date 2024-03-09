namespace MobileStore.GUI
{
    partial class accountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountForm));
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            txtAccName2 = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            txtPass = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            txtAccID = new TextBox();
            label6 = new Label();
            panel8 = new Panel();
            button1 = new Button();
            cmbPermission = new ComboBox();
            label7 = new Label();
            panel9 = new Panel();
            btnChangeAccount = new Button();
            cmbEmpID = new ComboBox();
            panel2 = new Panel();
            txtAccName = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ABC = new Label();
            panel1 = new Panel();
            lsvAccount = new ListView();
            btnExportEcel = new Button();
            panel11 = new Panel();
            groupBox14 = new GroupBox();
            groupBox17 = new GroupBox();
            txtContent = new TextBox();
            groupBox18 = new GroupBox();
            cmbTypeSearch = new ComboBox();
            btnSearch = new Button();
            btnClear = new Button();
            panel10 = new Panel();
            label8 = new Label();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel11.SuspendLayout();
            groupBox14.SuspendLayout();
            groupBox17.SuspendLayout();
            groupBox18.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.Tomato;
            btnDeleteAccount.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteAccount.ForeColor = SystemColors.ControlLightLight;
            btnDeleteAccount.Location = new Point(896, 487);
            btnDeleteAccount.Margin = new Padding(3, 4, 3, 4);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(101, 53);
            btnDeleteAccount.TabIndex = 8;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = Color.Tomato;
            btnAddAccount.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddAccount.ForeColor = SystemColors.ControlLightLight;
            btnAddAccount.Location = new Point(484, 487);
            btnAddAccount.Margin = new Padding(3, 4, 3, 4);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(101, 53);
            btnAddAccount.TabIndex = 6;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // txtAccName2
            // 
            txtAccName2.Location = new Point(154, 11);
            txtAccName2.Margin = new Padding(2, 3, 2, 3);
            txtAccName2.Name = "txtAccName2";
            txtAccName2.Size = new Size(342, 27);
            txtAccName2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 0;
            label2.Text = "Tên tài khoản:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtAccName2);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(8, 61);
            panel4.Margin = new Padding(2, 3, 2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(668, 43);
            panel4.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(154, 9);
            txtPass.Margin = new Padding(2, 3, 2, 3);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(342, 27);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtPass);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(8, 109);
            panel5.Margin = new Padding(2, 3, 2, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(668, 43);
            panel5.TabIndex = 2;
            // 
            // txtAccID
            // 
            txtAccID.Enabled = false;
            txtAccID.Location = new Point(154, 10);
            txtAccID.Margin = new Padding(2, 3, 2, 3);
            txtAccID.Name = "txtAccID";
            txtAccID.Size = new Size(171, 27);
            txtAccID.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 9);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 28);
            label6.TabIndex = 0;
            label6.Text = "ID:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtAccID);
            panel8.Controls.Add(button1);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(8, 15);
            panel8.Margin = new Padding(2, 3, 2, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(668, 43);
            panel8.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(405, 6);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 10;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbPermission
            // 
            cmbPermission.FormattingEnabled = true;
            cmbPermission.Location = new Point(155, 12);
            cmbPermission.Name = "cmbPermission";
            cmbPermission.Size = new Size(151, 28);
            cmbPermission.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(10, 9);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 28);
            label7.TabIndex = 0;
            label7.Text = "Quyền:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cmbPermission);
            panel9.Controls.Add(label7);
            panel9.Location = new Point(792, 25);
            panel9.Margin = new Padding(2, 3, 2, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(418, 43);
            panel9.TabIndex = 3;
            // 
            // btnChangeAccount
            // 
            btnChangeAccount.BackColor = Color.Tomato;
            btnChangeAccount.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeAccount.ForeColor = SystemColors.ControlLightLight;
            btnChangeAccount.Location = new Point(681, 487);
            btnChangeAccount.Margin = new Padding(3, 4, 3, 4);
            btnChangeAccount.Name = "btnChangeAccount";
            btnChangeAccount.Size = new Size(101, 53);
            btnChangeAccount.TabIndex = 7;
            btnChangeAccount.Text = "Sửa";
            btnChangeAccount.UseVisualStyleBackColor = false;
            btnChangeAccount.Click += btnChangeAccount_Click;
            // 
            // cmbEmpID
            // 
            cmbEmpID.FormattingEnabled = true;
            cmbEmpID.Location = new Point(155, 11);
            cmbEmpID.Margin = new Padding(2, 3, 2, 3);
            cmbEmpID.Name = "cmbEmpID";
            cmbEmpID.Size = new Size(154, 28);
            cmbEmpID.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Controls.Add(txtAccName);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(ABC);
            panel2.Location = new Point(2, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1277, 85);
            panel2.TabIndex = 24;
            // 
            // txtAccName
            // 
            txtAccName.AutoSize = true;
            txtAccName.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAccName.ForeColor = SystemColors.ControlLightLight;
            txtAccName.Location = new Point(179, 24);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(156, 32);
            txtAccName.TabIndex = 29;
            txtAccName.Text = "Acc Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1217, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.phone;
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // ABC
            // 
            ABC.AutoSize = true;
            ABC.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            ABC.ForeColor = SystemColors.ActiveCaptionText;
            ABC.Location = new Point(593, 24);
            ABC.Name = "ABC";
            ABC.Size = new Size(237, 40);
            ABC.TabIndex = 0;
            ABC.Text = "Alpha Mobile";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDeleteAccount);
            panel1.Controls.Add(btnAddAccount);
            panel1.Controls.Add(btnChangeAccount);
            panel1.Controls.Add(lsvAccount);
            panel1.Controls.Add(btnExportEcel);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(8, 102);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 561);
            panel1.TabIndex = 25;
            // 
            // lsvAccount
            // 
            lsvAccount.Location = new Point(8, 188);
            lsvAccount.Name = "lsvAccount";
            lsvAccount.Size = new Size(668, 270);
            lsvAccount.TabIndex = 26;
            lsvAccount.UseCompatibleStateImageBehavior = false;
            lsvAccount.SelectedIndexChanged += lsvAccount_SelectedIndexChanged;
            // 
            // btnExportEcel
            // 
            btnExportEcel.BackColor = Color.Tomato;
            btnExportEcel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportEcel.ForeColor = SystemColors.ControlLightLight;
            btnExportEcel.Location = new Point(1017, 371);
            btnExportEcel.Margin = new Padding(3, 4, 3, 4);
            btnExportEcel.Name = "btnExportEcel";
            btnExportEcel.Size = new Size(120, 55);
            btnExportEcel.TabIndex = 25;
            btnExportEcel.Text = "Xuất Excel";
            btnExportEcel.UseVisualStyleBackColor = false;
            btnExportEcel.Click += btnExportEcel_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(groupBox14);
            panel11.Controls.Add(btnSearch);
            panel11.Location = new Point(783, 167);
            panel11.Margin = new Padding(2, 3, 2, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(469, 187);
            panel11.TabIndex = 5;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(groupBox17);
            groupBox14.Controls.Add(groupBox18);
            groupBox14.Location = new Point(14, 4);
            groupBox14.Margin = new Padding(3, 4, 3, 4);
            groupBox14.Name = "groupBox14";
            groupBox14.Padding = new Padding(3, 4, 3, 4);
            groupBox14.Size = new Size(408, 99);
            groupBox14.TabIndex = 12;
            groupBox14.TabStop = false;
            groupBox14.Text = "Tìm kiếm";
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(txtContent);
            groupBox17.Location = new Point(222, 28);
            groupBox17.Margin = new Padding(3, 4, 3, 4);
            groupBox17.Name = "groupBox17";
            groupBox17.Padding = new Padding(3, 4, 3, 4);
            groupBox17.Size = new Size(163, 61);
            groupBox17.TabIndex = 2;
            groupBox17.TabStop = false;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(27, 24);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(114, 27);
            txtContent.TabIndex = 1;
            // 
            // groupBox18
            // 
            groupBox18.Controls.Add(cmbTypeSearch);
            groupBox18.Location = new Point(10, 24);
            groupBox18.Margin = new Padding(3, 4, 3, 4);
            groupBox18.Name = "groupBox18";
            groupBox18.Padding = new Padding(3, 4, 3, 4);
            groupBox18.Size = new Size(166, 67);
            groupBox18.TabIndex = 1;
            groupBox18.TabStop = false;
            // 
            // cmbTypeSearch
            // 
            cmbTypeSearch.FormattingEnabled = true;
            cmbTypeSearch.Location = new Point(13, 21);
            cmbTypeSearch.Margin = new Padding(3, 4, 3, 4);
            cmbTypeSearch.Name = "cmbTypeSearch";
            cmbTypeSearch.Size = new Size(138, 28);
            cmbTypeSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Tomato;
            btnSearch.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(14, 109);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 53);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Tomato;
            btnClear.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(884, 371);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 53);
            btnClear.TabIndex = 20;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(cmbEmpID);
            panel10.Controls.Add(label8);
            panel10.Location = new Point(792, 71);
            panel10.Margin = new Padding(2, 3, 2, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(418, 43);
            panel10.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(10, 9);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(146, 28);
            label8.TabIndex = 0;
            label8.Text = "Mã nhân viên:";
            // 
            // accountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 675);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "accountForm";
            Text = "accountForm";
            FormClosing += accountForm_FormClosing;
            Load += accountForm_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel11.ResumeLayout(false);
            groupBox14.ResumeLayout(false);
            groupBox17.ResumeLayout(false);
            groupBox17.PerformLayout();
            groupBox18.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private TextBox txtAccName2;
        private Label label2;
        private Panel panel4;
        private TextBox txtPass;
        private Label label3;
        private Panel panel5;
        private TextBox txtAccID;
        private Label label6;
        private Panel panel8;
        private ComboBox cmbPermission;
        private Label label7;
        private Panel panel9;
        private Button btnChangeAccount;
        private ComboBox cmbEmpID;
        private Panel panel2;
        private Label ABC;
        private Panel panel1;
        private Button btnExportEcel;
        private Panel panel11;
        private GroupBox groupBox14;
        private GroupBox groupBox17;
        private TextBox txtContent;
        private GroupBox groupBox18;
        private ComboBox cmbTypeSearch;
        private Button btnSearch;
        private Button btnClear;
        private Panel panel10;
        private Label label8;
        private ListView lsvAccount;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label txtAccName;
        private Button button1;
    }
}