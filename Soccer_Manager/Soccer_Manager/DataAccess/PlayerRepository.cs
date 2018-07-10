using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_Manager.DataAccess
{
    public class PlayerRepository
    {
        readonly Random random = new Random();

        readonly string[] titles = { "Auto", "Schiff", "Flugzüüg", "Schule", "Firma", "Vögel" };
        readonly string[] authors = { "Robbi", "Luca", "Stefan", "John", "Hans", "Freddy" };
        readonly double[] prices = { 11, 22, 33, 15, 18, 29 };




        public string GetRandomTitle()
        {
            return titles[random.Next(titles.Length)];
        }

        public string GetRandomAuthor()
        {
            return authors[random.Next(authors.Length)];
        }
        public double GetRandomPrice()
        {
            return prices[random.Next(prices.Length)];
        }











    }
}
