using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV4
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
            int columns = data[0].Length, rows = data.Length;
            double[] array = new double[columns];

            int i, j;
            double sumOfEachColumn = 0;

            for(i = 0; i < columns; i++)
            {
                for(j = 0; j < rows; j++)
                {
                    sumOfEachColumn += data[j][i];
                }
                array[i] = sumOfEachColumn / rows;
                sumOfEachColumn = 0;

            }

            return array;

        }
    }
}
