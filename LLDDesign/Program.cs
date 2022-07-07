﻿using DesignPatterns.Behavioural.Observer;
using LLDDesign.Behavioural.Strategy.Interface;
using LLDDesign.Structural.Adapter;
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
            Console.WriteLine("Adapter pattern implementation!");
            ICityAdapter cityAdapter = new CityAdapter();
            Console.WriteLine(cityAdapter.GetCity().FullName);

            Console.ReadLine();
            //Console.WriteLine("Hello World!");
        }
    }
}
