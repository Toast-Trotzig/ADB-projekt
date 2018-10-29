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
                errorMessage = "Please fill all mandatory fields.";
            }
            else if (ex.GetBaseException().GetType() == typeof(FormatException))
            {
                errorMessage = "Fel format på ett inmatat värde";
            }

            else
            {
                errorMessage = "Ett oväntat fel uppstod";
            }
            return errorMessage;
        }
    }
}
