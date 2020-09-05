using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FormLogin : Form
    {
        private OleDbConnection dataConnection;
        public FormLogin()
        {
            InitializeComponent();
            OpenDb();
        }
        private void OpenDb()
        {
            dataConnection = new OleDbConnection();
            try
            {
                dataConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Projects_2021\\Project_YairSuberri\\Access\\dbGym.mdb";
                dataConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accessing the database: " + e.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {        
    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckButtonClick(object sender, EventArgs e)
        {
            String line, password;
            int id;
            bool employIsAdmin;
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = " SELECT        employID, employPassword,employIsAdmin " +
                                           "FROM            tblEmployees " +
                                           "WHERE        employID= " + this.idNumber.Text;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                id = dataReader.GetInt32(0);
                password = dataReader.GetString(1);
                employIsAdmin = dataReader.GetBoolean(2);
                if (password == this.password.Text)
                {
                    this.Hide();
                    FormMenu frMenu = new FormMenu(dataConnection, employIsAdmin);
                    frMenu.Show();
                    frMenu.Disposed += new EventHandler(frMenu_Disposed);
                }
                else
                {
                    line = "invalid password: " + this.password.Text;
                    MessageBox.Show(line, "Error");
                }
            }
            catch (Exception err)
            {
                line = "invalid id: " + this.idNumber.Text + err.Message;
                MessageBox.Show(line, "Error");
            }
        }
        void frMenu_Disposed(object sender, EventArgs e)
        {
            this.idNumber.Text = "";
            this.password.Text = "";
            this.Show();
            this.Activate();
        }
    }
}
