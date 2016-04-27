using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RMIAuthServer
{
    public class Client
    {
        private ClientForm clientForm;
        private IChannel[] channelsList;
        private TcpChannel channel;
        private Type requiredType;
        private IUser remoteObject;

        public Client(ClientForm clientForm)
        {
            this.clientForm = clientForm;
        }

        public void Verify(string name, string password)
        {
            channelsList = ChannelServices.RegisteredChannels;

            if (channelsList.Length > 0)
            {
                clientForm.SetMessage("Checking user...");

                channel = (TcpChannel)channelsList[0];

                requiredType = typeof(IUser);

                remoteObject = (IUser)Activator.GetObject(requiredType, "tcp://localhost:9998/Auth");

                if (remoteObject.IsValidUser(name, password))
                    clientForm.SetMessage("✔ " + name + " is a valid user.");
                else
                    clientForm.SetMessage("✖ " + name + " is not a valid user.");
            }
            else
            {
                clientForm.SetMessage("✖  server is offline...");
            }
        }
    }
}
