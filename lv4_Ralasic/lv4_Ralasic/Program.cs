using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv4_Ralasic
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            
            Dataset data = new Dataset("data.csv");
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);
            Console.WriteLine("Column average: ");

            double[] columnAverage = adapter.CalculateAveragePerColumn(data);
            for (int i = 0; i < columnAverage.Length; i++)
            {
                Console.WriteLine(columnAverage[i]);
            }
            Console.WriteLine("Row average: ");
            double[] rowAverage = adapter.CalculateAveragePerRow(data);
            for (int i = 0; i < rowAverage.Length; i++)
            {
                Console.WriteLine(rowAverage[i]);
            }

        }
    }
}
