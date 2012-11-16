
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR.Hosting;

namespace SignalRDemo
{
    [HubName("chat")]
    public class Notifier : Hub 
    {

        public void Broadcast(dynamic data)
        {
            var notification = new { message = data.message, group = data.group, sender = data.sender };
            Clients.All.Send(notification); 
        }

        public void BroadcastToGroup(dynamic data)
        {
            var notification = new { message = data.message, group=data.group, sender = data.sender };
            string[] excludeList = new string[] { };
            string groupName = notification.group;
            Clients.Group(groupName, excludeList).Send(notification);
           
           
        }

       
    

        public void SuscribeMe(dynamic group)
        {
            Groups.Add(Context.ConnectionId, group);
        }

        public void UnSuscribeMe(string group)
        {
            Groups.Remove(Context.ConnectionId, group);
        }


        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected()
        {
            return base.OnDisconnected();
        }


        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }

 
    }
}