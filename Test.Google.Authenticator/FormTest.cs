using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Authenticator;
using QRCoder;

namespace Test.Google.Authenticator
{
    public partial class FormTest : Form
    {
        TwoFactorAuthenticator totp = new TwoFactorAuthenticator();

        public FormTest()
        {
            InitializeComponent();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            txtKey.Text = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            SetupCode sc = totp.GenerateSetupCode(txtIssuer.Text, txtUser.Text, txtKey.Text, 300, 300);

            //使用Google API 生成 QR
            //pictureBox1.ImageLocation = sc.QrCodeSetupImageUrl;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(sc.QrCodeSetupUrl, QRCodeGenerator.ECCLevel.L);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            pictureBoxQR.Image = qrCodeImage;
            pictureBoxQR.SizeMode = PictureBoxSizeMode.Zoom;

            lblAPI.Text = "图像API地址" + sc.QrCodeSetupImageUrl;
            lblQRAddr.Text = "令牌(二维码地址)" + sc.QrCodeSetupUrl;

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            lblResult.Text = "验证结果:" + totp.ValidateTwoFactorPIN(txtKey.Text, textBox2.Text).ToString();
        }
    }
}
