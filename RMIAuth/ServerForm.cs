using System.Threading;
using System.Windows.Forms;

namespace RMIAuthServer
{
    public partial class ServerForm : Form
    {
        private Server server;

        public ServerForm()
        {
            InitializeComponent();
            server = new Server();
        }

        private void ServerForm_Load(object sender, System.EventArgs e)
        {
            new Thread(new ThreadStart(() => new ClientForm().ShowDialog())).Start();
        }

        private void BtnStart_Click(object sender, System.EventArgs e)
        {
            BtnStart.Enabled = false;
            BtnStop.Enabled = true;
            ListBoxServerInformations.Items.Add("Server started...");

            server.Start();
        }

        delegate void SetMessageCallback(string message);
        public void SetMessage(string message)
        {
            if (InvokeRequired)
                BeginInvoke(new SetMessageCallback(SetMessage), message);
            else
                ListBoxServerInformations.Items.Add(message);
        }

        private void BtnStop_Click(object sender, System.EventArgs e)
        {
            BtnStart.Enabled = true;
            BtnStop.Enabled = false;
            ListBoxServerInformations.Items.Add("Server stopped...");

            server.Stop();
        }
    }
}
