
namespace KK2.UserControls
{
    partial class Buy
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
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.District_box = new MetroFramework.Controls.MetroComboBox();
            this.Haustype_box = new MetroFramework.Controls.MetroComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MinFlorTextbox = new KK2.UserControls.MiTextBox();
            this.MaxFlorTextbox = new KK2.UserControls.MiTextBox();
            this.MinNumbRoomsTextbox = new KK2.UserControls.MiTextBox();
            this.MaxNumbRoomsTextbox = new KK2.UserControls.MiTextBox();
            this.MinPriceTextbox = new KK2.UserControls.MiTextBox();
            this.MaxPriceTextbox = new KK2.UserControls.MiTextBox();
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
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.District_box);
            this.panel1.Controls.Add(this.Haustype_box);
            this.panel1.Location = new System.Drawing.Point(57, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 412);
            this.panel1.TabIndex = 0;
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
            this.materialFlatButton1.Location = new System.Drawing.Point(210, 328);
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
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(244, 205);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(31, 21);
            this.bunifuCustomLabel7.TabIndex = 26;
            this.bunifuCustomLabel7.Text = "до";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(69, 205);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(78, 21);
            this.bunifuCustomLabel8.TabIndex = 25;
            this.bunifuCustomLabel8.Text = "Цена от";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(314, 157);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(31, 21);
            this.bunifuCustomLabel5.TabIndex = 22;
            this.bunifuCustomLabel5.Text = "до";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(69, 157);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(198, 21);
            this.bunifuCustomLabel6.TabIndex = 21;
            this.bunifuCustomLabel6.Text = "Количество комнат от";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(195, 108);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(31, 21);
            this.bunifuCustomLabel4.TabIndex = 18;
            this.bunifuCustomLabel4.Text = "до";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(69, 108);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(79, 21);
            this.bunifuCustomLabel1.TabIndex = 17;
            this.bunifuCustomLabel1.Text = "Этаж от";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(339, 250);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(63, 21);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Район";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(125, 250);
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
            this.District_box.Location = new System.Drawing.Point(273, 274);
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
            this.Haustype_box.Location = new System.Drawing.Point(73, 274);
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
            // description_textbox
            // 
            this.description_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.description_textbox.Location = new System.Drawing.Point(616, 128);
            this.description_textbox.Multiline = true;
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(261, 361);
            this.description_textbox.TabIndex = 1;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(612, 104);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(111, 21);
            this.bunifuCustomLabel10.TabIndex = 30;
            this.bunifuCustomLabel10.Text = "ОПИСАНИЕ";
            // 
            // MinFlorTextbox
            // 
            this.MinFlorTextbox.AutoSize = true;
            this.MinFlorTextbox.DefaultText = null;
            this.MinFlorTextbox.error = true;
            this.MinFlorTextbox.Location = new System.Drawing.Point(155, 99);
            this.MinFlorTextbox.Name = "MinFlorTextbox";
            this.MinFlorTextbox.Size = new System.Drawing.Size(33, 30);
            this.MinFlorTextbox.TabIndex = 31;
            // 
            // MaxFlorTextbox
            // 
            this.MaxFlorTextbox.AutoSize = true;
            this.MaxFlorTextbox.DefaultText = null;
            this.MaxFlorTextbox.error = true;
            this.MaxFlorTextbox.Location = new System.Drawing.Point(232, 99);
            this.MaxFlorTextbox.Name = "MaxFlorTextbox";
            this.MaxFlorTextbox.Size = new System.Drawing.Size(33, 30);
            this.MaxFlorTextbox.TabIndex = 32;
            // 
            // MinNumbRoomsTextbox
            // 
            this.MinNumbRoomsTextbox.AutoSize = true;
            this.MinNumbRoomsTextbox.DefaultText = null;
            this.MinNumbRoomsTextbox.error = true;
            this.MinNumbRoomsTextbox.Location = new System.Drawing.Point(273, 148);
            this.MinNumbRoomsTextbox.Name = "MinNumbRoomsTextbox";
            this.MinNumbRoomsTextbox.Size = new System.Drawing.Size(33, 30);
            this.MinNumbRoomsTextbox.TabIndex = 33;
            // 
            // MaxNumbRoomsTextbox
            // 
            this.MaxNumbRoomsTextbox.AutoSize = true;
            this.MaxNumbRoomsTextbox.DefaultText = null;
            this.MaxNumbRoomsTextbox.error = true;
            this.MaxNumbRoomsTextbox.Location = new System.Drawing.Point(351, 148);
            this.MaxNumbRoomsTextbox.Name = "MaxNumbRoomsTextbox";
            this.MaxNumbRoomsTextbox.Size = new System.Drawing.Size(33, 30);
            this.MaxNumbRoomsTextbox.TabIndex = 34;
            // 
            // MinPriceTextbox
            // 
            this.MinPriceTextbox.AutoSize = true;
            this.MinPriceTextbox.DefaultText = null;
            this.MinPriceTextbox.error = true;
            this.MinPriceTextbox.Location = new System.Drawing.Point(155, 196);
            this.MinPriceTextbox.Name = "MinPriceTextbox";
            this.MinPriceTextbox.Size = new System.Drawing.Size(82, 30);
            this.MinPriceTextbox.TabIndex = 35;
            // 
            // MaxPriceTextbox
            // 
            this.MaxPriceTextbox.AutoSize = true;
            this.MaxPriceTextbox.DefaultText = null;
            this.MaxPriceTextbox.error = true;
            this.MaxPriceTextbox.Location = new System.Drawing.Point(281, 196);
            this.MaxPriceTextbox.Name = "MaxPriceTextbox";
            this.MaxPriceTextbox.Size = new System.Drawing.Size(82, 30);
            this.MaxPriceTextbox.TabIndex = 36;
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.panel1);
            this.Name = "Buy";
            this.Size = new System.Drawing.Size(940, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private MetroFramework.Controls.MetroComboBox District_box;
        private MetroFramework.Controls.MetroComboBox Haustype_box;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.TextBox description_textbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private MiTextBox MaxPriceTextbox;
        private MiTextBox MinPriceTextbox;
        private MiTextBox MaxNumbRoomsTextbox;
        private MiTextBox MinNumbRoomsTextbox;
        private MiTextBox MaxFlorTextbox;
        private MiTextBox MinFlorTextbox;
    }
}
