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
    public partial class FormTblSubscribers : Form
    {
        public FormTblSubscribers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormSubscribers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSubscribers.tblSubscribers' table. You can move, or remove it, as needed.
            this.tblSubscribersTableAdapter.Fill(this.dataSetSubscribers.tblSubscribers);
            // TODO: This line of code loads data into the 'dataSetSubscribers.tblSubscribers' table. You can move, or remove it, as needed.
            this.tblSubscribersTableAdapter.Fill(this.dataSetSubscribers.tblSubscribers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetSubscribers changes = (DataSetSubscribers)dataSetSubscribers.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblSubscribers.GetChanges();
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
                int numRows = tblSubscribersTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success"); dataSetSubscribers.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetSubscribers.RejectChanges();
            }
        }
    }
}
