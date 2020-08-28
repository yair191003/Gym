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
    public partial class FormTblTraining : Form
    {
        public FormTblTraining()
        {
            InitializeComponent();
        }

        private void FormTblTraining_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTraining.tblTraining' table. You can move, or remove it, as needed.
            this.tblTrainingTableAdapter.Fill(this.dataSetTraining.tblTraining);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetTraining changes = (DataSetTraining)dataSetTraining.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblTraining.GetChanges();
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
                int numRows = tblTrainingTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success"); dataSetTraining.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetTraining.RejectChanges();
            }
        }
    }
}
