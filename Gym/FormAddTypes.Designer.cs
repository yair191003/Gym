namespace Gym
{
    partial class FormAddTypes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.typeName = new System.Windows.Forms.TextBox();
            this.typeSets = new System.Windows.Forms.TextBox();
            this.typeRepeats = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblTypesTableAdapter = new Gym.DataSetTypesTableAdapters.tblTypesTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboTool = new System.Windows.Forms.ComboBox();
            this.comboAim = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "typeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "סוג האימון";
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
            this.typeSetsDataGridViewTextBoxColumn.HeaderText = "סטים";
            this.typeSetsDataGridViewTextBoxColumn.Name = "typeSetsDataGridViewTextBoxColumn";
            // 
            // typeRepeatsDataGridViewTextBoxColumn
            // 
            this.typeRepeatsDataGridViewTextBoxColumn.DataPropertyName = "typeRepeats";
            this.typeRepeatsDataGridViewTextBoxColumn.HeaderText = "חזרות";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "הוספת סוגי אימון";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "סוג האימון";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "שם המכשיר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "סטים";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "חזרות";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "מטרה";
            // 
            // typeName
            // 
            this.typeName.Location = new System.Drawing.Point(453, 79);
            this.typeName.Name = "typeName";
            this.typeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.typeName.Size = new System.Drawing.Size(232, 20);
            this.typeName.TabIndex = 1;
            // 
            // typeSets
            // 
            this.typeSets.Location = new System.Drawing.Point(453, 161);
            this.typeSets.Name = "typeSets";
            this.typeSets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.typeSets.Size = new System.Drawing.Size(232, 20);
            this.typeSets.TabIndex = 3;
            // 
            // typeRepeats
            // 
            this.typeRepeats.Location = new System.Drawing.Point(453, 213);
            this.typeRepeats.Name = "typeRepeats";
            this.typeRepeats.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.typeRepeats.Size = new System.Drawing.Size(232, 20);
            this.typeRepeats.TabIndex = 4;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(374, 300);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(56, 19);
            this.buttonBrowse.TabIndex = 7;
            this.buttonBrowse.Text = ". . .עיון";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // pictureLocation
            // 
            this.pictureLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLocation.Location = new System.Drawing.Point(453, 299);
            this.pictureLocation.Name = "pictureLocation";
            this.pictureLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pictureLocation.Size = new System.Drawing.Size(232, 20);
            this.pictureLocation.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(691, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "תמונה";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAdd.Location = new System.Drawing.Point(525, 325);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 34);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(927, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // tblTypesTableAdapter
            // 
            this.tblTypesTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboTool
            // 
            this.comboTool.FormattingEnabled = true;
            this.comboTool.Location = new System.Drawing.Point(453, 120);
            this.comboTool.Name = "comboTool";
            this.comboTool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboTool.Size = new System.Drawing.Size(232, 21);
            this.comboTool.TabIndex = 2;
            // 
            // comboAim
            // 
            this.comboAim.FormattingEnabled = true;
            this.comboAim.Location = new System.Drawing.Point(453, 256);
            this.comboAim.Name = "comboAim";
            this.comboAim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboAim.Size = new System.Drawing.Size(232, 21);
            this.comboAim.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1057, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "טבלת סוגי אימונים";
            // 
            // FormAddTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboAim);
            this.Controls.Add(this.comboTool);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureLocation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.typeRepeats);
            this.Controls.Add(this.typeSets);
            this.Controls.Add(this.typeName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAddTypes";
            this.Text = "FormAddTypes";
            this.Load += new System.EventHandler(this.FormAddTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox typeName;
        private System.Windows.Forms.TextBox typeSets;
        private System.Windows.Forms.TextBox typeRepeats;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox pictureLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataSetTypes dataSetTypes;
        private System.Windows.Forms.BindingSource tblTypesBindingSource;
        private DataSetTypesTableAdapters.tblTypesTableAdapter tblTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeToolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeSetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeRepeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typePictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboTool;
        private System.Windows.Forms.ComboBox comboAim;
        private System.Windows.Forms.Label label7;
    }
}