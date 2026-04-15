using System;

namespace SMT_STOPPER_RELEASE.bll.ActiveWindow
{
    public class ActiveWindowChangedEventArgs : EventArgs
    {
        public IntPtr WindowHandle { get; set; } = IntPtr.Zero;
        public string WindowTitle { get; set; } = string.Empty;

        public static ActiveWindowChangedEventArgs Create(string windowTitle, IntPtr windowHandle) =>
            new ActiveWindowChangedEventArgs() { WindowTitle = windowTitle, WindowHandle= windowHandle };
    }
}
