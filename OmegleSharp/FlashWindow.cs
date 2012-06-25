using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OmegleSharp
{
    internal static class FlashWindow
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct FLASHWINFO
        {
            public UInt32 cbSize;
            public IntPtr hwnd;
            public Int32 dwFlags;
            public UInt32 uCount;
            public Int32 dwTimeout;
        }

        [DllImport("user32.dll")]
        private static extern Int32 FlashWindowEx(ref FLASHWINFO pwfi);

        public enum FlashType
        {
            FLASHW_STOP = 0, // stop flashing
            FLASHW_CAPTION = 1, // flash the window title
            FLASHW_TRAY = 2, // flash the taskbar button
            FLASHW_ALL = 3, // 1 | 2
            FLASHW_TIMER = 4, // flash continuously
            FLASHW_TIMERNOFG = 12 // flash until the window comes to the foreground
        }

        public static void Flash(this Form window,
            FlashType type = FlashType.FLASHW_TIMERNOFG | FlashType.FLASHW_ALL, UInt32 count = UInt32.MaxValue)
        {
            window.Invoke(new MethodInvoker(delegate
            {
                FLASHWINFO fw = new FLASHWINFO();

                fw.cbSize = Convert.ToUInt32(Marshal.SizeOf(typeof(FLASHWINFO)));
                fw.hwnd = window.Handle;
                fw.dwFlags = (Int32)type;
                fw.uCount = count;

                FlashWindowEx(ref fw);
            }));
        }
    }
}