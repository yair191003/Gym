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
    public partial class FormRptSubscribersInCity : Form
    {
        private OleDbConnection dataConnection;
        private int subscrID;
        private string cityName;
        private string firstName;
        private string lastName;
        private string date;
        private string address;
        private string phone;
        private string mobile;
        private string email;
        private string picture;
        private string saveColor = "";
        public FormRptSubscribersInCity(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillCityCombo();
        }
        private void FillCityCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT cityName " +
                                          "FROM tblCities " +
                                          "ORDER BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboCity.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
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
                                          "FROM     tblSubscribers   " +
                                          "WHERE    subscrCity = \"" + comboCity.Text + "\" " +
                                          "ORDER BY subscrCity";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                cityName = comboCity.Text;
                while (dataReader.Read())
                {
                    subscrID = dataReader.GetInt32(0);
                    firstName = dataReader.GetString(1);
                    lastName = dataReader.GetString(2);
                    date = dataReader.GetDateTime(3).ToString();
                    address = dataReader.GetString(4);
                    phone = dataReader.GetString(6);
                    mobile = dataReader.GetString(7);
                    email = dataReader.GetString(8);
                    if (!dataReader.IsDBNull(9))
                    {
                        picture = dataReader.GetString(9);
                    }
                    counter++;
                    EditListView(counter);
                }
                dataReader.Close();     
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblSubscribers failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[10];
                if (counter == 1)
                {
                    arr[0] = cityName;
                }
                arr[1] = subscrID.ToString();
                arr[2] = firstName;
                arr[3] = lastName;
                arr[4] = date;
                arr[5] = address;
                arr[6] = phone;
                arr[7] = mobile;
                arr[8] = email;
                arr[9] = picture;
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
