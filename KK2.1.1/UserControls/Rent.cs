using KK2.Model;
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

namespace KK2.UserControls
{
    public partial class Rent : UserControl
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            TimeSpan MinDate = new TimeSpan(MinArendaDate.Value.Ticks);
            TimeSpan MaxDate = new TimeSpan(MaxArendaDate.Value.Ticks);
            if (MinFlorTextbox.error || MaxFlorTextbox.error || Convert.ToInt32(MinFlorTextbox.Text) > Convert.ToInt32(MaxFlorTextbox.Text) ||
                MinNumbRoomsTextbox.error || MaxNumbRoomsTextbox.error ||Convert.ToInt32(MinNumbRoomsTextbox.Text) > Convert.ToInt32(MaxNumbRoomsTextbox.Text) ||
                MinPriceTextbox.error || MaxPriceTextbox.error ||Convert.ToInt32(MinPriceTextbox.Text) > Convert.ToInt32(MaxPriceTextbox.Text) ||
                description_textbox.Text == "" ||
                District_box.Text == "" || Haustype_box.Text == "" ||
                MinDate > MaxDate)
            {
                MetroMessageBox.Show(this, "Заполните все поля!", "Ошибка",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataWorker.Advt.Rent.Create(Convert.ToInt32(Haustype_box.SelectedIndex + 1),
                    Convert.ToInt32(MinFlorTextbox.Text), Convert.ToInt32(MaxFlorTextbox.Text),
                    Convert.ToInt32(MinNumbRoomsTextbox.Text), Convert.ToInt32(MaxFlorTextbox.Text),
                    Convert.ToInt32(District_box.SelectedIndex + 1), Convert.ToDateTime(MinArendaDate.Text),
                    Convert.ToDateTime(MaxArendaDate.Text), description_textbox.Text,
                    Convert.ToInt32(MinPriceTextbox.Text), Convert.ToInt32(MaxPriceTextbox.Text));
                MetroMessageBox.Show(this, "Объявление добавлено", "Успешно",
                                   MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
