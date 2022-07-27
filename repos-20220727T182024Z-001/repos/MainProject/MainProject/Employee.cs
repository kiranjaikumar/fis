using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace MainProject
{
    public class Employee
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        List<Employee> employeelist = new List<Employee>();

        public string Login(string userid, string password)
        {
            if(string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(password))
            {
                return "User Id or Password cannot be Empty";
            }
            else if (userid=="Admin" && password=="Admin123")
            {
                return "Welcome Admin";
            }
            else
                return "Invalid User Id or Password";
        }

        public List<Employee> AllEmployess()
        {
            employeelist.Add(new Employee { ID = 100, Fname = "Parihar", Lname = "Kushwant", Gender = "Male", Salary = 35000 });
            employeelist.Add(new Employee { ID = 101, Fname = "Meghana", Lname = "Kurimi", Gender = "Female", Salary = 40000 });
            employeelist.Add(new Employee { ID = 102, Fname = "Deepak", Lname = "S", Gender = "Male", Salary = 45000 });
            employeelist.Add(new Employee { ID = 103, Fname = "Aakash", Lname = "Aanchal", Gender = "Male", Salary = 37000 });

            return employeelist;
        }

        public string GetName(string fname, string lname)
        {
            return string.Concat(fname + lname);
        }

        public List<Employee> GetEmployeeById(int id) 
        {
            List<Employee> e = (from emp in employeelist
                                where emp.ID == id
                                select emp).ToList();

            if (e != null)
            {
                return e;
            }
            else
                e = null;
            return e;
        }

        public static void Main()
        {

        }
    }
}
