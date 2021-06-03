namespace Gym
{
    partial class FormRptTrainingOfSubsc
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tblSubscribersTableAdapter = new Gym.DataSetSubscribersTableAdapters.tblSubscribersTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubscribersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSubscribers)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(429, 610);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "ניקוי";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonColor.Location = new System.Drawing.Point(1060, 610);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(116, 41);
            this.buttonColor.TabIndex = 5;
            this.buttonColor.Text = "בחר צבע";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonShow.Location = new System.Drawing.Point(580, 610);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(116, 41);
            this.buttonShow.TabIndex = 6;
            this.buttonShow.Text = "הצג";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(9, 312);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1166, 293);
            this.listView1.TabIndex = 125;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ת\"ז מנוי";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "תאריך ";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "שעה";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "סוג אימון";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "חדר";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "מכשיר לשימוש באימון";
            this.columnHeader6.Width = 149;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFirst.Location = new System.Drawing.Point(683, 274);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(60, 33);
            this.buttonFirst.TabIndex = 1;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click_1);
            // 
            // buttonLast
            // 
            this.buttonLast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLast.Location = new System.Drawing.Point(520, 274);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(61, 33);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(611, 274);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(62, 33);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(439, 274);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 33);
            this.buttonPrev.TabIndex = 4;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 119;
            this.label1.Text = "דוח אימונים למנוי";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.DataSource = this.tblSubscribersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 216);
            this.dataGridView1.TabIndex = 129;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // subscrIDDataGridViewTextBoxColumn
            // 
            this.subscrIDDataGridViewTextBoxColumn.DataPropertyName = "subscrID";
            this.subscrIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז מנוי";
            this.subscrIDDataGridViewTextBoxColumn.Name = "subscrIDDataGridViewTextBoxColumn";
            this.subscrIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscrFirstNameDataGridViewTextBoxColumn
            // 
            this.subscrFirstNameDataGridViewTextBoxColumn.DataPropertyName = "subscrFirstName";
            this.subscrFirstNameDataGridViewTextBoxColumn.HeaderText = "שם פרטי";
            this.subscrFirstNameDataGridViewTextBoxColumn.Name = "subscrFirstNameDataGridViewTextBoxColumn";
            this.subscrFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscrLastNameDataGridViewTextBoxColumn
            // 
            this.subscrLastNameDataGridViewTextBoxColumn.DataPropertyName = "subscrLastName";
            this.subscrLastNameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.subscrLastNameDataGridViewTextBoxColumn.Name = "subscrLastNameDataGridViewTextBoxColumn";
            this.subscrLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscrBirthDateDataGridViewTextBoxColumn
            // 
            this.subscrBirthDateDataGridViewTextBoxColumn.DataPropertyName = "subscrBirthDate";
            this.subscrBirthDateDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.subscrBirthDateDataGridViewTextBoxColumn.Name = "subscrBirthDateDataGridViewTextBoxColumn";
            this.subscrBirthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscrAddressDataGridViewTextBoxColumn
            // 
            this.subscrAddressDataGridViewTextBoxColumn.DataPropertyName = "subscrAddress";
            this.subscrAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.subscrAddressDataGridViewTextBoxColumn.Name = "subscrAddressDataGridViewTextBoxColumn";
            this.subscrAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscrCityDataGridViewTextBoxColumn
            // 
            this.subscrCityDataGridViewTextBoxColumn.DataPropertyName = "subscrCity";
            this.subscrCityDataGridViewTextBoxColumn.HeaderText = "עיר מגורים";
            this.subscrCityDataGridViewTextBoxColumn.Name = "subscrCityDataGridViewTextBoxColumn";
            this.subscrCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscrPhoneDataGridViewTextBoxColumn
            // 
            this.subscrPhoneDataGridViewTextBoxColumn.DataPropertyName = "subscrPhone";
            this.subscrPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון בית";
            this.subscrPhoneDataGridViewTextBoxColumn.Name = "subscrPhoneDataGridViewTextBoxColumn";
            this.subscrPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscrMobileDataGridViewTextBoxColumn
            // 
            this.subscrMobileDataGridViewTextBoxColumn.DataPropertyName = "subscrMobile";
            this.subscrMobileDataGridViewTextBoxColumn.HeaderText = "טלפון נייד";
            this.subscrMobileDataGridViewTextBoxColumn.Name = "subscrMobileDataGridViewTextBoxColumn";
            this.subscrMobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscrMailDataGridViewTextBoxColumn
            // 
            this.subscrMailDataGridViewTextBoxColumn.DataPropertyName = "subscrMail";
            this.subscrMailDataGridViewTextBoxColumn.HeaderText = "אימייל";
            this.subscrMailDataGridViewTextBoxColumn.Name = "subscrMailDataGridViewTextBoxColumn";
            this.subscrMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscrPictureDataGridViewTextBoxColumn
            // 
            this.subscrPictureDataGridViewTextBoxColumn.DataPropertyName = "subscrPicture";
            this.subscrPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.subscrPictureDataGridViewTextBoxColumn.Name = "subscrPictureDataGridViewTextBoxColumn";
            this.subscrPictureDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tblSubscribersTableAdapter
            // 
            this.tblSubscribersTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1091, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 130;
            this.label3.Text = "טבלת מנויים";
            // 
            // FormRptTrainingOfSubsc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.label1);
            this.Name = "FormRptTrainingOfSubsc";
            this.Text = "FormRptTrainingOfSubsc";
            this.Load += new System.EventHandler(this.FormRptTrainingOfSubsc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubscribersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSubscribers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label label3;
    }
}