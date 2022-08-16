using System;
using System.Collections.Generic;
//using static project.helper;

namespace project
{
    public enum personType
    {
        Male = 1,
        Female = 2
    }
    public enum Department
    {
        CS = 1,
        IS = 2,
        IT = 3,
        MM = 4
    }
    
        class Program
        {
            static void Main(string[] args)
            {
           
            int x;
           

            do {
                Console.WriteLine("1- Add Student");
                Console.WriteLine("2- Add Instructor");
                Console.WriteLine("3- Add Worker");
                Console.WriteLine("4- searching about Student");
                Console.WriteLine("5- searching about Instructor");
                Console.WriteLine("6- searching about Worker");
                Console.WriteLine("7- Delete Student");
                Console.WriteLine("8- Delete Instructor");
                Console.WriteLine("9- Delete Worker");
                Console.WriteLine("10-Display All Student in  CS , IS , IT AND MM ");
                Console.WriteLine("11-Display The student at the first rank in each department");
                Console.WriteLine("12-Display Instructors with male gender");
                Console.WriteLine("13-Display the largest three worker in salary  ");
                Console.WriteLine("               Enter number from 1 to 13");
                Console.WriteLine( "      -1  To close");
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    studentOperation s = new studentOperation();
                    s.add();
                }
                if (x == 2)
                {
                    instructorOperation s = new instructorOperation();
                    s.addInstructor();
                }
                if (x == 3)
                {
                    workerOperation s = new workerOperation();
                    s.addWorker();
                }
                if (x == 4)
                {
                    studentOperation s = new studentOperation();
                    s.search();
                }
                if (x == 5)
                {
                    instructorOperation s = new instructorOperation();
                    s.searchInstructor();
                }
                if (x == 6)
                {
                    workerOperation s = new workerOperation();
                    s.searchWorker();
                }
                if (x == 7)
                {
                    studentOperation s = new studentOperation();
                    s.delete();
                }
                if (x == 8)
                {
                    instructorOperation s = new instructorOperation();
                    s.deleteInstructor();
                }
                if (x == 9)
                {
                    workerOperation s = new workerOperation();
                    s.deleteWorker();
                }
                if (x == 10)
                {
                    studentOperation s = new studentOperation();
                    s.Display();
                }
                if (x == 11)
                {
                    studentOperation s = new studentOperation();
                    s.selectionSort();
                }
                if (x == 12)
                {
                    instructorOperation s = new instructorOperation();
                    
                    s.DisplayMale();
                }
                if (x == 13)
                {
                    workerOperation s = new workerOperation();
                    s.largestSalary();
                }
            } while (x!=-1);

        }
        }
    }

