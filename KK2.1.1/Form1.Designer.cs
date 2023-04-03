
namespace KK2
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_user1 = new KK2.UserControls.btn_panel();
            this.profile1 = new KK2.UserControls.Profile();
            this.sell1 = new KK2.UserControls.Sell();
            this.buy1 = new KK2.UserControls.Buy();
            this.get_by1 = new KK2.UserControls.Get_by();
            this.rent1 = new KK2.UserControls.Rent();
            this.creatVariant1 = new KK2.UserControls.CreatVariant();
            this.createDogovor1 = new KK2.UserControls.CreateDogovor();
            this.LoginLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(172)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::KK2.Properties.Resources.cancel_24px;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(1029, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 28);
            this.panel4.TabIndex = 2;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btn_user1);
            this.panel2.Controls.Add(this.LoginLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 565);
            this.panel2.TabIndex = 1;
            // 
            // btn_user1
            // 
            this.btn_user1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_user1.Location = new System.Drawing.Point(0, 144);
            this.btn_user1.Name = "btn_user1";
            this.btn_user1.Size = new System.Drawing.Size(196, 419);
            this.btn_user1.TabIndex = 31;
            this.btn_user1.Viev1 = this.profile1;
            this.btn_user1.Viev2 = this.sell1;
            this.btn_user1.Viev3 = this.buy1;
            this.btn_user1.Viev4 = this.get_by1;
            this.btn_user1.Viev5 = this.rent1;
            this.btn_user1.Viev6 = this.creatVariant1;
            this.btn_user1.Viev7 = this.createDogovor1;
            // 
            // profile1
            // 
            this.profile1.Location = new System.Drawing.Point(202, 35);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(898, 565);
            this.profile1.TabIndex = 6;
            // 
            // sell1
            // 
            this.sell1.Location = new System.Drawing.Point(202, 35);
            this.sell1.Name = "sell1";
            this.sell1.Size = new System.Drawing.Size(898, 565);
            this.sell1.TabIndex = 2;
            this.sell1.Visible = false;
            // 
            // buy1
            // 
            this.buy1.Location = new System.Drawing.Point(202, 35);
            this.buy1.Name = "buy1";
            this.buy1.Size = new System.Drawing.Size(898, 565);
            this.buy1.TabIndex = 3;
            this.buy1.Visible = false;
            // 
            // get_by1
            // 
            this.get_by1.Location = new System.Drawing.Point(202, 35);
            this.get_by1.Name = "get_by1";
            this.get_by1.Size = new System.Drawing.Size(898, 565);
            this.get_by1.TabIndex = 4;
            this.get_by1.Visible = false;
            // 
            // rent1
            // 
            this.rent1.Location = new System.Drawing.Point(202, 35);
            this.rent1.Name = "rent1";
            this.rent1.Size = new System.Drawing.Size(898, 565);
            this.rent1.TabIndex = 5;
            this.rent1.Visible = false;
            // 
            // creatVariant1
            // 
            this.creatVariant1.Location = new System.Drawing.Point(202, 35);
            this.creatVariant1.Name = "creatVariant1";
            this.creatVariant1.Size = new System.Drawing.Size(898, 565);
            this.creatVariant1.TabIndex = 8;
            // 
            // createDogovor1
            // 
            this.createDogovor1.Location = new System.Drawing.Point(202, 35);
            this.createDogovor1.Name = "createDogovor1";
            this.createDogovor1.Size = new System.Drawing.Size(898, 565);
            this.createDogovor1.TabIndex = 7;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(0, 97);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LoginLabel.Size = new System.Drawing.Size(196, 47);
            this.LoginLabel.TabIndex = 30;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::KK2.Properties.Resources.icons8_user_64;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 97);
            this.panel3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.creatVariant1);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.buy1);
            this.Controls.Add(this.sell1);
            this.Controls.Add(this.rent1);
            this.Controls.Add(this.get_by1);
            this.Controls.Add(this.createDogovor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private UserControls.Sell sell1;
        private UserControls.Buy buy1;
        private UserControls.Get_by get_by1;
        private UserControls.Rent rent1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel LoginLabel;
        private UserControls.Profile profile1;
        private UserControls.CreateDogovor createDogovor1;
        private UserControls.CreatVariant creatVariant1;
        private UserControls.btn_panel btn_user1;
    }
}

