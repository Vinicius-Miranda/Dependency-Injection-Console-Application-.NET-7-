using DependencyInjectionConsoleApplication.Interfaces;

namespace DependencyInjectionConsoleApplication.Models
{
    public class Person : IPerson
    {
        public void HaveBreakFast()
        {
            Console.WriteLine("I'm having my breakfest!");
        }

        public void Sleep()
        {
            Console.WriteLine("I'm tired, see you tomorrow!");
            Console.WriteLine("ZZZZZzzzzzz");
        }

        public void WakeUp()
        {
            Console.WriteLine("Good morning everybody...");
        }

        public void Work()
        {
            Console.WriteLine("Sorry I have to work, I talk to you later.");
        }
    }
}
