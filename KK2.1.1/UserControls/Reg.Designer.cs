
namespace KK2.UserControls
{
    partial class Reg
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sernameTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.patronameTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phnumberTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.p_seriesTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.p_numberTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.birthdayPicker12 = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.birthdayPicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.SuspendLayout();
            // 
            // nameTextbox
            // 
            this.nameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.nameTextbox.HintText = "";
            this.nameTextbox.isPassword = false;
            this.nameTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.nameTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.nameTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.nameTextbox.LineThickness = 3;
            this.nameTextbox.Location = new System.Drawing.Point(23, 20);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextbox.MaximumSize = new System.Drawing.Size(235, 41);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(235, 41);
            this.nameTextbox.TabIndex = 0;
            this.nameTextbox.Text = "Имя";
            this.nameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTextbox.Enter += new System.EventHandler(this.bunifuMaterialTextbox1_Enter);
            this.nameTextbox.Leave += new System.EventHandler(this.bunifuMaterialTextbox1_Leave);
            // 
            // sernameTextbox
            // 
            this.sernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sernameTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sernameTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.sernameTextbox.HintText = "";
            this.sernameTextbox.isPassword = false;
            this.sernameTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sernameTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.sernameTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sernameTextbox.LineThickness = 3;
            this.sernameTextbox.Location = new System.Drawing.Point(281, 20);
            this.sernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.sernameTextbox.Name = "sernameTextbox";
            this.sernameTextbox.Size = new System.Drawing.Size(249, 41);
            this.sernameTextbox.TabIndex = 1;
            this.sernameTextbox.Text = "Фамилия";
            this.sernameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sernameTextbox.Enter += new System.EventHandler(this.bunifuMaterialTextbox2_Enter);
            this.sernameTextbox.Leave += new System.EventHandler(this.bunifuMaterialTextbox2_Leave);
            // 
            // patronameTextbox
            // 
            this.patronameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patronameTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.patronameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patronameTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.patronameTextbox.HintText = "";
            this.patronameTextbox.isPassword = false;
            this.patronameTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.patronameTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.patronameTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.patronameTextbox.LineThickness = 3;
            this.patronameTextbox.Location = new System.Drawing.Point(23, 118);
            this.patronameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.patronameTextbox.Name = "patronameTextbox";
            this.patronameTextbox.Size = new System.Drawing.Size(507, 41);
            this.patronameTextbox.TabIndex = 2;
            this.patronameTextbox.Text = "Отчество";
            this.patronameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.patronameTextbox.Enter += new System.EventHandler(this.bunifuMaterialTextbox3_Enter);
            this.patronameTextbox.Leave += new System.EventHandler(this.bunifuMaterialTextbox3_Leave);
            // 
            // phnumberTextbox
            // 
            this.phnumberTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phnumberTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phnumberTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phnumberTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.phnumberTextbox.HintText = "";
            this.phnumberTextbox.isPassword = false;
            this.phnumberTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.phnumberTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.phnumberTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.phnumberTextbox.LineThickness = 3;
            this.phnumberTextbox.Location = new System.Drawing.Point(281, 185);
            this.phnumberTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.phnumberTextbox.Name = "phnumberTextbox";
            this.phnumberTextbox.Size = new System.Drawing.Size(249, 41);
            this.phnumberTextbox.TabIndex = 3;
            this.phnumberTextbox.Text = "Номер телефона";
            this.phnumberTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phnumberTextbox.Enter += new System.EventHandler(this.bunifuMaterialTextbox4_Enter);
            this.phnumberTextbox.Leave += new System.EventHandler(this.bunifuMaterialTextbox4_Leave);
            // 
            // p_seriesTextbox
            // 
            this.p_seriesTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.p_seriesTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.p_seriesTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_seriesTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.p_seriesTextbox.HintText = "";
            this.p_seriesTextbox.isPassword = false;
            this.p_seriesTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.p_seriesTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.p_seriesTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.p_seriesTextbox.LineThickness = 3;
            this.p_seriesTextbox.Location = new System.Drawing.Point(23, 290);
            this.p_seriesTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.p_seriesTextbox.Name = "p_seriesTextbox";
            this.p_seriesTextbox.Size = new System.Drawing.Size(249, 41);
            this.p_seriesTextbox.TabIndex = 4;
            this.p_seriesTextbox.Text = "Серия";
            this.p_seriesTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.p_seriesTextbox.Enter += new System.EventHandler(this.bunifuMaterialTextbox5_Enter);
            this.p_seriesTextbox.Leave += new System.EventHandler(this.bunifuMaterialTextbox5_Leave);
            // 
            // p_numberTextbox
            // 
            this.p_numberTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.p_numberTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.p_numberTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_numberTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.p_numberTextbox.HintText = "";
            this.p_numberTextbox.isPassword = false;
            this.p_numberTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.p_numberTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.p_numberTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.p_numberTextbox.LineThickness = 3;
            this.p_numberTextbox.Location = new System.Drawing.Point(281, 290);
            this.p_numberTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.p_numberTextbox.Name = "p_numberTextbox";
            this.p_numberTextbox.Size = new System.Drawing.Size(249, 41);
            this.p_numberTextbox.TabIndex = 5;
            this.p_numberTextbox.Text = "Номер";
            this.p_numberTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.p_numberTextbox.Enter += new System.EventHandler(this.bunifuMaterialTextbox6_Enter);
            this.p_numberTextbox.Leave += new System.EventHandler(this.bunifuMaterialTextbox6_Leave);
            // 
            // loginTextbox
            // 
            this.loginTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.loginTextbox.HintText = "";
            this.loginTextbox.isPassword = false;
            this.loginTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.loginTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.loginTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.loginTextbox.LineThickness = 3;
            this.loginTextbox.Location = new System.Drawing.Point(23, 398);
            this.loginTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(249, 41);
            this.loginTextbox.TabIndex = 6;
            this.loginTextbox.Text = "Логин";
            this.loginTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginTextbox.Enter += new System.EventHandler(this.bunifuMaterialTextbox7_Enter);
            this.loginTextbox.Leave += new System.EventHandler(this.bunifuMaterialTextbox7_Leave);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.passwordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordTextbox.HintText = "";
            this.passwordTextbox.isPassword = false;
            this.passwordTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.passwordTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.passwordTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.passwordTextbox.LineThickness = 3;
            this.passwordTextbox.Location = new System.Drawing.Point(281, 398);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(249, 41);
            this.passwordTextbox.TabIndex = 7;
            this.passwordTextbox.Text = "Пароль";
            this.passwordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextbox.Enter += new System.EventHandler(this.bunifuMaterialTextbox8_Enter);
            this.passwordTextbox.Leave += new System.EventHandler(this.bunifuMaterialTextbox8_Leave);
            // 
            // birthdayPicker12
            // 
            this.birthdayPicker12.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.birthdayPicker12.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayPicker12.Location = new System.Drawing.Point(281, 92);
            this.birthdayPicker12.MinimumSize = new System.Drawing.Size(0, 30);
            this.birthdayPicker12.Name = "birthdayPicker12";
            this.birthdayPicker12.Size = new System.Drawing.Size(235, 30);
            this.birthdayPicker12.TabIndex = 8;
            this.birthdayPicker12.UseCustomBackColor = true;
            this.birthdayPicker12.UseCustomForeColor = true;
            this.birthdayPicker12.UseStyleColors = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(228, 265);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(86, 24);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Паспорт";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.materialFlatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialFlatButton1.Location = new System.Drawing.Point(169, 460);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(208, 36);
            this.materialFlatButton1.TabIndex = 10;
            this.materialFlatButton1.Text = "Зарегестрироваться";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.BackColor = System.Drawing.Color.Black;
            this.birthdayPicker.BorderRadius = 0;
            this.birthdayPicker.ForeColor = System.Drawing.Color.White;
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayPicker.FormatCustom = "yyyy.MM.dd";
            this.birthdayPicker.Location = new System.Drawing.Point(23, 195);
            this.birthdayPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(208, 44);
            this.birthdayPicker.TabIndex = 11;
            this.birthdayPicker.Value = new System.DateTime(2021, 3, 18, 0, 0, 0, 0);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.birthdayPicker12);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.loginTextbox);
            this.Controls.Add(this.p_numberTextbox);
            this.Controls.Add(this.p_seriesTextbox);
            this.Controls.Add(this.phnumberTextbox);
            this.Controls.Add(this.patronameTextbox);
            this.Controls.Add(this.sernameTextbox);
            this.Controls.Add(this.nameTextbox);
            this.DoubleBuffered = true;
            this.Name = "Reg";
            this.Size = new System.Drawing.Size(558, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sernameTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox patronameTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phnumberTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox p_seriesTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox p_numberTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextbox;
        private MetroFramework.Controls.MetroDateTime birthdayPicker12;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private Bunifu.Framework.UI.BunifuDatepicker birthdayPicker;
    }
}
