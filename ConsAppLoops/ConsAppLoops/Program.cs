﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num;
            //string choice;
            //do
            // {
            //Console.WriteLine("Enter # to find out table of the #");
            //num = int.Parse(Console.ReadLine());
            // Console.WriteLine($"Table of {num} as follows:");
            // for (int i = 1; i <= 10; i++)
            //{
            //Console.WriteLine($"{num} * {i}=\t{num * i}");
            // }
            // Console.WriteLine("Wanna learn more?? If yes, press y \n To exit press any other key");
            //choice = Console.ReadLine().ToLower();
            //}
            //while (choice == "y");

            //Question for practice

            // {

            //{
            // Console.WriteLine("Enter username: ");
            //string username = Console.ReadLine();

            //  Console.WriteLine("Enter password: ");
            //string password = Console.ReadLine();

            //  if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            //{
            // Console.WriteLine("Please provide a username and password.");
            //  }
            //else if (username == "admin1256" && password == "admin@1256@1256")
            // {
            // Console.WriteLine("Sign-in successful!");
            // }
            //else
            // {
            // Console.WriteLine("Invalid user.");
            //}

            //  Console.ReadLine();
            //}
            // }
            // var myNum = 12;
            //var myString = "Sum";
            // var status = true;
            //var grade = 'A';
            //Console.WriteLine("Value Stored in myNum is :" + myNum + "\n Data Type : " + myNum.GetType());
            //  Console.WriteLine("Value Stored in myString is :" + myString + "\n Data Type : " + myString.GetType());
            //Console.WriteLine("Value Stored in myNum is :" + status + "\n Data Type : " + status.GetType());
            //Console.WriteLine("Value Stored in myNum is :" + grade + "\n Data Type : " + grade.GetType());
            //var myNum = 12;
            // dynamic myDynamic = 45;
            //Console.WriteLine("Value Stored in myDynamic is: "+myDynamic+"\n DataType Stored is:\t "+myDynamic.GetType());
            // myDynamic = "I am Sam";
            //Console.WriteLine("Value Stored in myDynamic is: " + myDynamic + "\n DataType Stored is:\t " + myDynamic.GetType());
            //myDynamic = 'A';
            //Console.WriteLine("Value Stored in myDynamic is: " + myDynamic + "\n DataType Stored is:\t " + myDynamic.GetType());
            // Console.WriteLine("Value Stored in myNum is: " + myNum + "\n DataType Stored is:\t " + myNum.GetType());



            //Console.ReadKey();

            //try{
            // double num1, num2,result;
            // Console.WriteLine("Enter First Number");
            // num1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter Second Number");
            // num2 = int.Parse(Console.ReadLine());
            // result = num1 / num2;
            // Console.WriteLine($"Result after dividing{num1} by {num2} is = \t {result}");
            //}
            // catch (Exception ex) { Console.WriteLine("Error!!!"+ex.Message); }
            // finally
            //{
            //   Console.ReadKey();
            // }
            //try
            //{
            //   Console.WriteLine("Please enter a number");
            //  string input = Console.ReadLine();

            // if (int.TryParse(input, out int result))
            //{
            //     Console.WriteLine("Parsed Number using inTryParse is: \t "+ result);
            // }
            // else
            // {
            //  Console.WriteLine("Failed to Parse");
            // }
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("Error!!!" + ex.Message); }
            // finally
            //{
            //   Console.ReadKey();
            //}



            // double num1, num2, result;
            //Console.WriteLine("Enter First Number");
            //double.TryParse(Console.ReadLine(), out num1);
            //Console.WriteLine("Enter Second number");
            //double.TryParse(Console.ReadLine(), out num2);
            //result = num1 / num2;
            // Console.WriteLine($"Result after dividing {num1} by {num2} is = \t {result}");

            // Console.ReadKey();

            try
            {
                string input = null;
                int tryParsedInt;
                int.TryParse(input, out tryParsedInt);
                //Console.WriteLine("Parsed Number is : \t + parsedNumber");
                //int parsedNumber = int.Parse(Console.ReadLine());
                //Console.WriteLine("Parsed Number is : \t " + parsedNumber);
               // Console.WriteLine("Enter a Number");
                //int convertedNumber = Convert.ToInt32(input);
               // Console.WriteLine("Convert Number is : \t " + convertedNumber);
               //Console.WriteLine("TryParsed number is "+tryparsedInt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

            }
            
        }
    }

    

