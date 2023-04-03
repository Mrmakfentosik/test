using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KK2.Model;

namespace KK2.UserControls
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }
       /* private void Profile_Load(object sender, EventArgs e)
        {
            DataWorker.Advt.Buy.Find(DataWorker.UserDw.thisUser.Id);
            DataWorker.Advt.Sell.Find(DataWorker.UserDw.thisUser.Id);
            DataWorker.Advt.Rent.Find(DataWorker.UserDw.thisUser.Id);
            DataWorker.Advt.GetBy.Find(DataWorker.UserDw.thisUser.Id);
            for (int i = 0; i <= DataWorker.Advt.Buy.Advts.Count - 1; i++)
            {
                Panel p = addLabel(i, Convert.ToString(DataWorker.Advt.Buy.Advts[i].HausTypeId));
                flowLayoutPanel1.Controls.Add(p);
            }
            for (int i = 0; i <= DataWorker.Advt.Sell.Advts.Count - 1; i++)
            {
                Panel p = addLabel(i, Convert.ToString(DataWorker.Advt.Sell.Advts[i].HausTypeId));
                flowLayoutPanel2.Controls.Add(p);
            }
            for (int i = 0; i <= DataWorker.Advt.GetBy.Advts.Count - 1; i++)
            {
                Panel p = addLabel(i, Convert.ToString(DataWorker.Advt.GetBy.Advts[i].HausTypeId));
                flowLayoutPanel3.Controls.Add(p);
            }
            for (int i = 0; i <= DataWorker.Advt.Rent.Advts.Count - 1; i++)
            {
                Panel p = addLabel(i, Convert.ToString(DataWorker.Advt.Rent.Advts[i].HausTypeId));
                flowLayoutPanel4.Controls.Add(p);
            }
        }*/

        

        Panel addLabel(int i, string text)
        {
            Panel p = new Panel();
            Label l = new Label();
            Button b = new Button();
            p.BackColor = Color.FromArgb(119, 211, 255);
            l.Name = "label" + i.ToString();
            l.Font = new Font("Century Gothic", 8, FontStyle.Regular);
            l.Text = text;
            l.Width = 100;
            l.Height = 80;
            l.TextAlign = ContentAlignment.MiddleLeft;
            l.Margin = new Padding(10);
            b.BackColor = Color.Red;
            b.Text = "Удалить";
            b.Width = 130;
            b.Height = 30;
            b.Dock = DockStyle.Bottom;
            p.Width = 130;
            p.Height = 120;
            p.Controls.Add(l);
            p.Controls.Add(b);
            void BtnSell_Click(object sender, EventArgs e)
            { 
                
            }


                return p;
        }

        /* создать массив кнопок, узнать на какую кнопку нажал, через иф делать событие*/
        private void Profile_Enter(object sender, EventArgs e)
        {
            DataWorker.Advt.Buy.Find(DataWorker.UserDw.thisUser.Id);
            DataWorker.Advt.Sell.Find(DataWorker.UserDw.thisUser.Id);
            DataWorker.Advt.Rent.Find(DataWorker.UserDw.thisUser.Id);
            DataWorker.Advt.GetBy.Find(DataWorker.UserDw.thisUser.Id);
            for (int i = 0; i <= DataWorker.Advt.Buy.Advts.Count - 1; i++)
            {
                Panel p = addLabel(i, Convert.ToString(DataWorker.Advt.Buy.Advts[i].Description));
                flowLayoutPanel1.Controls.Add(p);
            }
            for (int i = 0; i <= DataWorker.Advt.Sell.Advts.Count - 1; i++)
            {
                Panel p = addLabel(i, Convert.ToString(DataWorker.Advt.Sell.Advts[i].Description));
                flowLayoutPanel2.Controls.Add(p);
            }
            for (int i = 0; i <= DataWorker.Advt.GetBy.Advts.Count - 1; i++)
            {
                Panel p = addLabel(i, Convert.ToString(DataWorker.Advt.GetBy.Advts[i].Description));
                flowLayoutPanel3.Controls.Add(p);
            }
            for (int i = 0; i <= DataWorker.Advt.Rent.Advts.Count - 1; i++)
            {
                Panel p = addLabel(i, Convert.ToString(DataWorker.Advt.Rent.Advts[i].Description));
                flowLayoutPanel4.Controls.Add(p);
            }
        }

        private void Profile_Leave(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            flowLayoutPanel4.Controls.Clear();
        }
    }
}