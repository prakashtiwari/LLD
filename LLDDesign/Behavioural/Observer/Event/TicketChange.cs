using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer.Event
{
    /// <summary>
    /// This class is like an events which holds the context data.
    /// </summary>
    public class TicketChange
    {
        public int ArtistId { get; set; }
        public int Amount { get; set; }
        public TicketChange(int artist, int amount)
        {
            ArtistId = artist;
            Amount = amount;
        
        }
    }
}
