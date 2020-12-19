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
    public partial class FormChartToolsInRoom : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string[] arrRooms;
        private int[] arrRoomsID;
        private int[] arrToolAmount;
        public FormChartToolsInRoom(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            CountRooms();
            arrRooms = new string[counter];
            arrRoomsID = new int[counter];
            arrToolAmount = new int[counter];
            for (int i = 0; i < arrToolAmount.Length; i++)
            {
                arrToolAmount[i] = 0;
            }            
                FillArrRooms();
             FillArrTools();
              ShowChart();
               EditListView();
        }
        private void CountRooms()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblRooms  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblRooms failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillArrRooms()
        {
            try
            {
                int k = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandType = CommandType.Text;
                //datacommand.CommandText = "SELECT   COUNT(*) " +
                //                         "FROM     tblRooms  ";
                string t = "SELECT tblRooms.roomID, tblRooms.roomName" + 
                           " FROM tblRooms " +
                           "ORDER BY tblRooms.roomID ";
                datacommand.CommandText = t;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrRoomsID[k] = dataReader.GetInt32(0);
                    arrRooms[k] = dataReader.GetString(1);                  
                    k++;
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
       private void FillArrTools()
        {
       
            for (int idx = 0; idx < arrRooms.Length; idx++)
                CountTools(idx);
        }
        private void CountTools(int idx)
        {
            try
            {
               
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  tirRoomAmount " +
                                          "FROM    tblToolsInRoom  " +
                                          "WHERE   tirRoomID = " + arrRoomsID[idx] + "";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    string amount = dataReader.GetString(0);
                    arrToolAmount[idx] = arrToolAmount[idx] + int.Parse(amount);
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
         private void ShowChart()
        {
            try
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
                chart1.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;

                for (int i = 0; i < arrRooms.Length; i++)
                {
                    chart1.Series["כמות המכשירים בחדר"].Points.AddXY(arrRooms[i], arrToolAmount[i]);
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
                   for (int i = 0; i < arrRooms.Length; i++)
                   {
                       string[] arr = new string[2];
                       arr[0] = arrRooms[i];
                       arr[1] = arrToolAmount[i].ToString();
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
