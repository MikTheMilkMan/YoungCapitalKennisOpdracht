namespace Telefoonboek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addPersonBox1 = new System.Windows.Forms.TextBox();
            this.addPerson = new System.Windows.Forms.Button();
            this.clearPersonButton = new System.Windows.Forms.Button();
            this.searchBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showPersonButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editSelectedButton = new System.Windows.Forms.Button();
            this.removeCPerson = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listviewID = new System.Windows.Forms.ColumnHeader();
            this.listviewName = new System.Windows.Forms.ColumnHeader();
            this.listviewSurname = new System.Windows.Forms.ColumnHeader();
            this.listviewDoB = new System.Windows.Forms.ColumnHeader();
            this.listviewPhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.listviewMailAddress = new System.Windows.Forms.ColumnHeader();
            this.dateOfBirthClassed = new System.Windows.Forms.DateTimePicker();
            this.classedPersonMailAddress = new System.Windows.Forms.TextBox();
            this.classedPersonPhoneNumber = new System.Windows.Forms.TextBox();
            this.classedPersonSurname = new System.Windows.Forms.TextBox();
            this.addClassedPerson = new System.Windows.Forms.Button();
            this.showClassedPersonButton = new System.Windows.Forms.Button();
            this.clearClassedPersonButton = new System.Windows.Forms.Button();
            this.classedPersonName = new System.Windows.Forms.TextBox();
            this.searchBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addPersonBox1);
            this.tabPage1.Controls.Add(this.addPerson);
            this.tabPage1.Controls.Add(this.clearPersonButton);
            this.tabPage1.Controls.Add(this.searchBox1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.showPersonButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hardcoded Persons";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // addPersonBox1
            // 
            this.addPersonBox1.Location = new System.Drawing.Point(390, 43);
            this.addPersonBox1.Name = "addPersonBox1";
            this.addPersonBox1.PlaceholderText = "HC_Person Full Name";
            this.addPersonBox1.Size = new System.Drawing.Size(232, 23);
            this.addPersonBox1.TabIndex = 8;
            this.addPersonBox1.TextChanged += new System.EventHandler(this.addPersonBox1_TextChanged);
            // 
            // addPerson
            // 
            this.addPerson.Location = new System.Drawing.Point(390, 72);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(113, 25);
            this.addPerson.TabIndex = 7;
            this.addPerson.Text = "Add HC_Person";
            this.addPerson.UseVisualStyleBackColor = true;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // clearPersonButton
            // 
            this.clearPersonButton.Location = new System.Drawing.Point(390, 343);
            this.clearPersonButton.Name = "clearPersonButton";
            this.clearPersonButton.Size = new System.Drawing.Size(113, 49);
            this.clearPersonButton.TabIndex = 5;
            this.clearPersonButton.Text = "Clear All HC_Persons";
            this.clearPersonButton.UseVisualStyleBackColor = true;
            this.clearPersonButton.Click += new System.EventHandler(this.clearPersonButton_Click);
            // 
            // searchBox1
            // 
            this.searchBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.searchBox1.Location = new System.Drawing.Point(6, 6);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.PlaceholderText = "Search HC_Persons...";
            this.searchBox1.Size = new System.Drawing.Size(204, 23);
            this.searchBox1.TabIndex = 2;
            this.searchBox1.TextChanged += new System.EventHandler(this.searchBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 349);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // showPersonButton
            // 
            this.showPersonButton.Location = new System.Drawing.Point(509, 343);
            this.showPersonButton.Name = "showPersonButton";
            this.showPersonButton.Size = new System.Drawing.Size(113, 49);
            this.showPersonButton.TabIndex = 0;
            this.showPersonButton.Text = "Show All HC_Persons";
            this.showPersonButton.UseVisualStyleBackColor = true;
            this.showPersonButton.Click += new System.EventHandler(this.showPersonButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editSelectedButton);
            this.tabPage2.Controls.Add(this.removeCPerson);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.dateOfBirthClassed);
            this.tabPage2.Controls.Add(this.classedPersonMailAddress);
            this.tabPage2.Controls.Add(this.classedPersonPhoneNumber);
            this.tabPage2.Controls.Add(this.classedPersonSurname);
            this.tabPage2.Controls.Add(this.addClassedPerson);
            this.tabPage2.Controls.Add(this.showClassedPersonButton);
            this.tabPage2.Controls.Add(this.clearClassedPersonButton);
            this.tabPage2.Controls.Add(this.classedPersonName);
            this.tabPage2.Controls.Add(this.searchBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classed Persons";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editSelectedButton
            // 
            this.editSelectedButton.Location = new System.Drawing.Point(509, 219);
            this.editSelectedButton.Name = "editSelectedButton";
            this.editSelectedButton.Size = new System.Drawing.Size(113, 23);
            this.editSelectedButton.TabIndex = 13;
            this.editSelectedButton.Text = "Edit Selected";
            this.editSelectedButton.UseVisualStyleBackColor = true;
            this.editSelectedButton.Click += new System.EventHandler(this.editSelectedButton_Click);
            // 
            // removeCPerson
            // 
            this.removeCPerson.Location = new System.Drawing.Point(509, 188);
            this.removeCPerson.Name = "removeCPerson";
            this.removeCPerson.Size = new System.Drawing.Size(113, 25);
            this.removeCPerson.TabIndex = 12;
            this.removeCPerson.Text = "Remove Selected";
            this.removeCPerson.UseVisualStyleBackColor = true;
            this.removeCPerson.Click += new System.EventHandler(this.removeCPerson_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listviewID,
            this.listviewName,
            this.listviewSurname,
            this.listviewDoB,
            this.listviewMailAddress,
            this.listviewPhoneNumber});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(6, 43);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(375, 349);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listviewID
            // 
            this.listviewID.Text = "ID";
            this.listviewID.Width = 25;
            // 
            // listviewName
            // 
            this.listviewName.Text = "Name";
            this.listviewName.Width = 100;
            // 
            // listviewSurname
            // 
            this.listviewSurname.Text = "Surname";
            this.listviewSurname.Width = 100;
            // 
            // listviewDoB
            // 
            this.listviewDoB.Text = "Date of Birth";
            this.listviewDoB.Width = 100;
            // 
            // listviewPhoneNumber
            // 
            this.listviewPhoneNumber.Text = "Phone Number";
            this.listviewPhoneNumber.Width = 100;
            // 
            // listviewMailAddress
            // 
            this.listviewMailAddress.Text = "Mail Address";
            this.listviewMailAddress.Width = 100;
            // 
            // dateOfBirthClassed
            // 
            this.dateOfBirthClassed.Checked = false;
            this.dateOfBirthClassed.CustomFormat = "dd/mm/yyyy";
            this.dateOfBirthClassed.Location = new System.Drawing.Point(390, 101);
            this.dateOfBirthClassed.Name = "dateOfBirthClassed";
            this.dateOfBirthClassed.Size = new System.Drawing.Size(232, 23);
            this.dateOfBirthClassed.TabIndex = 10;
            this.dateOfBirthClassed.Value = new System.DateTime(2022, 8, 6, 0, 0, 0, 0);
            this.dateOfBirthClassed.ValueChanged += new System.EventHandler(this.dateOfBirthClassed_ValueChanged);
            // 
            // classedPersonMailAddress
            // 
            this.classedPersonMailAddress.Location = new System.Drawing.Point(390, 159);
            this.classedPersonMailAddress.Name = "classedPersonMailAddress";
            this.classedPersonMailAddress.PlaceholderText = "Mail Address";
            this.classedPersonMailAddress.Size = new System.Drawing.Size(232, 23);
            this.classedPersonMailAddress.TabIndex = 8;
            this.classedPersonMailAddress.TextChanged += new System.EventHandler(this.classedPersonMailAddress_TextChanged);
            // 
            // classedPersonPhoneNumber
            // 
            this.classedPersonPhoneNumber.Location = new System.Drawing.Point(390, 130);
            this.classedPersonPhoneNumber.Name = "classedPersonPhoneNumber";
            this.classedPersonPhoneNumber.PlaceholderText = "Phone Number";
            this.classedPersonPhoneNumber.Size = new System.Drawing.Size(232, 23);
            this.classedPersonPhoneNumber.TabIndex = 7;
            this.classedPersonPhoneNumber.TextChanged += new System.EventHandler(this.classedPersonPhoneNumber_TextChanged);
            // 
            // classedPersonSurname
            // 
            this.classedPersonSurname.Location = new System.Drawing.Point(390, 72);
            this.classedPersonSurname.Name = "classedPersonSurname";
            this.classedPersonSurname.PlaceholderText = "Surname";
            this.classedPersonSurname.Size = new System.Drawing.Size(232, 23);
            this.classedPersonSurname.TabIndex = 6;
            this.classedPersonSurname.TextChanged += new System.EventHandler(this.classedPersonSurname_TextChanged);
            // 
            // addClassedPerson
            // 
            this.addClassedPerson.Location = new System.Drawing.Point(390, 188);
            this.addClassedPerson.Name = "addClassedPerson";
            this.addClassedPerson.Size = new System.Drawing.Size(113, 25);
            this.addClassedPerson.TabIndex = 5;
            this.addClassedPerson.Text = "Add C_Person";
            this.addClassedPerson.UseVisualStyleBackColor = true;
            this.addClassedPerson.Click += new System.EventHandler(this.addClassedPerson_Click);
            // 
            // showClassedPersonButton
            // 
            this.showClassedPersonButton.Location = new System.Drawing.Point(509, 343);
            this.showClassedPersonButton.Name = "showClassedPersonButton";
            this.showClassedPersonButton.Size = new System.Drawing.Size(113, 49);
            this.showClassedPersonButton.TabIndex = 4;
            this.showClassedPersonButton.Text = " Show All  C_Persons ";
            this.showClassedPersonButton.UseVisualStyleBackColor = true;
            this.showClassedPersonButton.Click += new System.EventHandler(this.showClassedPersonButton_Click);
            // 
            // clearClassedPersonButton
            // 
            this.clearClassedPersonButton.Location = new System.Drawing.Point(390, 343);
            this.clearClassedPersonButton.Name = "clearClassedPersonButton";
            this.clearClassedPersonButton.Size = new System.Drawing.Size(113, 49);
            this.clearClassedPersonButton.TabIndex = 3;
            this.clearClassedPersonButton.Text = "Clear All C_Persons";
            this.clearClassedPersonButton.UseVisualStyleBackColor = true;
            this.clearClassedPersonButton.Click += new System.EventHandler(this.clearClassedPersonButton_Click);
            // 
            // classedPersonName
            // 
            this.classedPersonName.Location = new System.Drawing.Point(390, 43);
            this.classedPersonName.Name = "classedPersonName";
            this.classedPersonName.PlaceholderText = "Name";
            this.classedPersonName.Size = new System.Drawing.Size(232, 23);
            this.classedPersonName.TabIndex = 2;
            this.classedPersonName.TextChanged += new System.EventHandler(this.classedPersonName_TextChanged);
            // 
            // searchBox2
            // 
            this.searchBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.searchBox2.Location = new System.Drawing.Point(6, 6);
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.PlaceholderText = "Search C_Persons...";
            this.searchBox2.Size = new System.Drawing.Size(204, 23);
            this.searchBox2.TabIndex = 0;
            this.searchBox2.TextChanged += new System.EventHandler(this.searchBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox searchBox1;
        private ListBox listBox1;
        private Button showPersonButton;
        private Button clearPersonButton;
        private Button showClassedPersonButton;
        private Button clearClassedPersonButton;
        private TextBox classedPersonName;
        private TextBox searchBox2;
        private Button addClassedPerson;
        private TextBox classedPersonMailAddress;
        private TextBox classedPersonPhoneNumber;
        private TextBox classedPersonSurname;
        private Button addPerson;
        private TextBox addPersonBox1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateOfBirthClassed;
        private ListView listView1;
        private ColumnHeader listviewName;
        private ColumnHeader listviewSurname;
        private ColumnHeader listviewDoB;
        private ColumnHeader listviewPhoneNumber;
        private ColumnHeader listviewMailAddress;
        private Button removeCPerson;
        private Button editSelectedButton;
        private ColumnHeader listviewID;
    }
}