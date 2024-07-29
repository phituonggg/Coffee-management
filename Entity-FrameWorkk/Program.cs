using System;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using Entity_FrameWorkk;

namespace Entity_FrameWorkk
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new LoginForm());
        }
    }
}
