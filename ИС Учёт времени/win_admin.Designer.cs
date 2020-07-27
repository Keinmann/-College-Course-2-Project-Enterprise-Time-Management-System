namespace ИС_Учёт_времени
{
    partial class win_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win_admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.рабочееВремяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listemployee = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_empcreate = new System.Windows.Forms.Button();
            this.btn_empedit = new System.Windows.Forms.Button();
            this.btn_empdelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textnam = new System.Windows.Forms.TextBox();
            this.textsur = new System.Windows.Forms.TextBox();
            this.textlas = new System.Windows.Forms.TextBox();
            this.textlog = new System.Windows.Forms.TextBox();
            this.textpas = new System.Windows.Forms.TextBox();
            this.combosched = new System.Windows.Forms.ComboBox();
            this.combostat = new System.Windows.Forms.ComboBox();
            this.comboacc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnlook = new System.Windows.Forms.Button();
            this.btnnote = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.рабочееВремяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // рабочееВремяToolStripMenuItem
            // 
            this.рабочееВремяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикиРаботыToolStripMenuItem});
            this.рабочееВремяToolStripMenuItem.Name = "рабочееВремяToolStripMenuItem";
            this.рабочееВремяToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.рабочееВремяToolStripMenuItem.Text = "Рабочее время";
            // 
            // графикиРаботыToolStripMenuItem
            // 
            this.графикиРаботыToolStripMenuItem.Name = "графикиРаботыToolStripMenuItem";
            this.графикиРаботыToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.графикиРаботыToolStripMenuItem.Text = "Графики работы";
            this.графикиРаботыToolStripMenuItem.Click += new System.EventHandler(this.графикиРаботыToolStripMenuItem_Click);
            // 
            // listemployee
            // 
            this.listemployee.FormattingEnabled = true;
            this.listemployee.ItemHeight = 16;
            this.listemployee.Location = new System.Drawing.Point(12, 54);
            this.listemployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listemployee.Name = "listemployee";
            this.listemployee.Size = new System.Drawing.Size(258, 308);
            this.listemployee.TabIndex = 1;
            this.listemployee.SelectedIndexChanged += new System.EventHandler(this.listemployee_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сотрудники";
            // 
            // btn_empcreate
            // 
            this.btn_empcreate.Location = new System.Drawing.Point(285, 281);
            this.btn_empcreate.Name = "btn_empcreate";
            this.btn_empcreate.Size = new System.Drawing.Size(63, 23);
            this.btn_empcreate.TabIndex = 8;
            this.btn_empcreate.Text = "Создать";
            this.btn_empcreate.UseVisualStyleBackColor = true;
            this.btn_empcreate.Click += new System.EventHandler(this.btn_empcreate_Click);
            // 
            // btn_empedit
            // 
            this.btn_empedit.Enabled = false;
            this.btn_empedit.Location = new System.Drawing.Point(354, 281);
            this.btn_empedit.Name = "btn_empedit";
            this.btn_empedit.Size = new System.Drawing.Size(101, 23);
            this.btn_empedit.TabIndex = 9;
            this.btn_empedit.Text = "Редактировать";
            this.btn_empedit.UseVisualStyleBackColor = true;
            this.btn_empedit.Click += new System.EventHandler(this.btn_empedit_Click);
            // 
            // btn_empdelete
            // 
            this.btn_empdelete.Enabled = false;
            this.btn_empdelete.Location = new System.Drawing.Point(462, 281);
            this.btn_empdelete.Name = "btn_empdelete";
            this.btn_empdelete.Size = new System.Drawing.Size(63, 23);
            this.btn_empdelete.TabIndex = 10;
            this.btn_empdelete.Text = "Удалить";
            this.btn_empdelete.UseVisualStyleBackColor = true;
            this.btn_empdelete.Click += new System.EventHandler(this.btn_empdelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textnam);
            this.panel1.Controls.Add(this.textsur);
            this.panel1.Controls.Add(this.textlas);
            this.panel1.Controls.Add(this.textlog);
            this.panel1.Controls.Add(this.textpas);
            this.panel1.Controls.Add(this.combosched);
            this.panel1.Controls.Add(this.combostat);
            this.panel1.Controls.Add(this.comboacc);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(276, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 199);
            this.panel1.TabIndex = 4;
            // 
            // textnam
            // 
            this.textnam.Enabled = false;
            this.textnam.Location = new System.Drawing.Point(118, 26);
            this.textnam.Name = "textnam";
            this.textnam.Size = new System.Drawing.Size(131, 21);
            this.textnam.TabIndex = 2;
            // 
            // textsur
            // 
            this.textsur.Enabled = false;
            this.textsur.Location = new System.Drawing.Point(118, 3);
            this.textsur.Name = "textsur";
            this.textsur.Size = new System.Drawing.Size(131, 21);
            this.textsur.TabIndex = 1;
            // 
            // textlas
            // 
            this.textlas.Enabled = false;
            this.textlas.Location = new System.Drawing.Point(118, 49);
            this.textlas.Name = "textlas";
            this.textlas.Size = new System.Drawing.Size(131, 21);
            this.textlas.TabIndex = 3;
            // 
            // textlog
            // 
            this.textlog.Enabled = false;
            this.textlog.Location = new System.Drawing.Point(118, 72);
            this.textlog.Name = "textlog";
            this.textlog.Size = new System.Drawing.Size(131, 21);
            this.textlog.TabIndex = 4;
            // 
            // textpas
            // 
            this.textpas.Enabled = false;
            this.textpas.Location = new System.Drawing.Point(118, 95);
            this.textpas.Name = "textpas";
            this.textpas.Size = new System.Drawing.Size(131, 21);
            this.textpas.TabIndex = 5;
            // 
            // combosched
            // 
            this.combosched.Enabled = false;
            this.combosched.FormattingEnabled = true;
            this.combosched.Location = new System.Drawing.Point(118, 170);
            this.combosched.Name = "combosched";
            this.combosched.Size = new System.Drawing.Size(131, 24);
            this.combosched.TabIndex = 7;
            // 
            // combostat
            // 
            this.combostat.Enabled = false;
            this.combostat.FormattingEnabled = true;
            this.combostat.Location = new System.Drawing.Point(118, 144);
            this.combostat.Name = "combostat";
            this.combostat.Size = new System.Drawing.Size(131, 24);
            this.combostat.TabIndex = 7;
            // 
            // comboacc
            // 
            this.comboacc.Enabled = false;
            this.comboacc.FormattingEnabled = true;
            this.comboacc.Location = new System.Drawing.Point(118, 118);
            this.comboacc.Name = "comboacc";
            this.comboacc.Size = new System.Drawing.Size(131, 24);
            this.comboacc.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "График работы :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "График работы :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Статус :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Уровень доступа :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Пароль :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фамилия :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Логин :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Отчество :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.Location = new System.Drawing.Point(276, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Сотрудник";
            // 
            // btnlook
            // 
            this.btnlook.Location = new System.Drawing.Point(276, 339);
            this.btnlook.Name = "btnlook";
            this.btnlook.Size = new System.Drawing.Size(101, 23);
            this.btnlook.TabIndex = 11;
            this.btnlook.Text = "Просмотр";
            this.btnlook.UseVisualStyleBackColor = true;
            this.btnlook.Click += new System.EventHandler(this.btnlook_Click);
            // 
            // btnnote
            // 
            this.btnnote.Location = new System.Drawing.Point(383, 339);
            this.btnnote.Name = "btnnote";
            this.btnnote.Size = new System.Drawing.Size(101, 23);
            this.btnnote.TabIndex = 12;
            this.btnnote.Text = "Отметить";
            this.btnnote.UseVisualStyleBackColor = true;
            this.btnnote.Click += new System.EventHandler(this.btnnote_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label17.Location = new System.Drawing.Point(276, 317);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "Рабочее время";
            // 
            // win_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 376);
            this.Controls.Add(this.btnnote);
            this.Controls.Add(this.btnlook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_empdelete);
            this.Controls.Add(this.btn_empedit);
            this.Controls.Add(this.btn_empcreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listemployee);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(566, 415);
            this.MinimumSize = new System.Drawing.Size(566, 415);
            this.Name = "win_admin";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.win_admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox listemployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_empcreate;
        private System.Windows.Forms.Button btn_empedit;
        private System.Windows.Forms.Button btn_empdelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnlook;
        private System.Windows.Forms.Button btnnote;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox combostat;
        private System.Windows.Forms.ComboBox comboacc;
        private System.Windows.Forms.TextBox textnam;
        private System.Windows.Forms.TextBox textsur;
        private System.Windows.Forms.TextBox textlas;
        private System.Windows.Forms.TextBox textlog;
        private System.Windows.Forms.TextBox textpas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem рабочееВремяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикиРаботыToolStripMenuItem;
        private System.Windows.Forms.ComboBox combosched;
        private System.Windows.Forms.Label label10;
    }
}