using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseConvert2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word="789";
            try
            {
                int tryParsedNum;
                int.TryParse(word, out tryParsedNum);
                Console.WriteLine("The number is "+tryParsedNum*5);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!!!"+ex);
            }
            string timeDate = "06/22/2022";
            try
            {
                DateTime date = Convert.ToDateTime(timeDate);
                date = date.AddMonths(-1);
                Console.WriteLine("The date is "+date.Day + "/" + date.Month + "/" + date.Year);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex);
            }
            string spanTime = "09:37:24";
            try
            {
                TimeSpan time = TimeSpan.Parse(spanTime);
                time=time.Subtract(TimeSpan.FromHours(2));
                Console.WriteLine("The time span is "+time);
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
