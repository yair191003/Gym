namespace Gym
{
    partial class FormUpdateSubscribers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subscrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscrFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscrLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscrBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscrAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscrCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscrPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscrMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscrMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscrPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSubscribersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSubscribers = new Gym.DataSetSubscribers();
            this.subscrMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.subscrBirthDate = new System.Windows.Forms.DateTimePicker();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mobile = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboCity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.subscrAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subscrLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subscrFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tblSubscribersTableAdapter = new Gym.DataSetSubscribersTableAdapters.tblSubscribersTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.subscrID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubscribersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSubscribers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subscrIDDataGridViewTextBoxColumn,
            this.subscrFirstNameDataGridViewTextBoxColumn,
            this.subscrLastNameDataGridViewTextBoxColumn,
            this.subscrBirthDateDataGridViewTextBoxColumn,
            this.subscrAddressDataGridViewTextBoxColumn,
            this.subscrCityDataGridViewTextBoxColumn,
            this.subscrPhoneDataGridViewTextBoxColumn,
            this.subscrMobileDataGridViewTextBoxColumn,
            this.subscrMailDataGridViewTextBoxColumn,
            this.subscrPictureDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.dataGridView1.DataSource = this.tblSubscribersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 332);
            this.dataGridView1.TabIndex = 105;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // subscrIDDataGridViewTextBoxColumn
            // 
            this.subscrIDDataGridViewTextBoxColumn.DataPropertyName = "subscrID";
            this.subscrIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.subscrIDDataGridViewTextBoxColumn.Name = "subscrIDDataGridViewTextBoxColumn";
            // 
            // subscrFirstNameDataGridViewTextBoxColumn
            // 
            this.subscrFirstNameDataGridViewTextBoxColumn.DataPropertyName = "subscrFirstName";
            this.subscrFirstNameDataGridViewTextBoxColumn.HeaderText = "שם פרטי";
            this.subscrFirstNameDataGridViewTextBoxColumn.Name = "subscrFirstNameDataGridViewTextBoxColumn";
            // 
            // subscrLastNameDataGridViewTextBoxColumn
            // 
            this.subscrLastNameDataGridViewTextBoxColumn.DataPropertyName = "subscrLastName";
            this.subscrLastNameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.subscrLastNameDataGridViewTextBoxColumn.Name = "subscrLastNameDataGridViewTextBoxColumn";
            // 
            // subscrBirthDateDataGridViewTextBoxColumn
            // 
            this.subscrBirthDateDataGridViewTextBoxColumn.DataPropertyName = "subscrBirthDate";
            this.subscrBirthDateDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.subscrBirthDateDataGridViewTextBoxColumn.Name = "subscrBirthDateDataGridViewTextBoxColumn";
            // 
            // subscrAddressDataGridViewTextBoxColumn
            // 
            this.subscrAddressDataGridViewTextBoxColumn.DataPropertyName = "subscrAddress";
            this.subscrAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.subscrAddressDataGridViewTextBoxColumn.Name = "subscrAddressDataGridViewTextBoxColumn";
            // 
            // subscrCityDataGridViewTextBoxColumn
            // 
            this.subscrCityDataGridViewTextBoxColumn.DataPropertyName = "subscrCity";
            this.subscrCityDataGridViewTextBoxColumn.HeaderText = "עיר";
            this.subscrCityDataGridViewTextBoxColumn.Name = "subscrCityDataGridViewTextBoxColumn";
            // 
            // subscrPhoneDataGridViewTextBoxColumn
            // 
            this.subscrPhoneDataGridViewTextBoxColumn.DataPropertyName = "subscrPhone";
            this.subscrPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון בית";
            this.subscrPhoneDataGridViewTextBoxColumn.Name = "subscrPhoneDataGridViewTextBoxColumn";
            // 
            // subscrMobileDataGridViewTextBoxColumn
            // 
            this.subscrMobileDataGridViewTextBoxColumn.DataPropertyName = "subscrMobile";
            this.subscrMobileDataGridViewTextBoxColumn.HeaderText = "נייד";
            this.subscrMobileDataGridViewTextBoxColumn.Name = "subscrMobileDataGridViewTextBoxColumn";
            // 
            // subscrMailDataGridViewTextBoxColumn
            // 
            this.subscrMailDataGridViewTextBoxColumn.DataPropertyName = "subscrMail";
            this.subscrMailDataGridViewTextBoxColumn.HeaderText = "אימייל";
            this.subscrMailDataGridViewTextBoxColumn.Name = "subscrMailDataGridViewTextBoxColumn";
            // 
            // subscrPictureDataGridViewTextBoxColumn
            // 
            this.subscrPictureDataGridViewTextBoxColumn.DataPropertyName = "subscrPicture";
            this.subscrPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.subscrPictureDataGridViewTextBoxColumn.Name = "subscrPictureDataGridViewTextBoxColumn";
            // 
            // tblSubscribersBindingSource
            // 
            this.tblSubscribersBindingSource.DataMember = "tblSubscribers";
            this.tblSubscribersBindingSource.DataSource = this.dataSetSubscribers;
            // 
            // dataSetSubscribers
            // 
            this.dataSetSubscribers.DataSetName = "DataSetSubscribers";
            this.dataSetSubscribers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subscrMail
            // 
            this.subscrMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subscrMail.Location = new System.Drawing.Point(566, 172);
            this.subscrMail.Name = "subscrMail";
            this.subscrMail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subscrMail.Size = new System.Drawing.Size(100, 20);
            this.subscrMail.TabIndex = 104;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(697, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 103;
            this.label11.Text = "אימייל";
            // 
            // subscrBirthDate
            // 
            this.subscrBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subscrBirthDate.Location = new System.Drawing.Point(450, 85);
            this.subscrBirthDate.Name = "subscrBirthDate";
            this.subscrBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subscrBirthDate.Size = new System.Drawing.Size(200, 20);
            this.subscrBirthDate.TabIndex = 102;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(169, 176);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonBrowse.Size = new System.Drawing.Size(56, 19);
            this.buttonBrowse.TabIndex = 101;
            this.buttonBrowse.Text = ". . .עיון";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // pictureLocation
            // 
            this.pictureLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLocation.Location = new System.Drawing.Point(248, 175);
            this.pictureLocation.Name = "pictureLocation";
            this.pictureLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pictureLocation.Size = new System.Drawing.Size(232, 20);
            this.pictureLocation.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 99;
            this.label10.Text = "תמונה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(771, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // mobile
            // 
            this.mobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mobile.Location = new System.Drawing.Point(205, 128);
            this.mobile.Name = "mobile";
            this.mobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mobile.Size = new System.Drawing.Size(100, 20);
            this.mobile.TabIndex = 97;
            // 
            // phone
            // 
            this.phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phone.Location = new System.Drawing.Point(380, 129);
            this.phone.Name = "phone";
            this.phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone.Size = new System.Drawing.Size(100, 20);
            this.phone.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 132);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 95;
            this.label9.Text = "נייד";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 132);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "טלפון";
            // 
            // comboCity
            // 
            this.comboCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCity.FormattingEnabled = true;
            this.comboCity.Location = new System.Drawing.Point(591, 128);
            this.comboCity.Name = "comboCity";
            this.comboCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboCity.Size = new System.Drawing.Size(91, 21);
            this.comboCity.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(710, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "עיר";
            // 
            // subscrAddress
            // 
            this.subscrAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subscrAddress.Location = new System.Drawing.Point(205, 84);
            this.subscrAddress.Name = "subscrAddress";
            this.subscrAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subscrAddress.Size = new System.Drawing.Size(135, 20);
            this.subscrAddress.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 91);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "כתובת";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 91);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "תאריך לידה";
            // 
            // subscrLastName
            // 
            this.subscrLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subscrLastName.Location = new System.Drawing.Point(205, 46);
            this.subscrLastName.Name = "subscrLastName";
            this.subscrLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subscrLastName.Size = new System.Drawing.Size(100, 20);
            this.subscrLastName.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 48);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "שם משפחה";
            // 
            // subscrFirstName
            // 
            this.subscrFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subscrFirstName.Location = new System.Drawing.Point(408, 46);
            this.subscrFirstName.Name = "subscrFirstName";
            this.subscrFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subscrFirstName.Size = new System.Drawing.Size(100, 20);
            this.subscrFirstName.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 48);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "שם פרטי";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "ת\"ז";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(471, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 82;
            this.label1.Text = "עדכון מנוי";
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(603, 208);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(60, 33);
            this.buttonFirst.TabIndex = 110;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(440, 208);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(61, 33);
            this.buttonLast.TabIndex = 109;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(531, 208);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(62, 33);
            this.buttonNext.TabIndex = 108;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(359, 208);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 33);
            this.buttonPrev.TabIndex = 107;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(489, 271);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 42);
            this.buttonUpdate.TabIndex = 106;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tblSubscribersTableAdapter
            // 
            this.tblSubscribersTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // subscrID
            // 
            this.subscrID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subscrID.Enabled = false;
            this.subscrID.Location = new System.Drawing.Point(582, 49);
            this.subscrID.Name = "subscrID";
            this.subscrID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subscrID.Size = new System.Drawing.Size(100, 20);
            this.subscrID.TabIndex = 111;
            // 
            // FormUpdateSubscribers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.subscrID);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.subscrMail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.subscrBirthDate);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureLocation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subscrAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subscrLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subscrFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateSubscribers";
            this.Text = "FormUpdateSubscribers";
            this.Load += new System.EventHandler(this.FormUpdateSubscribers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubscribersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSubscribers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox subscrMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker subscrBirthDate;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox pictureLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox subscrAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subscrLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subscrFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonUpdate;
        private DataSetSubscribers dataSetSubscribers;
        private System.Windows.Forms.BindingSource tblSubscribersBindingSource;
        private DataSetSubscribersTableAdapters.tblSubscribersTableAdapter tblSubscribersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscrFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscrLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscrBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscrAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscrCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscrPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscrMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscrMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscrPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox subscrID;
    }
}