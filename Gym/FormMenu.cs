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
            employee.Disposed += new EventHandler(Form_Disposed);
        }

        private void citiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblCities city = new FormTblCities();
            city.Show();
            city.Disposed += new EventHandler(Form_Disposed);
        }

        private void subscribersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblSubscribers subscribers = new FormTblSubscribers();
            subscribers.Show();
            subscribers.Disposed += new EventHandler(Form_Disposed);
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblRooms rooms = new FormTblRooms();
            rooms.Show();
            rooms.Disposed += new EventHandler(Form_Disposed);
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblTools tools = new FormTblTools();
            tools.Show();
            tools.Disposed += new EventHandler(Form_Disposed);
        }

        private void toolsInRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblToolsInRooms toolsInRooms = new FormTblToolsInRooms();
            toolsInRooms.Show();
            toolsInRooms.Disposed += new EventHandler(Form_Disposed);
        }

        private void personalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblPersonals personals = new FormTblPersonals();
            personals.Show();
            personals.Disposed += new EventHandler(Form_Disposed);
        }

        private void aimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblAims aims = new FormTblAims();
            aims.Show();
            aims.Disposed += new EventHandler(Form_Disposed);
        }

        private void trainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblTraining training = new FormTblTraining();
            training.Show();
            training.Disposed += new EventHandler(Form_Disposed);
        }

        private void typesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblTypes types = new FormTblTypes();
            types.Show();
            types.Disposed += new EventHandler(Form_Disposed);
        }

        private void ToolStripMenuItemAddEmpoyee_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddEmployee frm = new FormAddEmployee(dataConnection, employIsAdmin);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddAimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddAims frm = new FormAddAims(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddCitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCities frm = new FormAddCities(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddPersonalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddPersonals frm = new FormAddPersonals(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddRooms frm = new FormAddRooms(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddSubscribersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSubscribers frm = new FormAddSubscribers(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddTools frm = new FormAddTools(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddToolsInRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddToolsInRoom frm = new FormAddToolsInRoom(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddTrainings frm = new FormAddTrainings(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddTypes frm = new FormAddTypes(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateEmployee frm = new FormUpdateEmployee(dataConnection, employIsAdmin);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void updatePersonalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdatePersonals frm = new FormUpdatePersonals(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void updateToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateTools frm = new FormUpdateTools(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void updateAimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateAims frm = new FormUpdateAims(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void updateRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateRooms frm = new FormUpdateRooms(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void updateSubscribersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateSubscribers frm = new FormUpdateSubscribers(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void updateToolsInRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateToolsInRoom frm = new FormUpdateToolsInRoom(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void updateTrainingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateTraining frm = new FormUpdateTraining(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void updateTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateTypes frm = new FormUpdateTypes(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }
        void Form_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void RptToolsInRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptToolsInRoom frm = new FormRptToolsInRoom(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void RptsubscribersInCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptSubscribersInCity frm = new FormRptSubscribersInCity(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void RptsubscribersByAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptSbscribersByAge frm = new FormRptSbscribersByAge(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptRoomsByTool frm = new FormRptRoomsByTool(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptTrainingOfSubsc frm = new FormRptTrainingOfSubsc(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptSubscribersByType frm = new FormRptSubscribersByType(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

        private void chart1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartToolsInRoom frm = new FormChartToolsInRoom(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed); 
        }

    }
}
