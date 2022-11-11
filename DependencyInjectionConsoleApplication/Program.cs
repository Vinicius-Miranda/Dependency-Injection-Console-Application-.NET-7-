using DependencyInjectionConsoleApplication;
using DependencyInjectionConsoleApplication.Models;
using Microsoft.Extensions.DependencyInjection;

var host = Startup.RegisterServices();

var person = ActivatorUtilities.CreateInstance<Person>(host.Services);

Console.WriteLine("Starting program....");

person.WakeUp();
Console.WriteLine("Type enter to continue!");
Console.ReadLine();
person.HaveBreakFast();
Console.WriteLine("Type enter to continue!");
Console.ReadLine();
person.Work();
Console.WriteLine("Type enter to continue!");
Console.ReadLine();
person.Sleep();
Console.WriteLine("Type enter to continue!");
Console.ReadLine();

Environment.Exit(0);
