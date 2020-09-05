using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FormAddPersonals : Form
    {
        private OleDbConnection dataConnection;
        public FormAddPersonals(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void FormAddPersonals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPersonals.tblPersonals' table. You can move, or remove it, as needed.
            this.tblPersonalsTableAdapter.Fill(this.dataSetPersonals.tblPersonals);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblpersonals " +
                                     "(personalID, personalNum, personalType, personalDay) " +
                                     " VALUES ( \"{0}\", \"{1}\", \"{2}\", \"{3}\")",
                                       personalId.Text, personalNum.Text, personalType.Text, personalDay.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblPersonals ended successfully");
                RefreshDataGridView();

            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblPersonals failed \n" + err.Message, "Error",
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
                                     "FROM     tblPersonals " +
                                     "ORDER BY personalID, personalNum";
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
