using System.Collections.Generic;

namespace Mean_Class_Library

{
    class Statistics
    {
        double mean;
        double[] data_array;
        int m;
        public double Mean(IEnumerable<double> data)
        {
            foreach (double element in data)
            {
                if (element == double.NaN)
                {
                    return double.NaN;
                }
            }

            data_array = data as double[];
            for (int i = 0; i < data_array.Length; i++)
            {
                mean += (data_array[i] - mean) / ++m;
            }
            return mean;
        }
    }

}