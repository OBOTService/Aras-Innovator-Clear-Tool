using Aras.IOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClearFile
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static Innovator inn = null;
        public static HttpServerConnection connection = null;

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if( FB.ShowDialog() ==  DialogResult.OK)
            {
                txtPath.Text = FB.SelectedPath;
            }
        }

        private void getDir(DirectoryInfo dir,ref int dircount,ref int count )
        {
            dircount += dir.GetDirectories().Count();
            foreach (DirectoryInfo NextFolder in dir.GetDirectories())
            {
                count += getFileCount(NextFolder);
                if (NextFolder.GetDirectories().Count() > 0)
                {
                    getDir(NextFolder,ref dircount, ref count);
                }
            }
        }

        private int getFileCount(DirectoryInfo dir)
        {
            return dir.GetFiles().Count();
        }

        private void btnGetDB_Click(object sender, EventArgs e)
        {
            string strServerURL = txtURL.Text;
            if (string.IsNullOrEmpty(strServerURL)) { return; }

            cmbDB.Items.Clear();
            string[] dbs = GetDataBase(strServerURL);
            foreach (var item in dbs)
            {
                cmbDB.Items.Add(item);
            }

            if (cmbDB.Items.Count > 0) { cmbDB.SelectedIndex = 0; }
        }

        public static string[] GetDataBase(string pServerURL)
        {
            return IomFactory.CreateHttpServerConnection(pServerURL).GetDatabases();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string strServerURL = txtURL.Text;
            if (string.IsNullOrEmpty(strServerURL)) {return; }

            string strDB = cmbDB.Text;
            if (string.IsNullOrEmpty(strDB)) {  return; }

            string strUserName = txtUserName.Text;
            if (string.IsNullOrEmpty(strUserName)) {return; }

            string strPassword = txtPwd.Text;
            if (string.IsNullOrEmpty(strPassword)) { return; }

            string strError = "";
            if (!LogIn(strServerURL, strDB, strUserName, strPassword, ref strError))
            {
                MessageBox.Show("Aras Login Error," + strError);
                return;
            }
            MessageBox.Show("Aras Login OK");
        }

        public static bool LogIn(string pUrl, string pDBName, string pUserName, string pPassword, ref string strError)
        {
            try
            {
                connection = IomFactory.CreateHttpServerConnection(pUrl, pDBName, pUserName, pPassword);
                Item result = connection.Login();
                if (result.isError())
                {
                    if (connection != null) { connection.Logout(); }
                    string str = result.getErrorString();
                    int startIndex = (str.IndexOf(":") + 1);
                    if (startIndex > 0) { str = str.Substring(startIndex); }
                    if (str.Contains("Authentication")) { str = "Invalid user or password"; }
                    strError = str;
                    return false;
                }
                else
                {
                    inn = result.getInnovator();
                    return true;
                }
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        List<string> fileList = new List<string>();
        List<string> fileIdList = new List<string>();
        List<string> ErrorfileIdList = new List<string>();
        private void btnExec_Click(object sender, EventArgs e)
        {
            fileList.Clear();
            ErrorfileIdList.Clear();
            fileIdList.Clear();

            Thread thStartAD = new Thread(new ThreadStart(SetADData));
            thStartAD.Start();
        }
        private void SetADData()
        {
            MethodInvoker mi = new MethodInvoker(this.StartExecAD);
            this.BeginInvoke(mi);
        }

        private void StartExecAD()
        {
            btnClear.Enabled = false;
            lblError.Text = "0";
            RB.Clear();

            //获取数据库名称
            string dbName = cmbDB.Text;
            string dbPath = txtPath.Text + "\\" + dbName;
            if (!Directory.Exists(dbPath)) { MessageBox.Show("没有需要处理得数据"); return; }
            DirectoryInfo TheFolder = new DirectoryInfo(dbPath);
            Thread.Sleep(100);
            System.Windows.Forms.Application.DoEvents();
            RB.AppendText("【" + DateTime.Now.ToString() + "】扫描中..."  + "\n");
            foreach (var item in TheFolder.GetDirectories())
            {
                Thread.Sleep(100);
                System.Windows.Forms.Application.DoEvents();
                string fileid = item.Name;
                getFileID(item);
            }
            lblFileCount.Text = fileList.Count.ToString();
            RB.AppendText("【" + DateTime.Now.ToString() + "】扫描完毕，开始整理垃圾数据...,这可能需要几分钟，请耐心等待..." + "\n");
            foreach (var item in fileList)
            {
                Thread.Sleep(100);
                System.Windows.Forms.Application.DoEvents();
                string path = Path.GetDirectoryName(item);
                string id = path.Substring(path.LastIndexOf(cmbDB.Text) + cmbDB.Text.Length).Replace("\\", "");
                Item fileItem = inn.getItemById("File", id);
                if (fileItem.getItemCount() != 1)
                {
                    ErrorfileIdList.Add(item);
                    lblError.Text = ErrorfileIdList.Count.ToString();
                    RB.AppendText("【" + DateTime.Now.ToString() + "】无效文件" + item + "\n");
                }
                fileIdList.Add(id);
            }
            RB.AppendText("【" + DateTime.Now.ToString() + "】整理完毕" + "\n");
            btnClear.Enabled = true;
        }

        private void getFileID(DirectoryInfo dir)
        {
            if (dir.GetDirectories().Count() > 0) {
                foreach (var item in dir.GetDirectories())
                {
                    getFileID(item);
                }
            }
            foreach (var item in dir.GetFiles())
            {
                fileList.Add(item.FullName);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            int count = 0;
            foreach (var item in ErrorfileIdList)
            {
                try
                {
                    RB.AppendText("【" + DateTime.Now.ToString() + "】清除文件" + item + "\n");
                    if (cbxHS.Checked)
                    {
                        Directory.Delete(Path.GetDirectoryName(item), true);
                    }
                    else
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(Path.GetDirectoryName(item),
                        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                        Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin,
                        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
                    }

                    count++;
                    lblClear.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    RB.AppendText("【" + DateTime.Now.ToString() + "】清除异常" + ex.Message + "\n");
                }
                RB.AppendText("【" + DateTime.Now.ToString() + "】清除完毕" + "\n");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
        }
    }
}
