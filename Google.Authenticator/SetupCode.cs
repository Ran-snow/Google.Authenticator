using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Authenticator
{
    /// <summary>
    /// 初始码
    /// </summary>
    public class SetupCode
    {
        /// <summary>
        /// 帐户名
        /// </summary>
        public string Account { get; internal set; }

        /// <summary>
        /// 共享密钥
        /// </summary>
        public string AccountSecretKey { get; internal set; }

        /// <summary>
        /// 手动输入密钥
        /// </summary>
        public string ManualEntryKey { get; internal set; }

        /// <summary>
        /// 二维码地址
        /// </summary>
        public string QrCodeSetupImageUrl { get; internal set; }

        /// <summary>
        /// 二维码内容
        /// </summary>
        public string QrCodeSetupUrl { get; internal set; }
    }
}
