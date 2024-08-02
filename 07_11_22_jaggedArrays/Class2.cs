using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11_22_jaggedArrays
{
    public static class TransportEnumExtensions
    {
        public static string GetString(this TransportEnum trans)
        {
            
            switch (trans)
            {
                case TransportEnum.Car: return "Car ";
                case TransportEnum.Walk: return "Walk";
                case TransportEnum.Subway: return "SubW";
                case TransportEnum.Bike: return "Bike";
                case TransportEnum.Bus: return "Bus ";
                    default:throw new Exception("unknown transport");    

            }
        }
        public static ConsoleColor GetColor(this TransportEnum trans)
        {
            switch (trans)
            {
                case TransportEnum.Car: return ConsoleColor.Blue;
                case TransportEnum.Walk: return ConsoleColor.DarkGray;
                case TransportEnum.Subway: return ConsoleColor.DarkMagenta;
                case TransportEnum.Bike: return ConsoleColor.DarkYellow;
                case TransportEnum.Bus: return ConsoleColor.White;
            default:throw new Exception("unknown transport");
        }
        }
    }
}
