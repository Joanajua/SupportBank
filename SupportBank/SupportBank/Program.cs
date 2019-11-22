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

            string[] Lines = File.ReadAllLines(@"../../../Transactions2014.csv");

            int totalTransactions = Lines.Length;

            List<Transaction> transactionList = new List<Transaction>();
            List<string> employeeNamesList = new List<string>();
            List<Accounts> accountsList = new List<Accounts>();

            Console.WriteLine("LIST OF TRANSACTIONS \n");

            for (int i = 1; i < totalTransactions; i++)
            {

                string[] column = Lines[i].Split(',');

                Transaction newTransaction = new Transaction();
                newTransaction.NameFrom = column[1];
                newTransaction.NameTo = column[2];
                newTransaction.Amount = column[4];


                Console.WriteLine($" {newTransaction.NameFrom} owes {newTransaction.NameTo}, {newTransaction.Amount}");

                transactionList.Add(newTransaction);


                //Compares if the names from newTransaction.NameFrom are already in the employeeNamesList, and if they are not
                //it adds them to the employeeNamesList


                if (!employeeNamesList.Contains(newTransaction.NameFrom))
                {
                    employeeNamesList.Add(newTransaction.NameFrom);
                }
            }

            

            //We are taking every name from employeeNamesList and comparing it to the names inside the transactionList

            for (int i = 0; i < employeeNamesList.Count; i++)
            {
                Accounts newAccounts = new Accounts();
                newAccounts.EmployeeName = employeeNamesList[0];
                newAccounts.Balance = 0;

                for (int r = 0; r < transactionList.Count; r++)
                {
                    decimal amountDecimal = decimal.Parse(transactionList[r].Amount);
                    if (transactionList[r].NameFrom == employeeNamesList[i])
                    {
                        newAccounts.Balance -= amountDecimal;
                    }
                    else if (transactionList[r].NameTo == employeeNamesList[i])
                    {
                        newAccounts.Balance += amountDecimal;
                    }
                }
                
            }
            Console.WriteLine("\nEMPLOYEES\' BALANCE \n");


            foreach (Accounts account in accountsList)
            {
               
                Console.WriteLine(account.EmployeeName + " " + account.Balance);
            }

            

            Console.WriteLine("\n LIST OF NAMES \n");

            //Prints the names inside employeeNamesLists
            foreach (string name in employeeNamesList)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();

        }


    }


    
}