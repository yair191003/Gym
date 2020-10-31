namespace Gym
{
    partial class FormUpdateTools
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
            this.toolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblToolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTools = new Gym.DataSetTools();
            this.toolName = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tblToolsTableAdapter = new Gym.DataSetToolsTableAdapters.tblToolsTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.toolNameDataGridViewTextBoxColumn,
            this.toolPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblToolsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 362);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolNameDataGridViewTextBoxColumn
            // 
            this.toolNameDataGridViewTextBoxColumn.DataPropertyName = "toolName";
            this.toolNameDataGridViewTextBoxColumn.HeaderText = "שם המכשיר";
            this.toolNameDataGridViewTextBoxColumn.Name = "toolNameDataGridViewTextBoxColumn";
            // 
            // toolPictureDataGridViewTextBoxColumn
            // 
            this.toolPictureDataGridViewTextBoxColumn.DataPropertyName = "toolPicture";
            this.toolPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.toolPictureDataGridViewTextBoxColumn.Name = "toolPictureDataGridViewTextBoxColumn";
            // 
            // tblToolsBindingSource
            // 
            this.tblToolsBindingSource.DataMember = "tblTools";
            this.tblToolsBindingSource.DataSource = this.dataSetTools;
            // 
            // dataSetTools
            // 
            this.dataSetTools.DataSetName = "DataSetTools";
            this.dataSetTools.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolName
            // 
            this.toolName.Enabled = false;
            this.toolName.Location = new System.Drawing.Point(449, 83);
            this.toolName.Name = "toolName";
            this.toolName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolName.Size = new System.Drawing.Size(232, 20);
            this.toolName.TabIndex = 88;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(370, 138);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(56, 19);
            this.buttonBrowse.TabIndex = 87;
            this.buttonBrowse.Text = ". . .עיון";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // pictureLocation
            // 
            this.pictureLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLocation.Location = new System.Drawing.Point(449, 134);
            this.pictureLocation.Name = "pictureLocation";
            this.pictureLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pictureLocation.Size = new System.Drawing.Size(232, 20);
            this.pictureLocation.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(687, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "תמונה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(916, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "שם המכשיר";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 81;
            this.label1.Text = "עדכון מכשיר";
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(621, 179);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(60, 33);
            this.buttonFirst.TabIndex = 94;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(458, 179);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(61, 33);
            this.buttonLast.TabIndex = 93;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(549, 179);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(62, 33);
            this.buttonNext.TabIndex = 92;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(377, 179);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 33);
            this.buttonPrev.TabIndex = 91;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(507, 242);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 42);
            this.buttonUpdate.TabIndex = 90;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tblToolsTableAdapter
            // 
            this.tblToolsTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormUpdateTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolName);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureLocation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateTools";
            this.Text = "FormUpdateTools";
            this.Load += new System.EventHandler(this.FormUpdateTools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox toolName;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox pictureLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonUpdate;
        private DataSetTools dataSetTools;
        private System.Windows.Forms.BindingSource tblToolsBindingSource;
        private DataSetToolsTableAdapters.tblToolsTableAdapter tblToolsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}