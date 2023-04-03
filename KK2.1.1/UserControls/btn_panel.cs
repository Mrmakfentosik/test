using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KK2.Model;

namespace KK2.UserControls
{
    public partial class btn_panel : UserControl
    {
        private Control v1;
        private Control v2;
        private Control v3;
        private Control v4;
        private Control v5;
        private Control v6;
        private Control v7;
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
        public Control Viev3
        {
            get
            {
                return v3;
            }
            set
            {
                v3 = value;
            }
        }
        public Control Viev4
        {
            get
            {
                return v4;
            }
            set
            {
                v4 = value;
            }
        }
        public Control Viev5
        {
            get
            {
                return v5;
            }
            set
            {
                v5 = value;
            }
        }
        public Control Viev6
        {
            get
            {
                return v6;
            }
            set
            {
                v6 = value;
            }
        }
        public Control Viev7
        {
            get
            {
                return v7;
            }
            set
            {
                v7 = value;
            }
        }

        public btn_panel()
        {
            InitializeComponent();
            pnlNav.Visible = false;
        }
        private void BtnSell_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = BtnSell.Height;
            pnlNav.Top = BtnSell.Top;
            pnlNav.Left = BtnSell.Left;
            BtnSell.BackColor = Color.FromArgb(119, 211, 255);
            BtnSell.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuTransition1.HideSync(v1);
            bunifuTransition1.HideSync(v3);
            bunifuTransition1.HideSync(v4);
            bunifuTransition1.HideSync(v5);
            bunifuTransition1.HideSync(v6);
            bunifuTransition1.HideSync(v7);
            bunifuTransition1.ShowSync(v2);
        }
        private void BtnProfile_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = BtnProfile.Height;
            pnlNav.Top = BtnProfile.Top;
            pnlNav.Left = BtnProfile.Left;
            BtnProfile.BackColor = Color.FromArgb(119, 211, 255);
            BtnProfile.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuTransition1.HideSync(v2);
            bunifuTransition1.HideSync(v3);
            bunifuTransition1.HideSync(v4);
            bunifuTransition1.HideSync(v5);
            bunifuTransition1.HideSync(v6);
            bunifuTransition1.HideSync(v7);
            bunifuTransition1.ShowSync(v1);

        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = BtnBuy.Height;
            pnlNav.Top = BtnBuy.Top;
            pnlNav.Left = BtnBuy.Left;
            BtnBuy.BackColor = Color.FromArgb(119, 211, 255);
            BtnBuy.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuTransition1.HideSync(v1);
            bunifuTransition1.HideSync(v3);
            bunifuTransition1.HideSync(v4);
            bunifuTransition1.HideSync(v5);
            bunifuTransition1.HideSync(v6);
            bunifuTransition1.HideSync(v7);
            bunifuTransition1.ShowSync(v3);
        }

        private void BtnRent_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = BtnRent.Height;
            pnlNav.Top = BtnRent.Top;
            pnlNav.Left = BtnRent.Left;
            BtnRent.BackColor = Color.FromArgb(119, 211, 255);
            BtnRent.ForeColor = Color.FromArgb(255, 255, 255);

            bunifuTransition1.HideSync(v1);
            bunifuTransition1.HideSync(v3);
            bunifuTransition1.HideSync(v4);
            bunifuTransition1.HideSync(v2);
            bunifuTransition1.HideSync(v6);
            bunifuTransition1.HideSync(v7);
            bunifuTransition1.ShowSync(v5);
        }


        private void BtnGetby_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = BtnGetby.Height;
            pnlNav.Top = BtnGetby.Top;
            pnlNav.Left = BtnGetby.Left;
            BtnGetby.BackColor = Color.FromArgb(119, 211, 255);
            BtnGetby.ForeColor = Color.FromArgb(255, 255, 255);

            bunifuTransition1.HideSync(v1);
            bunifuTransition1.HideSync(v3);
            bunifuTransition1.HideSync(v2);
            bunifuTransition1.HideSync(v5);
            bunifuTransition1.HideSync(v6);
            bunifuTransition1.HideSync(v7);
            bunifuTransition1.ShowSync(v4);
        }

        private void BtnVariant_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = BtnVariant.Height;
            pnlNav.Top = BtnVariant.Top;
            pnlNav.Left = BtnVariant.Left;
            BtnVariant.BackColor = Color.FromArgb(119, 211, 255);
            BtnVariant.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuTransition1.HideSync(v1);
            bunifuTransition1.HideSync(v3);
            bunifuTransition1.HideSync(v2);
            bunifuTransition1.HideSync(v5);
            bunifuTransition1.HideSync(v4);
            bunifuTransition1.HideSync(v7);
            bunifuTransition1.ShowSync(v6);
        }

        private void BtnDogovor_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = BtnDogovor.Height;
            pnlNav.Top = BtnDogovor.Top;
            pnlNav.Left = BtnDogovor.Left;
            BtnDogovor.BackColor = Color.FromArgb(119, 211, 255);
            BtnDogovor.ForeColor = Color.FromArgb(255, 255, 255);
            bunifuTransition1.HideSync(v1);
            bunifuTransition1.HideSync(v3);
            bunifuTransition1.HideSync(v2);
            bunifuTransition1.HideSync(v5);
            bunifuTransition1.HideSync(v6);
            bunifuTransition1.HideSync(v4);
            bunifuTransition1.ShowSync(v7);
        }

        private void BtnSell_Leave(object sender, EventArgs e)
        {
            BtnSell.BackColor = Color.FromArgb(255, 255, 255);
            BtnSell.ForeColor = Color.FromArgb(126, 169, 255);
            pnlNav.Visible = false;
        }

        private void BtnProfile_Leave(object sender, EventArgs e)
        {
            BtnProfile.BackColor = Color.FromArgb(255, 255, 255);
            BtnProfile.ForeColor = Color.FromArgb(126, 169, 255);

            pnlNav.Visible = false;
        }

        private void BtnBuy_Leave(object sender, EventArgs e)
        {
            BtnBuy.BackColor = Color.FromArgb(255, 255, 255);
            BtnBuy.ForeColor = Color.FromArgb(126, 169, 255);
            pnlNav.Visible = false;
        }

        private void BtnRent_Leave(object sender, EventArgs e)
        {
            BtnRent.BackColor = Color.FromArgb(255, 255, 255);
            BtnRent.ForeColor = Color.FromArgb(126, 169, 255);
            pnlNav.Visible = false;
        }

        private void BtnSell_Enter(object sender, EventArgs e)
        {
            BtnSell.BackColor = Color.FromArgb(0, 0, 0);
        }


        private void BtnGetby_Leave(object sender, EventArgs e)
        {
            BtnGetby.BackColor = Color.FromArgb(255, 255, 255);
            BtnGetby.ForeColor = Color.FromArgb(126, 169, 255);
            pnlNav.Visible = false;
        }

        private void btn_user_Load(object sender, EventArgs e)
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
            pnlNav.Visible = false;
        }

        private void BtnDogovor_Leave(object sender, EventArgs e)
        {
            BtnDogovor.BackColor = Color.FromArgb(255, 255, 255);
            BtnDogovor.ForeColor = Color.FromArgb(126, 169, 255);
            pnlNav.Visible = false;
        }
    }
}
