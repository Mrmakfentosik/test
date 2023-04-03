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
    public partial class MiTextBox : UserControl
    {
        private string txt;
        public string DefaultText
        {
            get
            {
                return txt;
            }
            set
            {
                txt = value;
            }
        }
        public string Text
        {
            get
            {
                return bunifuMaterialTextbox1.Text;
            }
        }

        public bool error { get; set; }
        public MiTextBox()
        {
            InitializeComponent();
        }
        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == txt || bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = txt;
                error = true;
            }
            else
            {
                error = false;
            }
        }

        private void MiTextBox_VisibleChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = txt;
            error = true;
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == txt || bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "";
            }
        }
    }
}
