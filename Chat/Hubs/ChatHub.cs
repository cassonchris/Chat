using Microsoft.AspNetCore.SignalR;

namespace Chat.Hubs
{
    public class ChatHub : Hub
    {
        public async void SendMessage(string message)
        {
            await Clients.All.InvokeAsync("sendMessage", new {message});
        }
    }
}