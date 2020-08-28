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
    public partial class FormTblEmployees : Form
    {
        public FormTblEmployees()
        {
            InitializeComponent();
        }

        private void FormTblEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEmployees.tblEmployees' table. You can move, or remove it, as needed.
            this.tblEmployeesTableAdapter.Fill(this.dataSetEmployees.tblEmployees);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetEmployees changes = (DataSetEmployees)dataSetEmployees.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblEmployees.GetChanges();
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
                int numRows = tblEmployeesTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success"); dataSetEmployees.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetEmployees.RejectChanges();
            }
        }
    }
}
