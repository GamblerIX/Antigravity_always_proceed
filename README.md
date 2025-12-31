# AlwaysProceed

一个简单的控制台应用程序，每秒自动发送一次 `Alt + Enter` 按键组合。

## 功能

- 启动后持续运行
- 每秒发送一次 `Alt + Enter`
- 按 `Ctrl+C` 或关闭终端退出

## 使用方法

直接运行 `AlwaysProceed.exe` 即可。

```
╔════════════════════════════════════════╗
║   AlwaysProceed - Alt+Enter Clicker    ║
╠════════════════════════════════════════╣
║  每秒自动发送一次 Alt+Enter 按键       ║
║  按 Ctrl+C 或关闭窗口退出              ║
╚════════════════════════════════════════╝

[20:30:01] 已发送 Alt+Enter
[20:30:02] 已发送 Alt+Enter
...
```

## 构建

需要 .NET 8 SDK：

```powershell
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

## 自动构建

推送 `v*` 标签时，GitHub Actions 会自动构建并创建 Release。
