namespace Gym
{
    partial class FormTblToolsInRooms
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
            this.tblToolsInRoomTableAdapter = new Gym.DataSetToolsInRoomTableAdapters.tblToolsInRoomTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToolsInRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToolsInRoom)).BeginInit();
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
            this.tirRoomIDDataGridViewTextBoxColumn,
            this.tirToolNameDataGridViewTextBoxColumn,
            this.tirRoomAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblToolsInRoomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 546);
            this.dataGridView1.TabIndex = 0;
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
            // tblToolsInRoomTableAdapter
            // 
            this.tblToolsInRoomTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(948, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "טבלת מכשירים בכל חדר";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(563, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTblToolsInRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblToolsInRooms";
            this.Text = "FormTblToolsInRooms";
            this.Load += new System.EventHandler(this.FormTblToolsInRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToolsInRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToolsInRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetToolsInRoom dataSetToolsInRoom;
        private System.Windows.Forms.BindingSource tblToolsInRoomBindingSource;
        private DataSetToolsInRoomTableAdapters.tblToolsInRoomTableAdapter tblToolsInRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tirRoomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tirToolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tirRoomAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}