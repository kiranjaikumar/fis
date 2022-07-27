using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class StringOperations
    {
        public int findLength(string str)
        {
            return str.Length;
        }
        public string reverseString(string str)
        {
            char[] reverseString = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i<j; i++, j--){
                char c = reverseString[i];
                reverseString[i] = reverseString[j];
                reverseString[j] = c;
            }
            return new string(reverseString);
        }
        public static void Main(String[] args)
        {
            int ch;
            do
            {
                StringOperations so = new StringOperations();
                Console.WriteLine("------------------------");
                Console.WriteLine("Enter Your Choice: \n1. Find length of string \n2. Reverse String \n3. Compare two strings \n4. Exit");
                Console.WriteLine("------------------------");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter a string to find length: ");
                        string str = Console.ReadLine();
                        Console.WriteLine("Length of {0} is : {1}",str, so.findLength(str));
                        break;
                    case 2:
                        Console.WriteLine("Enter a string to reverse it: ");
                        string str2 = Console.ReadLine();
                        Console.WriteLine("Reverse of {0} is : {1}", str2, so.reverseString(str2));
                        break;
                    case 3:
                        Console.WriteLine("Enter 1st string: ");
                        string str3 = Console.ReadLine();
                        Console.WriteLine("Enter 2nd string: ");
                        string str4 = Console.ReadLine();
                        if (str3.Equals(str4))
                        {
                            Console.WriteLine("{0} and {1} are equal.",str3,str4);
                        }
                        else
                        {
                            Console.WriteLine("{0} and {1} are not equal.", str3, str4);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Bye...!");
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            } while (ch != 4);

        }
    }
}
