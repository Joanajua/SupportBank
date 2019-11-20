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

            var transactionList = new Transaction[Lines.Length];

            var transaction = new Transaction();
            transaction.narrative = "hello";
            transaction.amount = "700";
            transaction.Date = "14/2/15";
            transaction.From = "Jon";
            transaction.To = "Amy";

            transactionList[0] = transaction;

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



            for (int i = 0; i < Lines.Length; i++)
            {
                if (transactionList[i] != null)
                {
                    Console.WriteLine(transactionList[i].Describe());
                } 
            }

            // Return the values.
            //Console.Write (values.ToString());
            Console.ReadLine();
        }

        class Transaction
        {
            public string Date;
            public string From;
            public string To;
            public string narrative;
            public string amount;

            public string Describe()
            {
                return $"A transaction from {From} to {To} for {amount}";
            }
        }

       


    }


    
}
