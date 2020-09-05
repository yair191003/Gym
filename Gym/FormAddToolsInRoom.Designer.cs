namespace Gym
{
    partial class FormAddToolsInRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tirRoomID = new System.Windows.Forms.TextBox();
            this.tirToolName = new System.Windows.Forms.TextBox();
            this.tirRoomAmount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataSetToolsInRoom = new Gym.DataSetToolsInRoom();
            this.tblToolsInRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblToolsInRoomTableAdapter = new Gym.DataSetToolsInRoomTableAdapters.tblToolsInRoomTableAdapter();
            this.tirRoomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tirToolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tirRoomAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToolsInRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToolsInRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת מכשיר לחדר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "מספר חדר";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "שם המכשיר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "כמות";
            // 
            // tirRoomID
            // 
            this.tirRoomID.Location = new System.Drawing.Point(387, 123);
            this.tirRoomID.Name = "tirRoomID";
            this.tirRoomID.Size = new System.Drawing.Size(236, 20);
            this.tirRoomID.TabIndex = 4;
            // 
            // tirToolName
            // 
            this.tirToolName.Location = new System.Drawing.Point(387, 170);
            this.tirToolName.Name = "tirToolName";
            this.tirToolName.Size = new System.Drawing.Size(236, 20);
            this.tirToolName.TabIndex = 5;
            // 
            // tirRoomAmount
            // 
            this.tirRoomAmount.Location = new System.Drawing.Point(387, 223);
            this.tirRoomAmount.Name = "tirRoomAmount";
            this.tirRoomAmount.Size = new System.Drawing.Size(236, 20);
            this.tirRoomAmount.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tirRoomIDDataGridViewTextBoxColumn,
            this.tirToolNameDataGridViewTextBoxColumn,
            this.tirRoomAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblToolsInRoomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 327);
            this.dataGridView1.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAdd.Location = new System.Drawing.Point(483, 282);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 34);
            this.buttonAdd.TabIndex = 66;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataSetToolsInRoom
            // 
            this.dataSetToolsInRoom.DataSetName = "DataSetToolsInRoom";
            this.dataSetToolsInRoom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblToolsInRoomBindingSource
            // 
            this.tblToolsInRoomBindingSource.DataMember = "tblToolsInRoom";
            this.tblToolsInRoomBindingSource.DataSource = this.dataSetToolsInRoom;
            // 
            // tblToolsInRoomTableAdapter
            // 
            this.tblToolsInRoomTableAdapter.ClearBeforeFill = true;
            // 
            // tirRoomIDDataGridViewTextBoxColumn
            // 
            this.tirRoomIDDataGridViewTextBoxColumn.DataPropertyName = "tirRoomID";
            this.tirRoomIDDataGridViewTextBoxColumn.HeaderText = "מספר חדר";
            this.tirRoomIDDataGridViewTextBoxColumn.Name = "tirRoomIDDataGridViewTextBoxColumn";
            // 
            // tirToolNameDataGridViewTextBoxColumn
            // 
            this.tirToolNameDataGridViewTextBoxColumn.DataPropertyName = "tirToolName";
            this.tirToolNameDataGridViewTextBoxColumn.HeaderText = "שם חדר";
            this.tirToolNameDataGridViewTextBoxColumn.Name = "tirToolNameDataGridViewTextBoxColumn";
            // 
            // tirRoomAmountDataGridViewTextBoxColumn
            // 
            this.tirRoomAmountDataGridViewTextBoxColumn.DataPropertyName = "tirRoomAmount";
            this.tirRoomAmountDataGridViewTextBoxColumn.HeaderText = "כמות";
            this.tirRoomAmountDataGridViewTextBoxColumn.Name = "tirRoomAmountDataGridViewTextBoxColumn";
            // 
            // FormAddToolsInRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tirRoomAmount);
            this.Controls.Add(this.tirToolName);
            this.Controls.Add(this.tirRoomID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddToolsInRoom";
            this.Text = "FormAddToolsInRoom";
            this.Load += new System.EventHandler(this.FormAddToolsInRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToolsInRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToolsInRoomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tirRoomID;
        private System.Windows.Forms.TextBox tirToolName;
        private System.Windows.Forms.TextBox tirRoomAmount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private DataSetToolsInRoom dataSetToolsInRoom;
        private System.Windows.Forms.BindingSource tblToolsInRoomBindingSource;
        private DataSetToolsInRoomTableAdapters.tblToolsInRoomTableAdapter tblToolsInRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tirRoomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tirToolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tirRoomAmountDataGridViewTextBoxColumn;
    }
}