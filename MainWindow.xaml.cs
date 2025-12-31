using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Threading;

namespace AlwaysProceed
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        
        // Windows API constants and functions
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private const byte VK_MENU = 0x12;  // Alt key
        private const byte VK_RETURN = 0x0D; // Enter key
        private const uint KEYEVENTF_KEYUP = 0x0002;

        public MainWindow()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            // Press Alt
            keybd_event(VK_MENU, 0, 0, 0);
            // Press Enter
            keybd_event(VK_RETURN, 0, 0, 0);
            // Release Enter
            keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0);
            // Release Alt
            keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, 0);

            StatusText.Text = $"最后执行时间: {DateTime.Now:HH:mm:ss}";
        }

        private void ClickerToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (ClickerToggle.IsOn)
            {
                _timer.Start();
                StatusText.Text = "逻辑已启动...";
            }
            else
            {
                _timer.Stop();
                StatusText.Text = "已停止";
            }
        }
    }
}
