namespace Gym
{
    partial class FormUpdateTypes
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
            this.comboAim = new System.Windows.Forms.ComboBox();
            this.comboTool = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.typeRepeats = new System.Windows.Forms.TextBox();
            this.typeSets = new System.Windows.Forms.TextBox();
            this.typeName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeToolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeSetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeRepeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typePictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTypes = new Gym.DataSetTypes();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tblTypesTableAdapter = new Gym.DataSetTypesTableAdapters.tblTypesTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // comboAim
            // 
            this.comboAim.FormattingEnabled = true;
            this.comboAim.Location = new System.Drawing.Point(224, 117);
            this.comboAim.Name = "comboAim";
            this.comboAim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboAim.Size = new System.Drawing.Size(232, 21);
            this.comboAim.TabIndex = 72;
            // 
            // comboTool
            // 
            this.comboTool.FormattingEnabled = true;
            this.comboTool.Location = new System.Drawing.Point(570, 115);
            this.comboTool.Name = "comboTool";
            this.comboTool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboTool.Size = new System.Drawing.Size(232, 21);
            this.comboTool.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(927, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(145, 161);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(56, 19);
            this.buttonBrowse.TabIndex = 69;
            this.buttonBrowse.Text = ". . .עיון";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // pictureLocation
            // 
            this.pictureLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLocation.Location = new System.Drawing.Point(224, 160);
            this.pictureLocation.Name = "pictureLocation";
            this.pictureLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pictureLocation.Size = new System.Drawing.Size(232, 20);
            this.pictureLocation.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(462, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "תמונה";
            // 
            // typeRepeats
            // 
            this.typeRepeats.Location = new System.Drawing.Point(224, 74);
            this.typeRepeats.Name = "typeRepeats";
            this.typeRepeats.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.typeRepeats.Size = new System.Drawing.Size(232, 20);
            this.typeRepeats.TabIndex = 65;
            // 
            // typeSets
            // 
            this.typeSets.Location = new System.Drawing.Point(570, 156);
            this.typeSets.Name = "typeSets";
            this.typeSets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.typeSets.Size = new System.Drawing.Size(232, 20);
            this.typeSets.TabIndex = 64;
            // 
            // typeName
            // 
            this.typeName.Enabled = false;
            this.typeName.Location = new System.Drawing.Point(570, 74);
            this.typeName.Name = "typeName";
            this.typeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.typeName.Size = new System.Drawing.Size(232, 20);
            this.typeName.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "מטרה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "חזרות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(827, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "סטים";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(827, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "שם המכשיר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "סוג האימון";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "עדכון סוגי אימון";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 328);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.typeToolDataGridViewTextBoxColumn.HeaderText = "שם מכשיר";
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
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(620, 209);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(60, 33);
            this.buttonFirst.TabIndex = 92;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(457, 209);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(61, 33);
            this.buttonLast.TabIndex = 91;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(548, 209);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(62, 33);
            this.buttonNext.TabIndex = 90;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(376, 209);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 33);
            this.buttonPrev.TabIndex = 89;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(506, 272);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 42);
            this.buttonUpdate.TabIndex = 88;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tblTypesTableAdapter
            // 
            this.tblTypesTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormUpdateTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboAim);
            this.Controls.Add(this.comboTool);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureLocation);
            this.Controls.Add(this.label10);
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
            this.Name = "FormUpdateTypes";
            this.Text = "FormUpdateTypes";
            this.Load += new System.EventHandler(this.FormUpdateTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAim;
        private System.Windows.Forms.ComboBox comboTool;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox pictureLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox typeRepeats;
        private System.Windows.Forms.TextBox typeSets;
        private System.Windows.Forms.TextBox typeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonUpdate;
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
    }
}