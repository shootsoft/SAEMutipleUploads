/**
 * SAE 批量上传工具 0.1
 * by http://www.shootsoft.net
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Web;

namespace SAE_Mutiple_Uploads
{
    public partial class FormMain : Form
    {
        private string nameSpace;
        private Uri uploadUrl;
        private string localPath;
        private bool isRunning = false;
        private Logger logger;

        #region Form构造销毁
        public FormMain()
        {
            InitializeComponent();
        }

        ~FormMain()
        {
            logger.Dispose();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            logger = new Logger("upload.log");
        } 
        #endregion

        #region 事件
        private void LinkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(LinkLabelAbout.Text);
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                RunUpload();
            }
            else
            {
                StopUplaod();
            }
        }

        private void ButtonLocal_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = TextBoxLocalPath.Text;
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TextBoxLocalPath.Text = fbd.SelectedPath;
                }
            }
        } 
        #endregion

        #region 启动&停止上传
        private void StopUplaod()
        {
            ButtonUpload.Enabled = false;
            isRunning = false;
        }

        private void RunUpload()
        {
            try
            {
                uploadUrl = new Uri(TextBoxUploadUrl.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("上传路径不正确！");
                Debug.WriteLine(ex);
                return;
            }
            nameSpace = TextBoxNamespace.Text;
            localPath = TextBoxLocalPath.Text;
            if (Directory.Exists(localPath))
            {
                string[] files = GetLocal(localPath);
                StatusLabel.Text = string.Format("共计{0}个本地文件", files.Length);
                ButtonUpload.Text = "停止(&S)";
                PanelMain.Enabled = false;
                isRunning = true;
                BackgroundWorkerUploading.RunWorkerAsync(files);
            }
            else
            {
                MessageBox.Show("本地路径不正确！");
            }
        } 
        #endregion

        #region 读取本地文件列表
        private string[] GetLocal(string path)
        {
            List<string> files = new List<string>();
            var dirs = Directory.GetDirectories(path);
            foreach (var item in dirs)
            {
                files.AddRange(GetLocal(item));
            }
            files.AddRange(Directory.GetFiles(path));
            return files.ToArray();
        } 
        #endregion

        #region 上传
        private void Upload(Uri uploadUrl, string nameSpace, string path, string file)
        {
            try
            {
                Uri dest = new Uri(uploadUrl, "?namespace=" + HttpUtility.UrlEncode(nameSpace)
                                        + "&dest=" + HttpUtility.UrlEncode(file.Substring(path.Length+1).Replace("\\","/")));

                using (WebClient wc = new WebClient())
                {
                    byte[] msg = wc.UploadFile(dest, file);
                    logger.Log(Encoding.UTF8.GetString(msg));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        } 
        #endregion

        #region 上传进程
        private void BackgroundWorkerUploading_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] files = e.Argument as string[];
            if (files != null && files.Length > 0)
            {
                for (int i = 0; isRunning && i < files.Length; i++)
                {
                    BackgroundWorkerUploading.ReportProgress((i + 1) * 100 / files.Length, (i + 1));
                    Upload(uploadUrl, nameSpace, localPath ,files[i]);
                }
            }

        }

        private void BackgroundWorkerUploading_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBarUploding.Value = e.ProgressPercentage;
            StatusLabel.Text = string.Format("{0}% 正在上传第{1}个", e.ProgressPercentage, e.UserState);
        }

        private void BackgroundWorkerUploading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (isRunning)
            {
                isRunning = false;
                StatusLabel.Text = "完成！";
            }
            else
            {
                StatusLabel.Text = "用户中断！";
            }
            ButtonUpload.Text = "上传(&U)";
            PanelMain.Enabled = true;
        }
        
        #endregion

    

    }
}
