using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11_22_jaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random random= new Random();
            int transportTypeCount= Enum.GetNames(typeof(TransportEnum)).Length; //to make equal transport enumn to 5
            
            TransportEnum[][] transport =new TransportEnum[12][];

            for(int i=1; i<=12; i++)
            {
                int daysCount=DateTime.DaysInMonth(DateTime.Now.Year,i);  // to get mnonths days. 
                

                transport[i-1]=new TransportEnum[daysCount];
                for (int day = 1; day <= daysCount; day++)
                {
                    int randomType=random.Next(transportTypeCount); //choosing random number between 1-5. 
                    transport[i - 1][day - 1] = (TransportEnum)randomType; //choosing object from transportenum  
                }
       
            }

            string[] monthNames = GetMonthNames();
            int monthNamesPart = monthNames.Max(n => n.Length) + 2;
            
            for(int month = 1; month <= transport.Length; month++)
            {
                Console.Write($"{monthNames[month - 1]}:".PadRight(monthNamesPart));
                for (int day = 1; day <= transport[month - 1].Length; day++)
                {
                    Console.ForegroundColor= ConsoleColor.Magenta;
                    Console.BackgroundColor = transport[month - 1][day-1].GetColor();
                    Console.Write(transport[month - 1][day-1].GetString());
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("  ");

                }
                Console.WriteLine("");
               

            }

           

        }
        private static String[] GetMonthNames()
        {
            string[] names = new string[12];
            for (int month = 1; month <= 12; month++)
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
                string name = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("tr"));
                names[month - 1] = name;
            }
            return names;
        }
    }
}
