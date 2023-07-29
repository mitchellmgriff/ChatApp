using Microsoft.AspNetCore.SignalR;
using System.Runtime.CompilerServices;

namespace ChatApplication.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);

        }


    }
}
