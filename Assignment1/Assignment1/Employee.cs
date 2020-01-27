using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Assignment1
{
    public class Employee
    {
        public delegate void ActionTaken(string[] msg, int i);
        public event ActionTaken Action;
        public string[] s = new string[3];
        public int i;
        public void ActionPerformed()
        {
            Action(s, i);
        }
        private int Id;
        private string emp_name;
        private string dept_name;
        public Employee(int Id, string emp_name, string dept_name)
        {
            this.Id = Id;
            this.emp_name = emp_name;
            this.dept_name = dept_name;
        }
        public int GetId(Employee E1)
        {
            i = 0;
            s[0] = MethodBase.GetCurrentMethod().Name;
            E1.Action += new Employee.ActionTaken(Action_Shown);
            E1.ActionPerformed();
            return this.Id;

        }
        public string GetName(Employee E1)
        {
            i = 1;
            s[1] = MethodBase.GetCurrentMethod().Name;
            E1.Action += new Employee.ActionTaken(Action_Shown);
            E1.Action -= new Employee.ActionTaken(Action_Shown);
            E1.ActionPerformed();
            return this.emp_name;
        }
        public string GetDepartmentName(Employee E1)
        {
            i = 2;
            s[2] = MethodBase.GetCurrentMethod().Name;
            E1.Action += new Employee.ActionTaken(Action_Shown);
            E1.Action -= new Employee.ActionTaken(Action_Shown);
            E1.ActionPerformed();
            return this.dept_name;
        }
        static void Action_Shown(string[] msg, int i)
        {
            Console.WriteLine(msg[i] + "  method called");
        }
        public void set(int uid)
        {
            Id = uid;
            Console.WriteLine("Updated Id: " + Id);

        }
        public void set(string name)
        {
            emp_name = name;
            Console.WriteLine("Updated employee name:" + emp_name);
        }
        public void set(string name, int Id)
        {
            dept_name = name;
            Console.WriteLine("Updated Department Name:" + dept_name);
        }
    }
}
