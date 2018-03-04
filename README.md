# ZmopSharp: 芝麻信用开放平台 SDK

[![AppVeyor](https://img.shields.io/appveyor/ci/JoyMoe/zmopsharp.svg)](https://ci.appveyor.com/project/JoyMoe/zmopsharp)
[![Travis](https://img.shields.io/travis/JoyMoe/ZmopSharp.svg)](https://travis-ci.org/JoyMoe/ZmopSharp)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://raw.githubusercontent.com/JoyMoe/ZmopSharp/master/LICENSE)
![net452](https://img.shields.io/badge/.Net-4.5.2-brightgreen.svg)
![net462](https://img.shields.io/badge/.Net-4.6.2-brightgreen.svg)
![netstandard1.3](https://img.shields.io/badge/.Net-netstandard1.3-brightgreen.svg)
![netstandard2.0](https://img.shields.io/badge/.Net-netstandard2.0-brightgreen.svg)

| 包                       | 发行构建                                     | 开发构建                                     | 下载                                       |
| ----------------------- | ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| ZmopSharp.Core          | [![NuGet](https://img.shields.io/nuget/v/ZmopSharp.Core.svg)](https://www.nuget.org/packages/ZmopSharp.Core) | [![NuGet](https://img.shields.io/nuget/vpre/ZmopSharp.Core.svg)](https://www.nuget.org/packages/ZmopSharp.Core/absoluteLatest) | [![NuGet](https://img.shields.io/nuget/dt/ZmopSharp.Core.svg)](https://www.nuget.org/packages/ZmopSharp.Core) |
| ZmopSharp.Authorization | [![NuGet](https://img.shields.io/nuget/v/ZmopSharp.Authorization.svg)](https://www.nuget.org/packages/ZmopSharp.Authorization) | [![NuGet](https://img.shields.io/nuget/vpre/ZmopSharp.Authorization.svg)](https://www.nuget.org/packages/ZmopSharp.Authorization/absoluteLatest) | [![NuGet](https://img.shields.io/nuget/dt/ZmopSharp.Authorization.svg)](https://www.nuget.org/packages/ZmopSharp.Authorization) |
| ZmopSharp.Certification | [![NuGet](https://img.shields.io/nuget/v/ZmopSharp.Certification.svg)](https://www.nuget.org/packages/ZmopSharp.Certification) | [![NuGet](https://img.shields.io/nuget/vpre/ZmopSharp.Certification.svg)](https://www.nuget.org/packages/ZmopSharp.Certification/absoluteLatest) | [![NuGet](https://img.shields.io/nuget/dt/ZmopSharp.Certification.svg)](https://www.nuget.org/packages/ZmopSharp.Certification) |
| ZmopSharp.Score         | [![NuGet](https://img.shields.io/nuget/v/ZmopSharp.Score.svg)](https://www.nuget.org/packages/ZmopSharp.Score) | [![NuGet](https://img.shields.io/nuget/vpre/ZmopSharp.Score.svg)](https://www.nuget.org/packages/ZmopSharp.Score/absoluteLatest) | [![NuGet](https://img.shields.io/nuget/dt/ZmopSharp.Score.svg)](https://www.nuget.org/packages/ZmopSharp.Score) |

## 安装

使用 Package Manager Console 或 Nuget.

```powershell
PM> Install-Package ZmopSharp.Core
PM> Install-Package ZmopSharp.Authorization
PM> Install-Package ZmopSharp.Certification
PM> Install-Package ZmopSharp.Score
```

## 功能

* [x] 核心实现（ZmopSharp.Core）
      * [x] 客户端（Client）
      * [x] 加密解密（Encryption）
      * [x] 请求（Request）
      * [x] 异常（Exception）
* [x] 芝麻授权（ZmopSharp.Authorization）
      * [x] 页面授权
      * [x] 授权查询
* [x] 芝麻认证（ZmopSharp.Certification）
      * [x] 初始化
      * [x] 开始认证
      * [x] 认证查询
* [x] 芝麻评分（ZmopSharp.Score）
      * [x] 信用评分
      * [x] 信用评分普惠版
* [ ] 数据反馈（ZmopSharp.Feedback）
      * [ ] 批量反馈
      * [ ] 反馈模板
* [ ] 芝麻IVS（ZmopSharp.Ivs）
      * [ ] 欺诈评分
      * [ ] 信息验证
      * [ ] 关注清单
* [ ] 行业关注（ZmopSharp.Watchlist）
      * [ ] 关注名单
      * [ ] 关注名单普惠版

## 协议

The MIT License

详见 [LICENSE](LICENSE).
