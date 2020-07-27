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
    public partial class win_admin : Form
    {
        User parental = new User();
        private string filepath = Application.StartupPath + "/pref/dbpreferences.txt";
        private DataTable employeetable = new DataTable();
        private DataTable statustable = new DataTable();
        private DataTable schedule = new DataTable();
        private bool editmode = false;
        private bool createmode = false;
        public win_admin(User parental)
        {
            this.parental = parental;
            InitializeComponent();
        }

        private void WriteMode() 
        {
            combostat.ForeColor = comboacc.ForeColor = textpas.ForeColor = textlog.ForeColor = textlas.ForeColor = textsur.ForeColor = textnam.ForeColor = Color.Black;
            combostat.Enabled = comboacc.Enabled = textpas.Enabled = textlog.Enabled = textlas.Enabled = textsur.Enabled = textnam.Enabled = combosched.Enabled = true;
            listemployee.Enabled = false;       
        }
        private void ReadMode() 
        {
            combostat.ForeColor = comboacc.ForeColor = textpas.ForeColor = textlog.ForeColor = textlas.ForeColor = textsur.ForeColor = textnam.ForeColor = Color.DimGray;
            combostat.Enabled = comboacc.Enabled = textpas.Enabled = textlog.Enabled = textlas.Enabled = textsur.Enabled = textnam.Enabled = combosched.Enabled = false;
        }
        private void ClearFields()
        {
            textnam.Text = textsur.Text = textlas.Text = textlog.Text = textpas.Text = "";
            combostat.SelectedIndex = comboacc.SelectedIndex = -1;
        }
        //BUTTONS---------------------------------------------------------
        private void btn_empedit_Click(object sender, EventArgs e)
        {
            editmode = !editmode;

            if (editmode)
            {
                WriteMode();
                btn_empcreate.Enabled = listemployee.Enabled= false;
                btn_empdelete.Text = "Отмена";
            }
            else
            {
                ReadMode();
                if (ValidateEdit())
                {
                    DB database = new DB();
                    database.SetPreferences(filepath);
                    MySqlCommand command = new MySqlCommand("UPDATE user SET Name = @nam,Surname=@sur,Lastname=@las,Login=@log,Password=@pas,Access=@acc,StatusId=@sta,ScheduleId=@sch WHERE Id = @id",database.getConnection());
                    command.Parameters.Add("@id", MySqlDbType.UInt32).Value = employeetable.Rows[listemployee.SelectedIndex].Field<UInt32>("Id");
                    command.Parameters.Add("@nam", MySqlDbType.VarChar).Value = textnam.Text;
                    command.Parameters.Add("@sur", MySqlDbType.VarChar).Value = textsur.Text;
                    command.Parameters.Add("@las", MySqlDbType.VarChar).Value = textlas.Text;
                    command.Parameters.Add("@log", MySqlDbType.VarChar).Value = textlog.Text;
                    command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = textpas.Text;
                    command.Parameters.Add("@acc", MySqlDbType.VarChar).Value = comboacc.SelectedIndex + 1;
                    command.Parameters.Add("@sta", MySqlDbType.VarChar).Value = combostat.SelectedIndex + 1;
                    command.Parameters.Add("@sch", MySqlDbType.UInt32).Value = schedule.Rows[combosched.SelectedIndex].Field<UInt32>("Id");
                    try
                    {
                        database.openConnection();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Аккаунт был изменён");
                        }
                        else
                        {
                            MessageBox.Show("Аккаунт не был изменён");
                        }
                    }
                    catch { MessageBox.Show("Ошибка базы данных", "Ошибка"); }
                    finally { database.closeConnection(); }
                }
                employeestolist();
            }
        }
        private void btn_empcreate_Click(object sender, EventArgs e)
        {
            createmode = !createmode;
            if (createmode)
            {
                WriteMode();
                ClearFields();
                btn_empedit.Enabled = false;
                btn_empdelete.Enabled = true;
                btn_empdelete.Text = "Отмена";
                comboacc.SelectedIndex = combostat.SelectedIndex = 0;
            }
            else
            {
                ReadMode();
                if (ValidateReg())
                { 
                    DB database = new DB();
                    database.SetPreferences(filepath);
                    MySqlCommand command = new MySqlCommand("INSERT INTO user (Name,Surname,Lastname,Login,Password,Access,StatusId,ScheduleId) values (@nam,@sur,@las,@log,@pas,@acc,@sta,@sch);", database.getConnection());

                    command.Parameters.Add("@nam", MySqlDbType.VarChar).Value = textnam.Text;
                    command.Parameters.Add("@sur", MySqlDbType.VarChar).Value = textsur.Text;
                    command.Parameters.Add("@las", MySqlDbType.VarChar).Value = textlas.Text;
                    command.Parameters.Add("@log", MySqlDbType.VarChar).Value = textlog.Text;
                    command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = textpas.Text;
                    command.Parameters.Add("@acc", MySqlDbType.VarChar).Value = comboacc.SelectedIndex+1;
                    command.Parameters.Add("@sta", MySqlDbType.VarChar).Value = combostat.SelectedIndex+1;
                    command.Parameters.Add("@sch", MySqlDbType.UInt32).Value = schedule.Rows[combosched.SelectedIndex].Field<UInt32>("Id");
                    try
                    {
                        database.openConnection();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Аккаунт был создан");
                        }
                        else
                        {
                            MessageBox.Show("Аккаунт не был создан");
                        }
                    }
                    catch { MessageBox.Show("Ошибка базы данных", "Ошибка"); }
                    finally { database.closeConnection(); }
                }
                btn_empdelete.Text = "Удалить";
                employeestolist();

            }
        }
        private void btn_empdelete_Click(object sender, EventArgs e)
        {
            if (!createmode && !editmode)
            {
                if (MessageBox.Show("Удаление учётной записи приведёт к\nкаскадному удалению всех записей о ней.\nВы уверены?", "Подтвердите действие", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DB database = new DB();
                    database.SetPreferences(filepath);
                    MySqlCommand command = new MySqlCommand("Delete from user where Id=@id;", database.getConnection());
                    command.Parameters.Add("@id", MySqlDbType.UInt32).Value = employeetable.Rows[listemployee.SelectedIndex].Field<UInt32>("Id");
                    try
                    {
                        database.openConnection();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Аккаунт был удалён");
                        }
                        else
                        {
                            MessageBox.Show("Аккаунт не был удалён");
                        }
                    }
                    catch { MessageBox.Show("Ошибка базы данных", "Ошибка"); }
                    finally { database.closeConnection(); }
                    employeestolist();
                }
            }
            if (createmode) { createmode = false; ClearFields(); employeestolist(); ReadMode(); btn_empdelete.Text = "Удалить"; }
            else if (editmode) { editmode = false; ClearFields(); employeestolist(); ReadMode(); btn_empdelete.Text = "Удалить"; }
          
        }
        //---------------------------------------------------------------
        public void employeestolist()
        {
            listemployee.Items.Clear();
            statustable.Clear();
            employeetable.Clear();
            string filepath = Application.StartupPath + "/pref/dbpreferences.txt";
            DB database = new DB();
            database.SetPreferences(filepath);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM user ORDER BY Surname;",database.getConnection());
            try
            {
                database.openConnection();
                adapter.SelectCommand = command;
                adapter.Fill(employeetable);
            }
            catch { MessageBox.Show("Ошибка работы базы данных", "Ошибка"); }
            finally { database.closeConnection(); }
            User [] employeelist = new User[employeetable.Rows.Count];

            for (int i = 0; i<employeetable.Rows.Count;i++) 
            {
                listemployee.Items.Remove(i);
                listemployee.Items.Add(employeetable.Rows[i].Field<string>("Surname") + " " + employeetable.Rows[i].Field<string>("Name") + " " + employeetable.Rows[i].Field<string>("Lastname"));
            }
            command = new MySqlCommand("SELECT * FROM userstatus;", database.getConnection());
            try
            {
                database.openConnection();
                adapter.SelectCommand = command;
                adapter.Fill(statustable);
            }
            catch { MessageBox.Show("Ошибка работы базы данных", "Ошибка"); }
            finally { database.closeConnection(); }
            combostat.Items.Clear();
            for (int i = 0; i < statustable.Rows.Count; i++) 
            {
                combostat.Items.Add(statustable.Rows[i].Field<string>("Status"));
            }
            comboacc.Items.Clear();
            comboacc.Items.Add("Пользователь");
            comboacc.Items.Add("Администратор");
            listemployee.Enabled = btn_empcreate.Enabled = true;
            btn_empdelete.Enabled = btn_empedit.Enabled = btnlook.Enabled= btnnote.Enabled = false;
            loadsched();

        }
        private void loadsched()
        {
            schedule.Clear();
            DB database = new DB();
            database.SetPreferences(filepath);
            MySqlDataAdapter adapter = new MySqlDataAdapter("select Name,Id from schedules order by Name;", database.getConnection());
            try
            {
                database.openConnection();
                adapter.Fill(schedule);
            }
            catch
            {
                MessageBox.Show("Ошибка работы базы данных");
            }
            finally 
            {
                database.closeConnection();
            }
            combosched.Items.Clear();
            for (int i = 0; i < schedule.Rows.Count; i++)
            {
                combosched.Items.Add(schedule.Rows[i].Field<string>("Name"));
            }
            combosched.SelectedIndex = -1;
        }
        private void win_admin_Load(object sender, EventArgs e)
        {
            employeestolist();
        }

        private void listemployee_SelectedIndexChanged(object sender, EventArgs e)
        { if (listemployee.SelectedIndex > employeetable.Rows.Count || listemployee.SelectedIndex < 0) { listemployee.SelectedIndex = 0; }
            if (listemployee.SelectedIndex >= 0) { btn_empdelete.Enabled = btn_empedit.Enabled = btnlook.Enabled = true; }
            else { btn_empdelete.Enabled = btn_empedit.Enabled=btnlook.Enabled = false; }
            textnam.Text = employeetable.Rows[listemployee.SelectedIndex].Field<string>("Name");
            textsur.Text = employeetable.Rows[listemployee.SelectedIndex].Field<string>("Surname");
            textlas.Text = employeetable.Rows[listemployee.SelectedIndex].Field<string>("Lastname");
            textlog.Text = employeetable.Rows[listemployee.SelectedIndex].Field<string>("Login");
            textpas.Text = employeetable.Rows[listemployee.SelectedIndex].Field<string>("Password");
            comboacc.SelectedIndex = Convert.ToInt32(employeetable.Rows[listemployee.SelectedIndex].Field<UInt32>("Access") - 1);
            combostat.SelectedIndex = Convert.ToInt32(employeetable.Rows[listemployee.SelectedIndex].Field<UInt32>("StatusId") - 1);
            Int32 empshcedid =Convert.ToInt32( employeetable.Rows[listemployee.SelectedIndex].Field<UInt32>("ScheduleId"));
            if (empshcedid != 0) 
            { 
            for (int i = 0; i < schedule.Rows.Count; i++) 
                {
                    if (empshcedid == Convert.ToInt32(schedule.Rows[i].Field<UInt32>("Id"))) 
                    {
                        combosched.SelectedIndex = Convert.ToInt32(i); break;
                    } 
                }
                btnnote.Enabled = btnlook.Enabled = true;
            }
            else { combosched.SelectedIndex = -1; }

        }
        private bool ValidateReg()
        {
            bool validated = true;
            DB database = new DB();
            database.SetPreferences(filepath);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE Login = @log;", database.getConnection());
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = this.textlog.Text;
            try { database.openConnection(); adapter.SelectCommand = command; adapter.Fill(table); }
            catch { MessageBox.Show("Ошибка базы данных при проверке", "Ошибка"); validated = false; }
            finally { database.closeConnection(); }
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Запись с логином: " + this.textlog.Text + "\nуже существует!\nСмените логин.", "Ошибка");
                validated = false;
            }
            else
            {
                if (textnam.Text.Length >= 45 ||
                    textnam.Text == "" ||
                    textnam.Text == "Введите имя" ||
                    textsur.Text.Length >= 45 ||
                    textsur.Text == "" ||
                    textsur.Text == "Введите фамилию" ||
                    textlas.Text.Length >= 45 ||
                    textlas.Text == "" ||
                    textlas.Text == "Введите отчество" ||
                    textlog.Text.Length >= 45 ||
                    textlog.Text == "" ||
                    textlog.Text == "Введите логин" ||
                    textpas.Text.Length >= 45 ||
                    textpas.Text == "" ||
                    textpas.Text == "Введите пароль"
                     )
                {
                    validated = false;
                }
                else
                {
                    for (int i = 0; i < textlog.Text.Length; i++)
                    {
                        string log = textlog.Text;
                        if (textlog.Text[i] < '1' || (textlog.Text[i] > '9' && textlog.Text[i] < 'A') || (textlog.Text[i] > 'Z' && textlog.Text[i] < 'a') || textlog.Text[i] > 'z')
                        { 
                            validated = false; MessageBox.Show("Логин должен содержать \nтолько латинские буквы\n и цифры", "Ошибка"); break; 
                        }

                    }
                    for (int i = 0; i < textpas.Text.Length; i++)
                    {
                        if (textpas.Text[i] < '1' || (textpas.Text[i] > '9' && textpas.Text[i] < 'A') || (textpas.Text[i] > 'Z' && textpas.Text[i] < 'a') || textpas.Text[i] > 'z')
                        { 
                            validated = false; MessageBox.Show("Пароль должен содержать \nтолько латинские буквы\nи цифры", "Ошибка"); break; 
                        }
                    }
                    for (int i = 0; i < textnam.Text.Length; i++) 
                    {
                        if (textnam.Text[i] < 'А' || (textnam.Text[i] > 'п' && textnam.Text[i] < 'р') || textnam.Text[i] > 'я') 
                        {
                            validated = false; MessageBox.Show("Имя должно содержать только кириллицу","Ошибка"); break;
                        }
                    }
                    for (int i = 0; i < textsur.Text.Length; i++)
                    {
                        if (textsur.Text[i] < 'А' || (textsur.Text[i] > 'п' && textsur.Text[i] < 'р') || textsur.Text[i] > 'я')
                        {
                            validated = false; MessageBox.Show("Фамилия должна содержать только кириллицу", "Ошибка"); break;
                        }
                    }
                    for (int i = 0; i < textlas.Text.Length; i++)
                    {
                        if (textlas.Text[i] < 'А' || (textlas.Text[i] > 'п' && textlas.Text[i] < 'р') || textlas.Text[i] > 'я')
                        {
                            validated = false; MessageBox.Show("Отчество должно содержать только кириллицу", "Ошибка"); break;
                        }
                    }
                }
            }
            return validated;
        }

        private bool ValidateEdit()
        {
            bool validated = true;
                if (textnam.Text.Length >= 45 ||
                    textnam.Text == "" ||
                    textnam.Text == "Введите имя" ||
                    textsur.Text.Length >= 45 ||
                    textsur.Text == "" ||
                    textsur.Text == "Введите фамилию" ||
                    textlas.Text.Length >= 45 ||
                    textlas.Text == "" ||
                    textlas.Text == "Введите отчество" ||
                    textlog.Text.Length >= 45 ||
                    textlog.Text == "" ||
                    textlog.Text == "Введите логин" ||
                    textpas.Text.Length >= 45 ||
                    textpas.Text == "" ||
                    textpas.Text == "Введите пароль"
                     )
                {
                    validated = false;
                }
                else
                {
                    for (int i = 0; i < textlog.Text.Length; i++)
                    {
                        string log = textlog.Text;
                        if (textlog.Text[i] < '1' || (textlog.Text[i] > '9' && textlog.Text[i] < 'A') || (textlog.Text[i] > 'Z' && textlog.Text[i] < 'a') || textlog.Text[i] > 'z')
                        { validated = false; MessageBox.Show("Логин должен содержать \nтолько латинские буквы\n и цифры", "Ошибка"); break; }

                    }
                    for (int i = 0; i < textpas.Text.Length; i++)
                    {
                        if (textpas.Text[i] < '1' || (textpas.Text[i] > '9' && textpas.Text[i] < 'A') || (textpas.Text[i] > 'Z' && textpas.Text[i] < 'a') || textpas.Text[i] > 'z')
                        { validated = false; MessageBox.Show("Пароль должен содержать \nтолько латинские буквы\nи цифры", "Ошибка"); break; }
                    }
                    for (int i = 0; i < textnam.Text.Length; i++)
                    {
                        if (textnam.Text[i] < 'А' || (textnam.Text[i] > 'п' && textnam.Text[i] < 'р') || textnam.Text[i] > 'я')
                        {
                            validated = false; MessageBox.Show("Имя должно содержать только кириллицу", "Ошибка");
                        }
                    }
                    for (int i = 0; i < textsur.Text.Length; i++)
                    {
                        if (textsur.Text[i] < 'А' || (textsur.Text[i] > 'п' && textsur.Text[i] < 'р') || textsur.Text[i] > 'я')
                        {
                            validated = false; MessageBox.Show("Фамилия должна содержать только кириллицу", "Ошибка");
                        }
                    }
                    for (int i = 0; i < textlas.Text.Length; i++)
                    {
                        if (textlas.Text[i] < 'А' || (textlas.Text[i] > 'п' && textlas.Text[i] < 'р') || textlas.Text[i] > 'я')
                        {
                            validated = false; MessageBox.Show("Отчество должно содержать только кириллицу", "Ошибка");
                        }
                    }
                
            }
            return validated;
        }

        private void графикиРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            win_schedules shed = new win_schedules();
            shed.MdiParent = this.MdiParent;
            shed.Show();
        }

        private void btnlook_Click(object sender, EventArgs e)
        {
            User usr = new User();
            usr.authorized = false;
            usr.id = employeetable.Rows[listemployee.SelectedIndex].Field<UInt32>("Id");
            usr.scheduleid = employeetable.Rows[listemployee.SelectedIndex].Field<UInt32>("ScheduleId");
            usr.username = employeetable.Rows[listemployee.SelectedIndex].Field<string>("Name");
            usr.usersurname = employeetable.Rows[listemployee.SelectedIndex].Field<string>("Surname");
            usr.userlastname = employeetable.Rows[listemployee.SelectedIndex].Field<string>("Lastname");
            win_user winusr = new win_user(usr, parental.useraccess);
            winusr.MdiParent = this.MdiParent;
            winusr.Show();
        }

        private void btnnote_Click(object sender, EventArgs e)
        {
            DB database = new DB();
            database.SetPreferences(filepath);
            DataTable check = new DataTable();
            MySqlCommand command = new MySqlCommand("select * from activities where UserId=@id and ActivityDate = date(now())",database.getConnection());
            command.Parameters.Add("@Id", MySqlDbType.UInt32).Value = employeetable.Rows[listemployee.SelectedIndex].Field<UInt32>("Id");
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
                command.Parameters.Add("@user_Id", MySqlDbType.UInt32).Value = employeetable.Rows[listemployee.SelectedIndex].Field<UInt32>("Id");
                command.Parameters.Add("@lunch", MySqlDbType.Int32).Value = lunch;
                }
                else 
                {
                lunch = 0;
                command = new MySqlCommand("update activities set Lunch = @lunch, ActivityTimeEnd = Time(now()), ActivityHours = subtime(curtime(),ActivityTimeInit) where UserId = @user_Id and Id > 0 and ActivityDate = date(now()) and ActivityTimeEnd = \"00:00:00\";", database.getConnection());
                command.Parameters.Add("@user_Id", MySqlDbType.UInt32).Value = employeetable.Rows[listemployee.SelectedIndex].Field<UInt32>("Id");
                command.Parameters.Add("@lunch", MySqlDbType.Int32).Value = lunch;
                }
               
            }
            else 
            {
                command = new MySqlCommand("insert into activities(UserId, ActivityDate, ActivityTimeInit, ActivityTimeEnd, ActivityHours, Lunch) select* from (select @user_Id,Date(now()),Time(now()),\"00:00:00\",\"00\",\'1') as tmp where not exists (select * from activities where id > 0 and UserId = @user_Id and ActivityDate = Date(Now()));", database.getConnection());
                command.Parameters.Add("@user_Id", MySqlDbType.UInt32).Value = employeetable.Rows[listemployee.SelectedIndex].Field<UInt32>("Id");
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
        }
    }
}
