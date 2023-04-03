
namespace KK2.UserControls
{
    partial class btn_panel
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn_panel));
            this.BtnRent = new System.Windows.Forms.Button();
            this.BtnGetby = new System.Windows.Forms.Button();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.BtnSell = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlNav = new System.Windows.Forms.Panel();
            this.BtnDogovor = new System.Windows.Forms.Button();
            this.BtnVariant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRent
            // 
            this.BtnRent.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.BtnRent, BunifuAnimatorNS.DecorationType.None);
            this.BtnRent.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRent.FlatAppearance.BorderSize = 0;
            this.BtnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRent.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.BtnRent.Location = new System.Drawing.Point(0, 208);
            this.BtnRent.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRent.Name = "BtnRent";
            this.BtnRent.Size = new System.Drawing.Size(246, 52);
            this.BtnRent.TabIndex = 3;
            this.BtnRent.Text = "Снять";
            this.BtnRent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnRent.UseVisualStyleBackColor = false;
            this.BtnRent.Click += new System.EventHandler(this.BtnRent_Click);
            this.BtnRent.Leave += new System.EventHandler(this.BtnRent_Leave);
            // 
            // BtnGetby
            // 
            this.BtnGetby.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.BtnGetby, BunifuAnimatorNS.DecorationType.None);
            this.BtnGetby.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGetby.FlatAppearance.BorderSize = 0;
            this.BtnGetby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetby.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnGetby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.BtnGetby.Location = new System.Drawing.Point(0, 156);
            this.BtnGetby.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGetby.Name = "BtnGetby";
            this.BtnGetby.Size = new System.Drawing.Size(246, 52);
            this.BtnGetby.TabIndex = 1;
            this.BtnGetby.Text = "Сдать";
            this.BtnGetby.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnGetby.UseVisualStyleBackColor = false;
            this.BtnGetby.Click += new System.EventHandler(this.BtnGetby_Click);
            this.BtnGetby.Leave += new System.EventHandler(this.BtnGetby_Leave);
            // 
            // BtnBuy
            // 
            this.BtnBuy.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.BtnBuy, BunifuAnimatorNS.DecorationType.None);
            this.BtnBuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBuy.FlatAppearance.BorderSize = 0;
            this.BtnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuy.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.BtnBuy.Location = new System.Drawing.Point(0, 104);
            this.BtnBuy.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(246, 52);
            this.BtnBuy.TabIndex = 1;
            this.BtnBuy.Text = "Купить";
            this.BtnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            this.BtnBuy.Leave += new System.EventHandler(this.BtnBuy_Leave);
            // 
            // BtnSell
            // 
            this.BtnSell.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.BtnSell, BunifuAnimatorNS.DecorationType.None);
            this.BtnSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSell.FlatAppearance.BorderSize = 0;
            this.BtnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSell.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.BtnSell.Location = new System.Drawing.Point(0, 52);
            this.BtnSell.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSell.Name = "BtnSell";
            this.BtnSell.Size = new System.Drawing.Size(246, 52);
            this.BtnSell.TabIndex = 1;
            this.BtnSell.Text = "Продать";
            this.BtnSell.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSell.UseVisualStyleBackColor = false;
            this.BtnSell.Click += new System.EventHandler(this.BtnSell_Click);
            this.BtnSell.Leave += new System.EventHandler(this.BtnSell_Leave);
            // 
            // BtnProfile
            // 
            this.BtnProfile.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.BtnProfile, BunifuAnimatorNS.DecorationType.None);
            this.BtnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProfile.FlatAppearance.BorderSize = 0;
            this.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfile.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.BtnProfile.Location = new System.Drawing.Point(0, 0);
            this.BtnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(246, 52);
            this.BtnProfile.TabIndex = 1;
            this.BtnProfile.Text = "Профиль";
            this.BtnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnProfile.UseVisualStyleBackColor = false;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            this.BtnProfile.Leave += new System.EventHandler(this.BtnProfile_Leave);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 5;
            this.bunifuTransition1.TimeStep = 0.03F;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bunifuTransition1.SetDecoration(this.pnlNav, BunifuAnimatorNS.DecorationType.None);
            this.pnlNav.Location = new System.Drawing.Point(0, 258);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 123);
            this.pnlNav.TabIndex = 2;
            // 
            // BtnDogovor
            // 
            this.BtnDogovor.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.BtnDogovor, BunifuAnimatorNS.DecorationType.None);
            this.BtnDogovor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDogovor.FlatAppearance.BorderSize = 0;
            this.BtnDogovor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDogovor.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.BtnDogovor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.BtnDogovor.Location = new System.Drawing.Point(0, 331);
            this.BtnDogovor.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDogovor.Name = "BtnDogovor";
            this.BtnDogovor.Size = new System.Drawing.Size(246, 69);
            this.BtnDogovor.TabIndex = 8;
            this.BtnDogovor.Text = "Составить договор";
            this.BtnDogovor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDogovor.UseVisualStyleBackColor = false;
            this.BtnDogovor.Click += new System.EventHandler(this.BtnDogovor_Click);
            this.BtnDogovor.Leave += new System.EventHandler(this.BtnDogovor_Leave);
            // 
            // BtnVariant
            // 
            this.BtnVariant.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.BtnVariant, BunifuAnimatorNS.DecorationType.None);
            this.BtnVariant.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVariant.FlatAppearance.BorderSize = 0;
            this.BtnVariant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVariant.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.BtnVariant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.BtnVariant.Location = new System.Drawing.Point(0, 260);
            this.BtnVariant.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVariant.Name = "BtnVariant";
            this.BtnVariant.Size = new System.Drawing.Size(246, 71);
            this.BtnVariant.TabIndex = 9;
            this.BtnVariant.Text = "Подобрать вариант";
            this.BtnVariant.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnVariant.UseVisualStyleBackColor = false;
            this.BtnVariant.Click += new System.EventHandler(this.BtnVariant_Click);
            this.BtnVariant.Leave += new System.EventHandler(this.BtnVariant_Leave);
            // 
            // btn_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.BtnDogovor);
            this.Controls.Add(this.BtnVariant);
            this.Controls.Add(this.BtnRent);
            this.Controls.Add(this.BtnGetby);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.BtnSell);
            this.Controls.Add(this.BtnProfile);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "btn_panel";
            this.Size = new System.Drawing.Size(246, 419);
            this.Load += new System.EventHandler(this.btn_user_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnGetby;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button BtnSell;
        private System.Windows.Forms.Button BtnRent;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button BtnDogovor;
        private System.Windows.Forms.Button BtnVariant;
    }
}
