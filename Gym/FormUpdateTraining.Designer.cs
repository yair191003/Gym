namespace Gym
{
    partial class FormUpdateTraining
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
            this.trainHour = new System.Windows.Forms.DateTimePicker();
            this.comboTool = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trainDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainSubscrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainToolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTrainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTraining = new Gym.DataSetTraining();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tblTrainingTableAdapter = new Gym.DataSetTrainingTableAdapters.tblTrainingTableAdapter();
            this.trainSubscrID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrainingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // trainHour
            // 
            this.trainHour.Enabled = false;
            this.trainHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.trainHour.Location = new System.Drawing.Point(631, 185);
            this.trainHour.Name = "trainHour";
            this.trainHour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trainHour.Size = new System.Drawing.Size(233, 20);
            this.trainHour.TabIndex = 3;
            this.trainHour.Value = new System.DateTime(2020, 9, 14, 14, 26, 0, 0);
            // 
            // comboTool
            // 
            this.comboTool.FormattingEnabled = true;
            this.comboTool.Location = new System.Drawing.Point(251, 190);
            this.comboTool.Name = "comboTool";
            this.comboTool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboTool.Size = new System.Drawing.Size(234, 21);
            this.comboTool.TabIndex = 6;
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(251, 106);
            this.comboType.Name = "comboType";
            this.comboType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboType.Size = new System.Drawing.Size(234, 21);
            this.comboType.TabIndex = 4;
            // 
            // comboRoom
            // 
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Location = new System.Drawing.Point(251, 145);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboRoom.Size = new System.Drawing.Size(233, 21);
            this.comboRoom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(874, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "שעה";
            // 
            // trainDate
            // 
            this.trainDate.Enabled = false;
            this.trainDate.Location = new System.Drawing.Point(631, 139);
            this.trainDate.Name = "trainDate";
            this.trainDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trainDate.Size = new System.Drawing.Size(233, 20);
            this.trainDate.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "מכשיר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "חדר";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "סוג אימון";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(874, 139);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "תאריך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(874, 94);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "מספר מנוי";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "עדכון אימון ";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 268);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // trainSubscrIDDataGridViewTextBoxColumn
            // 
            this.trainSubscrIDDataGridViewTextBoxColumn.DataPropertyName = "trainSubscrID";
            this.trainSubscrIDDataGridViewTextBoxColumn.HeaderText = "מספר מנוי";
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
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(666, 266);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(60, 33);
            this.buttonFirst.TabIndex = 7;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(503, 266);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(61, 33);
            this.buttonLast.TabIndex = 9;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(594, 266);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(62, 33);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(422, 266);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 33);
            this.buttonPrev.TabIndex = 10;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(552, 329);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 42);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tblTrainingTableAdapter
            // 
            this.tblTrainingTableAdapter.ClearBeforeFill = true;
            // 
            // trainSubscrID
            // 
            this.trainSubscrID.Enabled = false;
            this.trainSubscrID.Location = new System.Drawing.Point(631, 94);
            this.trainSubscrID.Name = "trainSubscrID";
            this.trainSubscrID.Size = new System.Drawing.Size(233, 20);
            this.trainSubscrID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1084, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 94;
            this.label8.Text = "טבלת אימונים";
            // 
            // FormUpdateTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trainSubscrID);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.trainHour);
            this.Controls.Add(this.comboTool);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.comboRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trainDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUpdateTraining";
            this.Text = "FormUpdateTraining";
            this.Load += new System.EventHandler(this.FormUpdateTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrainingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker trainHour;
        private System.Windows.Forms.ComboBox comboTool;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker trainDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonUpdate;
        private DataSetTraining dataSetTraining;
        private System.Windows.Forms.BindingSource tblTrainingBindingSource;
        private DataSetTrainingTableAdapters.tblTrainingTableAdapter tblTrainingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainSubscrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainToolDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox trainSubscrID;
        private System.Windows.Forms.Label label8;
    }
}