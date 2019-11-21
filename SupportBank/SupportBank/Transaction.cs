using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportBank
{
    class Transaction
    {
        public string NameFrom { get; set; }

        public string NameTo { get; set; }

        public string Balance { get; set; }

        /*public string Describe()
        {
            return $"A transaction from {From} to {To} for {Amount}";
        }*/
    }

}
