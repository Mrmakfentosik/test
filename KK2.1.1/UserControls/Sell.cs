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
using KK2.UserControls;
using KK2.Model;

namespace KK2.UserControls
{
    public partial class Sell : UserControl
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (DataWorker.error || RoomsTextbox.error || RowTextbox.error || SqTextbox.error ||AdresTextbox.error ||
                description_textbox.Text == "" ||
                District_box.SelectedIndex == -1 || Haustype_box.SelectedIndex == -1 || Price_box.error)
            {
                MetroMessageBox.Show(this, "Заполните все поля!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataWorker.Advt.Sell.Create(Convert.ToInt32(Haustype_box.SelectedIndex + 1),
                Convert.ToInt32(RowTextbox.Text), Convert.ToInt32(RoomsTextbox.Text),
                Convert.ToInt32(SqTextbox.Text), Convert.ToString(AdresTextbox.Text),
                Convert.ToInt32(District_box.SelectedIndex + 1), description_textbox.Text,
                Convert.ToInt32(Price_box.Text));
                MetroMessageBox.Show(this, "Объявление добавлено", "Успешно",
                                   MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
