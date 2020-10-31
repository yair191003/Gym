using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Gym
{
    public partial class FormUpdateToolsInRoom : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateToolsInRoom(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            RefreshDataGridView();
        }

        private void FormUpdateToolsInRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetToolsInRoom.tblToolsInRoom' table. You can move, or remove it, as needed.
            this.tblToolsInRoomTableAdapter.Fill(this.dataSetToolsInRoom.tblToolsInRoom);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE   tblToolsInRoom  \n" +
                                          "SET    tirRoomAmount    = " + tirRoomAmount.Text +"      \n" +
                                          "WHERE  tirRoomID  = " + tirRoomID.Text + " and tirToolName= \"" + tirToolName.Text + "\"";
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblToolsInRoom ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblToolsInRoom failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblToolsInRoom " +
                                     "ORDER BY tirRoomID,tirToolName";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh dataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }
        private void EnableButtons()
        {
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                buttonNext.Enabled = false;
        }
        private void FillSelectedRow()
        {
            try
            {
                tirRoomID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tirToolName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tirRoomAmount.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }
    }
}
