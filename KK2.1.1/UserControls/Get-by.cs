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
    public partial class Get_by : UserControl
    {
        public Get_by()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            TimeSpan MinDate = new TimeSpan(MinArendaDate.Value.Ticks);
            TimeSpan MaxDate = new TimeSpan(MaxArendaDate.Value.Ticks);
            if (DataWorker.error || AdresTextbox.error ||
                RowTextbox.error || RowTextbox.error || 
                RoomsTextbox.error || SqTextbox.error ||
                Haustype_box.Text == "" || District_box.Text == "" ||
                description_textbox.Text == "" ||
                MinDate > MaxDate)
            {
                MetroMessageBox.Show(this, "Заполните все поля!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataWorker.Advt.GetBy.Create(Convert.ToInt32(Haustype_box.SelectedIndex + 1),
                Convert.ToInt32(RowTextbox.Text), Convert.ToInt32(RoomsTextbox.Text),
                Convert.ToInt32(SqTextbox.Text), Convert.ToString(AdresTextbox.Text),
                Convert.ToInt32(District_box.SelectedIndex + 1), description_textbox.Text,
                Convert.ToDateTime(MinArendaDate.Text), Convert.ToDateTime(MaxArendaDate.Text),
                Convert.ToInt32(Price_box.Text));
                MetroMessageBox.Show(this, "Объявление добавлено", "Успешно",
                                   MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
