using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApplication1.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string message, int x, int y)
        {
            Clients.All.onNewMessage(message, x, y);
        }
        
        public void JoinRoom()
        {
            
        }
    }
}