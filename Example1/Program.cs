using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet1TableAdapters.tbl_employeesTableAdapter t = new DataSet1TableAdapters.tbl_employeesTableAdapter();

            foreach(var x in t.GetData())
            {
                Console.WriteLine(x.first_name);
            }
        }
    }
}
