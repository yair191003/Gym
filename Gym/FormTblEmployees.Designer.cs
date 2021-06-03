namespace Gym
{
    partial class FormTblEmployees
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
            this.tblEmployeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEmployees = new Gym.DataSetEmployees();
            this.tblEmployeesTableAdapter = new Gym.DataSetEmployeesTableAdapters.tblEmployeesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.DataSource = this.tblEmployeesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(25, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1269, 536);
            this.dataGridView1.TabIndex = 0;
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
            this.employIsAdminDataGridViewCheckBoxColumn.HeaderText = "מנהל?";
            this.employIsAdminDataGridViewCheckBoxColumn.Name = "employIsAdminDataGridViewCheckBoxColumn";
            // 
            // employPictureDataGridViewTextBoxColumn
            // 
            this.employPictureDataGridViewTextBoxColumn.DataPropertyName = "employPicture";
            this.employPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.employPictureDataGridViewTextBoxColumn.Name = "employPictureDataGridViewTextBoxColumn";
            // 
            // tblEmployeesBindingSource1
            // 
            this.tblEmployeesBindingSource1.DataMember = "tblEmployees";
            this.tblEmployeesBindingSource1.DataSource = this.dataSetEmployees;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "טבלת עובדים";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(597, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTblEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1306, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblEmployees";
            this.Text = "FormTblEmployees";
            this.Load += new System.EventHandler(this.FormTblEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetEmployees dataSetEmployees;
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
        private System.Windows.Forms.BindingSource tblEmployeesBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}