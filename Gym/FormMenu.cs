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
    public partial class FormMenu : Form
    {
        private OleDbConnection dataConnection;
        public FormMenu(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblEmployees employee = new FormTblEmployees();
            employee.Show();
            employee.Disposed += new EventHandler(frGym_Disposed);
        }

        private void citiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblCities city = new FormTblCities();
            city.Show();
            city.Disposed += new EventHandler(frGym_Disposed);
        }

        private void subscribersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblSubscribers subscribers = new FormTblSubscribers();
            subscribers.Show();
            subscribers.Disposed += new EventHandler(frGym_Disposed);
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblRooms rooms = new FormTblRooms();
            rooms.Show();
            rooms.Disposed += new EventHandler(frGym_Disposed);
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblTools tools = new FormTblTools();
            tools.Show();
            tools.Disposed += new EventHandler(frGym_Disposed);
        }

        private void toolsInRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblToolsInRooms toolsInRooms = new FormTblToolsInRooms();
            toolsInRooms.Show();
            toolsInRooms.Disposed += new EventHandler(frGym_Disposed);
        }

        private void personalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblPersonals personals = new FormTblPersonals();
            personals.Show();
            personals.Disposed += new EventHandler(frGym_Disposed);
        }

        private void aimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblAims aims = new FormTblAims();
            aims.Show();
            aims.Disposed += new EventHandler(frGym_Disposed);
        }

        private void trainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblTraining training = new FormTblTraining();
            training.Show();
            training.Disposed += new EventHandler(frGym_Disposed);
        }

        private void typesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblTypes types = new FormTblTypes();
            types.Show();
            types.Disposed += new EventHandler(frGym_Disposed);
        }
        void frGym_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }
    }
}
