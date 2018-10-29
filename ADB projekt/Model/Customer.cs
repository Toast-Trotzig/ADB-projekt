using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADB_projekt
{
    class Customer
    {
        public int PNr { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public string TeleNr { get; set; }

        public Customer ()
        {

        }

        public Customer (int pnr, string name, string email, string telenr)
        {
            PNr = pnr;
            Name = name;
            EMail = email;
            TeleNr = telenr;
        }
    }
}
