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
    public partial class FormChartSubscribersByAge : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private int[] arrAges;
        private int[] arrSubscrByAge;
        private int age;
        public FormChartSubscribersByAge(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            counter = 10;
            arrAges = new int[counter];
            arrSubscrByAge = new int[counter];
            FillArrAges();
            FillarrSubscrByAge();
            ShowChart();
            EditListView();
        }
        private void FillArrAges()
        {
            try
            {
                int k = 0;
                arrAges[0] = 0;
                while (k != counter)
                {
                    arrAges[k] = k * 10;
                    k++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblCities failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillarrSubscrByAge()
        {
            for (int idx = 0; idx < arrAges.Length; idx++)
                CountSubscrInCity(idx);
        }
        private void CountSubscrInCity(int idx)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  tblSubscribers.subscrBirthDate " +
                                          "FROM    tblSubscribers  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();               
                while (dataReader.Read())
                {
                    var today = DateTime.Today;
                    age = today.Year - dataReader.GetDateTime(0).Year;
                    for (int i = 0; i < arrAges.Length;i++ )
                    {
                        if (age > arrAges[i] && age<=arrAges[i+1])
                            arrSubscrByAge[i]++;
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
        private void ShowChart()
        {
            try
            {
                
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 10;
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
                chart1.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;
                for (int i = 0; i < arrAges.Length; i++)
                {
                    chart1.Series["כמות מנויים על פי תחום הגילאים"].Points.AddXY(arrAges[i], arrSubscrByAge[i] / 10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Show chart failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditListView()
        {
            try
            {
                for (int i = 0; i < arrAges.Length; i++)
                {
                    string[] arr = new string[2];
                    arr[0] = arrAges[i].ToString();
                    arr[1] = (arrSubscrByAge[i]/10).ToString();
                    ListViewItem item = new ListViewItem(arr);
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
