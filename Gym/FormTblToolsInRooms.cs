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
    public partial class FormTblToolsInRooms : Form
    {
        public FormTblToolsInRooms()
        {
            InitializeComponent();
        }

        private void FormTblToolsInRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetToolsInRoom.tblToolsInRoom' table. You can move, or remove it, as needed.
            this.tblToolsInRoomTableAdapter.Fill(this.dataSetToolsInRoom.tblToolsInRoom);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetToolsInRoom changes = (DataSetToolsInRoom)dataSetToolsInRoom.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblToolsInRoom.GetChanges();
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
                int numRows = tblToolsInRoomTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success"); dataSetToolsInRoom.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetToolsInRoom.RejectChanges();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
