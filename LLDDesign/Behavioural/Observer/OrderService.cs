using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public class OrderService: TicketChangeNotifier
    {
        public void PlaceOrder()
        {
            var eventData = new Event.TicketChange(10, 12);
            Console.WriteLine($"Order is placed: ArtistId{eventData.ArtistId} Price:{eventData.Amount}");
            ////
            Notify(eventData);        
        
        }
    }
}
