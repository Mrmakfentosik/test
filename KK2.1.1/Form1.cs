using System;
using System.Drawing;
using System.Windows.Forms;
using KK2.Model;

namespace KK2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoginLabel.Text = DataWorker.UserDw.thisUser.Login;
            panel1.MouseDown += new MouseEventHandler((o, e) =>
            {
                panel1.Capture = false;
                Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref m);
            });
        }
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackgroundImage = new Bitmap(KK2.Properties.Resources.cancel_24px_red);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackgroundImage = new Bitmap(KK2.Properties.Resources.cancel_24px);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            Close();
        }
        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            
            Opacity = 0.7;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Opacity = 1;
        }
    }
}
