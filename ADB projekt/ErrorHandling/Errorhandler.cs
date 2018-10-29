using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADB_projekt
{
    class Errorhandler
    {
        public String HandleException(Exception ex)
        {
            String errorMessage;

            if (ex.GetBaseException().GetType() == typeof(NullReferenceException))
            {
                errorMessage = "En instans du försöker komma åt existerar inte";
            }

            else if (ex.GetBaseException().GetType() == typeof(IndexOutOfRangeException))
            {
                errorMessage = "Kunde inte hitta det du letar efter";
            }
            else if (ex.GetBaseException().GetType() == typeof(MandatoryFieldException))
            {
                errorMessage = "Vänligen fyll i alla obligatoriska fält";
            }
            else if (ex.GetBaseException().GetType() == typeof(FormatException))
            {
                errorMessage = "Fel format på ett inmatat värde";
            }

            else if (ex.GetBaseException().GetType() == typeof(SqlException))
            {
                SqlException sqlex = (SqlException)ex;
                int errorCode = sqlex.ErrorCode;
                switch (errorCode)
                {

                    case 2627:
                        errorMessage = "Objektet du försöker lägga till existerar redan";
                        break;

                    case -2146232060:
                        errorMessage = "En kund med det Kundid finns redan";
                        break;

                    case 17:
                        errorMessage = "Databasen kan ej nås";
                        break;

                    case 0:
                        errorMessage = "Anslutningen misslyckades, tidsgräns uppnåd";
                        break;
                    default:
                        errorMessage = ex.Message;
                        break;
                }
            }
            else
            {
                errorMessage = "Ett oväntat fel uppstod";
            }
            return errorMessage;
        }
    }
}
