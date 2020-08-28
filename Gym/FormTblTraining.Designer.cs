namespace Gym
{
    partial class FormTblTraining
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
            this.tblTrainingTableAdapter = new Gym.DataSetTrainingTableAdapters.tblTrainingTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrainingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTraining)).BeginInit();
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
            this.trainSubscrIDDataGridViewTextBoxColumn,
            this.trainDateDataGridViewTextBoxColumn,
            this.trainHourDataGridViewTextBoxColumn,
            this.trainTypeDataGridViewTextBoxColumn,
            this.trainRoomDataGridViewTextBoxColumn,
            this.trainToolDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTrainingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(844, 514);
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
            this.trainRoomDataGridViewTextBoxColumn.HeaderText = "מספר חדר";
            this.trainRoomDataGridViewTextBoxColumn.Name = "trainRoomDataGridViewTextBoxColumn";
            // 
            // trainToolDataGridViewTextBoxColumn
            // 
            this.trainToolDataGridViewTextBoxColumn.DataPropertyName = "trainTool";
            this.trainToolDataGridViewTextBoxColumn.HeaderText = "שם מכשיר";
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
            // tblTrainingTableAdapter
            // 
            this.tblTrainingTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(727, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "טבלת אימונים";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(400, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTblTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblTraining";
            this.Text = "FormTblTraining";
            this.Load += new System.EventHandler(this.FormTblTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrainingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetTraining dataSetTraining;
        private System.Windows.Forms.BindingSource tblTrainingBindingSource;
        private DataSetTrainingTableAdapters.tblTrainingTableAdapter tblTrainingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainSubscrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainToolDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}