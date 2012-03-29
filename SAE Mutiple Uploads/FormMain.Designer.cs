namespace SAE_Mutiple_Uploads
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.BackgroundWorkerUploading = new System.ComponentModel.BackgroundWorker();
            this.ButtonUpload = new System.Windows.Forms.Button();
            this.TextBoxUploadUrl = new System.Windows.Forms.TextBox();
            this.ButtonLocal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNamespace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxLocalPath = new System.Windows.Forms.TextBox();
            this.LinkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBarUploding = new System.Windows.Forms.ToolStripProgressBar();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundWorkerUploading
            // 
            this.BackgroundWorkerUploading.WorkerReportsProgress = true;
            this.BackgroundWorkerUploading.WorkerSupportsCancellation = true;
            this.BackgroundWorkerUploading.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerUploading_DoWork);
            this.BackgroundWorkerUploading.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerUploading_ProgressChanged);
            this.BackgroundWorkerUploading.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerUploading_RunWorkerCompleted);
            // 
            // ButtonUpload
            // 
            this.ButtonUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUpload.Location = new System.Drawing.Point(489, 137);
            this.ButtonUpload.Name = "ButtonUpload";
            this.ButtonUpload.Size = new System.Drawing.Size(75, 36);
            this.ButtonUpload.TabIndex = 1;
            this.ButtonUpload.Text = "上传(&U)";
            this.ButtonUpload.UseVisualStyleBackColor = true;
            this.ButtonUpload.Click += new System.EventHandler(this.ButtonUpload_Click);
            // 
            // TextBoxUploadUrl
            // 
            this.TextBoxUploadUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUploadUrl.Location = new System.Drawing.Point(124, 3);
            this.TextBoxUploadUrl.Name = "TextBoxUploadUrl";
            this.TextBoxUploadUrl.Size = new System.Drawing.Size(417, 21);
            this.TextBoxUploadUrl.TabIndex = 2;
            this.TextBoxUploadUrl.Text = "http://";
            // 
            // ButtonLocal
            // 
            this.ButtonLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLocal.Location = new System.Drawing.Point(517, 75);
            this.ButtonLocal.Name = "ButtonLocal";
            this.ButtonLocal.Size = new System.Drawing.Size(24, 21);
            this.ButtonLocal.TabIndex = 3;
            this.ButtonLocal.Text = "...";
            this.ButtonLocal.UseVisualStyleBackColor = true;
            this.ButtonLocal.Click += new System.EventHandler(this.ButtonLocal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "上传文件接收地址:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "命名空间:";
            // 
            // TextBoxNamespace
            // 
            this.TextBoxNamespace.Location = new System.Drawing.Point(124, 28);
            this.TextBoxNamespace.Name = "TextBoxNamespace";
            this.TextBoxNamespace.Size = new System.Drawing.Size(114, 21);
            this.TextBoxNamespace.TabIndex = 5;
            this.TextBoxNamespace.Text = "wordpress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "本地路径:";
            // 
            // TextBoxLocalPath
            // 
            this.TextBoxLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLocalPath.Location = new System.Drawing.Point(124, 78);
            this.TextBoxLocalPath.Name = "TextBoxLocalPath";
            this.TextBoxLocalPath.Size = new System.Drawing.Size(387, 21);
            this.TextBoxLocalPath.TabIndex = 7;
            // 
            // LinkLabelAbout
            // 
            this.LinkLabelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkLabelAbout.AutoSize = true;
            this.LinkLabelAbout.Location = new System.Drawing.Point(457, 178);
            this.LinkLabelAbout.Name = "LinkLabelAbout";
            this.LinkLabelAbout.Size = new System.Drawing.Size(107, 12);
            this.LinkLabelAbout.TabIndex = 12;
            this.LinkLabelAbout.TabStop = true;
            this.LinkLabelAbout.Text = "www.shootsoft.net";
            this.LinkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAbout_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StatusLabel,
            this.ProgressBarUploding});
            this.statusStrip1.Location = new System.Drawing.Point(0, 200);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "状态";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(32, 17);
            this.StatusLabel.Text = "等待";
            // 
            // ProgressBarUploding
            // 
            this.ProgressBarUploding.Name = "ProgressBarUploding";
            this.ProgressBarUploding.Size = new System.Drawing.Size(300, 16);
            // 
            // PanelMain
            // 
            this.PanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMain.Controls.Add(this.label4);
            this.PanelMain.Controls.Add(this.TextBoxPassword);
            this.PanelMain.Controls.Add(this.TextBoxUploadUrl);
            this.PanelMain.Controls.Add(this.label1);
            this.PanelMain.Controls.Add(this.label2);
            this.PanelMain.Controls.Add(this.ButtonLocal);
            this.PanelMain.Controls.Add(this.TextBoxLocalPath);
            this.PanelMain.Controls.Add(this.TextBoxNamespace);
            this.PanelMain.Controls.Add(this.label3);
            this.PanelMain.Location = new System.Drawing.Point(20, 11);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(544, 109);
            this.PanelMain.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::SAE_Mutiple_Uploads.Properties.Resources.poweredby;
            this.pictureBox1.Location = new System.Drawing.Point(20, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 35);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "密码:";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(124, 53);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(114, 21);
            this.TextBoxPassword.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 222);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LinkLabelAbout);
            this.Controls.Add(this.ButtonUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2000, 260);
            this.MinimumSize = new System.Drawing.Size(600, 260);
            this.Name = "FormMain";
            this.Text = "SAE 批量上传工具 0.2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BackgroundWorkerUploading;
        private System.Windows.Forms.Button ButtonUpload;
        private System.Windows.Forms.TextBox TextBoxUploadUrl;
        private System.Windows.Forms.Button ButtonLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxNamespace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxLocalPath;
        private System.Windows.Forms.LinkLabel LinkLabelAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.ToolStripProgressBar ProgressBarUploding;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxPassword;
    }
}

