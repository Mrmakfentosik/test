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
    public partial class Log : UserControl
    {
        public Log()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (loginTextbox.Text == "Логин")
            {
                loginTextbox.Text = "";
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (loginTextbox.Text == "")
            {
                loginTextbox.Text = "Логин";
            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "Пароль")
            {
                passwordTextbox.isPassword = true;
                passwordTextbox.Text = "";
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "")
            {
                passwordTextbox.isPassword = false;
                passwordTextbox.Text = "Пароль";
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text == "Логин" || passwordTextbox.Text == "Пароль" ||
                loginTextbox.Text == "" || passwordTextbox.Text == "")
            {
                MetroMessageBox.Show(this, "Заполните все поля!", "Ошибка", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataWorker.UserDw.Find(loginTextbox.Text, passwordTextbox.Text);
                if (DataWorker.UserDw.thisUser.Password == passwordTextbox.Text && !DataWorker.error)
                {
                    Log_Reg _this = (Log_Reg)FindForm();
                    _this.Close();
                }
                else
                {
                    MetroMessageBox.Show(this, "Неверный логин или пароль!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
