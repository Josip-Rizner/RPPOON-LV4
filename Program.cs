using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV4
{
    class Program
    {
        static void Main(string[] args)
        {



            /*                  2. zadatak
            Dataset dataset = new Dataset("CSV.txt");
            Analyzer3rdParty analyzer3RdParty = new Analyzer3rdParty();
            IAnalytics adapter = new Adapter(analyzer3RdParty);

           
            double[] AvgPerColumn = adapter.CalculateAveragePerColumn(dataset);
            double[] AvgPerRow = adapter.CalculateAveragePerRow(dataset);

            for(int i = 0; i < AvgPerColumn.Length; i++)
            {
                Console.WriteLine(AvgPerColumn[i]);
            }

            for (int i = 0; i < AvgPerRow.Length; i++)
            {
                Console.WriteLine(AvgPerRow[i]);
            }
            */





            /*          3. zadatak
            List<IRentable> rentables = new List<IRentable>();
            RentingConsolePrinter rentingConsolePrinter = new RentingConsolePrinter();

            rentables.Add(new Video("The Lord of the Rings"));
            rentables.Add(new Book("Harry Potter"));

            rentingConsolePrinter.PrintTotalPrice(rentables);
            rentingConsolePrinter.DisplayItems(rentables);
            */



            /*              4. Zadatak
            List<IRentable> rentables = new List<IRentable>();
            RentingConsolePrinter rentingConsolePrinter = new RentingConsolePrinter();

            rentables.Add(new Video("The Lord of the Rings"));
            rentables.Add(new Book("Harry Potter"));
            rentables.Add(new HotItem(new Video("Avengers: Endgame")));
            rentables.Add(new HotItem(new Book("The Chronicles of Narnia")));

            rentingConsolePrinter.PrintTotalPrice(rentables);
            rentingConsolePrinter.DisplayItems(rentables);

            //Svaka hit knjiga i svaki hit film u ispisu ima "Trending:" pod description. Override-ana je metoda
            */





            List<IRentable> rentables = new List<IRentable>();
            RentingConsolePrinter rentingConsolePrinter = new RentingConsolePrinter();

            rentables.Add(new Video("The Lord of the Rings"));
            rentables.Add(new Book("Harry Potter"));
            rentables.Add(new HotItem(new Video("Avengers: Endgame")));
            rentables.Add(new HotItem(new Book("The Chronicles of Narnia")));
            rentables.Add(new DiscountedItem(new Video("The replacements")));
            rentables.Add(new DiscountedItem(new Book("Junaci Pavlove ulice")));

            rentingConsolePrinter.PrintTotalPrice(rentables);
            rentingConsolePrinter.DisplayItems(rentables);
        }
    }   
}
