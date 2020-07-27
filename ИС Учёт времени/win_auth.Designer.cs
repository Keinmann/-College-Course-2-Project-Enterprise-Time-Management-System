namespace ИС_Учёт_времени
{
    partial class win_auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win_auth));
            this.label_auth = new System.Windows.Forms.Label();
            this.textbox_login = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_auth
            // 
            this.label_auth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_auth.AutoSize = true;
            this.label_auth.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_auth.Location = new System.Drawing.Point(66, 9);
            this.label_auth.Name = "label_auth";
            this.label_auth.Size = new System.Drawing.Size(208, 32);
            this.label_auth.TabIndex = 0;
            this.label_auth.Text = "АВТОРИЗАЦИЯ";
            // 
            // textbox_login
            // 
            this.textbox_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textbox_login.Location = new System.Drawing.Point(111, 68);
            this.textbox_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_login.Name = "textbox_login";
            this.textbox_login.Size = new System.Drawing.Size(116, 21);
            this.textbox_login.TabIndex = 1;
            this.textbox_login.Text = "Введите логин";
            this.textbox_login.Enter += new System.EventHandler(this.textbox_login_Enter);
            this.textbox_login.Leave += new System.EventHandler(this.textbox_login_Leave);
            // 
            // textbox_password
            // 
            this.textbox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textbox_password.Location = new System.Drawing.Point(111, 107);
            this.textbox_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(116, 21);
            this.textbox_password.TabIndex = 2;
            this.textbox_password.Text = "Введите пароль";
            this.textbox_password.Enter += new System.EventHandler(this.textbox_password_Enter);
            this.textbox_password.Leave += new System.EventHandler(this.textbox_password_Leave);
            // 
            // button_login
            // 
            this.button_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_login.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_login.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button_login.Location = new System.Drawing.Point(128, 145);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(82, 38);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Вход";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // win_auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 198);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.textbox_login);
            this.Controls.Add(this.label_auth);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(347, 237);
            this.MinimumSize = new System.Drawing.Size(347, 237);
            this.Name = "win_auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_auth;
        private System.Windows.Forms.TextBox textbox_login;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Button button_login;
    }
}

