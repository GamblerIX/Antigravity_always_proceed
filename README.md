# AlwaysProceed

AlwaysProceed 是一个简单的 WPF 应用程序，旨在后台每秒自动触发一次 `Alt + Enter` 按键组合。

## 功能

- 后台自动点击 `Alt + Enter`。
- 使用 ModernWpf 风格的界面。
- 可开关控制。

## 构建与发布

项目使用 GitHub Actions 进行自动构建和发布。
当推送标签（例如 `v1.0.0`）时，会自动创建 Release 并上传二进制文件和安装包。

### 本地编译

需要安装 .NET 8 SDK。

```powershell
dotnet publish AlwaysProceed.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:PublishReadyToRun=true
```
