using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExample
{
    public class GeneralSettings
    {
        private static bool IsDebug = true;

        public static string ConnectionSeting
        {
            get
            {
                if (IsDebug)
                    return "Server=KAMILKAPLAN;Database=BootcampDB;User Id=sa;Password=1;";
                return "";
            }
        }

        public static string GetConnectionString()
        {
            return "Server=KAMILKAPLAN;Database=BootcampDB;User Id=sa;Password=1;";
        }
    }
}
