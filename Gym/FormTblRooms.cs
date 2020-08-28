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
    public partial class FormTblRooms : Form
    {
        public FormTblRooms()
        {
            InitializeComponent();
        }

        private void FormTblRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRooms.tblRooms' table. You can move, or remove it, as needed.
            this.tblRoomsTableAdapter.Fill(this.dataSetRooms.tblRooms);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetRooms changes = (DataSetRooms)dataSetRooms.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblRooms.GetChanges();
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
                int numRows = tblRoomsTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success"); dataSetRooms.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetRooms.RejectChanges();
            }
        }
    }
}
