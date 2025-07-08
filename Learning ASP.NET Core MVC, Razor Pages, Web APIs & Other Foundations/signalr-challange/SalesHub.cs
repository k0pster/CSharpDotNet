using Microsoft.AspNetCore.SignalR;

public class SalesHub : Hub
{
    public async Task PostNewSale(int amount)
    {
        if (amount > 1000)
        {
            await Clients.All.SendAsync("ReceiveLargeSale", amount);
        }
    }
}