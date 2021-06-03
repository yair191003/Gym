namespace Gym
{
    partial class FormUpdateToolsInRoom
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
            this.tirRoomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tirToolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tirRoomAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblToolsInRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetToolsInRoom = new Gym.DataSetToolsInRoom();
            this.tirRoomAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tblToolsInRoomTableAdapter = new Gym.DataSetToolsInRoomTableAdapters.tblToolsInRoomTableAdapter();
            this.tirToolName = new System.Windows.Forms.TextBox();
            this.tirRoomID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToolsInRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToolsInRoom)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 327);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.tirToolNameDataGridViewTextBoxColumn.HeaderText = "שם מכשיר";
            this.tirToolNameDataGridViewTextBoxColumn.Name = "tirToolNameDataGridViewTextBoxColumn";
            // 
            // tirRoomAmountDataGridViewTextBoxColumn
            // 
            this.tirRoomAmountDataGridViewTextBoxColumn.DataPropertyName = "tirRoomAmount";
            this.tirRoomAmountDataGridViewTextBoxColumn.HeaderText = "כמות";
            this.tirRoomAmountDataGridViewTextBoxColumn.Name = "tirRoomAmountDataGridViewTextBoxColumn";
            // 
            // tblToolsInRoomBindingSource
            // 
            this.tblToolsInRoomBindingSource.DataMember = "tblToolsInRoom";
            this.tblToolsInRoomBindingSource.DataSource = this.dataSetToolsInRoom;
            // 
            // dataSetToolsInRoom
            // 
            this.dataSetToolsInRoom.DataSetName = "DataSetToolsInRoom";
            this.dataSetToolsInRoom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tirRoomAmount
            // 
            this.tirRoomAmount.Location = new System.Drawing.Point(398, 178);
            this.tirRoomAmount.Name = "tirRoomAmount";
            this.tirRoomAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tirRoomAmount.Size = new System.Drawing.Size(236, 20);
            this.tirRoomAmount.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "כמות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "שם המכשיר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "מספר חדר";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "עדכון מכשיר בחדר";
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(600, 214);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(60, 33);
            this.buttonFirst.TabIndex = 4;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(437, 214);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(61, 33);
            this.buttonLast.TabIndex = 6;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(528, 214);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(62, 33);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(356, 214);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 33);
            this.buttonPrev.TabIndex = 7;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(486, 277);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 42);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tblToolsInRoomTableAdapter
            // 
            this.tblToolsInRoomTableAdapter.ClearBeforeFill = true;
            // 
            // tirToolName
            // 
            this.tirToolName.Enabled = false;
            this.tirToolName.Location = new System.Drawing.Point(398, 128);
            this.tirToolName.Name = "tirToolName";
            this.tirToolName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tirToolName.Size = new System.Drawing.Size(236, 20);
            this.tirToolName.TabIndex = 2;
            // 
            // tirRoomID
            // 
            this.tirRoomID.Enabled = false;
            this.tirRoomID.Location = new System.Drawing.Point(398, 78);
            this.tirRoomID.Name = "tirRoomID";
            this.tirRoomID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tirRoomID.Size = new System.Drawing.Size(236, 20);
            this.tirRoomID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1045, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 95;
            this.label5.Text = "טבלת מכשירים בחדר";
            // 
            // FormUpdateToolsInRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tirRoomID);
            this.Controls.Add(this.tirToolName);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tirRoomAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateToolsInRoom";
            this.Text = "FormUpdateToolsInRoom";
            this.Load += new System.EventHandler(this.FormUpdateToolsInRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToolsInRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToolsInRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tirRoomAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonUpdate;
        private DataSetToolsInRoom dataSetToolsInRoom;
        private System.Windows.Forms.BindingSource tblToolsInRoomBindingSource;
        private DataSetToolsInRoomTableAdapters.tblToolsInRoomTableAdapter tblToolsInRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tirRoomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tirToolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tirRoomAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tirToolName;
        private System.Windows.Forms.TextBox tirRoomID;
        private System.Windows.Forms.Label label5;
    }
}