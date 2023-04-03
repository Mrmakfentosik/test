using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK2
{
    public partial class Log_Reg : Form
    {
        public Log_Reg()
        {   
            InitializeComponent();
            Size = new Size(314, 542);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

            materialRaisedButton2.Visible = false;
            materialRaisedButton1.Visible = true;
            if (Width != MaximumSize.Width)
            {
                for (int i = Width; i < MaximumSize.Width; i += 10)
                {
                    Application.DoEvents();
                    ClientSize = new Size(i, ClientSize.Height);
                }
            }
            bunifuTransition2.HideSync(log1);
            bunifuTransition1.ShowSync(reg2);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            materialRaisedButton1.Visible = false;
            materialRaisedButton2.Visible = true;
            if (Width != MaximumSize.Width)
            {
                for (int i = Width; i < MaximumSize.Width; i += 10)
                {
                    Application.DoEvents();
                    ClientSize = new Size(i, ClientSize.Height);
                }
            }
            bunifuTransition2.HideSync(reg2);
            bunifuTransition1.ShowSync(log1);
        }

        public static explicit operator Log_Reg(System.Windows.DependencyObject v)
        {
            throw new NotImplementedException();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackgroundImage = new Bitmap(KK2.Properties.Resources.cancel_24px_red);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackgroundImage = new Bitmap(KK2.Properties.Resources.icons8_cancel_32);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
