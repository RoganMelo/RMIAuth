using System;
using System.Windows.Forms;

namespace RMIAuthServer
{
    public partial class ClientForm : Form
    {
        private Client client;

        public ClientForm()
        {
            InitializeComponent();
            client = new Client(this);
        }

        private void BtnVerify_Click(object sender, EventArgs e)
        {
            client.Verify(TextBoxName.Text, TextBoxPassword.Text);
        }

        delegate void SetMessageCallback(string message);
        public void SetMessage(string message)
        {
            if (InvokeRequired)
                BeginInvoke(new SetMessageCallback(SetMessage), message);
            else
                ListBoxClientInformations.Items.Add(message);
        }
    }
}
