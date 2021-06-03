namespace Gym
{
    partial class FormTblTypes
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
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeToolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeSetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeRepeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typePictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTypes = new Gym.DataSetTypes();
            this.tblTypesTableAdapter = new Gym.DataSetTypesTableAdapters.tblTypesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTypes)).BeginInit();
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
            this.typeNameDataGridViewTextBoxColumn,
            this.typeToolDataGridViewTextBoxColumn,
            this.typeSetsDataGridViewTextBoxColumn,
            this.typeRepeatsDataGridViewTextBoxColumn,
            this.typeAimDataGridViewTextBoxColumn,
            this.typePictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTypesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 557);
            this.dataGridView1.TabIndex = 0;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "typeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "סוג אימון";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            // 
            // typeToolDataGridViewTextBoxColumn
            // 
            this.typeToolDataGridViewTextBoxColumn.DataPropertyName = "typeTool";
            this.typeToolDataGridViewTextBoxColumn.HeaderText = "מכשיר";
            this.typeToolDataGridViewTextBoxColumn.Name = "typeToolDataGridViewTextBoxColumn";
            // 
            // typeSetsDataGridViewTextBoxColumn
            // 
            this.typeSetsDataGridViewTextBoxColumn.DataPropertyName = "typeSets";
            this.typeSetsDataGridViewTextBoxColumn.HeaderText = "חזרות";
            this.typeSetsDataGridViewTextBoxColumn.Name = "typeSetsDataGridViewTextBoxColumn";
            // 
            // typeRepeatsDataGridViewTextBoxColumn
            // 
            this.typeRepeatsDataGridViewTextBoxColumn.DataPropertyName = "typeRepeats";
            this.typeRepeatsDataGridViewTextBoxColumn.HeaderText = "סטים";
            this.typeRepeatsDataGridViewTextBoxColumn.Name = "typeRepeatsDataGridViewTextBoxColumn";
            // 
            // typeAimDataGridViewTextBoxColumn
            // 
            this.typeAimDataGridViewTextBoxColumn.DataPropertyName = "typeAim";
            this.typeAimDataGridViewTextBoxColumn.HeaderText = "מטרה";
            this.typeAimDataGridViewTextBoxColumn.Name = "typeAimDataGridViewTextBoxColumn";
            // 
            // typePictureDataGridViewTextBoxColumn
            // 
            this.typePictureDataGridViewTextBoxColumn.DataPropertyName = "typePicture";
            this.typePictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.typePictureDataGridViewTextBoxColumn.Name = "typePictureDataGridViewTextBoxColumn";
            // 
            // tblTypesBindingSource
            // 
            this.tblTypesBindingSource.DataMember = "tblTypes";
            this.tblTypesBindingSource.DataSource = this.dataSetTypes;
            // 
            // dataSetTypes
            // 
            this.dataSetTypes.DataSetName = "DataSetTypes";
            this.dataSetTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTypesTableAdapter
            // 
            this.tblTypesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(546, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "טבלת סוגי אימון";
            // 
            // FormTblTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblTypes";
            this.Text = "FormTblTypes";
            this.Load += new System.EventHandler(this.FormTblTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetTypes dataSetTypes;
        private System.Windows.Forms.BindingSource tblTypesBindingSource;
        private DataSetTypesTableAdapters.tblTypesTableAdapter tblTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeToolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeSetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeRepeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typePictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}