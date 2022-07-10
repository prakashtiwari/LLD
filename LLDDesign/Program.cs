using DesignPatterns.Behavioural.Observer;
using LLDDesign.Behavioural.Strategy.Interface;
using LLDDesign.Structural.Adapter;
using LLDDesign.Structural.Builder;
using LLDDesign.Structural.Decorator;
using Lucene.Net.Util;
using System;

namespace LLDDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            //PriorityQueue<int> priorityQueue = new PriorityQueue<int>();
            Console.WriteLine("Observer pattern");
            //OrderService service = new OrderService();            
            //TicketAvailabilityManagerService ticketAvailabilityManagerService = new TicketAvailabilityManagerService(service);
            //TicketBookingConfrmationService ticketBookingConfrmationService = new TicketBookingConfrmationService(service);            
            //service.PlaceOrder();
            //IExportStrategy export = new CsvExport();
            //Order order = new Order(2, "Test");
            //order.Export(export);
            //Console.WriteLine("Adapter pattern implementation!");
            //ICityAdapter cityAdapter = new CityAdapter();
            //Console.WriteLine(cityAdapter.GetCity().FullName);


            //IMailService mail = new OnPrimMAilService();
            //mail.SendMail();
            //StatisticsDecorator statisticsDecorator = new StatisticsDecorator(mail);
            //statisticsDecorator.SendMail();

            Garage garage = new Garage();
            CarBuilder bmw = new BMWBuilder();
            garage.Construct(bmw);
            garage.Show();
            CarBuilder mini = new MiniCooperBuilder();
            garage.Construct(mini);
            garage.Show();

            Console.ReadLine();
            //Console.WriteLine("Hello World!");
        }
    }
}
