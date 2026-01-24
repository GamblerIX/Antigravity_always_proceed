using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace AlwaysProceed
{
    class Program
    {
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private const byte VK_MENU = 0x12;     // Alt key
        private const byte VK_RETURN = 0x0D;   // Enter key
        private const uint KEYEVENTF_KEYUP = 0x0002;

        private static bool _running = true;
        private static ManualResetEvent _quitEvent = new ManualResetEvent(false);

        static void Main(string[] args)
        {
            Console.Title = "AlwaysProceed - Alt+Enter Clicker";
            Console.WriteLine("════════════════════════════════════════");
            Console.WriteLine(" AlwaysProceed - Alt+Enter Clicker    ");
            Console.WriteLine("════════════════════════════════════════");
            Console.WriteLine(" 每秒自动发送一次 Alt+Enter 按键       ");
            Console.WriteLine(" 按第一次 Ctrl+C 停止发送，第二次退出   ");
            Console.WriteLine("════════════════════════════════════════");
            Console.WriteLine();

            Console.CancelKeyPress += (sender, e) =>
            {
                e.Cancel = true;
                if (_running)
                {
                    _running = false;
                    Console.WriteLine("\n已停止发送 Alt+Enter。再次按下 Ctrl+C 退出程序...");
                }
                else
                {
                    Console.WriteLine("\n正在退出...");
                    _quitEvent.Set();
                }
            };

            Console.WriteLine("已启动，开始发送 Alt+Enter...\n");

            while (_running)
            {
                SendAltEnter();
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] 已发送 Alt+Enter");
                Thread.Sleep(1000);
            }

            _quitEvent.WaitOne();
            Console.WriteLine("程序已停止。");
        }

        private static void SendAltEnter()
        {
            // Press Alt
            keybd_event(VK_MENU, 0, 0, 0);
            // Press Enter
            keybd_event(VK_RETURN, 0, 0, 0);
            // Release Enter
            keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0);
            // Release Alt
            keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, 0);
        }
    }
}
