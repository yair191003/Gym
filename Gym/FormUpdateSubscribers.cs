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
    public partial class FormUpdateSubscribers : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateSubscribers(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillCityCombo();
            RefreshDataGridView();
        }

        private void FormUpdateSubscribers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSubscribers.tblSubscribers' table. You can move, or remove it, as needed.
            this.tblSubscribersTableAdapter.Fill(this.dataSetSubscribers.tblSubscribers);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblSubscribers  \n" +
                                          "SET    subscrFirstName    =  \"" + subscrFirstName.Text + "\" , \n" +
                                                  "subscrLastName    =  \"" + subscrLastName.Text + "\" , \n" +
                                                  "subscrBirthDate    =  #" + subscrBirthDate.Value.ToShortDateString() + "# , \n" +
                                                  "subscrAddress     =  \"" + subscrAddress.Text + "\" , \n" +
                                                  "subscrCity    =  \"" + comboCity.Text + "\" , \n" +
                                                  "subscrPhone       =  \"" + phone.Text + "\" , \n" +
                                                  "subscrMobile      =  \"" + mobile.Text + "\" , \n" +
                                                  "subscrMail       =  \"" + subscrMail.Text + "\" , \n" +
                                                  "subscrPicture     =  \"" + pictureLocation.Text + "\"  \n" +
                                          "WHERE  subscrID = " + subscrID.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblSubscribers ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblSubscribers failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void FillCityCombo()                                   // Populate cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT cityName " +
                                          "FROM tblCities " +
                                          "ORDER BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboCity.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
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
                                     "FROM     tblSubscribers " +
                                     "ORDER BY subscrID";
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

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            pictureLocation.Text = pictureFileName;
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
                subscrID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                subscrFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                subscrLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                subscrAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboCity.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                phone.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                mobile.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                subscrMail.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                pictureLocation.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                pictureBox1.ImageLocation = pictureLocation.Text;
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
