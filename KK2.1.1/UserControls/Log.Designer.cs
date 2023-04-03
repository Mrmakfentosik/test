
namespace KK2.UserControls
{
    partial class Log
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
            this.loginTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
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
            this.loginTextbox.Location = new System.Drawing.Point(114, 190);
            this.loginTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(314, 44);
            this.loginTextbox.TabIndex = 0;
            this.loginTextbox.Text = "Логин";
            this.loginTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginTextbox.Enter += new System.EventHandler(this.bunifuMaterialTextbox1_Enter);
            this.loginTextbox.Leave += new System.EventHandler(this.bunifuMaterialTextbox1_Leave);
            // 
            // passwordTextbox
            // 
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
            this.passwordTextbox.Location = new System.Drawing.Point(114, 276);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(314, 44);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.Text = "Пароль";
            this.passwordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextbox.Enter += new System.EventHandler(this.bunifuMaterialTextbox2_Enter);
            this.passwordTextbox.Leave += new System.EventHandler(this.bunifuMaterialTextbox2_Leave);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(233, 373);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(70, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Войти";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.loginTextbox);
            this.DoubleBuffered = true;
            this.Name = "Log";
            this.Size = new System.Drawing.Size(558, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox loginTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextbox;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}
