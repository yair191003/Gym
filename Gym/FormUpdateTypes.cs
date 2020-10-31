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
    public partial class FormUpdateTypes : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateTypes(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillToolCombo();
            FillAimCombo();
            RefreshDataGridView();
        }

        private void FormUpdateTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTypes.tblTypes' table. You can move, or remove it, as needed.
            this.tblTypesTableAdapter.Fill(this.dataSetTypes.tblTypes);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblTypes  \n" +
                                          "SET    typeTool    =  \"" + comboTool.Text + "\" , \n" +
                                                  "typeSets    =  " + typeSets.Text + " , \n" +
                                                  "typeRepeats     =  " + typeRepeats.Text + " , \n" +
                                                  "typeAim    =  \"" + comboAim.Text + "\" , \n" +
                                                  "typePicture     =  \"" + pictureLocation.Text + "\"  \n" +
                                          "WHERE  typeName = \"" + typeName.Text + "\"";
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblTypes ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblTypes failed \n" + err.Message, "Error",
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
                                     "FROM     tblTypes " +
                                     "ORDER BY typeName";
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
                MessageBox.Show("Fill Tools combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillAimCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT aimName " +
                                          "FROM tblAims " +
                                          "ORDER BY aimName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboAim.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Aims combobox failed \n" + err.Message, "Error",
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
                typeName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                comboTool.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                typeSets.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                typeRepeats.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboAim.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                pictureLocation.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
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
