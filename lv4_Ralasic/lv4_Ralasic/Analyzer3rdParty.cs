using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv4_Ralasic
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int columnCount = data[0].Length;
            int rowCount = data.Length;
            double[] results = new double[columnCount];

            for (int i = 0; i < columnCount; i++)
            {
                double sum = 0;
                for (int j = 0; j < rowCount; j++)
                {
                    sum += data[j][i];
                }
                results[i] = sum / rowCount;
            }
            return results;
        }
    }
}
