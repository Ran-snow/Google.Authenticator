namespace Test.Google.Authenticator
{
    partial class FormTest
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
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.btnGenerateQR = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAPI = new System.Windows.Forms.Label();
            this.lblQRAddr = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtIssuer = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Location = new System.Drawing.Point(2, 12);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxQR.TabIndex = 0;
            this.pictureBoxQR.TabStop = false;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(330, 78);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(152, 21);
            this.txtKey.TabIndex = 1;
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(488, 78);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateKey.TabIndex = 2;
            this.btnGenerateKey.Text = "生成Key";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Location = new System.Drawing.Point(488, 118);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateQR.TabIndex = 3;
            this.btnGenerateQR.Text = "生成二维码";
            this.btnGenerateQR.UseVisualStyleBackColor = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 21);
            this.textBox2.TabIndex = 4;
            // 
            // lblAPI
            // 
            this.lblAPI.AutoSize = true;
            this.lblAPI.Location = new System.Drawing.Point(12, 327);
            this.lblAPI.Name = "lblAPI";
            this.lblAPI.Size = new System.Drawing.Size(71, 12);
            this.lblAPI.TabIndex = 5;
            this.lblAPI.Text = "图像API地址";
            // 
            // lblQRAddr
            // 
            this.lblQRAddr.AutoSize = true;
            this.lblQRAddr.Location = new System.Drawing.Point(12, 349);
            this.lblQRAddr.Name = "lblQRAddr";
            this.lblQRAddr.Size = new System.Drawing.Size(101, 12);
            this.lblQRAddr.TabIndex = 6;
            this.lblQRAddr.Text = "令牌(二维码地址)";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 374);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 12);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "验证结果";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(488, 155);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 8;
            this.btnValidate.Text = "验证";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtIssuer
            // 
            this.txtIssuer.Location = new System.Drawing.Point(330, 47);
            this.txtIssuer.Name = "txtIssuer";
            this.txtIssuer.Size = new System.Drawing.Size(152, 21);
            this.txtIssuer.TabIndex = 9;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(330, 20);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(152, 21);
            this.txtUser.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "公司名";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtIssuer);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblQRAddr);
            this.Controls.Add(this.lblAPI);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnGenerateQR);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.pictureBoxQR);
            this.Name = "FormTest";
            this.Text = "测试";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Button btnGenerateQR;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAPI;
        private System.Windows.Forms.Label lblQRAddr;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtIssuer;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

