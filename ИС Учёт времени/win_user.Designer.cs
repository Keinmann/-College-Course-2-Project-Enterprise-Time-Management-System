namespace ИС_Учёт_времени
{
    partial class win_user
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
            this.labelempname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_s_lunch = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_s_timeend = new System.Windows.Forms.Label();
            this.label_s_timeinit = new System.Windows.Forms.Label();
            this.combomonth = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboyear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listactivities = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTimeInit = new System.Windows.Forms.Label();
            this.labelTimeEnd = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelLunch = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelmonthhour = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelempname
            // 
            this.labelempname.AutoSize = true;
            this.labelempname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelempname.Location = new System.Drawing.Point(12, 9);
            this.labelempname.Name = "labelempname";
            this.labelempname.Size = new System.Drawing.Size(81, 16);
            this.labelempname.TabIndex = 0;
            this.labelempname.Text = "Сотрудник";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отметиться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_s_lunch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label_s_timeend);
            this.groupBox1.Controls.Add(this.label_s_timeinit);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(211, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "График работы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Начало :";
            // 
            // label_s_lunch
            // 
            this.label_s_lunch.AutoSize = true;
            this.label_s_lunch.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_s_lunch.Location = new System.Drawing.Point(38, 115);
            this.label_s_lunch.Name = "label_s_lunch";
            this.label_s_lunch.Size = new System.Drawing.Size(41, 17);
            this.label_s_lunch.TabIndex = 7;
            this.label_s_lunch.Text = "Обед";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label9.Location = new System.Drawing.Point(12, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Конец :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.Location = new System.Drawing.Point(3, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Время на обед :";
            // 
            // label_s_timeend
            // 
            this.label_s_timeend.AutoSize = true;
            this.label_s_timeend.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_s_timeend.Location = new System.Drawing.Point(38, 73);
            this.label_s_timeend.Name = "label_s_timeend";
            this.label_s_timeend.Size = new System.Drawing.Size(46, 17);
            this.label_s_timeend.TabIndex = 7;
            this.label_s_timeend.Text = "Конец";
            // 
            // label_s_timeinit
            // 
            this.label_s_timeinit.AutoSize = true;
            this.label_s_timeinit.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_s_timeinit.Location = new System.Drawing.Point(38, 34);
            this.label_s_timeinit.Name = "label_s_timeinit";
            this.label_s_timeinit.Size = new System.Drawing.Size(52, 17);
            this.label_s_timeinit.TabIndex = 7;
            this.label_s_timeinit.Text = "Начало";
            // 
            // combomonth
            // 
            this.combomonth.FormattingEnabled = true;
            this.combomonth.Location = new System.Drawing.Point(17, 56);
            this.combomonth.Name = "combomonth";
            this.combomonth.Size = new System.Drawing.Size(121, 24);
            this.combomonth.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Просмотр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboyear
            // 
            this.comboyear.FormattingEnabled = true;
            this.comboyear.Location = new System.Drawing.Point(144, 56);
            this.comboyear.Name = "comboyear";
            this.comboyear.Size = new System.Drawing.Size(84, 24);
            this.comboyear.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Месяц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(141, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Год";
            // 
            // listactivities
            // 
            this.listactivities.FormattingEnabled = true;
            this.listactivities.ItemHeight = 16;
            this.listactivities.Items.AddRange(new object[] {
            "01\\04\\2020 : 7 часов (Обед)",
            "02\\04\\2020: 8 часов (Без обеда)"});
            this.listactivities.Location = new System.Drawing.Point(17, 119);
            this.listactivities.Name = "listactivities";
            this.listactivities.Size = new System.Drawing.Size(179, 308);
            this.listactivities.TabIndex = 6;
            this.listactivities.SelectedIndexChanged += new System.EventHandler(this.listactivities_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(201, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Начало :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(208, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Конец :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(214, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Часы :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(214, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Обед :";
            // 
            // labelTimeInit
            // 
            this.labelTimeInit.AutoSize = true;
            this.labelTimeInit.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.labelTimeInit.Location = new System.Drawing.Point(265, 119);
            this.labelTimeInit.Name = "labelTimeInit";
            this.labelTimeInit.Size = new System.Drawing.Size(52, 17);
            this.labelTimeInit.TabIndex = 7;
            this.labelTimeInit.Text = "Начало";
            // 
            // labelTimeEnd
            // 
            this.labelTimeEnd.AutoSize = true;
            this.labelTimeEnd.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.labelTimeEnd.Location = new System.Drawing.Point(265, 136);
            this.labelTimeEnd.Name = "labelTimeEnd";
            this.labelTimeEnd.Size = new System.Drawing.Size(46, 17);
            this.labelTimeEnd.TabIndex = 7;
            this.labelTimeEnd.Text = "Конец";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.labelHours.Location = new System.Drawing.Point(265, 153);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(38, 17);
            this.labelHours.TabIndex = 7;
            this.labelHours.Text = "Часы";
            // 
            // labelLunch
            // 
            this.labelLunch.AutoSize = true;
            this.labelLunch.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.labelLunch.Location = new System.Drawing.Point(266, 170);
            this.labelLunch.Name = "labelLunch";
            this.labelLunch.Size = new System.Drawing.Size(77, 17);
            this.labelLunch.TabIndex = 7;
            this.labelLunch.Text = "Был\\Не был";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(99, 9);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(79, 17);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "Сотрудник";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(141, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Часы за месяц";
            // 
            // labelmonthhour
            // 
            this.labelmonthhour.AutoSize = true;
            this.labelmonthhour.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.labelmonthhour.Location = new System.Drawing.Point(255, 87);
            this.labelmonthhour.Name = "labelmonthhour";
            this.labelmonthhour.Size = new System.Drawing.Size(38, 17);
            this.labelmonthhour.TabIndex = 7;
            this.labelmonthhour.Text = "Часы";
            // 
            // win_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLunch);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelTimeEnd);
            this.Controls.Add(this.listactivities);
            this.Controls.Add(this.labelmonthhour);
            this.Controls.Add(this.labelTimeInit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelempname);
            this.Controls.Add(this.combomonth);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboyear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Location = new System.Drawing.Point(376, 487);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(376, 487);
            this.Name = "win_user";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.win_user_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelempname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combomonth;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboyear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_s_lunch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_s_timeend;
        private System.Windows.Forms.Label label_s_timeinit;
        private System.Windows.Forms.ListBox listactivities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelTimeInit;
        private System.Windows.Forms.Label labelTimeEnd;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelLunch;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelmonthhour;
    }
}