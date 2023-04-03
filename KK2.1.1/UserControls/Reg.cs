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
    public partial class Reg : UserControl
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (nameTextbox.Text == "Имя")
            {
            nameTextbox.Text = "";
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (nameTextbox.Text == "")
            {
                nameTextbox.Text = "Имя";
            }
            
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (sernameTextbox.Text == "Фамилия")
            {
                sernameTextbox.Text = "";
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (sernameTextbox.Text == "")
            {
                sernameTextbox.Text = "Фамилия";
            }
        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            if (patronameTextbox.Text == "Отчество")
            {
                patronameTextbox.Text = "";
            }
        }

        private void bunifuMaterialTextbox3_Leave(object sender, EventArgs e)
        {
            if (patronameTextbox.Text == "")
            {
                patronameTextbox.Text = "Отчество";
            }
        }

        private void bunifuMaterialTextbox4_Enter(object sender, EventArgs e)
        {
            if (phnumberTextbox.Text == "Номер телефона")
            {
                phnumberTextbox.Text = "";
            }
        }

        private void bunifuMaterialTextbox4_Leave(object sender, EventArgs e)
        {
            if (phnumberTextbox.Text == "")
            {
                phnumberTextbox.Text = "Номер телефона";
            }
        }

        private void bunifuMaterialTextbox5_Enter(object sender, EventArgs e)
        {
            if (p_seriesTextbox.Text == "Серия")
            {
                p_seriesTextbox.Text = "";
            }
        }

        private void bunifuMaterialTextbox5_Leave(object sender, EventArgs e)
        {
            if (p_seriesTextbox.Text == "")
            {
            p_seriesTextbox.Text = "Серия";
            }

        }

        private void bunifuMaterialTextbox6_Enter(object sender, EventArgs e)
        {
            if (p_numberTextbox.Text == "Номер")
            {
                p_numberTextbox.Text = "";
            }
        }

        private void bunifuMaterialTextbox6_Leave(object sender, EventArgs e)
        {
            if (p_numberTextbox.Text == "")
            {
            p_numberTextbox.Text = "Номер";
            }
        }

        private void bunifuMaterialTextbox7_Enter(object sender, EventArgs e)
        {
            if (loginTextbox.Text == "Логин")
            {
                loginTextbox.Text = "";
            }
        }

        private void bunifuMaterialTextbox7_Leave(object sender, EventArgs e)
        {
            if (loginTextbox.Text == "")
            {
            loginTextbox.Text = "Логин";
            }
        }

        private void bunifuMaterialTextbox8_Enter(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "Пароль")
            {
            passwordTextbox.Text = "";
            passwordTextbox.isPassword = true;
            }
        }

        private void bunifuMaterialTextbox8_Leave(object sender, EventArgs e)
        {

            if (passwordTextbox.Text == "")
            {
                passwordTextbox.isPassword = false;
                passwordTextbox.Text = "Пароль";
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text == "Имя" || nameTextbox.Text == "" ||
                sernameTextbox.Text == "Фамилия" || sernameTextbox.Text == "" ||
                patronameTextbox.Text == "Отчество" || patronameTextbox.Text == "" ||
                phnumberTextbox.Text =="Номер телефона" || phnumberTextbox.Text == "" ||
                p_seriesTextbox.Text == "Серия" || p_seriesTextbox.Text == "" ||
                p_numberTextbox.Text == "Номер" || p_numberTextbox.Text == "" ||
                loginTextbox.Text == "Логин" || loginTextbox.Text == "" ||
                passwordTextbox.Text == "Пароль" || passwordTextbox.Text == "")
            {

                MetroMessageBox.Show(this, "Заполните все поля!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataWorker.UserDw.CreateUser(nameTextbox.Text, sernameTextbox.Text, patronameTextbox.Text, birthdayPicker.Value,
                    Convert.ToInt32(phnumberTextbox.Text), Convert.ToInt32(p_seriesTextbox.Text),
                    Convert.ToInt32(p_numberTextbox.Text), 
                    loginTextbox.Text, passwordTextbox.Text);
                if (!DataWorker.error)
                {

                    Log_Reg _this = (Log_Reg)FindForm();
                    _this.Close();
                }
                else
                {

                        MetroMessageBox.Show(this, "Правильно заполните поля!", "Ошибка",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
