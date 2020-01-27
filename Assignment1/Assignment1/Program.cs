using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Assignment1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the employee ID");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name of Employee");
            string e_name = Console.ReadLine();
            Console.WriteLine("Enter Department of Employee");
            string d_name = Console.ReadLine();
            Employee E1 = new Employee(Id, e_name, d_name);
            int id = E1.GetId(E1);
            Console.WriteLine("Employee ID:" + id);
            string ename = E1.GetName(E1);
            Console.WriteLine("Employee Name:" + ename);
            string dname = E1.GetDepartmentName(E1);
            Console.WriteLine("Department Name Of Employee:" + dname);
            Console.WriteLine("Enter Id to Update ");
            int update_id = Convert.ToInt32(Console.ReadLine());
            E1.set(update_id);
            Console.WriteLine("Enter name of employee to Update ");
            string update_ename = Console.ReadLine();
            E1.set(update_ename);
            Console.WriteLine("Enter Department name to Update ");
            string update_dname = Console.ReadLine();
            E1.set(update_dname, 0);

        }


    }
}
