using DesignPatterns.Behavioural.Observer.Event;
using DesignPatterns.Behavioural.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public abstract class TicketChangeNotifier
    {
        public List<ITicketchangeListner> ticketchangeListners = new List<ITicketchangeListner>();

        public void Notify(TicketChange eventData)
        {
            foreach (ITicketchangeListner ticketchangeListner in ticketchangeListners)
            {
                ticketchangeListner.ReceiveNotification(eventData);


            }

        }
        public void Subscribe(ITicketchangeListner ticketchangeListner)
        {
            ticketchangeListners.Add(ticketchangeListner);


        }

    }
}
