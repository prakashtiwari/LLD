using DesignPatterns.Behavioural.Observer;
using System;

namespace LLDDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer pattern");
            OrderService service = new OrderService();            
            TicketAvailabilityManagerService ticketAvailabilityManagerService = new TicketAvailabilityManagerService(service);
            TicketBookingConfrmationService ticketBookingConfrmationService = new TicketBookingConfrmationService(service);
            service.PlaceOrder();
            Console.ReadLine();
            //Console.WriteLine("Hello World!");
        }
    }
}
