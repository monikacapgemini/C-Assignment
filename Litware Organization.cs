using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using static ClassLibrary2.Litware;

namespace ConsoleApp6
{
    class LitwareOrganization
    {
        public static void Main(string[] args)
        {
            try
            {
                Library myObject = new Library();
                myObject.displayEmployees();
                Litware.Main(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();


        }
    }
}
