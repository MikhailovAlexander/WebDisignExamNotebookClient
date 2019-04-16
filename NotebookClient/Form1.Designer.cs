namespace NotebookClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvPeople = new System.Windows.Forms.ListView();
            this.clmFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSecondName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBirthDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbPersonData = new System.Windows.Forms.GroupBox();
            this.btnSavePersonCancel = new System.Windows.Forms.Button();
            this.btnSavePerson = new System.Windows.Forms.Button();
            this.dtpPersonBirthDay = new System.Windows.Forms.DateTimePicker();
            this.lblPersonBirthDay = new System.Windows.Forms.Label();
            this.tbPersonSecondName = new System.Windows.Forms.TextBox();
            this.lblPersonSecondName = new System.Windows.Forms.Label();
            this.tbPersonFirstName = new System.Windows.Forms.TextBox();
            this.lblPersonFirstName = new System.Windows.Forms.Label();
            this.btnContactSwitchAdd = new System.Windows.Forms.Button();
            this.gbContactData = new System.Windows.Forms.GroupBox();
            this.lbSetContactType = new System.Windows.Forms.ListBox();
            this.btnSaveContactCancel = new System.Windows.Forms.Button();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.tbContactValue = new System.Windows.Forms.TextBox();
            this.lblContactValue = new System.Windows.Forms.Label();
            this.lblSetContactType = new System.Windows.Forms.Label();
            this.gbContactTypeData = new System.Windows.Forms.GroupBox();
            this.btnSaveContactTypeCancel = new System.Windows.Forms.Button();
            this.btnSaveContactType = new System.Windows.Forms.Button();
            this.tbContactType = new System.Windows.Forms.TextBox();
            this.lblContactType = new System.Windows.Forms.Label();
            this.btnContactTypeAdd = new System.Windows.Forms.Button();
            this.lvContacts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnContactDelete = new System.Windows.Forms.Button();
            this.btnContactSwitchUpdate = new System.Windows.Forms.Button();
            this.gbPersonData.SuspendLayout();
            this.gbContactData.SuspendLayout();
            this.gbContactTypeData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPeople
            // 
            this.lvPeople.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFirstName,
            this.clmSecondName,
            this.clmBirthDay});
            this.lvPeople.FullRowSelect = true;
            this.lvPeople.GridLines = true;
            this.lvPeople.Location = new System.Drawing.Point(15, 13);
            this.lvPeople.Name = "lvPeople";
            this.lvPeople.Size = new System.Drawing.Size(404, 295);
            this.lvPeople.TabIndex = 0;
            this.lvPeople.UseCompatibleStateImageBehavior = false;
            this.lvPeople.View = System.Windows.Forms.View.Details;
            this.lvPeople.SelectedIndexChanged += new System.EventHandler(this.LvPeople_SelectedIndexChanged);
            // 
            // clmFirstName
            // 
            this.clmFirstName.Text = "Имя";
            this.clmFirstName.Width = 150;
            // 
            // clmSecondName
            // 
            this.clmSecondName.Text = "Фамилия";
            this.clmSecondName.Width = 150;
            // 
            // clmBirthDay
            // 
            this.clmBirthDay.Text = "Дата рождения";
            this.clmBirthDay.Width = 100;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(189, 327);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(102, 327);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(81, 36);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(276, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // gbPersonData
            // 
            this.gbPersonData.Controls.Add(this.btnSavePersonCancel);
            this.gbPersonData.Controls.Add(this.btnSavePerson);
            this.gbPersonData.Controls.Add(this.dtpPersonBirthDay);
            this.gbPersonData.Controls.Add(this.lblPersonBirthDay);
            this.gbPersonData.Controls.Add(this.tbPersonSecondName);
            this.gbPersonData.Controls.Add(this.lblPersonSecondName);
            this.gbPersonData.Controls.Add(this.tbPersonFirstName);
            this.gbPersonData.Controls.Add(this.lblPersonFirstName);
            this.gbPersonData.Location = new System.Drawing.Point(427, 202);
            this.gbPersonData.Name = "gbPersonData";
            this.gbPersonData.Size = new System.Drawing.Size(294, 135);
            this.gbPersonData.TabIndex = 5;
            this.gbPersonData.TabStop = false;
            this.gbPersonData.Text = "Данные человека";
            this.gbPersonData.Visible = false;
            // 
            // btnSavePersonCancel
            // 
            this.btnSavePersonCancel.Location = new System.Drawing.Point(172, 108);
            this.btnSavePersonCancel.Name = "btnSavePersonCancel";
            this.btnSavePersonCancel.Size = new System.Drawing.Size(99, 20);
            this.btnSavePersonCancel.TabIndex = 7;
            this.btnSavePersonCancel.Text = "Отменить";
            this.btnSavePersonCancel.UseVisualStyleBackColor = true;
            this.btnSavePersonCancel.Click += new System.EventHandler(this.BtnSavePersonCancel_Click);
            // 
            // btnSavePerson
            // 
            this.btnSavePerson.Location = new System.Drawing.Point(172, 82);
            this.btnSavePerson.Name = "btnSavePerson";
            this.btnSavePerson.Size = new System.Drawing.Size(99, 20);
            this.btnSavePerson.TabIndex = 6;
            this.btnSavePerson.Text = "Сохранить";
            this.btnSavePerson.UseVisualStyleBackColor = true;
            this.btnSavePerson.Click += new System.EventHandler(this.BtnSavePerson_Click);
            // 
            // dtpPersonBirthDay
            // 
            this.dtpPersonBirthDay.Location = new System.Drawing.Point(9, 98);
            this.dtpPersonBirthDay.Name = "dtpPersonBirthDay";
            this.dtpPersonBirthDay.Size = new System.Drawing.Size(119, 20);
            this.dtpPersonBirthDay.TabIndex = 5;
            // 
            // lblPersonBirthDay
            // 
            this.lblPersonBirthDay.AutoSize = true;
            this.lblPersonBirthDay.Location = new System.Drawing.Point(6, 82);
            this.lblPersonBirthDay.Name = "lblPersonBirthDay";
            this.lblPersonBirthDay.Size = new System.Drawing.Size(86, 13);
            this.lblPersonBirthDay.TabIndex = 4;
            this.lblPersonBirthDay.Text = "Дата рождения";
            // 
            // tbPersonSecondName
            // 
            this.tbPersonSecondName.Location = new System.Drawing.Point(65, 54);
            this.tbPersonSecondName.Name = "tbPersonSecondName";
            this.tbPersonSecondName.Size = new System.Drawing.Size(223, 20);
            this.tbPersonSecondName.TabIndex = 3;
            // 
            // lblPersonSecondName
            // 
            this.lblPersonSecondName.AutoSize = true;
            this.lblPersonSecondName.Location = new System.Drawing.Point(6, 57);
            this.lblPersonSecondName.Name = "lblPersonSecondName";
            this.lblPersonSecondName.Size = new System.Drawing.Size(56, 13);
            this.lblPersonSecondName.TabIndex = 2;
            this.lblPersonSecondName.Text = "Фамилия";
            // 
            // tbPersonFirstName
            // 
            this.tbPersonFirstName.Location = new System.Drawing.Point(65, 25);
            this.tbPersonFirstName.Name = "tbPersonFirstName";
            this.tbPersonFirstName.Size = new System.Drawing.Size(223, 20);
            this.tbPersonFirstName.TabIndex = 1;
            // 
            // lblPersonFirstName
            // 
            this.lblPersonFirstName.AutoSize = true;
            this.lblPersonFirstName.Location = new System.Drawing.Point(6, 25);
            this.lblPersonFirstName.Name = "lblPersonFirstName";
            this.lblPersonFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblPersonFirstName.TabIndex = 0;
            this.lblPersonFirstName.Text = "Имя";
            // 
            // btnContactSwitchAdd
            // 
            this.btnContactSwitchAdd.Location = new System.Drawing.Point(425, 172);
            this.btnContactSwitchAdd.Name = "btnContactSwitchAdd";
            this.btnContactSwitchAdd.Size = new System.Drawing.Size(108, 23);
            this.btnContactSwitchAdd.TabIndex = 8;
            this.btnContactSwitchAdd.Text = "Добавить контакт";
            this.btnContactSwitchAdd.UseVisualStyleBackColor = true;
            this.btnContactSwitchAdd.Click += new System.EventHandler(this.BtnSwitchAddContact_Click);
            // 
            // gbContactData
            // 
            this.gbContactData.Controls.Add(this.lbSetContactType);
            this.gbContactData.Controls.Add(this.btnSaveContactCancel);
            this.gbContactData.Controls.Add(this.btnSaveContact);
            this.gbContactData.Controls.Add(this.tbContactValue);
            this.gbContactData.Controls.Add(this.lblContactValue);
            this.gbContactData.Controls.Add(this.lblSetContactType);
            this.gbContactData.Location = new System.Drawing.Point(429, 349);
            this.gbContactData.Name = "gbContactData";
            this.gbContactData.Size = new System.Drawing.Size(294, 100);
            this.gbContactData.TabIndex = 9;
            this.gbContactData.TabStop = false;
            this.gbContactData.Text = "Данные контакта";
            this.gbContactData.Visible = false;
            // 
            // lbSetContactType
            // 
            this.lbSetContactType.FormattingEnabled = true;
            this.lbSetContactType.Location = new System.Drawing.Point(87, 19);
            this.lbSetContactType.Name = "lbSetContactType";
            this.lbSetContactType.Size = new System.Drawing.Size(201, 17);
            this.lbSetContactType.TabIndex = 8;
            this.lbSetContactType.DoubleClick += new System.EventHandler(this.LbSetContactType_DoubleClick);
            // 
            // btnSaveContactCancel
            // 
            this.btnSaveContactCancel.Location = new System.Drawing.Point(82, 72);
            this.btnSaveContactCancel.Name = "btnSaveContactCancel";
            this.btnSaveContactCancel.Size = new System.Drawing.Size(99, 20);
            this.btnSaveContactCancel.TabIndex = 7;
            this.btnSaveContactCancel.Text = "Отменить";
            this.btnSaveContactCancel.UseVisualStyleBackColor = true;
            this.btnSaveContactCancel.Click += new System.EventHandler(this.BtnSaveContactCancel_Click);
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.Location = new System.Drawing.Point(187, 72);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(99, 20);
            this.btnSaveContact.TabIndex = 6;
            this.btnSaveContact.Text = "Сохранить";
            this.btnSaveContact.UseVisualStyleBackColor = true;
            this.btnSaveContact.Click += new System.EventHandler(this.BtnSaveContact_Click);
            // 
            // tbContactValue
            // 
            this.tbContactValue.Location = new System.Drawing.Point(87, 44);
            this.tbContactValue.Name = "tbContactValue";
            this.tbContactValue.Size = new System.Drawing.Size(201, 20);
            this.tbContactValue.TabIndex = 3;
            // 
            // lblContactValue
            // 
            this.lblContactValue.AutoSize = true;
            this.lblContactValue.Location = new System.Drawing.Point(6, 47);
            this.lblContactValue.Name = "lblContactValue";
            this.lblContactValue.Size = new System.Drawing.Size(48, 13);
            this.lblContactValue.TabIndex = 2;
            this.lblContactValue.Text = "Контакт";
            // 
            // lblSetContactType
            // 
            this.lblSetContactType.AutoSize = true;
            this.lblSetContactType.Location = new System.Drawing.Point(6, 25);
            this.lblSetContactType.Name = "lblSetContactType";
            this.lblSetContactType.Size = new System.Drawing.Size(75, 13);
            this.lblSetContactType.TabIndex = 0;
            this.lblSetContactType.Text = "Тип контакта";
            // 
            // gbContactTypeData
            // 
            this.gbContactTypeData.Controls.Add(this.btnSaveContactTypeCancel);
            this.gbContactTypeData.Controls.Add(this.btnSaveContactType);
            this.gbContactTypeData.Controls.Add(this.tbContactType);
            this.gbContactTypeData.Controls.Add(this.lblContactType);
            this.gbContactTypeData.Location = new System.Drawing.Point(125, 372);
            this.gbContactTypeData.Name = "gbContactTypeData";
            this.gbContactTypeData.Size = new System.Drawing.Size(294, 72);
            this.gbContactTypeData.TabIndex = 10;
            this.gbContactTypeData.TabStop = false;
            this.gbContactTypeData.Text = "Тип контакта";
            this.gbContactTypeData.Visible = false;
            // 
            // btnSaveContactTypeCancel
            // 
            this.btnSaveContactTypeCancel.Location = new System.Drawing.Point(87, 46);
            this.btnSaveContactTypeCancel.Name = "btnSaveContactTypeCancel";
            this.btnSaveContactTypeCancel.Size = new System.Drawing.Size(99, 20);
            this.btnSaveContactTypeCancel.TabIndex = 7;
            this.btnSaveContactTypeCancel.Text = "Отменить";
            this.btnSaveContactTypeCancel.UseVisualStyleBackColor = true;
            this.btnSaveContactTypeCancel.Click += new System.EventHandler(this.BtnSaveContactTypeCancel_Click);
            // 
            // btnSaveContactType
            // 
            this.btnSaveContactType.Location = new System.Drawing.Point(189, 46);
            this.btnSaveContactType.Name = "btnSaveContactType";
            this.btnSaveContactType.Size = new System.Drawing.Size(99, 20);
            this.btnSaveContactType.TabIndex = 6;
            this.btnSaveContactType.Text = "Сохранить";
            this.btnSaveContactType.UseVisualStyleBackColor = true;
            this.btnSaveContactType.Click += new System.EventHandler(this.BtnSaveContactType_Click);
            // 
            // tbContactType
            // 
            this.tbContactType.Location = new System.Drawing.Point(85, 19);
            this.tbContactType.Name = "tbContactType";
            this.tbContactType.Size = new System.Drawing.Size(201, 20);
            this.tbContactType.TabIndex = 3;
            // 
            // lblContactType
            // 
            this.lblContactType.AutoSize = true;
            this.lblContactType.Location = new System.Drawing.Point(3, 24);
            this.lblContactType.Name = "lblContactType";
            this.lblContactType.Size = new System.Drawing.Size(83, 13);
            this.lblContactType.TabIndex = 2;
            this.lblContactType.Text = "Название типа";
            // 
            // btnContactTypeAdd
            // 
            this.btnContactTypeAdd.Location = new System.Drawing.Point(15, 381);
            this.btnContactTypeAdd.Name = "btnContactTypeAdd";
            this.btnContactTypeAdd.Size = new System.Drawing.Size(81, 36);
            this.btnContactTypeAdd.TabIndex = 11;
            this.btnContactTypeAdd.Text = "Добавить тип контакта";
            this.btnContactTypeAdd.UseVisualStyleBackColor = true;
            this.btnContactTypeAdd.Click += new System.EventHandler(this.BtnContactTypeAdd_Click);
            // 
            // lvContacts
            // 
            this.lvContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvContacts.FullRowSelect = true;
            this.lvContacts.GridLines = true;
            this.lvContacts.Location = new System.Drawing.Point(425, 13);
            this.lvContacts.Name = "lvContacts";
            this.lvContacts.Size = new System.Drawing.Size(363, 153);
            this.lvContacts.TabIndex = 12;
            this.lvContacts.UseCompatibleStateImageBehavior = false;
            this.lvContacts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Тип контакта";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Контакт";
            this.columnHeader2.Width = 200;
            // 
            // btnContactDelete
            // 
            this.btnContactDelete.Location = new System.Drawing.Point(681, 172);
            this.btnContactDelete.Name = "btnContactDelete";
            this.btnContactDelete.Size = new System.Drawing.Size(107, 23);
            this.btnContactDelete.TabIndex = 14;
            this.btnContactDelete.Text = "Удалить контакт";
            this.btnContactDelete.UseVisualStyleBackColor = true;
            this.btnContactDelete.Click += new System.EventHandler(this.BtnContactDelete_Click);
            // 
            // btnContactSwitchUpdate
            // 
            this.btnContactSwitchUpdate.Location = new System.Drawing.Point(547, 172);
            this.btnContactSwitchUpdate.Name = "btnContactSwitchUpdate";
            this.btnContactSwitchUpdate.Size = new System.Drawing.Size(118, 23);
            this.btnContactSwitchUpdate.TabIndex = 13;
            this.btnContactSwitchUpdate.Text = "Изменить контакт";
            this.btnContactSwitchUpdate.UseVisualStyleBackColor = true;
            this.btnContactSwitchUpdate.Click += new System.EventHandler(this.BtnContactSwitchUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.btnContactSwitchAdd);
            this.Controls.Add(this.btnContactDelete);
            this.Controls.Add(this.btnContactSwitchUpdate);
            this.Controls.Add(this.lvContacts);
            this.Controls.Add(this.btnContactTypeAdd);
            this.Controls.Add(this.gbContactTypeData);
            this.Controls.Add(this.gbContactData);
            this.Controls.Add(this.gbPersonData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lvPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbPersonData.ResumeLayout(false);
            this.gbPersonData.PerformLayout();
            this.gbContactData.ResumeLayout(false);
            this.gbContactData.PerformLayout();
            this.gbContactTypeData.ResumeLayout(false);
            this.gbContactTypeData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPeople;
        private System.Windows.Forms.ColumnHeader clmFirstName;
        private System.Windows.Forms.ColumnHeader clmSecondName;
        private System.Windows.Forms.ColumnHeader clmBirthDay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbPersonData;
        private System.Windows.Forms.Button btnSavePerson;
        private System.Windows.Forms.DateTimePicker dtpPersonBirthDay;
        private System.Windows.Forms.Label lblPersonBirthDay;
        private System.Windows.Forms.TextBox tbPersonSecondName;
        private System.Windows.Forms.Label lblPersonSecondName;
        private System.Windows.Forms.TextBox tbPersonFirstName;
        private System.Windows.Forms.Label lblPersonFirstName;
        private System.Windows.Forms.Button btnSavePersonCancel;
        private System.Windows.Forms.Button btnContactSwitchAdd;
        private System.Windows.Forms.GroupBox gbContactData;
        private System.Windows.Forms.ListBox lbSetContactType;
        private System.Windows.Forms.Button btnSaveContactCancel;
        private System.Windows.Forms.Button btnSaveContact;
        private System.Windows.Forms.TextBox tbContactValue;
        private System.Windows.Forms.Label lblContactValue;
        private System.Windows.Forms.Label lblSetContactType;
        private System.Windows.Forms.GroupBox gbContactTypeData;
        private System.Windows.Forms.Button btnSaveContactTypeCancel;
        private System.Windows.Forms.Button btnSaveContactType;
        private System.Windows.Forms.TextBox tbContactType;
        private System.Windows.Forms.Label lblContactType;
        private System.Windows.Forms.Button btnContactTypeAdd;
        private System.Windows.Forms.ListView lvContacts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnContactDelete;
        private System.Windows.Forms.Button btnContactSwitchUpdate;
    }
}

