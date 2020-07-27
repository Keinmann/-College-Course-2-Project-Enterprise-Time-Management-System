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
using MySql.Data.MySqlClient;

namespace ИС_Учёт_времени
{
    public partial class win_prestart : Form
    {
        string dirpath = Application.StartupPath + "/pref";
        string filepath = Application.StartupPath + "/pref/dbpreferences.txt";
        private win_main parental;

        public win_prestart(win_main parental)
        {
            this.parental = parental;
            InitializeComponent();
            CheckDataBaseConnection();
        }

        void CheckDataBaseConnection()
        {
            bool prefError = false;
            if (!Directory.Exists(dirpath))
            {
                Directory.CreateDirectory(dirpath);
                prefError = true;
            }
            if (!File.Exists(filepath))
            {
                File.CreateText(filepath);
                prefError = true;
            }
            else
            {
                String cmdline = File.ReadAllText(filepath);
                if (!cmdline.Contains("server=") ||
                    !cmdline.Contains("port=") ||
                    !cmdline.Contains("username=") ||
                    !cmdline.Contains("password=") ||
                    !cmdline.Contains("database="))
                {
                    prefError = true;
                }
            }
            if (!prefError)
            {
                DB db = new DB();
                db.SetPreferences(filepath);
                if (!db.checkConnection()) { prefError = true; }
                else { prefError = false; }
                db.End();
                db = null;
            }

            if (prefError)
            {
                EnableContents();
                MessageBox.Show("Ошибка соединения с БД\nНеобходима настройка.");
            }
            else
            {
                DisableContents();
            }


        }
        private void EnableContents()
        {
            bdcheckbox.ForeColor = Color.Red;
            paneltextadr.Enabled = true;
            paneltextdbname.Enabled = true;
            paneltextname.Enabled = true;
            paneltextpass.Enabled = true;
            paneltextport.Enabled = true;
            panelbtncheck.Enabled = true;
            panelbtncheck.Visible = true;
        }
        private void DisableContents()
        {
            bdcheckbox.ForeColor = Color.Green;
            bdcheckbox.Checked = true;
            elementscheckbox.Checked = true;
            elementscheckbox.ForeColor = Color.Green;
            paneltextadr.Enabled = false;
            paneltextdbname.Enabled = false;
            paneltextname.Enabled = false;
            paneltextpass.Enabled = false;
            paneltextport.Enabled = false;
            panelbtncheck.Enabled = false;
            panelbtncheck.Visible = false;
        }
        private void panelbtncheck_Click(object sender, EventArgs e)
        {
            bool connection = false;
            if (paneltextadr.TextLength > 0 && paneltextport.TextLength > 0 && paneltextname.TextLength > 0 && paneltextpass.TextLength > 0 && paneltextdbname.TextLength > 0)
            {
                DisableContents();
                string cmd = "server=" + paneltextadr.Text + ";port=" + paneltextport.Text + ";username=" + paneltextname.Text + ";password=" + paneltextpass.Text + ";database=" + paneltextdbname.Text;
                File.WriteAllText(filepath, cmd);
                DB database = new DB();
                database.SetPreferences(filepath);
                if (database.checkConnection())
                {
                    DisableContents();
                    connection = true;
                }
                else 
                {   
                    MessageBox.Show("Проверка не выполена");
                    EnableContents();
                    connection = false;
                }
                if (connection == true && MessageBox.Show("Соединение с базой данных установлено.\nСоздать структуру базы данных?\n(Неоходимо при первом запуске системы)", "Уведомление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand(
                        "CREATE TABLE IF NOT EXISTS `schedules` " +
                        "(`Id` INT UNSIGNED NOT NULL AUTO_INCREMENT," +
                        " `Name` VARCHAR(45) CHARACTER SET 'utf8' NOT NULL," +
                        " `TimeInit` TIME NOT NULL," +
                        " `TimeEnd` TIME NOT NULL," +
                        " `Lunch` TIME NULL DEFAULT NULL," +
                        " PRIMARY KEY(`Id`))" +
                        " ENGINE = InnoDB" +
                        " AUTO_INCREMENT = 14" +
                        " DEFAULT CHARACTER SET = utf8;" +
                        " CREATE UNIQUE INDEX `Id_UNIQUE` ON `schedules` (`Id` ASC) VISIBLE;" +
                        " CREATE UNIQUE INDEX `Name_UNIQUE` ON `schedules` (`Name` ASC) VISIBLE;" +
                        " CREATE TABLE IF NOT EXISTS `userstatus` (" +
                        " `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT," +
                        " `Status` VARCHAR(45) CHARACTER SET 'utf8' NOT NULL," +
                        " PRIMARY KEY(`Id`))" +
                        " ENGINE = InnoDB" +
                        " AUTO_INCREMENT = 3" +
                        " DEFAULT CHARACTER SET = utf8;" +
                        " CREATE UNIQUE INDEX `Id_UNIQUE` ON `userstatus` (`Id` ASC) VISIBLE;" +
                        " CREATE TABLE IF NOT EXISTS `user` (" +
                        " `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT," +
                        " `Name` VARCHAR(45) CHARACTER SET 'utf8' NOT NULL," +
                        " `Surname` VARCHAR(45) CHARACTER SET 'utf8' NOT NULL," +
                        " `Lastname` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL," +
                        " `Login` VARCHAR(45) CHARACTER SET 'utf8' NOT NULL," +
                        " `Password` VARCHAR(45) CHARACTER SET 'utf8' NOT NULL," +
                        " `Access` INT UNSIGNED NOT NULL," +
                        " `StatusId` INT UNSIGNED NOT NULL," +
                        " `ScheduleId` INT UNSIGNED NOT NULL DEFAULT '0'," +
                        " PRIMARY KEY(`Id`, `ScheduleId`, `StatusId`)," +
                        " CONSTRAINT `ScheduleId`" +
                        " FOREIGN KEY(`ScheduleId`)" +
                        " REFERENCES `schedules` (`Id`)" +
                        " ON DELETE RESTRICT" +
                        " ON UPDATE CASCADE," +
                        " CONSTRAINT `StatusId`" +
                        " FOREIGN KEY(`StatusId`)" +
                        " REFERENCES `userstatus` (`Id`)" +
                        " ON DELETE NO ACTION" +
                        " ON UPDATE NO ACTION)" +
                        " ENGINE = InnoDB" +
                        " AUTO_INCREMENT = 19" +
                        " DEFAULT CHARACTER SET = utf8;" +
                        " CREATE UNIQUE INDEX `Id_UNIQUE` ON `user` (`Id` ASC) VISIBLE;" +
                        " CREATE UNIQUE INDEX `Login_UNIQUE` ON `user` (`Login` ASC) VISIBLE;" +
                        " CREATE INDEX `ScheduleId_idx` ON `user` (`StatusId` ASC) VISIBLE;" +
                        " CREATE INDEX `ScheduleId_idx1` ON `user` (`ScheduleId` ASC) VISIBLE;" +
                        " CREATE TABLE IF NOT EXISTS `activities` (" +
                        " `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT," +
                        " `UserId` INT UNSIGNED NOT NULL," +
                        " `ActivityDate` DATE NOT NULL," +
                        " `ActivityTimeInit` TIME NOT NULL," +
                        " `ActivityTimeEnd` TIME NOT NULL DEFAULT '00:00:00'," +
                        " `ActivityHours` TIME NOT NULL DEFAULT '00:00:00'," +
                        " `Lunch` INT UNSIGNED NOT NULL DEFAULT '1'," +
                        " PRIMARY KEY(`Id`, `UserId`)," +
                        " CONSTRAINT `UserId`" +
                        " FOREIGN KEY(`UserId`)" +
                        " REFERENCES `user` (`Id`)" +
                        " ON DELETE RESTRICT" +
                        " ON UPDATE CASCADE)" +
                        " ENGINE = InnoDB" +
                        " AUTO_INCREMENT = 66" +
                        " DEFAULT CHARACTER SET = utf8;" +
                        " CREATE UNIQUE INDEX `Id_UNIQUE` ON `activities` (`Id` ASC) VISIBLE;" +
                        " CREATE INDEX `UserId_idx` ON `activities` (`UserId` ASC) VISIBLE;" +
                        " INSERT INTO schedules(Name, TimeInit, TimeEnd, Lunch) VALUES" +
                        " (\"DEFAULT\", \"00:00:00\", \"00:00:00\", \"00:00:00\");" +
                        " INSERT INTO `userstatus` (`Id`, `Status`) VALUES(1, 'Неактивен');" +
                        " INSERT INTO `userstatus` (`Id`, `Status`) VALUES(2, 'Активен');" +
                        " INSERT INTO `user` (`Name`, `Surname`, `Lastname`, `Login`, `Password`, `Access`, `StatusId`, `ScheduleId`) VALUES('SERVER', 'ACCOUNT', NULL, 'admin', 'admin', 2, 2, (select Id from schedules where Name = \"DEFAULT\"));" +
                        " COMMIT;",database.getConnection());
                    try
                    {
                        database.openConnection();
                        if (command.ExecuteNonQuery()==1) 
                        {
                            
                        };
                    }
                    catch 
                    {
                        MessageBox.Show("Ошибка создания объектов БД","Ошибка");
                    }
                    finally 
                    {
                        database.closeConnection();
                        MessageBox.Show("Элементы БД созданы", "Уведомление");
                    }
                    database.End();
                    database = null;
                }

            }
            else 
            {
                MessageBox.Show("Введите данные БД"); 
            }


        }

    }
}
