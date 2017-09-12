namespace ClearFile
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.gb = new System.Windows.Forms.GroupBox();
            this.cbxHS = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Aras = new System.Windows.Forms.GroupBox();
            this.btnGetDB = new System.Windows.Forms.Button();
            this.cmbDB = new System.Windows.Forms.ComboBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.FB = new System.Windows.Forms.FolderBrowserDialog();
            this.RB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.Aras.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(-2, 7);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(79, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "文件仓库路径";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(84, 3);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(310, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(400, 1);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(42, 23);
            this.btnSelectPath.TabIndex = 2;
            this.btnSelectPath.Text = "选择";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // gb
            // 
            this.gb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb.Controls.Add(this.cbxHS);
            this.gb.Controls.Add(this.btnClear);
            this.gb.Controls.Add(this.lblClear);
            this.gb.Controls.Add(this.lblError);
            this.gb.Controls.Add(this.lblFileCount);
            this.gb.Controls.Add(this.btnExec);
            this.gb.Controls.Add(this.label1);
            this.gb.Controls.Add(this.label7);
            this.gb.Controls.Add(this.label2);
            this.gb.Location = new System.Drawing.Point(1, 206);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(441, 181);
            this.gb.TabIndex = 3;
            this.gb.TabStop = false;
            this.gb.Text = "统计数据";
            // 
            // cbxHS
            // 
            this.cbxHS.AutoSize = true;
            this.cbxHS.Location = new System.Drawing.Point(24, 155);
            this.cbxHS.Name = "cbxHS";
            this.cbxHS.Size = new System.Drawing.Size(74, 17);
            this.cbxHS.TabIndex = 6;
            this.cbxHS.Text = "永久删除";
            this.cbxHS.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(24, 111);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 38);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "开始清理";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(221, 32);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(13, 13);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "0";
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(96, 32);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(13, 13);
            this.lblFileCount.TabIndex = 0;
            this.lblFileCount.Text = "0";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(24, 67);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(144, 38);
            this.btnExec.TabIndex = 4;
            this.btnExec.Text = "扫描垃圾";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "无效文件个数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件个数";
            // 
            // Aras
            // 
            this.Aras.Controls.Add(this.btnGetDB);
            this.Aras.Controls.Add(this.cmbDB);
            this.Aras.Controls.Add(this.btnlogin);
            this.Aras.Controls.Add(this.label6);
            this.Aras.Controls.Add(this.label5);
            this.Aras.Controls.Add(this.label4);
            this.Aras.Controls.Add(this.label3);
            this.Aras.Controls.Add(this.txtPwd);
            this.Aras.Controls.Add(this.txtUserName);
            this.Aras.Controls.Add(this.txtURL);
            this.Aras.Location = new System.Drawing.Point(1, 27);
            this.Aras.Name = "Aras";
            this.Aras.Size = new System.Drawing.Size(441, 173);
            this.Aras.TabIndex = 5;
            this.Aras.TabStop = false;
            this.Aras.Text = "Aras Innovator";
            // 
            // btnGetDB
            // 
            this.btnGetDB.Location = new System.Drawing.Point(410, 59);
            this.btnGetDB.Name = "btnGetDB";
            this.btnGetDB.Size = new System.Drawing.Size(24, 23);
            this.btnGetDB.TabIndex = 5;
            this.btnGetDB.Text = ".";
            this.btnGetDB.UseVisualStyleBackColor = true;
            this.btnGetDB.Click += new System.EventHandler(this.btnGetDB_Click);
            // 
            // cmbDB
            // 
            this.cmbDB.FormattingEnabled = true;
            this.cmbDB.Location = new System.Drawing.Point(83, 56);
            this.cmbDB.Name = "cmbDB";
            this.cmbDB.Size = new System.Drawing.Size(321, 21);
            this.cmbDB.TabIndex = 2;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(160, 141);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(144, 28);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "登录";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "数据库";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "URL";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(82, 115);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(322, 20);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.Text = "innovator";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(82, 87);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(322, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "admin";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(82, 26);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(322, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://localhost/innovatorServer";
            // 
            // RB
            // 
            this.RB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RB.BackColor = System.Drawing.Color.Black;
            this.RB.ForeColor = System.Drawing.Color.White;
            this.RB.HideSelection = false;
            this.RB.Location = new System.Drawing.Point(448, 3);
            this.RB.Name = "RB";
            this.RB.Size = new System.Drawing.Size(364, 384);
            this.RB.TabIndex = 6;
            this.RB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "已清除个数";
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Location = new System.Drawing.Point(357, 32);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(13, 13);
            this.lblClear.TabIndex = 0;
            this.lblClear.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 387);
            this.Controls.Add(this.RB);
            this.Controls.Add(this.Aras);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Name = "frmMain";
            this.Text = "垃圾文件清理";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.Aras.ResumeLayout(false);
            this.Aras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Aras;
        private System.Windows.Forms.Button btnGetDB;
        private System.Windows.Forms.ComboBox cmbDB;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.FolderBrowserDialog FB;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RB;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbxHS;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Label label1;
    }
}

