using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ArrayOperations
    {
        int[] marksArray;
        public void CreateArray(int num)
        {
            marksArray = new int[num];
        }
        public void insertMarks(int num)
        {
            for(int i=0; i < num; i++)
            {
                int marks=0;
                Console.WriteLine("Enter marks for subject {0}", i+1);
                marks = int.Parse(Console.ReadLine());
                marksArray[i] = marks;
            }
        }
        public int findTotal()
        {
            int total = 0;
            foreach(int m in marksArray)
            {
                total = total + m;
                
            }
            return total;
        }

        public int avgMarks()
        {
            int avg=findTotal()/marksArray.Length;
            return avg;
        }

        public int minMarks()
        {
            int min = marksArray[0];
            foreach(int marks in marksArray)
            {
                if (marks < min)
                {
                    min = marks;
                }
            }
            return min;
        }
        public int maxMarks()
        {
            int max = marksArray[0];
            foreach (int marks in marksArray)
            {
                if (marks > max)
                {
                    max = marks;
                }
            }
            return max;
        }

        public void sortAscending()
        {
            Array.Sort(marksArray);
            Console.WriteLine("Marks in ascending order");
            foreach (int marks in marksArray)
            {
                Console.Write(marks + " "); 
            }
            Console.WriteLine();
        }
        public void sordDescending()
        {
            Array.Reverse(marksArray);
            Console.WriteLine("Marks in descending order:");
            foreach(int marks in marksArray)
            {
                Console.Write(marks+" ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayOperations arr = new ArrayOperations();
            int num;
            Console.WriteLine("Enetr number subjects: ");
            num = Convert.ToInt32(Console.ReadLine());
            arr.CreateArray(num);
            arr.insertMarks(num);
            int ch;
            do
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Slect your choice: \n1. Total Marks \n2. Average Marks \n3. Min. Marks \n4. Max. Marks \n5. Marks in Ascending Order \n6. Marks in Descending Order \n7. Exit");
                Console.WriteLine("-------------------------");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Total of marks: {0}",arr.findTotal());
                        break;
                    case 2:
                        Console.WriteLine("Average of marks: {0}", arr.avgMarks());
                        break;
                    case 3:
                        Console.WriteLine("Min. Marks: {0}", arr.minMarks());
                        break;
                    case 4:
                        Console.WriteLine("Max. Marks: {0}", arr.maxMarks());
                        break;
                    case 5:
                        arr.sortAscending();
                        break;
                    case 6:
                        arr.sordDescending();
                        break;
                    case 7:
                        Console.WriteLine("Bye....!");
                        break;
                    default:
                        Console.WriteLine("Wrong Choice....!");
                        break;

                }
            } while (ch != 7);


        }
    }
}
