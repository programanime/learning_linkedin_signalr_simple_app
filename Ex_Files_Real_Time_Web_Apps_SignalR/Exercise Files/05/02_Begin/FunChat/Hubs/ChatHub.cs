using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApplication1.Hubs
{
    public class ChatHub : Hub
    {
        public void JoinRoom(string room)
        {
            Groups.Add(Context.ConnectionId, room);
        }
        public void SendMessage(string room, string message, int x, int y)
        {
            Clients.Group(room).onNewMessage(message, x, y);
        }
    }
}