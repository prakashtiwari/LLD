using DesignPatterns.Behavioural.Observer.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer.Interface
{
    public interface ITicketchangeListner
    {
        void ReceiveNotification(TicketChange ticketChange);

    }
}
