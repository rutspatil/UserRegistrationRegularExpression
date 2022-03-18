using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegularExPr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello all welcome to User Registration Regex");
            bool flag = true;
            while (flag)
            {

                Console.WriteLine("Enter Program number to get executed \n1. Validate first name \n2.Validate Lastname " +
                    "\n3. Validate EmailID \n4. Exit");
                ValidationRegex Checkpattern = new ValidationRegex();
                int option = Convert.ToInt32(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        Console.WriteLine("*First letter should be capital.");
                        Console.WriteLine("*length should be Minimum three characters.");
                        Console.WriteLine("Enter First name :");
                        string fname = Console.ReadLine();
                        Checkpattern.Checkfirstname(fname);
                        break;
                    case 2:
                        Console.WriteLine("*First letter should be capital.");
                        Console.WriteLine("*length should be Minimum three characters.");
                        Console.WriteLine("Enter Last name :");
                        string lname = Console.ReadLine();
                        Checkpattern.Checklastname(lname);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email id :");
                        string email = Console.ReadLine();
                        Checkpattern.Checkemail(email);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

