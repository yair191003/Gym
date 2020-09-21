using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym
{
    public partial class FormUpdateEmployee : Form
    {
        private OleDbConnection dataConnection;
        private bool employIsAdmin;
        private int lastRow = 0;
        public FormUpdateEmployee(OleDbConnection dataConnection, bool employIsAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.employIsAdmin = employIsAdmin;
            if (!employIsAdmin)
                buttonUpdate.Enabled = false;
            FillCityCombo();
            RefreshDataGridView();
        }

        private void FormUpdateEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEmployees.tblEmployees' table. You can move, or remove it, as needed.
            this.tblEmployeesTableAdapter.Fill(this.dataSetEmployees.tblEmployees);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblEmployees  \n" +
                                          "SET    employFirstName    =  \"" + EmployFirstName.Text + "\" , \n" +
                                                  "employLastName    =  \"" + EmployLastName.Text + "\" , \n" +
                                                  "employAddress     =  \"" + EmployAddress.Text + "\" , \n" +
                                                  "employCity    =  \"" + comboCity.Text + "\" , \n" +
                                                  "employPhone       =  \"" + phone.Text + "\" , \n" +                                                  
                                                  "employMobile      =  \"" + mobile.Text + "\" , \n" +
                                                  "employMail       =  \"" + EmployMail.Text + "\" , \n" +
                                                  "employPassword       =  \"" + EmployPassword.Text + "\" , \n" +
                                                  "employIsAdmin =    " + isManeger.Checked + "   , \n" +
                                                  "employPicture     =  \"" + pictureLocation.Text + "\"  \n" +
                                          "WHERE  employID = " + EmployId.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblEmployees ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblEmployees failed \n" + err.Message, "Error",
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
                                     "FROM     tblEmployees " +
                                     "ORDER BY employID";
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
        private void buttonBrowse_Click_1(object sender, EventArgs e)
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
                EmployId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                EmployFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                EmployLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                EmployAddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboCity.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                phone.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                mobile.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                EmployMail.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                EmployPassword.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                isManeger.Checked = dataGridView1.SelectedRows[0].Cells[10].Value.ToString() == "True";
                pictureLocation.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
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

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
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

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
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
    }
}
