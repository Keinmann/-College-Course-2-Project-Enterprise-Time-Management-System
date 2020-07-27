using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ИС_Учёт_времени
{
    public partial class win_user : Form
    {
        UInt32 access;
        private User parental;
        private string filepath = Application.StartupPath + "/pref/dbpreferences.txt";
        DataTable activities = new DataTable();
        DataTable Months = new DataTable();
        DataTable Years = new DataTable();
        public win_user(User parental , UInt32 UIaccess)
        {
            this.parental = parental;
            InitializeComponent();
            access = UIaccess;
        }

        private void win_user_Load(object sender, EventArgs e)
        {

            labelFIO.Text = parental.usersurname + " " + parental.username + " " + parental.userlastname;
            DB database = new DB();
            database.SetPreferences(filepath);
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("select * from schedules where Id = @id;", database.getConnection());
            command.Parameters.Add("@id",MySqlDbType.UInt32).Value = parental.scheduleid;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            try { database.openConnection(); adapter.Fill(table); }
            catch { MessageBox.Show("Ошибка работы базы данных", "Ошибка"); }
            finally { database.closeConnection(); }
            if (table.Rows.Count > 0) 
            {
                label_s_timeinit.Text = table.Rows[0].Field<TimeSpan>("TimeInit").ToString().Substring(0,5);
                label_s_timeend.Text = table.Rows[0].Field<TimeSpan>("TimeEnd").ToString().Substring(0, 5);
                label_s_lunch.Text = table.Rows[0].Field<TimeSpan>("Lunch").ToString().Substring(0, 5);
            }
            Updatedata(DateTime.Now.Month, DateTime.Now.Year);
            combomonth.Text = MonthName(DateTime.Now.Month);
            comboyear.Text = DateTime.Now.Year.ToString();
            
        }
        private void Updatedata(Int32 month, Int32 year) 
        {
            activities.Clear();
            Years.Clear();
            Months.Clear();
            DB _database = new DB();
            _database.SetPreferences(filepath);
            MySqlCommand _command = new MySqlCommand("select distinct extract(Year from ActivityDate) as Years from activities where UserId = @uid order by Years desc", _database.getConnection());
            _command.Parameters.Add("@uid", MySqlDbType.UInt32).Value = parental.id;
            MySqlDataAdapter _adapter = new MySqlDataAdapter(_command);
            try
            {
                _database.openConnection();
                _adapter.Fill(Years);
            }
            catch { MessageBox.Show("Ошибка работы базы данных", "Ошибка"); }
            finally { _database.closeConnection(); }

            _command = new MySqlCommand("select distinct extract(Month from ActivityDate) as Months from activities where UserId = @uid order by Months desc", _database.getConnection());
            _command.Parameters.Add("@uid", MySqlDbType.UInt32).Value = parental.id;
            _adapter = new MySqlDataAdapter(_command);
            try
            {
                _database.openConnection();
                _adapter.Fill(Months);
            }
            catch { MessageBox.Show("Ошибка работы базы данных", "Ошибка"); }
            finally { _database.closeConnection(); }

            int nowmonth = month;
            int nowyear = year;
            combomonth.Items.Clear();
            for (int i = 0; i < Months.Rows.Count; i++) 
            {
                string monthname = "";
                Int32 index = Months.Rows[i].Field<Int32>("Months");
                monthname = MonthName(index);
                combomonth.Items.Add(monthname);
            }
            comboyear.Items.Clear();
            for (int i = 0; i < Years.Rows.Count; i++)
            {
                comboyear.Items.Add(Years.Rows[i].Field<Int32>("Years").ToString());
            }
            //
            _command = new MySqlCommand("select * from activities where UserId = @uid and extract(month from ActivityDate) = @cum and extract(year from ActivityDate) = @cuy;", _database.getConnection());
            _command.Parameters.Add("@uid", MySqlDbType.UInt32).Value = parental.id;
            _command.Parameters.Add("@cum", MySqlDbType.UInt32).Value = nowmonth;
            _command.Parameters.Add("@cuy", MySqlDbType.UInt32).Value = nowyear;
            _adapter.SelectCommand = _command;
            try
            {
                _database.openConnection();
                _adapter.Fill(activities);
            }
            catch { MessageBox.Show("Ошибка работы базы данных", "Ошибка"); }
            finally 
            {
                _database.closeConnection();
            }
            listactivities.Items.Clear();
            //
            for (int i = 0; i < activities.Rows.Count; i++) 
            {
                string actname = activities.Rows[i].Field<DateTime>("ActivityDate").Date.ToShortDateString() + " : " + activities.Rows[i].Field<TimeSpan>("ActivityHours").ToString();
                listactivities.Items.Add(actname);
            }
            //
            TimeSpan sumtime = new TimeSpan();
            for (int i = 0; i < activities.Rows.Count; i++)
            {
                sumtime += activities.Rows[i].Field<TimeSpan>("ActivityHours");
            }
            labelmonthhour.Text = sumtime.ToString().Substring(0,5);
        }

        private void listactivities_SelectedIndexChanged(object sender, EventArgs e)
        {
        if (listactivities.SelectedIndex < 0) listactivities.SelectedIndex = 0;
        labelTimeInit.Text = activities.Rows[listactivities.SelectedIndex].Field<TimeSpan>("ActivityTimeInit").ToString().Substring(0,5);
        labelTimeEnd.Text = activities.Rows[listactivities.SelectedIndex].Field<TimeSpan>("ActivityTimeEnd").ToString().Substring(0, 5);
        labelHours.Text = activities.Rows[listactivities.SelectedIndex].Field<TimeSpan>("ActivityHours").ToString().Substring(0, 5);
        labelLunch.Text = activities.Rows[listactivities.SelectedIndex].Field<UInt32>("Lunch") == 1? "Отмечен" : "Не отмечен" ;
           
        }
        private string MonthName(Int32 index) 
        {
            string name = "";
            switch (index)
            {
                case 1: name = "Январь"; break;
                case 2: name = "Февраль"; break;
                case 3: name = "Март"; break;
                case 4: name = "Апрель"; break;
                case 5: name = "Май"; break;
                case 6: name = "Июнь"; break;
                case 7: name = "Июль"; break;
                case 8: name = "Август"; break;
                case 9: name = "Сентябрь"; break;
                case 10: name = "Октябрь"; break;
                case 11: name = "Ноябрь"; break;
                case 12: name = "Декабрь"; break;
            }

            return name;
        }
        private Int32 MonthIndex(string name) 
        {
            Int32 index=DateTime.Now.Month;
            switch (name) 
            {
                case "Январь": index = 1; break;
                case "Февраль": index = 2; break;
                case "Март": index = 3; break;
                case "Апрель": index = 4; break;
                case "Май": index = 5; break;
                case "Июнь": index = 6; break;
                case "Июль": index = 7; break;
                case "Август": index = 8; break;
                case "Сентябрь": index = 9; break;
                case "Октябрь": index = 10; break;
                case "Ноябрь": index = 11; break;
                case "Декабрь": index = 12; break;
            }
            return index;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 month = MonthIndex(combomonth.Text);
            Int32 year = Convert.ToInt32(comboyear.Text);
            Updatedata(month,year);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB database = new DB();
            database.SetPreferences(filepath);
            DataTable check = new DataTable();
            MySqlCommand command = new MySqlCommand("select * from activities where UserId=@id and ActivityDate = date(now())", database.getConnection());
            command.Parameters.Add("@Id", MySqlDbType.UInt32).Value = parental.id;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            try { database.openConnection(); adapter.Fill(check); }
            catch { MessageBox.Show("Ошибка работы базы данных", "Ошибка"); }
            finally { database.closeConnection(); }
            if (check.Rows.Count > 0)
            {
                int lunch = 0;
                if (MessageBox.Show("Сотрудник обедал?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lunch = 1;
                    command = new MySqlCommand("update activities set Lunch = @lunch, ActivityTimeEnd = curtime(), ActivityHours = subtime(curtime(), subtime(ActivityTimeInit , (select Lunch from schedules where Id = (Select ScheduleId from user where Id = @user_Id)))) where UserId = @user_Id and Id > 0 and ActivityDate = Date(now()) and ActivityTimeEnd = \"00:00:00\";", database.getConnection());
                    command.Parameters.Add("@user_Id", MySqlDbType.UInt32).Value = parental.id;
                    command.Parameters.Add("@lunch", MySqlDbType.Int32).Value = lunch;
                }
                else
                {
                    lunch = 0;
                    command = new MySqlCommand("update activities set Lunch = @lunch, ActivityTimeEnd = Time(now()), ActivityHours = subtime(curtime(),ActivityTimeInit) where UserId = @user_Id and Id > 0 and ActivityDate = date(now()) and ActivityTimeEnd = \"00:00:00\";", database.getConnection());
                    command.Parameters.Add("@user_Id", MySqlDbType.UInt32).Value = parental.id;
                    command.Parameters.Add("@lunch", MySqlDbType.Int32).Value = lunch;
                }

            }
            else
            {
                command = new MySqlCommand("insert into activities(UserId, ActivityDate, ActivityTimeInit, ActivityTimeEnd, ActivityHours, Lunch) select* from (select @user_Id,Date(now()),Time(now()),\"00:00:00\",\"00\",\'1') as tmp where not exists (select * from activities where id > 0 and UserId = @user_Id and ActivityDate = Date(Now()));", database.getConnection());
                command.Parameters.Add("@user_Id", MySqlDbType.UInt32).Value = parental.id;
            }
            try
            {
                database.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Отметка сделана", "Уведомление");
                }
                else
                {
                    MessageBox.Show("Отметка не сделана", "Уведомление");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка работы базы данных", "Ошибка");
            }
            finally
            {
                database.closeConnection();
            }
            Updatedata(DateTime.Now.Month,DateTime.Now.Year);
        }

    }
}

