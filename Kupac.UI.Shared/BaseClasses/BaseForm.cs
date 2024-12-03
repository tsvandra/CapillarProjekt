using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kupac.UI.Shared.BaseClasses
{
    public class BaseForm : Form
    {


        // Windows API call to enable form dragging ------- start
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        public const int HTBOTTOMRIGHT = 17;  // Bottom-right corner of the window


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // Windows API call to enable form dragging ------- end

        public const int WM_NCHITTEST = 0x84;
        public const int HTCLIENT = 1;
        public const int HTLEFT = 10;
        public const int HTRIGHT = 11;
        public const int HTTOP = 12;
        public const int HTTOPLEFT = 13;
        public const int HTTOPRIGHT = 14;
        public const int HTBOTTOM = 15;
        public const int HTBOTTOMLEFT = 16;


        public BaseForm() 
        {
            this.BackColor = Color.Thistle;

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                float dpiX = g.DpiX;
                float dpiY = g.DpiY;

                float scaleFactorX = dpiX / 96;
                float scaleFactorY = dpiY / 96;


                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

                // Set to 80% size
                this.Size = new Size(
                    (int)((screenWidth * 0.8) / scaleFactorX),
                    (int)((screenHeight * 0.8) / scaleFactorY));
            }
        }

        // With this i can move the form aruond
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        // Eseménykezelés a form átméretezéséhez
        protected override void WndProc(ref Message m)
        {
            const int resizeHandleSize = 10;  // A sáv mérete, ahol az egér átméretezési sávként viselkedik

            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)  // Az egér pozíciójának ellenőrzése
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (cursor.X <= resizeHandleSize && cursor.Y <= resizeHandleSize)
                {
                    m.Result = (IntPtr)HTTOPLEFT;  // Bal felső sarok átméretezése
                }
                else if (cursor.X >= this.ClientSize.Width - resizeHandleSize && cursor.Y <= resizeHandleSize)
                {
                    m.Result = (IntPtr)HTTOPRIGHT;  // Jobb felső sarok átméretezése
                }
                else if (cursor.X <= resizeHandleSize && cursor.Y >= this.ClientSize.Height - resizeHandleSize)
                {
                    m.Result = (IntPtr)HTBOTTOMLEFT;  // Bal alsó sarok átméretezése
                }
                else if (cursor.X >= this.ClientSize.Width - resizeHandleSize && cursor.Y >= this.ClientSize.Height - resizeHandleSize)
                {
                    m.Result = (IntPtr)HTBOTTOMRIGHT;  // Jobb alsó sarok átméretezése
                }
                else if (cursor.X <= resizeHandleSize)
                {
                    m.Result = (IntPtr)HTLEFT;  // Bal oldal átméretezése
                }
                else if (cursor.X >= this.ClientSize.Width - resizeHandleSize)
                {
                    m.Result = (IntPtr)HTRIGHT;  // Jobb oldal átméretezése
                }
                else if (cursor.Y <= resizeHandleSize)
                {
                    m.Result = (IntPtr)HTTOP;  // Felső átméretezése
                }
                else if (cursor.Y >= this.ClientSize.Height - resizeHandleSize)
                {
                    m.Result = (IntPtr)HTBOTTOM;  // Alsó átméretezése
                }
            }
        }

    }
}
