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
    public partial class FormRptTrainingOfSubsc : Form
    {
        private OleDbConnection dataConnection;
        private string saveColor = "";
        private int lastRow = 0;
        private string subscrID;
        private string trainDate;
        private string trainHour;
        private string trainType;
        private string trainRoom;
        private string trainTool;
        public FormRptTrainingOfSubsc(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }
        private void FormRptTrainingOfSubsc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSubscribers.tblSubscribers' table. You can move, or remove it, as needed.
            this.tblSubscribersTableAdapter.Fill(this.dataSetSubscribers.tblSubscribers);
            buttonFirst_Click_1(sender, e);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }
        private void FillSelectedRow()
        {
            try
            {
                subscrID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   subscrID " +
                                          "FROM     tblSubscribers   " +
                                          "WHERE    subscrID = " + subscrID.ToString() + " " +
                                          "ORDER BY subscrID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    subscrID = dataReader.GetInt32(0).ToString();
                    GetTrainings();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblSubscribers failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetTrainings()
        {
            try
            {
                int counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   *" +
                                          " FROM tblTraining " +
                                          "WHERE    trainSubscrID = " + subscrID.ToString() + " " +
                                          "ORDER BY trainSubscrID  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    trainDate = dataReader.GetDateTime(1).ToShortDateString().ToString();
                    trainHour = dataReader.GetDateTime(2).TimeOfDay.ToString();
                    trainType = dataReader.GetString(3);
                    trainRoom = dataReader.GetInt32(4).ToString();
                    trainTool = dataReader.GetString(5);
                    counter++;
                    EditListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblTraining failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[6];
                if (counter == 1)
                {
                    arr[0] = subscrID;
                    
                }
                arr[1] = trainDate;
                arr[2] = trainHour;
                arr[3] = trainType;
                arr[4] = trainRoom;
                arr[5] = trainTool;
                ListViewItem item = new ListViewItem(arr);
                if (saveColor != "")
                    item.ForeColor = Color.FromArgb(int.Parse(saveColor));
                listView1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            buttonColor.BackColor = cd.Color;
            saveColor = buttonColor.BackColor.ToArgb().ToString();
        }

        private void buttonFirst_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }
    }
}
