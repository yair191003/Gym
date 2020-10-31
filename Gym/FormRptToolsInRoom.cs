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
    public partial class FormRptToolsInRoom : Form
    {
        private OleDbConnection dataConnection;
        private string roomID;
        private string roomName;
        private string toolName;
        private string amount;
        private string saveColor = "";
        private int lastRow =0;
        public FormRptToolsInRoom(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;          
        }

        private void FormRptToolsInRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRooms.tblRooms' table. You can move, or remove it, as needed.
            this.tblRoomsTableAdapter.Fill(this.dataSetRooms.tblRooms);
            buttonFirst_Click(sender, e);
            // TODO: This line of code loads data into the 'dataSetToolsInRoom.tblToolsInRoom' table. You can move, or remove it, as needed.

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   roomID, roomName " +
                                          "FROM     tblRooms   " +
                                          "WHERE    RoomID = " + roomID + " " +
                                          "ORDER BY roomID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    roomID = dataReader.GetInt32(0).ToString();
                    roomName = dataReader.GetString(1);
                    GetToools();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblRooms failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetToools()
        {
            try
            {
                int counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   tirToolName,tirRoomAmount"  +
                                          " FROM tblToolsInRoom "   +
                                          "WHERE    tirRoomID = " + roomID + " " +
                                          "ORDER BY tirToolName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    toolName = dataReader.GetString(0);
                    amount = dataReader.GetString(1);
                    counter++;
                    EditListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblToolsInRoom failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[4];
                if (counter == 1)
                {
                    arr[0] = roomID;
                    arr[1] = roomName;
                }
                arr[2] = toolName;
                arr[3] = amount;
                ListViewItem item = new ListViewItem(arr);
                if (saveColor != "")
                    item.ForeColor = Color.FromArgb(int.Parse(saveColor));
                listView1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
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
                roomID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                EnableButtons();
             }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            buttonColor.BackColor = cd.Color;
            saveColor = buttonColor.BackColor.ToArgb().ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
