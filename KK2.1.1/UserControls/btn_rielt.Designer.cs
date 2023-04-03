
namespace KK2.UserControls
{
    partial class btn_rielt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn_rielt));
            this.BtnDogovor = new System.Windows.Forms.Button();
            this.BtnVariant = new System.Windows.Forms.Button();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlNav = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            this.BtnDogovor.Location = new System.Drawing.Point(0, 71);
            this.BtnDogovor.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDogovor.Name = "BtnDogovor";
            this.BtnDogovor.Size = new System.Drawing.Size(246, 69);
            this.BtnDogovor.TabIndex = 6;
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
            this.BtnVariant.Location = new System.Drawing.Point(0, 0);
            this.BtnVariant.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVariant.Name = "BtnVariant";
            this.BtnVariant.Size = new System.Drawing.Size(246, 71);
            this.BtnVariant.TabIndex = 7;
            this.BtnVariant.Text = "Подобрать вариант";
            this.BtnVariant.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnVariant.UseVisualStyleBackColor = false;
            this.BtnVariant.Click += new System.EventHandler(this.BtnVarian_Click);
            this.BtnVariant.Leave += new System.EventHandler(this.BtnVariant_Leave);
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
            this.pnlNav.Location = new System.Drawing.Point(0, 103);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 123);
            this.pnlNav.TabIndex = 8;
            // 
            // btn_rielt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDogovor);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.BtnVariant);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "btn_rielt";
            this.Size = new System.Drawing.Size(246, 228);
            this.Load += new System.EventHandler(this.btn_rielt_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Button BtnDogovor;
        private System.Windows.Forms.Button BtnVariant;
        private System.Windows.Forms.Panel pnlNav;
    }
}
