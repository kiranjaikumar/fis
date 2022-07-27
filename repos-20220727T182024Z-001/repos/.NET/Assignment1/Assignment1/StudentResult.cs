using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class StudentResult
    {
        int[] cSharp;
        int[] html;
        int[] sql;
        public StudentResult(int num)
        {
            cSharp = new int[num];
            html = new int[num];
            sql = new int[num];
            
        }
        public void acceptMarks(int num)
        {
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter CSharp marks of student {0}",i+1);
                cSharp[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter HTML marks of student {0}", i + 1);
                html[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter SQL marks of student {0}", i + 1);
                sql[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------");
            }

        }
        public void displayResult(int num)
        {
            for(int i=0; i < num; i++)
            {
                int total = cSharp[i] + html[i] + sql[i];
                int avg = total / 3;
                
                if (avg > 50)
                {
                    Console.WriteLine("Student {0} Total Marks: {1} Avg. Marks: {2}  Result: Pass", i + 1, total, avg);
                }
                else
                {
                    Console.WriteLine("Student {0} Total Marks: {1} Avg. Marks: {2}  Result: Fail", i + 1, total, avg);
                }
            }
        }
        public static void Main(String[] args)
        {
            
            int num;
            Console.WriteLine("Enter number of students: ");
            num = int.Parse(Console.ReadLine());
            StudentResult sr = new StudentResult(num);
            sr.acceptMarks(num);
            sr.displayResult(num);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
