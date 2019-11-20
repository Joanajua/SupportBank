using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the file's text.
            string [] Lines = File.ReadAllLines(@"../../../Transactions2014.csv");

            // Split into lines.
            //readCsv = readCsv.Remove('\n');
            //string[] lines = readCsv.Split(new char[] { '\n' });

            // See how many rows and columns there are.
            int num_rows = Lines.Length;
            int num_cols = Lines[0].Split(',').Length;


            // Allocate the data array.
            string[,] values = new string[num_rows, num_cols];

            // Load the array.
            for (int r = 0; r < num_rows; r++)
            {
                string[] line_r = Lines[r].Split(',');
                for (int c = 0; c < num_cols; c++)
                {
                    values[r, c] = line_r[c]; //class
                }
            }

            // Return the values.
            Console.Write (values.ToString());
            Console.ReadLine();
        }


    }


    
}
