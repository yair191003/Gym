namespace Gym
{
    partial class FormUpdateEmployee
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
            this.label12 = new System.Windows.Forms.Label();
            this.EmployPassword = new System.Windows.Forms.TextBox();
            this.EmployMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EmployBirthDate = new System.Windows.Forms.DateTimePicker();
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tblEmployeesTableAdapter = new Gym.DataSetEmployeesTableAdapters.tblEmployeesTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(640, 143);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "סיסמה";
            // 
            // EmployPassword
            // 
            this.EmployPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployPassword.Location = new System.Drawing.Point(515, 143);
            this.EmployPassword.Name = "EmployPassword";
            this.EmployPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployPassword.Size = new System.Drawing.Size(100, 20);
            this.EmployPassword.TabIndex = 81;
            // 
            // EmployMail
            // 
            this.EmployMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployMail.Location = new System.Drawing.Point(721, 140);
            this.EmployMail.Name = "EmployMail";
            this.EmployMail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployMail.Size = new System.Drawing.Size(100, 20);
            this.EmployMail.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(837, 140);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "אימייל";
            // 
            // EmployBirthDate
            // 
            this.EmployBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployBirthDate.Location = new System.Drawing.Point(44, 49);
            this.EmployBirthDate.Name = "EmployBirthDate";
            this.EmployBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployBirthDate.Size = new System.Drawing.Size(200, 20);
            this.EmployBirthDate.TabIndex = 78;
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 318);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.employCityDataGridViewTextBoxColumn.HeaderText = "עיר ";
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
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(18, 147);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonBrowse.Size = new System.Drawing.Size(56, 19);
            this.buttonBrowse.TabIndex = 76;
            this.buttonBrowse.Text = ". . .עיון";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click_1);
            // 
            // pictureLocation
            // 
            this.pictureLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLocation.Location = new System.Drawing.Point(97, 146);
            this.pictureLocation.Name = "pictureLocation";
            this.pictureLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pictureLocation.Size = new System.Drawing.Size(232, 20);
            this.pictureLocation.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 146);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "תמונה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(925, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // mobile
            // 
            this.mobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mobile.Location = new System.Drawing.Point(105, 98);
            this.mobile.Name = "mobile";
            this.mobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mobile.Size = new System.Drawing.Size(100, 20);
            this.mobile.TabIndex = 72;
            // 
            // phone
            // 
            this.phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phone.Location = new System.Drawing.Point(336, 95);
            this.phone.Name = "phone";
            this.phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone.Size = new System.Drawing.Size(100, 20);
            this.phone.TabIndex = 71;
            // 
            // isManeger
            // 
            this.isManeger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isManeger.AutoSize = true;
            this.isManeger.Location = new System.Drawing.Point(401, 146);
            this.isManeger.Margin = new System.Windows.Forms.Padding(2);
            this.isManeger.Name = "isManeger";
            this.isManeger.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isManeger.Size = new System.Drawing.Size(58, 17);
            this.isManeger.TabIndex = 70;
            this.isManeger.Text = "?מנהל";
            this.isManeger.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 98);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "נייד";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 95);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "טלפון";
            // 
            // comboCity
            // 
            this.comboCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCity.FormattingEnabled = true;
            this.comboCity.Location = new System.Drawing.Point(534, 91);
            this.comboCity.Name = "comboCity";
            this.comboCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboCity.Size = new System.Drawing.Size(91, 21);
            this.comboCity.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 91);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "עיר";
            // 
            // EmployAddress
            // 
            this.EmployAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployAddress.Location = new System.Drawing.Point(696, 88);
            this.EmployAddress.Name = "EmployAddress";
            this.EmployAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployAddress.Size = new System.Drawing.Size(135, 20);
            this.EmployAddress.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(837, 91);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "כתובת";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 49);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "תאריך לידה";
            // 
            // EmployLastName
            // 
            this.EmployLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployLastName.Location = new System.Drawing.Point(359, 46);
            this.EmployLastName.Name = "EmployLastName";
            this.EmployLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployLastName.Size = new System.Drawing.Size(100, 20);
            this.EmployLastName.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 48);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "שם משפחה";
            // 
            // EmployFirstName
            // 
            this.EmployFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployFirstName.Location = new System.Drawing.Point(562, 46);
            this.EmployFirstName.Name = "EmployFirstName";
            this.EmployFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployFirstName.Size = new System.Drawing.Size(100, 20);
            this.EmployFirstName.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 48);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "שם פרטי";
            // 
            // EmployId
            // 
            this.EmployId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployId.Enabled = false;
            this.EmployId.Location = new System.Drawing.Point(747, 46);
            this.EmployId.Name = "EmployId";
            this.EmployId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployId.Size = new System.Drawing.Size(100, 20);
            this.EmployId.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(853, 49);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "ת\"ז";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(492, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "עדכון עובד";
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(606, 209);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(60, 33);
            this.buttonFirst.TabIndex = 87;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(443, 209);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(61, 33);
            this.buttonLast.TabIndex = 86;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(534, 209);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(62, 33);
            this.buttonNext.TabIndex = 85;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(362, 209);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 33);
            this.buttonPrev.TabIndex = 84;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(492, 272);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 42);
            this.buttonUpdate.TabIndex = 83;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tblEmployeesTableAdapter
            // 
            this.tblEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonUpdate);
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
            this.Name = "FormUpdateEmployee";
            this.Text = "FormUpdateEmployee";
            this.Load += new System.EventHandler(this.FormUpdateEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EmployPassword;
        private System.Windows.Forms.TextBox EmployMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker EmployBirthDate;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonUpdate;
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}