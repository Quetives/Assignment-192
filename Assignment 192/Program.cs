using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_192
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {           
            Console.WriteLine("Please enter a day of the week:");
            string attempt = Console.ReadLine();

            DaysOfTheWeek Day;
            
            try
            {
                Day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), attempt);
                Console.WriteLine("Today is " + Day);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }                      
            Console.ReadLine();   
        }
    }
}

