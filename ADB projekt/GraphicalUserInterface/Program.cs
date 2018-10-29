using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB_projekt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("BRO HERE I AM");
            Dal dal = new Dal();
            Car car = new Car("ABC123", "Class C", "Volvo");
            //Dictionary<string,object> entity = utils.GetParameters(car);

            //dal.HandleEntity("CarCRUD", entity, "Insert");
           // dal.HandleEntity("CarCRUD", entity, "Delete");
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
