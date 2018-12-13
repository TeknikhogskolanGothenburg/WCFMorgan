using System;
using System.Drawing;
using System.ServiceModel;
using System.Windows.Forms;

namespace CarRentalFormsRestHost
{
    public partial class Form1 : Form
    {
        private ServiceHost host;

        public Form1()
        {
            InitializeComponent();
            host = new ServiceHost(typeof(CarRentalService.CarRentalRestService));
            host.Open();
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
                host = new ServiceHost(typeof(CarRentalService.CarRentalRestService));
                host.Open();
                lblStatus.Text = "Host is connected";
                lblStatus.ForeColor = Color.Green;
                btnConnect.Text = "Disconnect";
            }
        }
    }
}