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
    public partial class FormAddTrainings : Form
    {
       private OleDbConnection dataConnection;
       public FormAddTrainings(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
              FillRoomCombo();
              FillIDCombo();
              FillTypeCombo();
              FillToolCombo();
        }

        private void FormAddTrainings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTraining.tblTraining' table. You can move, or remove it, as needed.
            this.tblTrainingTableAdapter.Fill(this.dataSetTraining.tblTraining);

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblTraining " +
                                     "(trainSubscrID, trainDate, trainHour, trainType, trainRoom, trainTool) " +
                                     " VALUES ( \"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\")",
                                       comboID.Text, trainDate.Value, trainHour.Value, comboType.Text, comboRoom.Text, comboTool.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblTrainings ended successfully");
                RefreshDataGridView();

            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblTrainings failed \n" + err.Message, "Error",
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
                                     "FROM     tblTraining " +
                                     "ORDER BY trainSubscrID, trainDate, trainHour";
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
        private void FillRoomCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT roomID " +
                                          "FROM     tblRooms " +
                                          "ORDER BY roomID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboRoom.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Room combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillIDCombo()                                  
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT subscrID " +
                                          "FROM tblSubscribers " +
                                          "ORDER BY subscrID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboID.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Subscriber combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillTypeCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT typeName " +
                                          "FROM tblTypes " +
                                          "ORDER BY typeName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboType.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Type combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillToolCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT toolName " +
                                          "FROM tblTools " +
                                          "ORDER BY toolName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboTool.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Tool combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
