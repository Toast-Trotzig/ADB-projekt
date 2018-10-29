using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADB_projekt.Utensils
{
    class Utils
    {
        public static Dictionary<string, object> GetParameters(object target)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            if (target != null)
            {
                foreach (var prop in target.GetType().GetProperties())
                {
                    parameters.Add(prop.Name, prop.GetValue(target, null));
                }
            }
            return parameters;
        }
    }
}
