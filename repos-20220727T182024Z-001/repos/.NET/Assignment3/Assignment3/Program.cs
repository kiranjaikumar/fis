using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Employee
    {
        int empId;
        string name;
        string department;
        string address;
        string city;
        string empType;
        double slary=25000;
        public int EmpId
        {
            get
            {
                return empId;
            }
            set
            {
                empId = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public double Salary
        {
            get { return slary; }
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
        public string EmpType
        {
            get { return empType; }
            set { empType = value; }
        }
        public virtual void Accept()
        {
            Console.WriteLine("Base accept");
        }
        public virtual void Display()
        {
            Console.WriteLine("Base display");
        }
    }
    class PermanentEmployee: Employee
    {
        int leaves;
        double pf;
        public int Leaves
        {
            get { return leaves; }
            set { leaves = value; }
        }
        public double PF
        {
            get { return pf; }
            set { pf = value; }
        }

        public override double GetSalary()
        {

            return base.GetSalary()+pf;
        }
        public override void Accept()
        {
            // Console.WriteLine("Permanent accept called");
            Console.WriteLine("Enter employee Id");
            EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter employee Department");
            Department = Console.ReadLine();
            Console.WriteLine("Enter employee Address");
            Address = Console.ReadLine();
            Console.WriteLine("Enter employee City");
            City = Console.ReadLine();
            Console.WriteLine("Enter employee PF");
            pf = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter employee Leaves");
            leaves = int.Parse(Console.ReadLine());


        }
        public override void Display()
        {
            // Console.WriteLine("Permanent display called");
            Console.WriteLine("---------------------");
            Console.WriteLine("Employee Details");
            Console.WriteLine("---------------------");
            Console.WriteLine("Emp ID: {0}", EmpId);
            Console.WriteLine("name: {0}",Name);
            Console.WriteLine("Department: {0}", Department);
            Console.WriteLine("Employee Type: {0}", EmpType);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("City: {0}",City);
            Console.WriteLine("PF: {0}",pf);
            Console.WriteLine("Leaves: {0}",leaves);
            Console.WriteLine("Total Salary: {0}", GetSalary());


        }

    }
    class ContractEmployee: Employee
    {
        double perk;
        public double Perk
        {
            get { return perk; }
            set { perk = value; }
        }

        public override double GetSalary()
        {
            return base.GetSalary()+perk;
        }

        public override void Accept()
        {
            //  Console.WriteLine("Contract accept called");
            Console.WriteLine("Enter employee Id");
            EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter employee Department");
            Department = Console.ReadLine();
            Console.WriteLine("Enter employee Address");
            Address = Console.ReadLine();
            Console.WriteLine("Enter employee City");
            City = Console.ReadLine();
            Console.WriteLine("Enter employee Perk");
            perk = Convert.ToDouble(Console.ReadLine());
           


        }
        public override  void Display()
        {
            // Console.WriteLine("Contract display called");
            Console.WriteLine("---------------------");
            Console.WriteLine("Employee Details");
            Console.WriteLine("---------------------");
            Console.WriteLine("Emp ID: {0}", EmpId);
            Console.WriteLine("name: {0}", Name);
            Console.WriteLine("Department: {0}", Department);
            Console.WriteLine("Employee Type: {0}", EmpType);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("City: {0}", City);
            Console.WriteLine("Perk: {0}", perk);
            Console.WriteLine("Total Salary: {0}", GetSalary());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            do
            {
            EmployeeType:
                Employee emp;
                Console.WriteLine("Select Type of Employee: \n1. Permanent Employee \n2. Contract Employee");
                ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                 emp = new PermanentEmployee();
                    emp.EmpType = "Permanent Emplyee";
                }
                else if (ch == 2)
                {
                 emp = new ContractEmployee();
                    emp.EmpType = "Contract Emplyee";
                }
                else
                {
                    Console.WriteLine("Wrong choice");
                    goto EmployeeType;
                }
                OperationType:
                Console.WriteLine("---------------------");
                Console.WriteLine("Select your choice:\n1. Insert employee details. \n2. Display Employee details \n3. Switch emp type \n4. Exit");
                ch = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                switch (ch)
                {
                    case 1:
                        emp.Accept();
                        goto OperationType;
                        
                    case 2:
                        emp.Display();
                        goto OperationType;
                    case 3:
                        goto EmployeeType;
                      
                    case 4:
                        Console.WriteLine("Bye..");
                        break;

                    default:

                        Console.WriteLine("Wrong Choice");
                        goto OperationType;
                        
                }
            } while (ch != 4);
        }
    }
}
