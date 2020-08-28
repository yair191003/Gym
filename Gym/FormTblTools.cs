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
    public partial class FormTblTools : Form
    {
        public FormTblTools()
        {
            InitializeComponent();
        }

        private void FormTblTools_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTools.tblTools' table. You can move, or remove it, as needed.
            this.tblToolsTableAdapter.Fill(this.dataSetTools.tblTools);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetTools changes = (DataSetTools)dataSetTools.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblTools.GetChanges();
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
                int numRows = tblToolsTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success"); dataSetTools.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetTools.RejectChanges();
            }
        }
    }
}
