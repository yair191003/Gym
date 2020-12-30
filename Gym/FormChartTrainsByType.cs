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
    public partial class FormChartTrainsByType : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string[] arrTypes;
        private int[] arrSubscrType;
        public FormChartTrainsByType(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            CountTypes();
            arrTypes = new string[counter];
            arrSubscrType = new int[counter];
            FillArrTypes();
            FillArrTirSubscr();
            ShowChart();
            EditListView();
        }
        private void CountTypes()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblTypes  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblTypes failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillArrTypes()
        {
            try
            {
                int k = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   typeName " +
                                          "FROM     tblTypes  " +
                                          "ORDER BY typeName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrTypes[k] = dataReader.GetString(0);
                    k++;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblTypes failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillArrTirSubscr()
        {
            for (int idx = 0; idx < arrTypes.Length; idx++)
                CountTrainings(idx);
        }

        private void CountTrainings(int idx)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  personalType   " +
                                          "FROM    tblPersonals";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetString(0) == arrTypes[idx])
                    {
                        arrSubscrType[idx]++;
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblPersonals failed " +
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

                for (int i = 0; i < arrTypes.Length; i++)
                {
                    chart1.Series["מספר המנויים שביצעו את אותו סוג אימון"].Points.AddXY(arrTypes[i], arrSubscrType[i]);
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
                for (int i = 0; i < arrTypes.Length; i++)
                {
                    string[] arr = new string[2];
                    arr[0] = arrTypes[i];
                    arr[1] = arrSubscrType[i].ToString();
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
