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
            List<string> employeeList = new List<string>();

            
            for (int i = 1; i < totalTransactions; i++)
            {
                //var transaction = Lines[i];
                string[] words = Lines[i].Split(',');

                Transaction newTransaction = new Transaction();
                newTransaction.NameFrom = words[1];
                newTransaction.NameTo = words[2];
                newTransaction.Balance = words[4];

                ///we can put this into a variable and print that var
                //Console.WriteLine($" {newTransaction.NameFrom} owes {newTransaction.NameTo}, {newTransaction.Balance}");

                transactionList.Add(newTransaction);


                //gets values for employeeList from the instance newTransaction

            
                //if (!employeeList.Contains(newTransaction.NameFrom)) {

                //}

                if (!employeeList.Contains(newTransaction.NameFrom))
                {
                    employeeList.Add(newTransaction.NameFrom);
                }

                //else if (!employeeList.Contains(newTransaction.NameTo))
                //{
                //    employeeList.Add(newTransaction.NameTo);
                //}
                
                //else
                //{
                //    employeeList.Remove(newTransaction.NameFrom);
                //    employeeList.Remove(newTransaction.NameTo);
                //}

               


               
                ////  foreach (string name in employeeList)
                //  {
                //      if (name != newTransaction.NameFrom && name != newTransaction.NameTo)
                //      { 
                //          employeeList.Add(name);
                //      }

                //      Console.WriteLine($" {newTransaction.NameFrom} {Environment.NewLine} {newTransaction.NameTo}");

                //  //}



                ///we can put this into a variable and print that var


                //foreach (string name in employeeList)
                //{
                //    if (newTransaction.NameFrom == employeeList[])
                //    {
                //        employeeList.Add(newTransaction.NameFrom);
                //    }

                //}

                //     StringComparison(newTransaction.NameFrom, newTransaction.NameTo);



            }

            foreach (string name in employeeList)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();

        }

       // 1 Take names from file (cols From and To) and create an Array (or Object) of each one.
       // 2 Give every of the Arrays (objects) an initial value (ex. 500) inside a variable called totalAmount.
       // 3 When name is in the From column means owes money --- totalAmount - amountColumn and we put back this into the variable totalAmount
       // 4 when name is in the To column totalAmount + amountColumn and put back the value into var totalAmount




    }


    
}