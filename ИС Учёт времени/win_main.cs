using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ИС_Учёт_времени
{
    public partial class win_main : Form
    {
        public bool prestart = false;
        public User user = new User();

        public win_main()
        {
            InitializeComponent();
            
        }

        private void win_main_Load(object sender, EventArgs e)
        {
            Prestart();
            if (prestart == true)
            {
                if (user.authorized == false && (MessageBox.Show("Пользватель не авторизован.\nНачать авторизацию?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    Open_win_auth();
                }
            }
            else 
            {
                win_prestart conf = new win_prestart(this);
                conf.MdiParent = this;
                conf.Show();
            }
            notify.Visible = false;
            notify.BalloonTipText = "Приложение свёрнуто";
            notify.Text = notify.BalloonTipTitle = this.Text;
        }

        private void Open_win_auth() 
        {
            win_auth win_auth = new win_auth(parental: this);
            win_auth.MdiParent = this;
            win_auth.Show();
        }

        private void Prestart() 
        { string filepath = Application.StartupPath + "/pref/dbpreferences.txt";
            if (File.Exists(filepath))
            {
                string contents = File.ReadAllText(filepath);
                if (contents.Contains("server"))
                {
                    DB test = new DB();
                    test.SetPreferences(filepath);
                    if (test.checkConnection() == true)
                    {
                        prestart = true;
                    }
                    else
                    {
                        prestart = false;
                    }
                }
                else 
                {
                    prestart = false;
                }
            }
            else
            { 
                prestart = false; 
            }
            
        }
        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.authorized == true && MessageBox.Show("Вы уверены?", "Подтвердите дейстие", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deauthorize();
                Open_win_auth();
            }
            else if (user.authorized == false) 
            {
                Open_win_auth();
            }
            
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void authorize()
        {
            this.Text = "ИС Учёт Времени [" + user.usersurname + " " + user.username + " " + user.userlastname + "]";
            if (user.statusid == 1) { this.Text += " [Неактивен]"; }
            notify.Text = notify.BalloonTipTitle = this.Text;
            beginworkintoolmenu.Enabled = true;
            switch (user.useraccess)
            {
                case 1:
                    win_user win_usr = new win_user(this.user,this.user.useraccess);
                    win_usr.MdiParent = this;
                    win_usr.Show(); 
                    break;
                case 2: 
                    win_admin win_adm = new win_admin(this.user);
                    win_adm.MdiParent = this;
                    win_adm.Show();
                    break;
            }
        }
        public void deauthorize() 
        {
            this.Text = "ИС Учёт Времени [Не авторизован]";
            notify.Text = notify.BalloonTipTitle = this.Text;
            user.Clear();
            while (MdiChildren.Count() > 0)
            { MdiChildren[0].Close(); }
            beginworkintoolmenu.Enabled = false;
        }

        private void настройкаПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            win_prestart win_prestart = new win_prestart(parental: this);
            win_prestart.MdiParent = this;
            win_prestart.Show();
        }

        private void win_main_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notify.Visible = true;
                notify.ShowBalloonTip(700);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notify.Visible = false;
            }
        }

        private void quit_w_m_cms_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void beginworkintoolmenu_Click(object sender, EventArgs e)
        {
            switch (user.useraccess)
            {
                case 1:
                    win_user win_usr = new win_user(this.user, this.user.useraccess) ;
                    win_usr.MdiParent = this;
                    win_usr.Show(); break;
                case 2:
                    win_admin win_adm = new win_admin(this.user);
                    win_adm.MdiParent = this;
                    win_adm.Show(); break;
            }
        }
    }
}
