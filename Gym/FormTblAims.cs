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
    public partial class FormTblAims : Form
    {
        public FormTblAims()
        {
            InitializeComponent();
        }

        private void FormTblAims_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAims.tblAims' table. You can move, or remove it, as needed.
            this.tblAimsTableAdapter.Fill(this.dataSetAims.tblAims);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetAims changes = (DataSetAims)dataSetAims.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblAims.GetChanges();
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
                int numRows = tblAimsTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success"); dataSetAims.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetAims.RejectChanges();
            }
        }
    }
}
