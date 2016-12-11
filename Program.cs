using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBookstore
{
    class Program
    {
        static void Main(string[] args)
        {
            Book ksiazka = new Book("Krzyzacy", "Powieść historyczna", "WW", "Henryk Sienkiewicz", 1900);
            ksiazka.show();
            Book ksiazkaDuplicate = ksiazka.clone();
            ksiazkaDuplicate.show();

            Console.WriteLine(ksiazka.Equals(ksiazkaDuplicate));
            Console.WriteLine(ksiazka == ksiazkaDuplicate);

            ksiazka = ksiazkaDuplicate;
            Console.WriteLine(ksiazka.Equals(ksiazkaDuplicate));
            Console.WriteLine(ksiazka == ksiazkaDuplicate);

            Console.ReadKey();

        }
    }
}
