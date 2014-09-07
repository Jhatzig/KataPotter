using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPotter
{
    public static class KataPotter
    {

        private static Dictionary<int, double> remises = new Dictionary<int, double>();

        private static double defaultPriceBook = 8;

        public static double getPrices(int[] books)
        {
            remises = remises.Count == 0 ? InitRemise() : remises;
            return books.Count() != 0 ? getPricesBook(books) : 0;
        }

        private static double getPricesBook(int[] books)
        {
            if (books.Count() == 1)
            {
                return defaultPriceBook;
            }
            var price = 0.0;
            double remise;
            remises.TryGetValue(books.Distinct().Count(), out remise);

            price = books.Distinct().Count() * defaultPriceBook * remise;
            
            var dif = books.Count() - books.Distinct().Count();
            if (dif > 0)
            {
                price += dif * defaultPriceBook;
            }

            return price;

        }


        private static Dictionary<int, double> InitRemise()
        {
            remises.Add(1, 1);
            remises.Add(2, 0.95);
            remises.Add(3, 0.90);
            remises.Add(4, 0.80);
            remises.Add(5, 0.75);
            return remises;
        }

    }

}
