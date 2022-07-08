using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalRExample.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnected(){
            return base.OnConnected();
        }
        
        public void NewMessage(string username, string message)
        {
            Clients.Others.sentMessage(username, message, DateTime.Now);
            //Clients.All.sentMessage(username, message, DateTime.Now);
        }
    }
}