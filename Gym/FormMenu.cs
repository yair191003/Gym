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
        private bool employIsAdmin;
        public FormMenu(OleDbConnection dataConnection, bool employIsAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.employIsAdmin = employIsAdmin;
            if (!employIsAdmin)
            {
                employeesToolStripMenuItem.Enabled = false;
            }
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

        private void ToolStripMenuItemAddEmpoyee_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddEmployee frm = new FormAddEmployee(dataConnection, employIsAdmin);
            frm.Show();
            frm.Disposed += new EventHandler(frGym_Disposed);
        }

        private void AddAimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddAims frm = new FormAddAims(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(frGym_Disposed);
        }

        private void AddCitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCities frm = new FormAddCities(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(frGym_Disposed);
        }

        private void AddPersonalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddPersonals frm = new FormAddPersonals(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(frGym_Disposed);
        }

        private void AddRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddRooms frm = new FormAddRooms(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(frGym_Disposed);
        }

        private void AddSubscribersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSubscribers frm = new FormAddSubscribers(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(frGym_Disposed);
        }

        private void AddToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddTools frm = new FormAddTools(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(frGym_Disposed);
        }

        private void AddToolsInRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddToolsInRoom frm = new FormAddToolsInRoom(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(frGym_Disposed);
        }

        private void AddTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddTrainings frm = new FormAddTrainings(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(frGym_Disposed);
        }

        private void AddTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddTypes frm = new FormAddTypes(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(frGym_Disposed);
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateEmployee frm = new FormUpdateEmployee(dataConnection, employIsAdmin);
            frm.Show();
            frm.Disposed += new EventHandler(frGym_Disposed); 
        }
    }
}
