using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Ass_Cs05
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public class Program
    {
        static void Main()
        {


            #region Q1
            //1. Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //Console.WriteLine("Days of the week:");

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region Q2

            // Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            // Note range for seasons(spring march to may, summer june to august, autumn September to November, winter December to February)

            Console.Write("Enter a season name: ");
            string input = Console.ReadLine();

            if (Enum.TryParse(typeof(Season), input, true, out object result))
            {
                Season Select = (Season)result;

                switch (Select)
                {
                    case Season.Spring:
                        Console.WriteLine(Season.Spring + ": March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine(Season.Summer + ": June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine(Season.Autumn + ": September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine(Season.Winter + ": December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season name! Please enter one of: Spring, Summer, Autumn, Winter.");
            }

            #endregion

        }
    }
}
