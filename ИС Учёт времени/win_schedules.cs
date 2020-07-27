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
    public partial class win_schedules : Form
    {
        private string filepath = Application.StartupPath + "/pref/dbpreferences.txt";
        private bool add = false, edit = false;
        DataTable table = new DataTable();
        public win_schedules()
        {
            InitializeComponent();
        }
        private void UpdateData()
        {
            table.Clear();
            DB database = new DB();
            database.SetPreferences(filepath);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("select * from schedules order by TimeInit", database.getConnection());
            adapter.SelectCommand = command;
            try 
            { 
                database.openConnection();
                adapter.Fill(table);     
            }
            catch { MessageBox.Show("Ошибка базы данных","Ошибка"); }
            finally { database.closeConnection(); }
            listschedules.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++) 
            {
                listschedules.Items.Add(table.Rows[i].Field<String>("Name"));
            }
            btnEdit.Enabled = btnDelete.Enabled = false;
            maskInit.Text = maskEnd.Text = maskBreak.Text = "0000";

        }
        private void WriteMode() 
        {
            btnDelete.Text = "Отмена";
            btnDelete.Enabled = maskBreak.Enabled = maskEnd.Enabled = maskInit.Enabled = true;
            listschedules.Enabled = false;
        }
        private void ReadMode() 
        {
            btnDelete.Text = "Удалить";
            btnDelete.Enabled = maskBreak.Enabled = maskEnd.Enabled = maskInit.Enabled = false;
            listschedules.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = !add;
            if (add)
            {
                WriteMode();
                maskBreak.Text = maskInit.Text = maskEnd.Text = "0000";
                btnEdit.Enabled = false;
            }
            else
            {
                bool valid = false;
                ReadMode();
                DB database = new DB();
                database.SetPreferences(filepath);
                MySqlCommand command = new MySqlCommand("select * from schedules where Name = @nam", database.getConnection());
                command.Parameters.Add("@nam", MySqlDbType.VarChar).Value = maskInit.Text + " - " + maskEnd.Text + " | Обед: " + maskBreak.Text;
                try
                {
                    DataTable checktable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    database.openConnection();
                    adapter.Fill(checktable);
                    if (checktable.Rows.Count > 0) { valid = false; MessageBox.Show("Такая запись уже существует", "Ошибка"); return; }
                    else { valid = true; }
                }
                catch
                {
                    MessageBox.Show("Ошибка работы базы данных", "Ошибка");
                }
                finally 
                {
                    database.closeConnection();
                }
                if (valid)
                {
                    command = new MySqlCommand("insert into schedules(Name,TimeInit,TimeEnd,Lunch) values (@nam,@tii,@tie,@lun);", database.getConnection());
                    command.Parameters.Add("@nam", MySqlDbType.VarChar).Value = maskInit.Text + " - " + maskEnd.Text + " | Обед: " + maskBreak.Text;
                    command.Parameters.Add("@tii", MySqlDbType.Time).Value = TimeSpan.Parse( maskInit.Text+":00");
                    command.Parameters.Add("@tie", MySqlDbType.Time).Value = TimeSpan.Parse(maskBreak.Text + ":00");
                    command.Parameters.Add("@lun", MySqlDbType.Time).Value = TimeSpan.Parse(maskBreak.Text + ":00");
                    try
                    {
                        database.openConnection();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Запись создана");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка создания записи");
                        }
                    }
                    catch { MessageBox.Show("Ошибка работы базы данных", "Ошибка"); }
                    finally
                    {
                        database.closeConnection();
                    }
                    UpdateData();
                }
                btnEdit.Enabled = true;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            edit = !edit;
            if (edit)
            {
                WriteMode();
                btnAdd.Enabled = false;
            }
            else 
            {
                btnAdd.Enabled = true;
                ReadMode();
                DB database = new DB();
                database.SetPreferences(filepath);
                string name = maskInit.Text + " - " + maskEnd.Text + " | Обед: " + maskBreak.Text; 
                MySqlCommand command = new MySqlCommand("update schedules set Name = @nam , TimeInit = @tii , TimeEnd = @tie , Lunch = @lun where Id = @id;", database.getConnection());
                    command.Parameters.Add("@id", MySqlDbType.UInt32).Value = table.Rows[listschedules.SelectedIndex].Field<UInt32>("Id");
                    command.Parameters.Add("@nam", MySqlDbType.VarChar).Value = name;
                    command.Parameters.Add("@tii", MySqlDbType.Time).Value = TimeSpan.Parse(maskInit.Text + ":00");
                    command.Parameters.Add("@tie", MySqlDbType.Time).Value = TimeSpan.Parse(maskEnd.Text + ":00");
                    command.Parameters.Add("@lun", MySqlDbType.Time).Value = TimeSpan.Parse(maskBreak.Text + ":00");
                    try
                    {
                        database.openConnection();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Запись изменена");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка изменения записи");
                        }
                    }
                    catch { MessageBox.Show("Ошибка работы базы данных", "Ошибка"); }
                    finally
                    {
                        database.closeConnection();
                    }
                    UpdateData();
                btnAdd.Enabled = true;
                
            }
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                edit = false;
                ReadMode();
                btnEdit.Enabled = false;
                btnAdd.Enabled = true;
            }
            else if (add) { add = false; ReadMode(); maskBreak.Text = maskEnd.Text = maskInit.Text = "00:00"; }
            else if (MessageBox.Show("Подтвердите удаление записи","Подтвердите действие",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                DB database = new DB();
                database.SetPreferences(filepath);
                MySqlCommand command = new MySqlCommand("delete from schedules where Id = @id;",database.getConnection());
                command.Parameters.Add("@id",MySqlDbType.UInt32).Value = table.Rows[listschedules.SelectedIndex].Field<UInt32>("Id");
                try { database.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись удалена");
                    }
                    else 
                    {
                        MessageBox.Show("Запись не удалена");
                    }
                }
                catch { MessageBox.Show("Ошибка работы базы данных", "Ошибка"); }
                finally { database.closeConnection(); }
            }
            UpdateData();
        }
        private void listschedules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listschedules.SelectedIndex != -1)
            {
                btnDelete.Enabled = btnEdit.Enabled = true;
                maskInit.Text = table.Rows[listschedules.SelectedIndex].Field<TimeSpan>("TimeInit").ToString();
                maskEnd.Text = table.Rows[listschedules.SelectedIndex].Field<TimeSpan>("TimeEnd").ToString();
                maskBreak.Text = table.Rows[listschedules.SelectedIndex].Field<TimeSpan>("Lunch").ToString();
            }
        }

        private void win_schedules_Load(object sender, EventArgs e)
        {
            UpdateData();
            btnEdit.Enabled = btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            add = edit = false;
        }
    }
}
