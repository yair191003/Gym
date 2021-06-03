namespace Gym
{
    partial class FormTblSubscribers
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tblSubscribersTableAdapter = new Gym.DataSetSubscribersTableAdapters.tblSubscribersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubscribersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSubscribers)).BeginInit();
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
            this.dataGridView1.DataSource = this.tblSubscribersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 566);
            this.dataGridView1.TabIndex = 0;
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
            this.subscrCityDataGridViewTextBoxColumn.HeaderText = "עיר מגורים";
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
            this.subscrMobileDataGridViewTextBoxColumn.HeaderText = "טלפון נייד";
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "טבלת מנויים";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(557, 626);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblSubscribersTableAdapter
            // 
            this.tblSubscribersTableAdapter.ClearBeforeFill = true;
            // 
            // FormTblSubscribers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblSubscribers";
            this.Text = "FormTblSubscribers";
            this.Load += new System.EventHandler(this.FormSubscribers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubscribersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSubscribers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
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
    }
}