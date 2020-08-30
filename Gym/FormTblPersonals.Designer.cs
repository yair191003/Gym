namespace Gym
{
    partial class FormTblPersonals
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
            this.personalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPersonals = new Gym.DataSetPersonals();
            this.tblPersonalsTableAdapter = new Gym.DataSetPersonalsTableAdapters.tblPersonalsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPersonals)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 551);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.personalNumDataGridViewTextBoxColumn.HeaderText = "מספר אישי";
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
            this.personalDayDataGridViewTextBoxColumn.HeaderText = "יום";
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
            // tblPersonalsTableAdapter
            // 
            this.tblPersonalsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(971, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "טבלת אימונים אישיים";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(545, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTblPersonals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblPersonals";
            this.Text = "FormTblPersonals";
            this.Load += new System.EventHandler(this.FormTblPersonals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPersonals)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}