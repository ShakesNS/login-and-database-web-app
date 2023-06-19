using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdooDal
{
    public static class Tools
    {
        //Connection String
        public static string cnnStr
        {
            get
            {
                return @"Server=Z36-08\SQLEXPRESS;Database=db_Deneme;Integrated Security=True";
            }
        }

    }
}
