using Microsoft.AspNetCore.SignalR;

namespace UpdateUIWithSignalR.Hubs
{
    public class AdminHub : Hub
    {
        public async Task SendJobStatus(string type, string message, string status)
        {
            await Clients.Caller.SendAsync("ReceivedMessage", type, message, status);
        }
    }
}
