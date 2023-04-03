
namespace KK2.UserControls
{
    partial class Sell
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
            this.Haustype_box = new MetroFramework.Controls.MetroComboBox();
            this.District_box = new MetroFramework.Controls.MetroComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdresTextbox = new KK2.UserControls.MiTextBox();
            this.SqTextbox = new KK2.UserControls.MiTextBox();
            this.RoomsTextbox = new KK2.UserControls.MiTextBox();
            this.RowTextbox = new KK2.UserControls.MiTextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.Price_box = new KK2.UserControls.MiTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.Haustype_box.Location = new System.Drawing.Point(47, 235);
            this.Haustype_box.Name = "Haustype_box";
            this.Haustype_box.Size = new System.Drawing.Size(210, 30);
            this.Haustype_box.TabIndex = 0;
            this.Haustype_box.UseSelectable = true;
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
            this.District_box.Location = new System.Drawing.Point(279, 235);
            this.District_box.Name = "District_box";
            this.District_box.Size = new System.Drawing.Size(210, 30);
            this.District_box.TabIndex = 5;
            this.District_box.UseSelectable = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(161, 51);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(204, 21);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "ЗАПОЛНИТЕ ВСЕ ПОЛЯ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Price_box);
            this.panel1.Controls.Add(this.AdresTextbox);
            this.panel1.Controls.Add(this.SqTextbox);
            this.panel1.Controls.Add(this.RoomsTextbox);
            this.panel1.Controls.Add(this.RowTextbox);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.District_box);
            this.panel1.Controls.Add(this.Haustype_box);
            this.panel1.Location = new System.Drawing.Point(57, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 412);
            this.panel1.TabIndex = 7;
            // 
            // AdresTextbox
            // 
            this.AdresTextbox.AutoSize = true;
            this.AdresTextbox.DefaultText = "Адрес";
            this.AdresTextbox.error = true;
            this.AdresTextbox.Location = new System.Drawing.Point(279, 150);
            this.AdresTextbox.Name = "AdresTextbox";
            this.AdresTextbox.Size = new System.Drawing.Size(210, 30);
            this.AdresTextbox.TabIndex = 36;
            // 
            // SqTextbox
            // 
            this.SqTextbox.AutoSize = true;
            this.SqTextbox.DefaultText = "Общая площадь";
            this.SqTextbox.error = true;
            this.SqTextbox.Location = new System.Drawing.Point(47, 150);
            this.SqTextbox.Name = "SqTextbox";
            this.SqTextbox.Size = new System.Drawing.Size(210, 30);
            this.SqTextbox.TabIndex = 35;
            // 
            // RoomsTextbox
            // 
            this.RoomsTextbox.AutoSize = true;
            this.RoomsTextbox.DefaultText = "Количество комнат";
            this.RoomsTextbox.error = true;
            this.RoomsTextbox.Location = new System.Drawing.Point(279, 94);
            this.RoomsTextbox.Name = "RoomsTextbox";
            this.RoomsTextbox.Size = new System.Drawing.Size(210, 30);
            this.RoomsTextbox.TabIndex = 34;
            // 
            // RowTextbox
            // 
            this.RowTextbox.AutoSize = true;
            this.RowTextbox.DefaultText = "Этаж";
            this.RowTextbox.error = true;
            this.RowTextbox.Location = new System.Drawing.Point(47, 94);
            this.RowTextbox.Name = "RowTextbox";
            this.RowTextbox.Size = new System.Drawing.Size(210, 30);
            this.RowTextbox.TabIndex = 33;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(352, 211);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(63, 21);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Район";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(103, 211);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(91, 21);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Тип дома";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(208, 350);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(114, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Отправить";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(631, 99);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(111, 21);
            this.bunifuCustomLabel10.TabIndex = 32;
            this.bunifuCustomLabel10.Text = "ОПИСАНИЕ";
            // 
            // description_textbox
            // 
            this.description_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.description_textbox.Location = new System.Drawing.Point(616, 128);
            this.description_textbox.Multiline = true;
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(261, 361);
            this.description_textbox.TabIndex = 31;
            // 
            // Price_box
            // 
            this.Price_box.AutoSize = true;
            this.Price_box.DefaultText = "Цена";
            this.Price_box.error = true;
            this.Price_box.Location = new System.Drawing.Point(47, 294);
            this.Price_box.Name = "Price_box";
            this.Price_box.Size = new System.Drawing.Size(210, 30);
            this.Price_box.TabIndex = 42;
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.panel1);
            this.Name = "Sell";
            this.Size = new System.Drawing.Size(940, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox Haustype_box;
        private MetroFramework.Controls.MetroComboBox District_box;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.TextBox description_textbox;
        private UserControls.MiTextBox RowTextbox;
        private UserControls.MiTextBox AdresTextbox;
        private UserControls.MiTextBox SqTextbox;
        private UserControls.MiTextBox RoomsTextbox;
        private MiTextBox Price_box;
    }
}
