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
    public partial class FormRptSubscribersByType : Form
    {
        private OleDbConnection dataConnection;
        private string trainSubscrID;
        private string trainDate;
        private string trainHour;
        private string trainType;
        private string trainRoom;
        private string trainTool;
        private string saveColor = "";
        public FormRptSubscribersByType(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillTypeCombo();
        }
        private void FillTypeCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT typeName " +
                                          "FROM tblTypes " +
                                          "ORDER BY typeName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboType.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Type combobox failed \n" + err.Message, "Error",
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
                datacommand.CommandText = "SELECT   * " +
                                          " FROM tblTraining " +
                                         "WHERE    trainType = \"" + comboType.Text + "\" " +
                                          " ORDER BY trainType  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
               
                while (dataReader.Read())
                {
                    trainSubscrID = dataReader.GetInt32(0).ToString();
                    trainDate = dataReader.GetDateTime(1).ToShortDateString().ToString();
                    trainHour = dataReader.GetDateTime(2).TimeOfDay.ToString();
                    trainType = dataReader.GetString(3);
                    trainRoom = dataReader.GetInt32(4).ToString();
                    trainTool = dataReader.GetString(5);
                    counter++;
                    EditListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblTraining failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[6];
                if (counter == 1)
                {
                    arr[0] = trainType;

                }
                arr[1] = trainSubscrID;
                arr[2] = trainDate;
                arr[3] = trainHour;
                arr[4] = trainRoom;
                arr[5] = trainTool;
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
