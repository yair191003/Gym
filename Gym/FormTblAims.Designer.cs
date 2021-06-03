namespace Gym
{
    partial class FormTblAims
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
            this.aimNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAimsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAims = new Gym.DataSetAims();
            this.tblAimsTableAdapter = new Gym.DataSetAimsTableAdapters.tblAimsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAimsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAims)).BeginInit();
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
            this.aimNameDataGridViewTextBoxColumn,
            this.aimPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAimsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 560);
            this.dataGridView1.TabIndex = 0;
            // 
            // aimNameDataGridViewTextBoxColumn
            // 
            this.aimNameDataGridViewTextBoxColumn.DataPropertyName = "aimName";
            this.aimNameDataGridViewTextBoxColumn.HeaderText = "מטרה";
            this.aimNameDataGridViewTextBoxColumn.Name = "aimNameDataGridViewTextBoxColumn";
            // 
            // aimPictureDataGridViewTextBoxColumn
            // 
            this.aimPictureDataGridViewTextBoxColumn.DataPropertyName = "aimPicture";
            this.aimPictureDataGridViewTextBoxColumn.HeaderText = "תמונת מטרה";
            this.aimPictureDataGridViewTextBoxColumn.Name = "aimPictureDataGridViewTextBoxColumn";
            // 
            // tblAimsBindingSource
            // 
            this.tblAimsBindingSource.DataMember = "tblAims";
            this.tblAimsBindingSource.DataSource = this.dataSetAims;
            // 
            // dataSetAims
            // 
            this.dataSetAims.DataSetName = "DataSetAims";
            this.dataSetAims.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAimsTableAdapter
            // 
            this.tblAimsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "טבלת מטרות";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(566, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTblAims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblAims";
            this.Text = "FormTblAims";
            this.Load += new System.EventHandler(this.FormTblAims_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAimsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAims)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetAims dataSetAims;
        private System.Windows.Forms.BindingSource tblAimsBindingSource;
        private DataSetAimsTableAdapters.tblAimsTableAdapter tblAimsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}