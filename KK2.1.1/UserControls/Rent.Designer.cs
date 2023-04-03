
namespace KK2.UserControls
{
    partial class Rent
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaxArendaDate = new MetroFramework.Controls.MetroDateTime();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MinArendaDate = new MetroFramework.Controls.MetroDateTime();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.District_box = new MetroFramework.Controls.MetroComboBox();
            this.Haustype_box = new MetroFramework.Controls.MetroComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.MaxPriceTextbox = new KK2.UserControls.MiTextBox();
            this.MinPriceTextbox = new KK2.UserControls.MiTextBox();
            this.MaxNumbRoomsTextbox = new KK2.UserControls.MiTextBox();
            this.MinNumbRoomsTextbox = new KK2.UserControls.MiTextBox();
            this.MaxFlorTextbox = new KK2.UserControls.MiTextBox();
            this.MinFlorTextbox = new KK2.UserControls.MiTextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.MaxPriceTextbox);
            this.panel1.Controls.Add(this.MinPriceTextbox);
            this.panel1.Controls.Add(this.MaxNumbRoomsTextbox);
            this.panel1.Controls.Add(this.MinNumbRoomsTextbox);
            this.panel1.Controls.Add(this.MaxFlorTextbox);
            this.panel1.Controls.Add(this.MinFlorTextbox);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.MaxArendaDate);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.MinArendaDate);
            this.panel1.Controls.Add(this.bunifuCustomLabel11);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.District_box);
            this.panel1.Controls.Add(this.Haustype_box);
            this.panel1.Location = new System.Drawing.Point(54, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 474);
            this.panel1.TabIndex = 1;
            // 
            // MaxArendaDate
            // 
            this.MaxArendaDate.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MaxArendaDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.MaxArendaDate.Location = new System.Drawing.Point(386, 267);
            this.MaxArendaDate.MinimumSize = new System.Drawing.Size(0, 27);
            this.MaxArendaDate.Name = "MaxArendaDate";
            this.MaxArendaDate.Size = new System.Drawing.Size(135, 27);
            this.MaxArendaDate.TabIndex = 33;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(349, 272);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(31, 21);
            this.bunifuCustomLabel10.TabIndex = 32;
            this.bunifuCustomLabel10.Text = "до";
            // 
            // MinArendaDate
            // 
            this.MinArendaDate.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MinArendaDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.MinArendaDate.Location = new System.Drawing.Point(208, 267);
            this.MinArendaDate.MinimumSize = new System.Drawing.Size(0, 27);
            this.MinArendaDate.Name = "MinArendaDate";
            this.MinArendaDate.Size = new System.Drawing.Size(135, 27);
            this.MinArendaDate.TabIndex = 31;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(32, 272);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(170, 21);
            this.bunifuCustomLabel11.TabIndex = 30;
            this.bunifuCustomLabel11.Text = "Период аренды от";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(161, 51);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(204, 21);
            this.bunifuCustomLabel9.TabIndex = 29;
            this.bunifuCustomLabel9.Text = "ЗАПОЛНИТЕ ВСЕ ПОЛЯ";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(210, 402);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(114, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "Отправить";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(339, 324);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(63, 21);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Район";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(125, 324);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(91, 21);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Тип дома";
            // 
            // District_box
            // 
            this.District_box.FormattingEnabled = true;
            this.District_box.ItemHeight = 24;
            this.District_box.Items.AddRange(new object[] {
            "Дёмский",
            "Калининский",
            "Кировский",
            "Ленинский",
            "Октябрьский",
            "Орджоникидзевский",
            "Советский"});
            this.District_box.Location = new System.Drawing.Point(274, 348);
            this.District_box.Name = "District_box";
            this.District_box.Size = new System.Drawing.Size(193, 30);
            this.District_box.TabIndex = 11;
            this.District_box.UseSelectable = true;
            // 
            // Haustype_box
            // 
            this.Haustype_box.FormattingEnabled = true;
            this.Haustype_box.ItemHeight = 24;
            this.Haustype_box.Items.AddRange(new object[] {
            "Гостинка",
            "Малосемейки",
            "Сталинка",
            "Хрущевка",
            "Брежневка",
            "Студия",
            "Стандартная квартира",
            "Лофт",
            "Частный дом",
            "Коттедж",
            "Вилла",
            "Дуплекс",
            "Таунхаус",
            "Пентхаус",
            "Апартамент",
            "Атриумариум"});
            this.Haustype_box.Location = new System.Drawing.Point(73, 348);
            this.Haustype_box.Name = "Haustype_box";
            this.Haustype_box.Size = new System.Drawing.Size(193, 30);
            this.Haustype_box.TabIndex = 10;
            this.Haustype_box.UseSelectable = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(631, 99);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(111, 21);
            this.bunifuCustomLabel12.TabIndex = 32;
            this.bunifuCustomLabel12.Text = "ОПИСАНИЕ";
            // 
            // description_textbox
            // 
            this.description_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.description_textbox.Location = new System.Drawing.Point(616, 128);
            this.description_textbox.Multiline = true;
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(261, 392);
            this.description_textbox.TabIndex = 31;
            // 
            // MaxPriceTextbox
            // 
            this.MaxPriceTextbox.AutoSize = true;
            this.MaxPriceTextbox.DefaultText = null;
            this.MaxPriceTextbox.error = true;
            this.MaxPriceTextbox.Location = new System.Drawing.Point(281, 193);
            this.MaxPriceTextbox.Name = "MaxPriceTextbox";
            this.MaxPriceTextbox.Size = new System.Drawing.Size(82, 30);
            this.MaxPriceTextbox.TabIndex = 48;
            // 
            // MinPriceTextbox
            // 
            this.MinPriceTextbox.AutoSize = true;
            this.MinPriceTextbox.DefaultText = null;
            this.MinPriceTextbox.error = true;
            this.MinPriceTextbox.Location = new System.Drawing.Point(155, 193);
            this.MinPriceTextbox.Name = "MinPriceTextbox";
            this.MinPriceTextbox.Size = new System.Drawing.Size(82, 30);
            this.MinPriceTextbox.TabIndex = 47;
            // 
            // MaxNumbRoomsTextbox
            // 
            this.MaxNumbRoomsTextbox.AutoSize = true;
            this.MaxNumbRoomsTextbox.DefaultText = null;
            this.MaxNumbRoomsTextbox.error = true;
            this.MaxNumbRoomsTextbox.Location = new System.Drawing.Point(351, 145);
            this.MaxNumbRoomsTextbox.Name = "MaxNumbRoomsTextbox";
            this.MaxNumbRoomsTextbox.Size = new System.Drawing.Size(33, 30);
            this.MaxNumbRoomsTextbox.TabIndex = 46;
            // 
            // MinNumbRoomsTextbox
            // 
            this.MinNumbRoomsTextbox.AutoSize = true;
            this.MinNumbRoomsTextbox.DefaultText = null;
            this.MinNumbRoomsTextbox.error = true;
            this.MinNumbRoomsTextbox.Location = new System.Drawing.Point(273, 145);
            this.MinNumbRoomsTextbox.Name = "MinNumbRoomsTextbox";
            this.MinNumbRoomsTextbox.Size = new System.Drawing.Size(33, 30);
            this.MinNumbRoomsTextbox.TabIndex = 45;
            // 
            // MaxFlorTextbox
            // 
            this.MaxFlorTextbox.AutoSize = true;
            this.MaxFlorTextbox.DefaultText = null;
            this.MaxFlorTextbox.error = true;
            this.MaxFlorTextbox.Location = new System.Drawing.Point(232, 96);
            this.MaxFlorTextbox.Name = "MaxFlorTextbox";
            this.MaxFlorTextbox.Size = new System.Drawing.Size(33, 30);
            this.MaxFlorTextbox.TabIndex = 44;
            // 
            // MinFlorTextbox
            // 
            this.MinFlorTextbox.AutoSize = true;
            this.MinFlorTextbox.DefaultText = null;
            this.MinFlorTextbox.error = true;
            this.MinFlorTextbox.Location = new System.Drawing.Point(155, 96);
            this.MinFlorTextbox.Name = "MinFlorTextbox";
            this.MinFlorTextbox.Size = new System.Drawing.Size(33, 30);
            this.MinFlorTextbox.TabIndex = 43;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(244, 202);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(31, 21);
            this.bunifuCustomLabel7.TabIndex = 42;
            this.bunifuCustomLabel7.Text = "до";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(69, 202);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(78, 21);
            this.bunifuCustomLabel8.TabIndex = 41;
            this.bunifuCustomLabel8.Text = "Цена от";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(314, 154);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(31, 21);
            this.bunifuCustomLabel5.TabIndex = 40;
            this.bunifuCustomLabel5.Text = "до";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(69, 154);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(198, 21);
            this.bunifuCustomLabel6.TabIndex = 39;
            this.bunifuCustomLabel6.Text = "Количество комнат от";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(195, 105);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(31, 21);
            this.bunifuCustomLabel4.TabIndex = 38;
            this.bunifuCustomLabel4.Text = "до";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(69, 105);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(79, 21);
            this.bunifuCustomLabel1.TabIndex = 37;
            this.bunifuCustomLabel1.Text = "Этаж от";
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.panel1);
            this.Name = "Rent";
            this.Size = new System.Drawing.Size(940, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private MetroFramework.Controls.MetroComboBox District_box;
        private MetroFramework.Controls.MetroComboBox Haustype_box;
        private MetroFramework.Controls.MetroDateTime MaxArendaDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private MetroFramework.Controls.MetroDateTime MinArendaDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.TextBox description_textbox;
        private MiTextBox MaxPriceTextbox;
        private MiTextBox MinPriceTextbox;
        private MiTextBox MaxNumbRoomsTextbox;
        private MiTextBox MinNumbRoomsTextbox;
        private MiTextBox MaxFlorTextbox;
        private MiTextBox MinFlorTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
