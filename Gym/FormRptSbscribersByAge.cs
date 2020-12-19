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
    public partial class FormRptSbscribersByAge : Form
    {
        private OleDbConnection dataConnection;
        private int age;
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
        public FormRptSbscribersByAge(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT subscrID, subscrFirstName, subscrLastName, subscrBirthDate, subscrAddress, subscrCity, subscrPhone, subscrMobile, subscrMail, subscrPicture " +
                                           " FROM tblSubscribers " +
                                           "ORDER BY subscrBirthDate" ;                                                                                                                         
                OleDbDataReader dataReader = datacommand.ExecuteReader();                
                while (dataReader.Read())
                {
                    var today = DateTime.Today;
                    age = DateTime.Now.Year - dataReader.GetDateTime(3).Year;
                    if (age <= Convert.ToInt32(toAge.Text) && age >= Convert.ToInt32(fromAge.Text))
                    {
                        subscrID = dataReader.GetInt32(0);
                        firstName = dataReader.GetString(1);
                        lastName = dataReader.GetString(2);
                        date = dataReader.GetDateTime(3).ToString();
                        address = dataReader.GetString(4);
                        cityName = dataReader.GetString(5);
                        phone = dataReader.GetString(6);
                        mobile = dataReader.GetString(7);
                        email = dataReader.GetString(8);
                        if (!dataReader.IsDBNull(9))
                        {
                            picture = dataReader.GetString(9);
                        }
                       
                        EditListView();
                    }
                    else
                    {
                        int a = 1;
                    }
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
        private void EditListView()
        {
            try
            {                                                   
                     string[] arr = new string[11];
                     arr[0] = subscrID.ToString();
                     arr[1] = firstName;
                     arr[2] = lastName;
                     arr[3] = date;
                     arr[4] = address;
                     arr[5] = cityName;
                     arr[6] = phone;
                     arr[7] = mobile;
                     arr[8] = email;
                     arr[9] = picture;
                     arr[10] = age.ToString();
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

        private void fromAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
