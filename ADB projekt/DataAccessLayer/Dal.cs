using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace ADB_projekt
{
    class Dal {
        
        //Insert or Delete entities from database
        public void HandleEntity(string procedure, Dictionary<string, object> dict, string statement)
        {
            using (SqlConnection con = DBsecurity.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(procedure, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var item in dict)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
                cmd.Parameters.AddWithValue("@StatementType", statement);
                cmd.ExecuteNonQuery();
            }
        }

        //Find cars in database
        public void FindCar(string regnr, DataGridView grid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@regNr", regnr);
            FindEntities("CarCRUD", parameters, grid);
        }

        //Find models of car classtypes
        public void FindCarModels(string classtype, DataGridView grid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@classType", classtype);
            FindEntities("CarCRUD", parameters, grid);
        }

        public void FindAllCars(DataGridView grid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            FindEntities("CarCRUD", parameters, grid);
        }

        //Find customers in database
        public void FindCustomer(int pnr, DataGridView grid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pNr", pnr);
            FindEntities("CustomerCRUD", parameters, grid);
        }

        //Find bookings in database
        public void FindBook(string regnr, int pnr, DataGridView grid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@regNr", regnr);
            parameters.Add("@pNr", pnr);
            FindEntities("BookCRUD", parameters, grid);
        }

        //Find entities in database
        public void FindEntities(string procedure, Dictionary<string, object> parameters, DataGridView grid)
        {
            using (SqlConnection con = DBsecurity.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(procedure, con);
                DataTable table = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var item in parameters)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
                cmd.Parameters.AddWithValue("@StatementType", "Select");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                grid.DataSource = new BindingSource(table, null);
            }
            
        }
    }
}
