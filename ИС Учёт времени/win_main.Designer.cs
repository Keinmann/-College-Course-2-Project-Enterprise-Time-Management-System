namespace ИС_Учёт_времени
{
    partial class win_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win_main));
            this.win_main_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorize_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginworkintoolmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.win_main_contextmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quit_w_m_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.win_main_contextmenustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // win_main_ToolStripMenuItem
            // 
            this.win_main_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorize_ToolStripMenuItem,
            this.exit_ToolStripMenuItem});
            this.win_main_ToolStripMenuItem.Name = "win_main_ToolStripMenuItem";
            this.win_main_ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.win_main_ToolStripMenuItem.Text = "Программа";
            // 
            // autorize_ToolStripMenuItem
            // 
            this.autorize_ToolStripMenuItem.Name = "autorize_ToolStripMenuItem";
            this.autorize_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autorize_ToolStripMenuItem.Text = "Авторизация";
            this.autorize_ToolStripMenuItem.Click += new System.EventHandler(this.авторизацияToolStripMenuItem_Click);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exit_ToolStripMenuItem.Text = "Выход";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.win_main_ToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.beginworkintoolmenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаПодключенияToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкаПодключенияToolStripMenuItem
            // 
            this.настройкаПодключенияToolStripMenuItem.Name = "настройкаПодключенияToolStripMenuItem";
            this.настройкаПодключенияToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.настройкаПодключенияToolStripMenuItem.Text = "Подключение базы данных";
            this.настройкаПодключенияToolStripMenuItem.Click += new System.EventHandler(this.настройкаПодключенияToolStripMenuItem_Click);
            // 
            // beginworkintoolmenu
            // 
            this.beginworkintoolmenu.Enabled = false;
            this.beginworkintoolmenu.Name = "beginworkintoolmenu";
            this.beginworkintoolmenu.Size = new System.Drawing.Size(99, 20);
            this.beginworkintoolmenu.Text = "Начать работу";
            this.beginworkintoolmenu.Click += new System.EventHandler(this.beginworkintoolmenu_Click);
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.win_main_contextmenustrip;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            // 
            // win_main_contextmenustrip
            // 
            this.win_main_contextmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quit_w_m_cms});
            this.win_main_contextmenustrip.Name = "win_main_contextmenustrip";
            this.win_main_contextmenustrip.Size = new System.Drawing.Size(109, 26);
            // 
            // quit_w_m_cms
            // 
            this.quit_w_m_cms.Name = "quit_w_m_cms";
            this.quit_w_m_cms.Size = new System.Drawing.Size(108, 22);
            this.quit_w_m_cms.Text = "Выход";
            this.quit_w_m_cms.Click += new System.EventHandler(this.quit_w_m_cms_Click);
            // 
            // win_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "win_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИС Учёт Времени [Не авторизован]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.win_main_Load);
            this.Resize += new System.EventHandler(this.win_main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.win_main_contextmenustrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem win_main_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorize_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаПодключенияToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip win_main_contextmenustrip;
        private System.Windows.Forms.ToolStripMenuItem quit_w_m_cms;
        private System.Windows.Forms.ToolStripMenuItem beginworkintoolmenu;
    }
}