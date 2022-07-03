using DesignPatterns.Behavioural.Observer.Event;
using DesignPatterns.Behavioural.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public class TicketBookingConfrmationService : ITicketchangeListner
    {

        public TicketBookingConfrmationService(TicketChangeNotifier notifier)
        {
            notifier.Subscribe(this);
        }
        public void ReceiveNotification(TicketChange ticketChange)
        {
            Console.WriteLine($"TicketBookingConfrmationService received notifiction artistId {ticketChange.ArtistId}");
        }
    }
}
