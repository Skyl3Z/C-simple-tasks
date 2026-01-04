using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exercise 1

            //string name = "skylez";

            //string number = "+995 599 41 63 19";

            //int age = 17;

            //Console.WriteLine(name);
            //Console.WriteLine(number);
            //Console.WriteLine(age);

            //var name1 = "skylez";

            //var age1 = 20;


            // exercise 2

            //int a = 17;
            //int b = 3;

            //int r = a % b;
            //Console.WriteLine(r);

            //b = 4;

            //int r2 = a % b;
            //Console.WriteLine(r2); 


            // exercise 3

            //Console.WriteLine("enter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    //Console.WriteLine($"{i} * {num} = {i * num}");
            //    Console.WriteLine("{0} * {1} = {2}", i, num, i * num);
            //}


            //for (int i = 0; i <= 15; i++)
            //{
            //    if (i % 3 == 0 && i % 5 ==0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            // exercise 4

            //Console.WriteLine("type a message:");
            //string message = Console.ReadLine();

            //for (int i = 0; i < message.Length; i++)
            //{
            //    Console.WriteLine(message[i]);
            //}


            //for (int i = message.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(message[i]);


            // exercise 5


            //bool isValid = true;

            //while (isValid)
            //{
            //    Console.WriteLine("Enter a password:");
            //    string password = Console.ReadLine();

            //    Console.WriteLine("Confirm your password:");
            //    string confirmPassword = Console.ReadLine();

            //    if (!password.Equals("") && !confirmPassword.Equals(""))
            //    {
            //        if (password.Equals(confirmPassword))
            //        {
            //            Console.WriteLine("Passwords match");
            //            isValid = false;
            //        } else
            //        {
            //            Console.WriteLine("Passwords don't match");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a password");
            //    }
            //}


            // exercise 6

            //List<int> odds = new List<int>();
            //List<int> evens = new List<int>();

            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        evens.Add(i);
            //    }
            //    else
            //    {
            //        odds.Add(i);
            //    }
            //}

            //foreach (int num in odds)
            //{
            //    Console.WriteLine(num); 
            //}

            //foreach (int num  in evens)
            //{
            //    Console.WriteLine(num);
            //}


            // exercise 7

            //int num = 10;
            //int num1 = 0;
            //int length = 5;

            //int[] arr = new int[5];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = num1 + num;
            //    num1 += num;

            //}

            //foreach (int n in arr)
            //{
            //    Console.WriteLine(n);
            //}


            // exercise 8

            //int[] arr = new int[]
            //{ 
            //    1, 2, 3, 4, 5, 6
            //};



            //if (sumOfArr(arr, out int sum))
            //{ 
            //    Console.WriteLine($"Sum:{sum}");
            //} else
            //{
            //    Console.WriteLine("Array is empty");
            //}


            // exercise 9

            //bool success = false;

            //while (!success) 
            //{
            //    try
            //    {
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        success = true;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine($"error message: {e.Message}");
            //    }

            //    Console.WriteLine(success ? "Yey" : "oh no");
            //}1

            //if (int.TryParse(Console.ReadLine(), out int result))
            //{
            //    Console.WriteLine("Yey" + result);
            //}
            //else
            //{
            //    Console.WriteLine("oh no");
            //}


            int x = 1;
            string y = "1";
            int y1 = Convert.ToInt32(y);

            Console.WriteLine(x.Equals(y1));

        }
        
        static bool TryParse(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            } catch (Exception)
            {
                return false;
            }

            
        }

        static double calculateArea(int w, int h)
        {
            return w * h / 2D;
        }

        static bool sumOfArr(int[] arr, out int sum)
        {
            sum = 0;

            if (arr.Length > 0)
            {
                foreach (int n in arr)
                {
                    sum += n;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
} 
