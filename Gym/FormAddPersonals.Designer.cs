namespace Gym
{
    partial class FormAddPersonals
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
            this.dataSetPersonals = new Gym.DataSetPersonals();
            this.tblPersonalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonalsTableAdapter = new Gym.DataSetPersonalsTableAdapters.tblPersonalsTableAdapter();
            this.personalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tblPersonalsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personalIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalNumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.personalId = new System.Windows.Forms.TextBox();
            this.personalNum = new System.Windows.Forms.TextBox();
            this.personalType = new System.Windows.Forms.TextBox();
            this.personalDay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPersonals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonalsBindingSource1)).BeginInit();
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
            this.personalIDDataGridViewTextBoxColumn,
            this.personalNumDataGridViewTextBoxColumn,
            this.personalTypeDataGridViewTextBoxColumn,
            this.personalDayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonalsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(0, 0);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSetPersonals
            // 
            this.dataSetPersonals.DataSetName = "DataSetPersonals";
            this.dataSetPersonals.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonalsBindingSource
            // 
            this.tblPersonalsBindingSource.DataMember = "tblPersonals";
            this.tblPersonalsBindingSource.DataSource = this.dataSetPersonals;
            // 
            // tblPersonalsTableAdapter
            // 
            this.tblPersonalsTableAdapter.ClearBeforeFill = true;
            // 
            // personalIDDataGridViewTextBoxColumn
            // 
            this.personalIDDataGridViewTextBoxColumn.DataPropertyName = "personalID";
            this.personalIDDataGridViewTextBoxColumn.HeaderText = "personalID";
            this.personalIDDataGridViewTextBoxColumn.Name = "personalIDDataGridViewTextBoxColumn";
            // 
            // personalNumDataGridViewTextBoxColumn
            // 
            this.personalNumDataGridViewTextBoxColumn.DataPropertyName = "personalNum";
            this.personalNumDataGridViewTextBoxColumn.HeaderText = "personalNum";
            this.personalNumDataGridViewTextBoxColumn.Name = "personalNumDataGridViewTextBoxColumn";
            // 
            // personalTypeDataGridViewTextBoxColumn
            // 
            this.personalTypeDataGridViewTextBoxColumn.DataPropertyName = "personalType";
            this.personalTypeDataGridViewTextBoxColumn.HeaderText = "personalType";
            this.personalTypeDataGridViewTextBoxColumn.Name = "personalTypeDataGridViewTextBoxColumn";
            // 
            // personalDayDataGridViewTextBoxColumn
            // 
            this.personalDayDataGridViewTextBoxColumn.DataPropertyName = "personalDay";
            this.personalDayDataGridViewTextBoxColumn.HeaderText = "personalDay";
            this.personalDayDataGridViewTextBoxColumn.Name = "personalDayDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personalIDDataGridViewTextBoxColumn1,
            this.personalNumDataGridViewTextBoxColumn1,
            this.personalTypeDataGridViewTextBoxColumn1,
            this.personalDayDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.tblPersonalsBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(1160, 356);
            this.dataGridView2.TabIndex = 1;
            // 
            // tblPersonalsBindingSource1
            // 
            this.tblPersonalsBindingSource1.DataMember = "tblPersonals";
            this.tblPersonalsBindingSource1.DataSource = this.dataSetPersonals;
            // 
            // personalIDDataGridViewTextBoxColumn1
            // 
            this.personalIDDataGridViewTextBoxColumn1.DataPropertyName = "personalID";
            this.personalIDDataGridViewTextBoxColumn1.HeaderText = "ת\"ז";
            this.personalIDDataGridViewTextBoxColumn1.Name = "personalIDDataGridViewTextBoxColumn1";
            // 
            // personalNumDataGridViewTextBoxColumn1
            // 
            this.personalNumDataGridViewTextBoxColumn1.DataPropertyName = "personalNum";
            this.personalNumDataGridViewTextBoxColumn1.HeaderText = "מספר אישי";
            this.personalNumDataGridViewTextBoxColumn1.Name = "personalNumDataGridViewTextBoxColumn1";
            // 
            // personalTypeDataGridViewTextBoxColumn1
            // 
            this.personalTypeDataGridViewTextBoxColumn1.DataPropertyName = "personalType";
            this.personalTypeDataGridViewTextBoxColumn1.HeaderText = "סוג אימון";
            this.personalTypeDataGridViewTextBoxColumn1.Name = "personalTypeDataGridViewTextBoxColumn1";
            // 
            // personalDayDataGridViewTextBoxColumn1
            // 
            this.personalDayDataGridViewTextBoxColumn1.DataPropertyName = "personalDay";
            this.personalDayDataGridViewTextBoxColumn1.HeaderText = "יום בשבוע";
            this.personalDayDataGridViewTextBoxColumn1.Name = "personalDayDataGridViewTextBoxColumn1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "הוספת אימון אישי";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ת\"ז";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "מספר אישי";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(694, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "סוג אימון";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "יום בשבוע";
            // 
            // personalId
            // 
            this.personalId.Location = new System.Drawing.Point(432, 70);
            this.personalId.Name = "personalId";
            this.personalId.Size = new System.Drawing.Size(223, 20);
            this.personalId.TabIndex = 7;
            // 
            // personalNum
            // 
            this.personalNum.Location = new System.Drawing.Point(432, 106);
            this.personalNum.Name = "personalNum";
            this.personalNum.Size = new System.Drawing.Size(223, 20);
            this.personalNum.TabIndex = 8;
            // 
            // personalType
            // 
            this.personalType.Location = new System.Drawing.Point(432, 136);
            this.personalType.Name = "personalType";
            this.personalType.Size = new System.Drawing.Size(223, 20);
            this.personalType.TabIndex = 9;
            // 
            // personalDay
            // 
            this.personalDay.Location = new System.Drawing.Point(432, 173);
            this.personalDay.Name = "personalDay";
            this.personalDay.Size = new System.Drawing.Size(223, 20);
            this.personalDay.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(510, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "הוסף";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddPersonals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personalDay);
            this.Controls.Add(this.personalType);
            this.Controls.Add(this.personalNum);
            this.Controls.Add(this.personalId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAddPersonals";
            this.Text = "FormAddPersonals";
            this.Load += new System.EventHandler(this.FormAddPersonals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPersonals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonalsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetPersonals dataSetPersonals;
        private System.Windows.Forms.BindingSource tblPersonalsBindingSource;
        private DataSetPersonalsTableAdapters.tblPersonalsTableAdapter tblPersonalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalNumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tblPersonalsBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox personalId;
        private System.Windows.Forms.TextBox personalNum;
        private System.Windows.Forms.TextBox personalType;
        private System.Windows.Forms.TextBox personalDay;
        private System.Windows.Forms.Button button1;
    }
}