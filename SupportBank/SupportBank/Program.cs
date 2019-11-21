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

            int totalTransactions = Lines.Length;

            List<Transaction> transactionList = new List<Transaction>();
            //List<Employee> employeeList = new List<Employee>();

            for (int i = 1; i < totalTransactions; i++)
            {
                var transaction = Lines[i];
                string[] words = Lines[i].Split(',');

                Transaction newTransaction = new Transaction();
                newTransaction.NameFrom = words[1];
                newTransaction.NameTo = words[2];
                newTransaction.Balance = words[4];

            
                Console.WriteLine($" {newTransaction.NameFrom} owes {newTransaction.NameTo}, {newTransaction.Balance}");

                transactionList.Add(newTransaction);


                //Console.WriteLine(words[4]);
            }



            // Print all transactions
            foreach (Transaction transaction in transactionList)
            {
                Console.WriteLine($"Transaction from {transaction.NameFrom} to {transaction.NameTo} for amount {transaction.Balance}");
            }

            // Print all employees
            //foreach (Employee employee in employeeList)
            //{
            //    Console.WriteLine($"Employee {employee.Name} has balance {employee.Balance}");
            //}




            /* var transactionList = new Transaction[Lines.Length];

             var transaction = new Transaction();

             transaction.Date = "14/2/15";
             transaction.From = "Jon";
             transaction.To = "Amy";
             transaction.Narrative = "hello";
             transaction.Amount = "700";

             transactionList[0] = transaction;*/


            // create a new transaction
            // assign the date variable


            Console.ReadLine();
        }

       // 1 Take names from file (cols From and To) and create an Array (or Object) of each one.
       // 2 Give every of the Arrays (objects) an initial value (ex. 500) inside a variable called totalAmount.
       // 3 When name is in the From column means owes money --- totalAmount - amountColumn and we put back this into the variable totalAmount
       // 4 when name is in the To column totalAmount + amountColumn and put back the value into var totalAmount




    }


    
}
