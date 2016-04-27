using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RMIAuthServer
{
    public class Server
    {
        private TcpChannel channel;
        private Type commonInterfaceType;

        public void Start()
        {
            channel = new TcpChannel(9998);
            ChannelServices.RegisterChannel(channel, true);

            commonInterfaceType = Type.GetType("RMIAuthServer.User");

            RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType, "Auth", WellKnownObjectMode.SingleCall);
        }

        public void Stop()
        {
            ChannelServices.UnregisterChannel(channel);

            channel = null;
        }
    }
}
