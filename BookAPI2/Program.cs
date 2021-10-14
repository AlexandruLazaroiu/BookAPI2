using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryMandatory2;

namespace BookAPI2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Managers.BooksManager.booksTest.Add("990",new Book("990", "Jimmy doesnt know","Ion Creanga", 213));
            Managers.BooksManager.booksTest.Add("700", new Book("700", "Jimmy doesnt know", "Ion Creanga", 213));
            Managers.BooksManager.booksTest.Add("555", new Book("555", "Jimmy doesnt know", "Ion Creanga", 213));
            Managers.BooksManager.booksTest.Add("333", new Book("333", "Jimmy doesnt know", "Ion Creanga", 213));
            Managers.BooksManager.booksTest.Add("111", new Book("111", "Jimmy doesnt know", "Ion Creanga", 213));
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
