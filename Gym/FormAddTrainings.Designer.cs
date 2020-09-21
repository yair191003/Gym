namespace Gym
{
    partial class FormAddTrainings
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
            this.trainSubscrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainToolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTrainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTraining = new Gym.DataSetTraining();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trainDate = new System.Windows.Forms.DateTimePicker();
            this.tblTrainingTableAdapter = new Gym.DataSetTrainingTableAdapters.tblTrainingTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.comboID = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboTool = new System.Windows.Forms.ComboBox();
            this.trainHour = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrainingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainSubscrIDDataGridViewTextBoxColumn,
            this.trainDateDataGridViewTextBoxColumn,
            this.trainHourDataGridViewTextBoxColumn,
            this.trainTypeDataGridViewTextBoxColumn,
            this.trainRoomDataGridViewTextBoxColumn,
            this.trainToolDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTrainingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // trainSubscrIDDataGridViewTextBoxColumn
            // 
            this.trainSubscrIDDataGridViewTextBoxColumn.DataPropertyName = "trainSubscrID";
            this.trainSubscrIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.trainSubscrIDDataGridViewTextBoxColumn.Name = "trainSubscrIDDataGridViewTextBoxColumn";
            // 
            // trainDateDataGridViewTextBoxColumn
            // 
            this.trainDateDataGridViewTextBoxColumn.DataPropertyName = "trainDate";
            this.trainDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.trainDateDataGridViewTextBoxColumn.Name = "trainDateDataGridViewTextBoxColumn";
            // 
            // trainHourDataGridViewTextBoxColumn
            // 
            this.trainHourDataGridViewTextBoxColumn.DataPropertyName = "trainHour";
            this.trainHourDataGridViewTextBoxColumn.HeaderText = "שעה";
            this.trainHourDataGridViewTextBoxColumn.Name = "trainHourDataGridViewTextBoxColumn";
            // 
            // trainTypeDataGridViewTextBoxColumn
            // 
            this.trainTypeDataGridViewTextBoxColumn.DataPropertyName = "trainType";
            this.trainTypeDataGridViewTextBoxColumn.HeaderText = "סוג אימון";
            this.trainTypeDataGridViewTextBoxColumn.Name = "trainTypeDataGridViewTextBoxColumn";
            // 
            // trainRoomDataGridViewTextBoxColumn
            // 
            this.trainRoomDataGridViewTextBoxColumn.DataPropertyName = "trainRoom";
            this.trainRoomDataGridViewTextBoxColumn.HeaderText = "חדר";
            this.trainRoomDataGridViewTextBoxColumn.Name = "trainRoomDataGridViewTextBoxColumn";
            // 
            // trainToolDataGridViewTextBoxColumn
            // 
            this.trainToolDataGridViewTextBoxColumn.DataPropertyName = "trainTool";
            this.trainToolDataGridViewTextBoxColumn.HeaderText = "מכשיר";
            this.trainToolDataGridViewTextBoxColumn.Name = "trainToolDataGridViewTextBoxColumn";
            // 
            // tblTrainingBindingSource
            // 
            this.tblTrainingBindingSource.DataMember = "tblTraining";
            this.tblTrainingBindingSource.DataSource = this.dataSetTraining;
            // 
            // dataSetTraining
            // 
            this.dataSetTraining.DataSetName = "DataSetTraining";
            this.dataSetTraining.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "הוספת אימון אישי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 71);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "מספר מנוי";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 116);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "תאריך";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "סוג אימון";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "חדר";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(648, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "מכשיר";
            // 
            // trainDate
            // 
            this.trainDate.Location = new System.Drawing.Point(405, 116);
            this.trainDate.Name = "trainDate";
            this.trainDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trainDate.Size = new System.Drawing.Size(233, 20);
            this.trainDate.TabIndex = 9;
            // 
            // tblTrainingTableAdapter
            // 
            this.tblTrainingTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "שעה";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAdd.Location = new System.Drawing.Point(493, 329);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 34);
            this.buttonAdd.TabIndex = 38;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboRoom
            // 
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Location = new System.Drawing.Point(404, 248);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboRoom.Size = new System.Drawing.Size(233, 21);
            this.comboRoom.TabIndex = 68;
            // 
            // comboID
            // 
            this.comboID.FormattingEnabled = true;
            this.comboID.Location = new System.Drawing.Point(404, 71);
            this.comboID.Name = "comboID";
            this.comboID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboID.Size = new System.Drawing.Size(234, 21);
            this.comboID.TabIndex = 69;
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(404, 209);
            this.comboType.Name = "comboType";
            this.comboType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboType.Size = new System.Drawing.Size(234, 21);
            this.comboType.TabIndex = 70;
            // 
            // comboTool
            // 
            this.comboTool.FormattingEnabled = true;
            this.comboTool.Location = new System.Drawing.Point(404, 293);
            this.comboTool.Name = "comboTool";
            this.comboTool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboTool.Size = new System.Drawing.Size(234, 21);
            this.comboTool.TabIndex = 71;
            // 
            // trainHour
            // 
            this.trainHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.trainHour.Location = new System.Drawing.Point(405, 162);
            this.trainHour.Name = "trainHour";
            this.trainHour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trainHour.Size = new System.Drawing.Size(233, 20);
            this.trainHour.TabIndex = 9;
            this.trainHour.Value = new System.DateTime(2020, 9, 14, 14, 26, 0, 0);
            // 
            // FormAddTrainings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.trainHour);
            this.Controls.Add(this.comboTool);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.comboID);
            this.Controls.Add(this.comboRoom);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trainDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAddTrainings";
            this.Text = "FormAddTrainings";
            this.Load += new System.EventHandler(this.FormAddTrainings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrainingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker trainDate;
        private DataSetTraining dataSetTraining;
        private System.Windows.Forms.BindingSource tblTrainingBindingSource;
        private DataSetTrainingTableAdapters.tblTrainingTableAdapter tblTrainingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainSubscrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainToolDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.ComboBox comboID;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.ComboBox comboTool;
        private System.Windows.Forms.DateTimePicker trainHour;
    }
}