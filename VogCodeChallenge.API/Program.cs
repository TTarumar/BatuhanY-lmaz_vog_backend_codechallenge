using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace VogCodeChallenge.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            EmployeeList myEmployee = new EmployeeList();
            myEmployee.Add(new Employee { Name = "Batuhan", LastName = "Yılmaz", JobTitle = "Mobile Developer", Adress = "Ankara/Türkiye" });
            myEmployee.Add(new Employee { Name = "Logan", LastName = "Felix", JobTitle = "Web Developer", Adress = "Vancouver/Canada" });
            myEmployee.Add(new Employee { Name = "Mehmet", LastName = "Kılıc", JobTitle = "Sales Expert", Adress = "Istanbul/Türkiye" });

            foreach (var item in myEmployee)
            {
                Console.WriteLine(item);
            }




        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
