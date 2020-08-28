using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FormTblPersonals : Form
    {
        public FormTblPersonals()
        {
            InitializeComponent();
        }

        private void FormTblPersonals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPersonals.tblPersonals' table. You can move, or remove it, as needed.
            this.tblPersonalsTableAdapter.Fill(this.dataSetPersonals.tblPersonals);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetPersonals changes = (DataSetPersonals)dataSetPersonals.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblPersonals.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                if (badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach (DataRow row in badRows)
                    {
                        foreach (DataColumn col in row.GetColumnsInError())
                        {
                            errorMsg = errorMsg + row.GetColumnsInError() + "\n";
                        }
                    }
                    MessageBox.Show("Errors in data: " + errorMsg, "Please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int numRows = tblPersonalsTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success"); dataSetPersonals.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetPersonals.RejectChanges();
            }
        }
    }
}
