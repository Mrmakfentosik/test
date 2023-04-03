using MetroFramework;
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
    public partial class Buy : UserControl
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (MinFlorTextbox.error || MaxFlorTextbox.error || Convert.ToInt32(MinFlorTextbox.Text) > Convert.ToInt32(MaxFlorTextbox.Text) |
                MinNumbRoomsTextbox.error || MaxNumbRoomsTextbox.error || Convert.ToInt32(MinNumbRoomsTextbox.Text) > Convert.ToInt32(MaxNumbRoomsTextbox.Text) |
                MinPriceTextbox.error || MaxPriceTextbox.error || Convert.ToInt32(MinPriceTextbox.Text) > Convert.ToInt32(MaxPriceTextbox.Text) |
                description_textbox.Text == ""||
                District_box.SelectedIndex == -1 | Haustype_box.SelectedIndex == -1)
                {
                      MetroMessageBox.Show(this, "Заполните все поля!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                DataWorker.Advt.Buy.Create(Convert.ToInt32(Haustype_box.SelectedIndex + 1), 
                    Convert.ToInt32(MinFlorTextbox.Text), Convert.ToInt32(MaxFlorTextbox.Text), 
                    Convert.ToInt32(MinNumbRoomsTextbox.Text), Convert.ToInt32(MaxFlorTextbox.Text), 
                    Convert.ToInt32(District_box.SelectedIndex + 1), description_textbox.Text,
                    Convert.ToInt32(MinPriceTextbox.Text), Convert.ToInt32(MaxPriceTextbox.Text));
                MetroMessageBox.Show(this, "Объявление добавлено", "Успешно",
                                   MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
