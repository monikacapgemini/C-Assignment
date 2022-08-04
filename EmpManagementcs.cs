using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using static ClassLibrary2.Litware;


namespace HRMng
{

    class EmpManagement
    {
        public void method()
        {
            List<string> DeptName = new List<string>();
            DeptName.Add("HR");
            DeptName.Add("Marketing");
            DeptName.Add("Finance");
            DeptName.Add("Sales");
            if (DeptName.Contains("HR"))
            {
                Console.WriteLine("enter employee number");
                int EmpNo = int.Parse(Console.ReadLine());
                Console.WriteLine("enter emp name");
                string empname = Console.ReadLine();
                Console.WriteLine("enter emp salary");
                double Salary = double.Parse(Console.ReadLine());

            }
        }
        static void Main(string[] args)
        {
            try
            {
                Library myObject = new Library();
                myObject.displayEmployees();
                Litware.Main(args);
                EmpManagement p = new EmpManagement();
                p.method();
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}