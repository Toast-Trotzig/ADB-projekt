using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB_projekt
{
    class Controller
    {
        Dal dal = new Dal();

        public void HandleEnitity(string procedure, Dictionary<string, object> dict, string statement)
        {
            dal.HandleEntity(procedure, dict, statement);
        }

        public void FindCar(string regnr, DataGridView grid)
        {
            dal.FindCar(regnr, grid);
        }

        public void FindCarModels(string classtype, DataGridView grid)
        {
            dal.FindCarModels(classtype, grid);
        }

        public void FindAllCars(DataGridView grid)
        {
            dal.FindAllCars(grid);
        }

        public void FindCustomer(int pnr, DataGridView grid)
        {
            dal.FindCustomer(pnr, grid);
        }

        public void FindBook(string regnr, int pnr, DataGridView grid)
        {
            dal.FindBook(regnr, pnr, grid);
        }
    }
}
