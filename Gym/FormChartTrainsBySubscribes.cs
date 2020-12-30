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
    public partial class FormChartTrainsBySubscribes : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private int[] arrSubscrID;
        private int[] arrTirSubscr;
        public FormChartTrainsBySubscribes(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            CountSubscrID();
            arrSubscrID = new int[counter];
            arrTirSubscr = new int[counter];
            FillArrSubscrID();
            FillArrTirSubscr();
            ShowChart();
            EditListView();
        }
        private void CountSubscrID()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblSubscribers  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblSubscribers failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillArrSubscrID()
        {
            try
            {
                int k = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   subscrID " +
                                          "FROM     tblSubscribers  " +
                                          "ORDER BY subscrID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrSubscrID[k] = dataReader.GetInt32(0);
                    k++;
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
        private void FillArrTirSubscr()
        {
            for (int idx = 0; idx < arrSubscrID.Length; idx++)
                CountTrainings(idx);
        }

        private void CountTrainings(int idx)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  trainSubscrID   " +
                                          "FROM    tblTraining";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0) == arrSubscrID[idx])
                    {
                        arrTirSubscr[idx]++;
                    }
                    
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
        private void ShowChart()
        {
            try
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(1, 22);
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
                chart1.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;

                for (int i = 0; i < arrSubscrID.Length; i++)
                {
                    chart1.Series["מספר האימונים לכל מנוי"].Points.AddXY(arrSubscrID[i], arrTirSubscr[i]);
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
                for (int i = 0; i < arrSubscrID.Length; i++)
                {
                    string[] arr = new string[2];
                    arr[0] = arrSubscrID[i].ToString();
                    arr[1] = arrTirSubscr[i].ToString();
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
