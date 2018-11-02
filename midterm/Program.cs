using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int min_hr = 8;
            Console.WriteLine("*** TOTAL WAGE ACCORDING TO DESIGNATION AS FOLLOWS : *** ");
            Console.WriteLine("MANAGER : 1500 RS ");
            Console.WriteLine("SUPERVISOR : 1200 RS ");
            Console.WriteLine("WORKER : 800 RS ");
            Console.WriteLine("what is your working hour ? ");
            min_hr = Convert.ToInt32(Console.ReadLine());
            if(min_hr<5)
            {
                Console.WriteLine("today is halfday");
            }
            else
            {
                Console.WriteLine("it is a normal working day");
            }


            Console.WriteLine("calculating bonus for extra hours : ");
            Console.WriteLine("1 : extra hour for manager ");
            Console.WriteLine("2 : extra hour for supervisor ");
            Console.WriteLine("3 : extra hour for worker ");
            Console.WriteLine("4 : exit ");
            Console.WriteLine("enter your choice : ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1: int wage = 1500;
                    Console.WriteLine("enter your working hour ? ");
                    min_hr = Convert.ToInt32(Console.ReadLine());
                    
                    if (min_hr>8)
                    {

                        wage = wage + (wage * 20/100) ;
                        Console.WriteLine("your wage is : " + wage);
                    }
                    else
                    {
                        Console.WriteLine("salary remains same no extra bonus!!");
                    }

                    break;
                case 2:
                    int wages = 1200;
                    Console.WriteLine("enter your working hour ? ");
                    min_hr = Convert.ToInt32(Console.ReadLine());

                    if (min_hr > 8)
                    {

                        wages = wages + (wages * 20 / 100);
                        Console.WriteLine("your wage is : " + wages);
                    }
                    else
                    {
                        Console.WriteLine("salary remains same no extra bonus!!");
                    }

                    break;
                case 3:
                    int sal = 800;
                    
                    Console.WriteLine("enter your working hour ? ");
                    min_hr = Convert.ToInt32(Console.ReadLine());

                    if (min_hr > 8)
                    {
                        
                            sal = sal + (sal * 20 / 100);
                            
                        
                        Console.WriteLine("your wage is : " + sal);


                    }
                    else
                    {
                        Console.WriteLine("salary remains same no extra bonus!!");
                    }
                    
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }

            Console.ReadLine();


            Console.WriteLine(" displaying daily waise pay for person ");
            Console.WriteLine("tell your designation : ");
            Console.WriteLine("1 : manager ");
            Console.WriteLine("2 : supervisor ");
            Console.WriteLine("3 : worker ");
            Console.WriteLine("4 : exit ");
            Console.WriteLine("enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("your name is ram  you are manager and your daily pay  is 1500 rs");
                    break;
                case 2:
                    Console.WriteLine("your name is sita you are supervisor and your daily pay  is 1200 rs");
                    break;
                case 3:
                    Console.WriteLine("your name is suresh you are worker and your daily pay  is 800 rs");
                    break;
                case 4:
                    Environment.Exit(0);
                    break;

            }

            Console.ReadLine();



        }
    }
}
