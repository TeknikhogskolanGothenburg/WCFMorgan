using System;
using System.Drawing;
using System.ServiceModel;
using System.Windows.Forms;

namespace CarRentalServiceFormsHost
{
    public partial class Form1 : Form
    {
        private ServiceHost host;

        public Form1()
        {
            InitializeComponent();
            host = new ServiceHost(typeof(CarRentalService.CarRentalService));
            host.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!(host.State == CommunicationState.Closed || host.State == CommunicationState.Created))
            {
                host.Close();
                lblStatus.Text = "Host is disconnected";
                lblStatus.ForeColor = Color.Red;
                btnConnect.Text = "Connect";
            }
            else
            {
                host = new ServiceHost(typeof(CarRentalService.CarRentalService));
                host.Open();
                lblStatus.Text = "Host is connected";
                lblStatus.ForeColor = Color.Green;
                btnConnect.Text = "Disconnect";
            }
        }
    }
}