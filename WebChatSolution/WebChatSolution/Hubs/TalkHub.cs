using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChatSolution.Hubs
{
    public class TalkHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}