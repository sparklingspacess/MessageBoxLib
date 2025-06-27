using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MessageBoxLib
{
    class Notifier
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        public static uint ParseMsgBoxData(string btn, string icon)
        {
            uint information = 0x00000040;
            uint warning = 0x00000030;
            uint error = 0x00000010;
            uint question = 0x00000020;
            uint ok = 0x00000000;
            uint okcancel = 0x00000001;
            uint yesno = 0x00000004;
            uint p1 = 0;
            uint p2 = 0;
            if (btn == "Ok")
            {
                p1 = ok;
            }
            else if (btn == "OkCancel")
            {
                p1 = okcancel;
            }
            else if (btn == "YesNo")
            {
                p1 = yesno;
            }
            if (icon == "Information")
            {
                p2 = information;
            }
            else if (icon == "Warning")
            {
                p2 = warning;
            }
            else if (icon == "Error")
            {
                p2 = error;
            }
            else if (icon == "Question")
            {
                p2 = question;
            }
            uint type = p1 | p2;
            return type;
        }
        public static int MessageBox(string txt, string title, string btn, string icon)
        {
            uint type = ParseMsgBoxData(btn, icon);
            int val = MessageBox(IntPtr.Zero, txt, title, type);
            return val;
        }
    }
}
