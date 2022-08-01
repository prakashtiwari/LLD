using DesignPatterns.Behavioural.Observer;
using LLDDesign.Behavioural.Strategy.Interface;
using LLDDesign.Creational;
using LLDDesign.Creational.Builder;
using LLDDesign.LRU;
using LLDDesign.Structural.Adapter;
using LLDDesign.Structural.Builder;
using LLDDesign.Structural.Decorator;
using Lucene.Net.Util;
using System;
using System.Collections.Generic;

namespace LLDDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            //PriorityQueue<int> priorityQueue = new PriorityQueue<int>();
            Console.WriteLine("Observer pattern");
            BuilderPattern();
            //CheckModulo();
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

            //Garage garage = new Garage();
            //CarBuilder bmw = new BMWBuilder();
            //garage.Construct(bmw);
            //garage.Show();
            //CarBuilder mini = new MiniCooperBuilder();
            //garage.Construct(mini);
            //garage.Show();
            LRUCacheImplementation();

            Console.ReadLine();
            //Console.WriteLine("Hello World!");
        }
        private static void CheckModulo()
        {
            Console.WriteLine(10 % 4);
            for (int i = 1; i <= 4; i++)
                Console.WriteLine(i % 4);
        }
        public static void BuilderPattern()
        {
            var furnitureItems = new List<FurnitureItem>()
            {
                new FurnitureItem("Sectional couch",12,12,100,10),
                new FurnitureItem("Side sofa",12,15,20,25),
                new FurnitureItem("Good coup board",13,15,20,12)
            };
            var inventoryBuilder = new DailyReportBuilder(furnitureItems);
            InventoryBuildDirector inventoryBuildDirector = new InventoryBuildDirector(inventoryBuilder);
            inventoryBuildDirector.BuildCompleteReport();
            var report = inventoryBuilder.GetDailyReport();
            Console.WriteLine(report.Debug());
        }

        public static void LRUCacheImplementation()
        {
            LRuCache lRuCache = new LRuCache(5);
            int val = lRuCache.Get(5);
            if (val == -1)
            {
                lRuCache.Put(5,10);
                Console.WriteLine("Cache is empty");
                val = lRuCache.Get(5);
                Console.WriteLine("Cache val is: " + val);
            }
            else
            {
                Console.WriteLine("Cache val is: " + val);
            }
        }
    }
}
