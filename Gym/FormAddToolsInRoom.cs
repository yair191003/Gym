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
    public partial class FormAddToolsInRoom : Form
    {
        private OleDbConnection dataConnection;
        public FormAddToolsInRoom(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void FormAddToolsInRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetToolsInRoom.tblToolsInRoom' table. You can move, or remove it, as needed.
            this.tblToolsInRoomTableAdapter.Fill(this.dataSetToolsInRoom.tblToolsInRoom);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblToolsInRoom " +
                                     "(tirRoomID, tirToolName, tirRoomAmount) " +
                                     " VALUES ( \"{0}\", \"{1}\", \"{2}\")",
                                       tirRoomID.Text, tirToolName.Text, tirRoomAmount.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblToolsInRoom ended successfully");
                RefreshDataGridView();

            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblToolsInRoom failed \n" + err.Message, "Error",
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
                                     "FROM    tblToolsInRoom  " +
                                     "ORDER BY tirRoomID";
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

    }
}
