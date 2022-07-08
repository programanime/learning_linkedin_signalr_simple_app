using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRExample.Hubs
{
    public class ChatHub : Hub
    {
        public void NewMessage(string username, string message)
        {
            Clients.All.sentMessage(username, message, DateTime.Now);
        }
    }
}