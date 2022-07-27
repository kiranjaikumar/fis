using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Marks
    {
        int rollNo;
        string name;
        int sem;
        string batch;
        string branch;
        int[] marks;
        bool flag=true;
        int subjectCount;
        public Marks(int rollNo, string name, int sem, string branch, string batch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.sem = sem;
            this.branch = branch;
            this.batch = batch;
        }
        public void insertMarks(int num)
        {
            this.subjectCount = num;
            marks = new int[num];
            for(int i=0; i < num; i++)
            {
                Console.WriteLine("Enetr marks for subject {0} :",i+1);
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public void displayResult()
        {
            Console.WriteLine("Marks for the all subjects are as below:");
            Console.WriteLine();
            int total=0;
            foreach(int j in marks)
            {
                Console.Write(j + ", ");
                if (j > 35)
                {
                    total += j;
                }
                else
                {
                    flag = false;
                    total += j;
                }
            }
            Console.WriteLine("Total Marks: {0}",total);
            if (flag == false)
            {
                Console.WriteLine("Result: FAIL. Better luck next time (One or more subject has less than or equal to 35 marks)");
            }
            else if (total/subjectCount<50)
            {
                Console.WriteLine("Result: FAIL. Better luck next time (Average score is less than or equal to 50): {0}",total/subjectCount);
            }
            else{
                Console.WriteLine("Congratulations....! Result: PASS, Score: {0}%",total/subjectCount);
            }
        }

        public void displayDetails()
        {
            
            Console.WriteLine("Student Name: {0}",name);
            Console.WriteLine("Roll No: {0}",rollNo);
            Console.WriteLine("Class/ Branch: {0}",branch);
            Console.WriteLine("Sem: {0}",sem);
            Console.WriteLine("Batch: {0}", batch);

            displayResult();
           
        }

    }
    class StudentResult
    {
        public static void Main()
        {
            int rollNo;
            string name;
            int sem;
            string batch;
            string branch;
            int subjectCount;
            Console.WriteLine("Enetr student name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter roll no: ");
            rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Branch name");
            branch = Console.ReadLine();
            Console.WriteLine("Enter Sem No: ");
            sem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enetr Batch/ Division: ");
            batch = Console.ReadLine();
            Console.WriteLine("Enter total subject count: ");
            subjectCount = int.Parse(Console.ReadLine());

            Marks mm = new Marks(rollNo, name, sem,branch,  batch);
            mm.insertMarks(subjectCount);
            int ch;
            do
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Select your choice:\n1. Display Result \n2. Display all details with result \n3. Exit");
                ch = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------");
                switch (ch)
                {
                    case 1:
                        mm.displayResult();
                        break;
                    case 2:
                        mm.displayDetails();
                        break;
                    case 3:
                        Console.WriteLine("Bye...!");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
               

            } while (ch != 3);






        }
    }
}
