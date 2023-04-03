using KK2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK2.UserControls
{
    public partial class btn_rielt : UserControl
    {
        private bool v;
        private Control v1;
        private Control v2;
        public bool vis 
        {
            get
            {
                return v;
            }
            set
            {
                v = value;
            }
        }
        public Control Viev1
        {
            get
            {
                return v1;
            }
            set
            {
                v1 = value;
            }
        }
        public Control Viev2
        {
            get
            {
                return v2;
            }
            set
            {
                v2 = value;
            }
        }
        public btn_rielt()
        {
            InitializeComponent();

            BtnVariant.Visible = false;
            BtnDogovor.Visible = false;
        }

        private void BtnVarian_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnVariant.Height;
            pnlNav.Top = BtnVariant.Top;
            pnlNav.Left = BtnVariant.Left;
            BtnVariant.BackColor = Color.FromArgb(119, 211, 255);
            BtnVariant.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuTransition1.HideSync(v1);
            bunifuTransition1.ShowSync(v2);
        }
        private void BtnDogovor_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnDogovor.Height;
            pnlNav.Top = BtnDogovor.Top;
            pnlNav.Left = BtnDogovor.Left;
            BtnDogovor.BackColor = Color.FromArgb(119, 211, 255);
            BtnDogovor.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuTransition1.HideSync(v2);
            bunifuTransition1.ShowSync(v1);

        }
        private void btn_rielt_Load(object sender, EventArgs e)
        {
            if (DataWorker.UserDw.thisUser.Rielt == 1)
            {
                BtnVariant.Visible = true;
                BtnDogovor.Visible = true;
            }
            else
            {
                BtnVariant.Visible = false;
                BtnDogovor.Visible = false;
            }
        }
        private void BtnVariant_Leave(object sender, EventArgs e)
        {
            BtnVariant.BackColor = Color.FromArgb(255, 255, 255);
            BtnVariant.ForeColor = Color.FromArgb(126, 169, 255);
        }

        private void BtnDogovor_Leave(object sender, EventArgs e)
        {
            BtnDogovor.BackColor = Color.FromArgb(255, 255, 255);
            BtnDogovor.ForeColor = Color.FromArgb(126, 169, 255);
        }
    }
}
