using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADB_projekt
{
    class Car
    {
        public string RegNr { get; set; }
        public string ClassType { get; set; }
        public string Model { get; set; }

        public Car ()
        {

        }

        public Car (string regnr, string classtype, string model)
        {
            RegNr = regnr;
            ClassType = classtype;
            Model = model;
        }
    }
}
