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
    public partial class FormRptRoomsByTool : Form
    {
        private OleDbConnection dataConnection;
        private string Tool;
        private string roomID;
        private string roomName;
        private string picture;
        private string saveColor = "";
        public FormRptRoomsByTool(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillToolCombo();
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
                MessageBox.Show("Fill Tool combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                int counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   tirRoomID " +
                                          "FROM     tblToolsInRoom   " +
                                          "WHERE    tirToolName = \"" + comboTool.Text + "\" ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                Tool = comboTool.Text;                
                while (dataReader.Read())
                {
                    roomID = dataReader.GetInt32(0).ToString();
                    GetRooms();
                    counter++;
                   
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
        private void GetRooms()
        {
            try
            {
                int counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   *" +
                                          " FROM    tblRooms " +
                                          "WHERE    roomID = " + roomID + " " ;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    roomName = dataReader.GetString(1);
                    if (!dataReader.IsDBNull(2))
                    {
                        picture = dataReader.GetString(2);
                    }
                    else
                    {
                        picture = "";
                    }
                    counter++;
                    EditListView(counter);
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
        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[4];
                if (counter == 1)
                {
                    arr[0] = Tool;
                    arr[1] = roomID;

                }
                arr[2] = roomName;
                arr[3] = picture;
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            buttonColor.BackColor = cd.Color;
            saveColor = buttonColor.BackColor.ToArgb().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
