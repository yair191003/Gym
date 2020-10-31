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
    public partial class FormUpdateAims : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateAims(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            RefreshDataGridView();
        }

        private void FormUpdateAims_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAims.tblAims' table. You can move, or remove it, as needed.
            this.tblAimsTableAdapter.Fill(this.dataSetAims.tblAims);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblAims  \n" +
                                          "SET    aimPicture     =  \"" + pictureLocation.Text + "\"  \n" +
                                          "WHERE  aimName = \"" + AimName.Text + "\"";
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblAims ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblAims failed \n" + err.Message, "Error",
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
                                     "FROM     tblAims " +
                                     "ORDER BY aimName";
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
        private void FillSelectedRow()
        {
            try
            {
                AimName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                pictureLocation.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
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
        private void EnableButtons()
        {
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                buttonNext.Enabled = false;
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
