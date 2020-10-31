using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FormUpdatePersonals : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdatePersonals(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillIDCombo();
            FillTypeCombo();
            FillDayCombo();
            RefreshDataGridView();
        }

        private void FormUpdatePersonals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPersonals.tblPersonals' table. You can move, or remove it, as needed.
            this.tblPersonalsTableAdapter.Fill(this.dataSetPersonals.tblPersonals);

        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE  tblPersonals  \n" +
                                          "SET    personalType     =  \"" + comboType.Text + "\" , \n" +
                                                  "personalDay    =  \"" + comboDay.Text + "\"  \n" +
                                          "WHERE  personalID  = " + comboID.Text + " and personalNum=" + personalNum.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView2.CurrentCell = dataGridView2[0, lastRow];
                MessageBox.Show("Update tblPersonals ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblPersonals failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillIDCombo()                                   // Populate cities combobox
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
                MessageBox.Show("Fill Subscribers combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillDayCombo()
        {
            try
            {

                comboDay.Items.Add("ראשון");
                comboDay.Items.Add("שני");
                comboDay.Items.Add("שלישי");
                comboDay.Items.Add("רביעי");
                comboDay.Items.Add("חמישי");
                comboDay.Items.Add("שישי");
                comboDay.Items.Add("שבת");
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Day combobox failed \n" + err.Message, "Error",
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
        private void EnableButtons()
        {
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView2.Rows.Count - 1)
                buttonNext.Enabled = false;
        }
        
        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblPersonals " +
                                     "ORDER BY personalID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView2.DataSource = tbl;
                dataGridView2.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh dataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow].Selected = false;
            lastRow = dataGridView2.Rows.Count - 1;
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }
        private void FillSelectedRow()
        {
            try
            {
                comboID.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                personalNum.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                comboType.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                comboDay.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                dataGridView2.CurrentCell = dataGridView2[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView2.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }
    }
}
