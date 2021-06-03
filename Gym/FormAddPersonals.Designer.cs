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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.personalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPersonals = new Gym.DataSetPersonals();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.personalNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboID = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.tblPersonalsTableAdapter = new Gym.DataSetPersonalsTableAdapters.tblPersonalsTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPersonals)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personalIDDataGridViewTextBoxColumn,
            this.personalNumDataGridViewTextBoxColumn,
            this.personalTypeDataGridViewTextBoxColumn,
            this.personalDayDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblPersonalsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 241);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(1160, 408);
            this.dataGridView2.TabIndex = 1;
            // 
            // personalIDDataGridViewTextBoxColumn
            // 
            this.personalIDDataGridViewTextBoxColumn.DataPropertyName = "personalID";
            this.personalIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.personalIDDataGridViewTextBoxColumn.Name = "personalIDDataGridViewTextBoxColumn";
            // 
            // personalNumDataGridViewTextBoxColumn
            // 
            this.personalNumDataGridViewTextBoxColumn.DataPropertyName = "personalNum";
            this.personalNumDataGridViewTextBoxColumn.HeaderText = "מספר סידורי";
            this.personalNumDataGridViewTextBoxColumn.Name = "personalNumDataGridViewTextBoxColumn";
            // 
            // personalTypeDataGridViewTextBoxColumn
            // 
            this.personalTypeDataGridViewTextBoxColumn.DataPropertyName = "personalType";
            this.personalTypeDataGridViewTextBoxColumn.HeaderText = "סוג אימון";
            this.personalTypeDataGridViewTextBoxColumn.Name = "personalTypeDataGridViewTextBoxColumn";
            // 
            // personalDayDataGridViewTextBoxColumn
            // 
            this.personalDayDataGridViewTextBoxColumn.DataPropertyName = "personalDay";
            this.personalDayDataGridViewTextBoxColumn.HeaderText = "יום בשבוע";
            this.personalDayDataGridViewTextBoxColumn.Name = "personalDayDataGridViewTextBoxColumn";
            // 
            // tblPersonalsBindingSource
            // 
            this.tblPersonalsBindingSource.DataMember = "tblPersonals";
            this.tblPersonalsBindingSource.DataSource = this.dataSetPersonals;
            // 
            // dataSetPersonals
            // 
            this.dataSetPersonals.DataSetName = "DataSetPersonals";
            this.dataSetPersonals.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label2.Location = new System.Drawing.Point(721, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ת\"ז";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "מספר סידורי של אימון";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "סוג אימון";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "יום בשבוע";
            // 
            // personalNum
            // 
            this.personalNum.Location = new System.Drawing.Point(425, 116);
            this.personalNum.Name = "personalNum";
            this.personalNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.personalNum.Size = new System.Drawing.Size(223, 20);
            this.personalNum.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(510, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "הוסף";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboID
            // 
            this.comboID.FormattingEnabled = true;
            this.comboID.Location = new System.Drawing.Point(425, 82);
            this.comboID.Name = "comboID";
            this.comboID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboID.Size = new System.Drawing.Size(222, 21);
            this.comboID.TabIndex = 1;
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(426, 148);
            this.comboType.Name = "comboType";
            this.comboType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboType.Size = new System.Drawing.Size(222, 21);
            this.comboType.TabIndex = 3;
            // 
            // comboDay
            // 
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Location = new System.Drawing.Point(426, 185);
            this.comboDay.Name = "comboDay";
            this.comboDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboDay.Size = new System.Drawing.Size(222, 21);
            this.comboDay.TabIndex = 4;
            // 
            // tblPersonalsTableAdapter
            // 
            this.tblPersonalsTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1041, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "טבלת אימונים אישיים";
            // 
            // FormAddPersonals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboDay);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.comboID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personalNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormAddPersonals";
            this.Text = "FormAddPersonals";
            this.Load += new System.EventHandler(this.FormAddPersonals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPersonals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox personalNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboID;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.ComboBox comboDay;
        private DataSetPersonals dataSetPersonals;
        private System.Windows.Forms.BindingSource tblPersonalsBindingSource;
        private DataSetPersonalsTableAdapters.tblPersonalsTableAdapter tblPersonalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
    }
}