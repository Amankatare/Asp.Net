using Microsoft.AspNetCore.SignalR;

namespace ChatWithMe.MVC.Hubs
{
    public class ChatHub : Hub
    {
        /*
        public override async Task OnConnectedAsync(string user)
        {
            await Clients.Others.SendAsync("ReceiveMessage", " just joined");
        }
        */
        public async Task SendMessage(string user,string message)
        {
           var userId = Context.UserIdentifier;
            await Clients.Others.SendAsync("ReceiveMessage", user,message,DateTime.Now.ToShortTimeString());
        }

        /*
        public async Task Broadcast(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", new
            {
                Sender =  Context.User.Identity.Name,
                Message = message
            });
        */
        }
    }

