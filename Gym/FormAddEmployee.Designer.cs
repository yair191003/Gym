namespace Gym
{
    partial class FormAddEmployee
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
            this.components = new System.ComponentModel.Container();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mobile = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.isManeger = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboCity = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EmployAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmployLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employIsAdminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEmployees = new Gym.DataSetEmployees();
            this.tblEmployeesTableAdapter = new Gym.DataSetEmployeesTableAdapters.tblEmployeesTableAdapter();
            this.EmployBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.EmployMail = new System.Windows.Forms.TextBox();
            this.EmployPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataSetCities = new Gym.DataSetCities();
            this.tblCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCitiesTableAdapter = new Gym.DataSetCitiesTableAdapters.tblCitiesTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(534, 237);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonBrowse.Size = new System.Drawing.Size(56, 19);
            this.buttonBrowse.TabIndex = 48;
            this.buttonBrowse.Text = ". . .עיון";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // pictureLocation
            // 
            this.pictureLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLocation.Location = new System.Drawing.Point(613, 236);
            this.pictureLocation.Name = "pictureLocation";
            this.pictureLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pictureLocation.Size = new System.Drawing.Size(232, 20);
            this.pictureLocation.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(851, 236);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "תמונה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(925, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // mobile
            // 
            this.mobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mobile.Location = new System.Drawing.Point(359, 127);
            this.mobile.Name = "mobile";
            this.mobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mobile.Size = new System.Drawing.Size(100, 20);
            this.mobile.TabIndex = 44;
            // 
            // phone
            // 
            this.phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phone.Location = new System.Drawing.Point(534, 128);
            this.phone.Name = "phone";
            this.phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone.Size = new System.Drawing.Size(100, 20);
            this.phone.TabIndex = 43;
            // 
            // isManeger
            // 
            this.isManeger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isManeger.AutoSize = true;
            this.isManeger.Location = new System.Drawing.Point(436, 173);
            this.isManeger.Margin = new System.Windows.Forms.Padding(2);
            this.isManeger.Name = "isManeger";
            this.isManeger.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isManeger.Size = new System.Drawing.Size(58, 17);
            this.isManeger.TabIndex = 42;
            this.isManeger.Text = "?מנהל";
            this.isManeger.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 131);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "נייד";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(656, 131);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "טלפון";
            // 
            // comboCity
            // 
            this.comboCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCity.FormattingEnabled = true;
            this.comboCity.Location = new System.Drawing.Point(745, 127);
            this.comboCity.Name = "comboCity";
            this.comboCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboCity.Size = new System.Drawing.Size(91, 21);
            this.comboCity.TabIndex = 4;
            this.comboCity.SelectedIndexChanged += new System.EventHandler(this.comboCity_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAdd.Location = new System.Drawing.Point(690, 277);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 34);
            this.buttonAdd.TabIndex = 37;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(864, 130);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "עיר";
            // 
            // EmployAddress
            // 
            this.EmployAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployAddress.Location = new System.Drawing.Point(359, 83);
            this.EmployAddress.Name = "EmployAddress";
            this.EmployAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployAddress.Size = new System.Drawing.Size(135, 20);
            this.EmployAddress.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 90);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "כתובת";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(820, 90);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "תאריך לידה";
            // 
            // EmployLastName
            // 
            this.EmployLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployLastName.Location = new System.Drawing.Point(359, 45);
            this.EmployLastName.Name = "EmployLastName";
            this.EmployLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployLastName.Size = new System.Drawing.Size(100, 20);
            this.EmployLastName.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 47);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "שם משפחה";
            // 
            // EmployFirstName
            // 
            this.EmployFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployFirstName.Location = new System.Drawing.Point(562, 45);
            this.EmployFirstName.Name = "EmployFirstName";
            this.EmployFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployFirstName.Size = new System.Drawing.Size(100, 20);
            this.EmployFirstName.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 47);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "שם פרטי";
            // 
            // EmployId
            // 
            this.EmployId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployId.Location = new System.Drawing.Point(747, 45);
            this.EmployId.Name = "EmployId";
            this.EmployId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployId.Size = new System.Drawing.Size(100, 20);
            this.EmployId.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(853, 48);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "ת\"ז";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(625, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "הוספת עובד";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employIDDataGridViewTextBoxColumn,
            this.employFirstNameDataGridViewTextBoxColumn,
            this.employLastNameDataGridViewTextBoxColumn,
            this.employBirthDateDataGridViewTextBoxColumn,
            this.employAddressDataGridViewTextBoxColumn,
            this.employCityDataGridViewTextBoxColumn,
            this.employPhoneDataGridViewTextBoxColumn,
            this.employMobileDataGridViewTextBoxColumn,
            this.employMailDataGridViewTextBoxColumn,
            this.employPasswordDataGridViewTextBoxColumn,
            this.employIsAdminDataGridViewCheckBoxColumn,
            this.employPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEmployeesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 318);
            this.dataGridView1.TabIndex = 49;
            // 
            // employIDDataGridViewTextBoxColumn
            // 
            this.employIDDataGridViewTextBoxColumn.DataPropertyName = "employID";
            this.employIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.employIDDataGridViewTextBoxColumn.Name = "employIDDataGridViewTextBoxColumn";
            // 
            // employFirstNameDataGridViewTextBoxColumn
            // 
            this.employFirstNameDataGridViewTextBoxColumn.DataPropertyName = "employFirstName";
            this.employFirstNameDataGridViewTextBoxColumn.HeaderText = "שם פרטי";
            this.employFirstNameDataGridViewTextBoxColumn.Name = "employFirstNameDataGridViewTextBoxColumn";
            // 
            // employLastNameDataGridViewTextBoxColumn
            // 
            this.employLastNameDataGridViewTextBoxColumn.DataPropertyName = "employLastName";
            this.employLastNameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.employLastNameDataGridViewTextBoxColumn.Name = "employLastNameDataGridViewTextBoxColumn";
            // 
            // employBirthDateDataGridViewTextBoxColumn
            // 
            this.employBirthDateDataGridViewTextBoxColumn.DataPropertyName = "employBirthDate";
            this.employBirthDateDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.employBirthDateDataGridViewTextBoxColumn.Name = "employBirthDateDataGridViewTextBoxColumn";
            // 
            // employAddressDataGridViewTextBoxColumn
            // 
            this.employAddressDataGridViewTextBoxColumn.DataPropertyName = "employAddress";
            this.employAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.employAddressDataGridViewTextBoxColumn.Name = "employAddressDataGridViewTextBoxColumn";
            // 
            // employCityDataGridViewTextBoxColumn
            // 
            this.employCityDataGridViewTextBoxColumn.DataPropertyName = "employCity";
            this.employCityDataGridViewTextBoxColumn.HeaderText = "עיר מגורים";
            this.employCityDataGridViewTextBoxColumn.Name = "employCityDataGridViewTextBoxColumn";
            // 
            // employPhoneDataGridViewTextBoxColumn
            // 
            this.employPhoneDataGridViewTextBoxColumn.DataPropertyName = "employPhone";
            this.employPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון בית";
            this.employPhoneDataGridViewTextBoxColumn.Name = "employPhoneDataGridViewTextBoxColumn";
            // 
            // employMobileDataGridViewTextBoxColumn
            // 
            this.employMobileDataGridViewTextBoxColumn.DataPropertyName = "employMobile";
            this.employMobileDataGridViewTextBoxColumn.HeaderText = "טלפון נייד";
            this.employMobileDataGridViewTextBoxColumn.Name = "employMobileDataGridViewTextBoxColumn";
            // 
            // employMailDataGridViewTextBoxColumn
            // 
            this.employMailDataGridViewTextBoxColumn.DataPropertyName = "employMail";
            this.employMailDataGridViewTextBoxColumn.HeaderText = "אימייל";
            this.employMailDataGridViewTextBoxColumn.Name = "employMailDataGridViewTextBoxColumn";
            // 
            // employPasswordDataGridViewTextBoxColumn
            // 
            this.employPasswordDataGridViewTextBoxColumn.DataPropertyName = "employPassword";
            this.employPasswordDataGridViewTextBoxColumn.HeaderText = "סיסמה";
            this.employPasswordDataGridViewTextBoxColumn.Name = "employPasswordDataGridViewTextBoxColumn";
            // 
            // employIsAdminDataGridViewCheckBoxColumn
            // 
            this.employIsAdminDataGridViewCheckBoxColumn.DataPropertyName = "employIsAdmin";
            this.employIsAdminDataGridViewCheckBoxColumn.HeaderText = "?מנהל";
            this.employIsAdminDataGridViewCheckBoxColumn.Name = "employIsAdminDataGridViewCheckBoxColumn";
            // 
            // employPictureDataGridViewTextBoxColumn
            // 
            this.employPictureDataGridViewTextBoxColumn.DataPropertyName = "employPicture";
            this.employPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.employPictureDataGridViewTextBoxColumn.Name = "employPictureDataGridViewTextBoxColumn";
            // 
            // tblEmployeesBindingSource
            // 
            this.tblEmployeesBindingSource.DataMember = "tblEmployees";
            this.tblEmployeesBindingSource.DataSource = this.dataSetEmployees;
            // 
            // dataSetEmployees
            // 
            this.dataSetEmployees.DataSetName = "DataSetEmployees";
            this.dataSetEmployees.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmployeesTableAdapter
            // 
            this.tblEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // EmployBirthDate
            // 
            this.EmployBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployBirthDate.Location = new System.Drawing.Point(604, 84);
            this.EmployBirthDate.Name = "EmployBirthDate";
            this.EmployBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployBirthDate.Size = new System.Drawing.Size(200, 20);
            this.EmployBirthDate.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(851, 177);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "אימייל";
            // 
            // EmployMail
            // 
            this.EmployMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployMail.Location = new System.Drawing.Point(720, 171);
            this.EmployMail.Name = "EmployMail";
            this.EmployMail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployMail.Size = new System.Drawing.Size(100, 20);
            this.EmployMail.TabIndex = 52;
            // 
            // EmployPassword
            // 
            this.EmployPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployPassword.Location = new System.Drawing.Point(514, 173);
            this.EmployPassword.Name = "EmployPassword";
            this.EmployPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployPassword.Size = new System.Drawing.Size(100, 20);
            this.EmployPassword.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(643, 174);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "סיסמה";
            // 
            // dataSetCities
            // 
            this.dataSetCities.DataSetName = "DataSetCities";
            this.dataSetCities.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCitiesBindingSource
            // 
            this.tblCitiesBindingSource.DataMember = "tblCities";
            this.tblCitiesBindingSource.DataSource = this.dataSetCities;
            // 
            // tblCitiesTableAdapter
            // 
            this.tblCitiesTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.EmployPassword);
            this.Controls.Add(this.EmployMail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EmployBirthDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureLocation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.isManeger);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboCity);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmployAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmployLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmployFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddEmployee";
            this.Text = "FormAddEmployee";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox pictureLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.CheckBox isManeger;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboCity;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmployAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmployLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmployFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmployId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetEmployees dataSetEmployees;
        private System.Windows.Forms.BindingSource tblEmployeesBindingSource;
        private DataSetEmployeesTableAdapters.tblEmployeesTableAdapter tblEmployeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn employIsAdminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker EmployBirthDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EmployMail;
        private System.Windows.Forms.TextBox EmployPassword;
        private System.Windows.Forms.Label label12;
        private DataSetCities dataSetCities;
        private System.Windows.Forms.BindingSource tblCitiesBindingSource;
        private DataSetCitiesTableAdapters.tblCitiesTableAdapter tblCitiesTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}