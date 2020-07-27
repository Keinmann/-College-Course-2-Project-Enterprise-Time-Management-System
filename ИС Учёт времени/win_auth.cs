using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИС_Учёт_времени
{
    public partial class win_auth : Form
    {   
        private string filepath = Application.StartupPath + "/pref/dbpreferences.txt";
        private win_main parental;
        private DataTable table = new DataTable();
        public win_auth(win_main parental)
        {
            this.parental = parental;
            InitializeComponent();
        }

        //Обработка полей
        private void textbox_login_Enter(object sender, EventArgs e)
        {
            if(textbox_login.Text=="Введите логин") textbox_login.Text = "";
        }
        private void textbox_password_Enter(object sender, EventArgs e)
        {
            if (textbox_password.Text == "Введите пароль") textbox_password.Text = "";
        }
        private void textbox_login_Leave(object sender, EventArgs e)
        {
            if (textbox_login.Text == "") textbox_login.Text = "Введите логин";
        }
        private void textbox_password_Leave(object sender, EventArgs e)
        {
            if (textbox_password.Text == "") textbox_password.Text = "Введите пароль";
        }
        //---------------
        private void button_login_Click(object sender, EventArgs e)
        {
            if (!ValidateAuth()) 
            {
                MessageBox.Show("Данные введены некорректно","Ошибка");
                return;
            }
            if (Authorise())
            {
                parental.user.id = table.Rows[0].Field<UInt32>("Id");
                parental.user.username = table.Rows[0].Field<string>("Name");
                parental.user.usersurname = table.Rows[0].Field<string>("Surname");
                parental.user.userlastname = table.Rows[0].Field<string>("Lastname");
                parental.user.useraccess = table.Rows[0].Field<UInt32>("Access");
                parental.user.statusid = table.Rows[0].Field<UInt32>("StatusId");
                parental.user.authorized = true;
                parental.user.scheduleid = table.Rows[0].Field<UInt32>("ScheduleId");
                MessageBox.Show("Вы вошли как\n"+parental.user.usersurname+" "+parental.user.username+" "+parental.user.userlastname, "Уведомление");
                parental.authorize();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации","Ошибка");
            }
        }
        private bool ValidateAuth() 
        {
            if (textbox_login.Text.Length > 45 ||
                textbox_password.Text.Length > 45)
            {
                return false;
            }
            else { return true; }
        }
        private bool Authorise() 
        {
            String login = textbox_login.Text;
            String password = textbox_password.Text;
            DB database = new DB();
            database.SetPreferences(filepath);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            bool islogged = false;
            MySqlCommand command = new MySqlCommand("SELECT Id, Name, Surname, Lastname, Access, StatusId, ScheduleId FROM user WHERE Login = @log AND Password = @pas;",database.getConnection());
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command; 
            try
            {
                database.openConnection();
                adapter.Fill(table);
            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных","Ошибка");
            }
            finally 
            {
                database.closeConnection();
            }
            if (table.Rows.Count > 0) 
            {
                islogged = true;
            }
            else
            {
                islogged = false;
            }
            return islogged;
        }
    }
}
