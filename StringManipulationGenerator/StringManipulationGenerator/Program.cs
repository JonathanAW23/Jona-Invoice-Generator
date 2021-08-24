using System;
using RomanNumerals;

namespace StringManipulationGenerator
{
    class Program
    {
        static string GenerateCode(int currentNumber) 
        {
            currentNumber++;
            string month, year, dayFullVer,day;
            int date,yearNum;
            DateTime today = DateTime.Today;
            month = today.ToString("MM");
            year = today.ToString("yyyy");
            yearNum = Convert.ToInt32(today.ToString("yy"));
            dayFullVer = today.ToString("ddddd");
            date = (int)today.Day;
            day = dayFullVer.Substring(0, 2);
            var romDate = new RomanNumeral(date);
            var romYear = new RomanNumeral(yearNum);
            return ($"INV/{year}{month}/{day.ToUpper()}/{romDate}/{romYear}/{currentNumber}");
        }

        static void Main(string[] args)
        {
            int counter = 10983;
            Console.WriteLine(GenerateCode(counter));
        }
    }
}
