namespace ИС_Учёт_времени
{
    partial class win_schedules
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
            this.listschedules = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskInit = new System.Windows.Forms.MaskedTextBox();
            this.maskEnd = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskBreak = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // listschedules
            // 
            this.listschedules.FormattingEnabled = true;
            this.listschedules.ItemHeight = 16;
            this.listschedules.Location = new System.Drawing.Point(12, 13);
            this.listschedules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listschedules.Name = "listschedules";
            this.listschedules.Size = new System.Drawing.Size(252, 244);
            this.listschedules.TabIndex = 0;
            this.listschedules.SelectedIndexChanged += new System.EventHandler(this.listschedules_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(270, 146);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(270, 182);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 28);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(270, 218);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 28);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(272, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начало рабочего дня :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(272, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Конец рабочего дня :";
            // 
            // maskInit
            // 
            this.maskInit.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskInit.Enabled = false;
            this.maskInit.Location = new System.Drawing.Point(314, 32);
            this.maskInit.Mask = "00:00";
            this.maskInit.Name = "maskInit";
            this.maskInit.Size = new System.Drawing.Size(59, 21);
            this.maskInit.TabIndex = 3;
            this.maskInit.Text = "0000";
            this.maskInit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskInit.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskInit.ValidatingType = typeof(System.DateTime);
            // 
            // maskEnd
            // 
            this.maskEnd.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.maskEnd.Enabled = false;
            this.maskEnd.Location = new System.Drawing.Point(314, 75);
            this.maskEnd.Mask = "00:00";
            this.maskEnd.Name = "maskEnd";
            this.maskEnd.Size = new System.Drawing.Size(59, 21);
            this.maskEnd.TabIndex = 3;
            this.maskEnd.Text = "0000";
            this.maskEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskEnd.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskEnd.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(272, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Длина перерыва :";
            // 
            // maskBreak
            // 
            this.maskBreak.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.maskBreak.Enabled = false;
            this.maskBreak.Location = new System.Drawing.Point(314, 118);
            this.maskBreak.Mask = "00:00";
            this.maskBreak.Name = "maskBreak";
            this.maskBreak.Size = new System.Drawing.Size(59, 21);
            this.maskBreak.TabIndex = 3;
            this.maskBreak.Text = "0000";
            this.maskBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskBreak.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskBreak.ValidatingType = typeof(System.DateTime);
            // 
            // win_schedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 268);
            this.Controls.Add(this.maskBreak);
            this.Controls.Add(this.maskEnd);
            this.Controls.Add(this.maskInit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listschedules);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(441, 307);
            this.MinimumSize = new System.Drawing.Size(441, 307);
            this.Name = "win_schedules";
            this.Text = "Графики работ";
            this.Load += new System.EventHandler(this.win_schedules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listschedules;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskInit;
        private System.Windows.Forms.MaskedTextBox maskEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskBreak;
    }
}