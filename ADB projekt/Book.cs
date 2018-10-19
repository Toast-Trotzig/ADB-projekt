using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADB_projekt
{
    class Book
    {
        public int PNr {get; set;}
        public string RegNr { get; set; }
        public DateTime Date { get; set; }

        public Book ()
        {

        }
        
        public Book (int pnr, string regnr, DateTime date)
        {
            PNr = pnr;
            RegNr = regnr;
            Date = date;
        }
    }
}
