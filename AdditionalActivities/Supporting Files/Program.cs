using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View;
using System.Threading;
using System.Runtime.InteropServices;

namespace AdditionalActivities
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public const int BROADCAST = 0xffff;
        public static readonly int WM_SHOW = RegisterWindowMessage("WM_SHOW");
        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);

        static Mutex mutex = new Mutex(true, "AKR AddAct SingleInstanceApp Mutex");

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(MainForm.Shared());
                mutex.ReleaseMutex();
            }
            else
                PostMessage((IntPtr)BROADCAST, WM_SHOW, IntPtr.Zero, IntPtr.Zero);
        }
    }
}
