using SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SignalRDemo
{
    public class MyCustomConnection : PersistentConnection
    {
         
            protected override Task OnReceivedAsync(IRequest request, string connectionId, string data)
            {
                //  return base.OnReceivedAsync(request, connectionId, data);
                return Connection.Broadcast(connectionId + ":" + data);
            }
     
    }
}