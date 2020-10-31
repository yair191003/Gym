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
    public partial class FormUpdateTraining : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateTraining(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillRoomCombo();
            FillTypeCombo();
            FillToolCombo();
            RefreshDataGridView();
        }

        private void FormUpdateTraining_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTraining.tblTraining' table. You can move, or remove it, as needed.
            this.tblTrainingTableAdapter.Fill(this.dataSetTraining.tblTraining);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblTraining  \n" +
                                          "SET    trainType    =  \"" + comboType.Text + "\" , \n" +
                                                  "trainRoom       =  " + comboRoom.Text + " , \n" +
                                                  "trainTool     =  \"" + comboTool.Text + "\"  \n" +
                                          "WHERE  trainSubscrID = " + trainSubscrID.Text + " and trainDate = #" + trainDate.Value + "#" + " and trainHour = #" + trainHour.Value + "#";
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblTraining ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblTraining failed \n" + err.Message, "Error",
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
                                          "FROM tblRooms " +
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
                trainSubscrID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                trainDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                trainHour.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboType.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboRoom.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboTool.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
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
