> 代码为个人贡献，非官方
# Google.Authenticator For .NET

## 介绍
基于TOTP([RFC 6238](https://tools.ietf.org/html/rfc6238?spm=a2c4g.11186623.2.5.hWkX4D))协议实现Google Authenticator 双因子（2FA two-factor authentication）认证。

## 项目由来

本项目并非原创
而是基于[BrandonPotter/GoogleAuthenticator](https://github.com/BrandonPotter/GoogleAuthenticator)修改而来，仅作少量修改。二维码生成部分使用[codebude/QRCoder](https://github.com/codebude/QRCoder)技术

## 原理

原理参考请[点击](https://www.csdn.net/article/2014-09-23/2821808-Google-Authenticator)这里

## 使用方法

生成二维码
```
TwoFactorAuthenticator totp = new TwoFactorAuthenticator();
SetupCode sc = totp.GenerateSetupCode("ISSUER", "USER", "KEY", 300, 300);

var imageURL = sc.QrCodeSetupImageUrl;
```

验证PIN码
```
bool result = totp.ValidateTwoFactorPIN("KEY", "PIN")
```

## 其他

客户端建议使用官方应用或自行实现

