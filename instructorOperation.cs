using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    class instructorOperation:instructor
    {
        public void addInstructor()
        {
            instructor s = new instructor();
            Console.Write(" Enter Name :");
            s.Name = Console.ReadLine();
            Console.Write(" Enter id :");
            while (!(s.Id >= 10000000000 && s.Id <= 99999999999))
            {
                s.Id = long.Parse(Console.ReadLine());
            }
            Console.Write(" Enter Age :");
            while (!(s.Age > 0))
            {
                s.Age = int.Parse(Console.ReadLine());
            }
            try
            {
                if (Enum.TryParse(Console.ReadLine(), out personType type))
                {
                    s.Gender = type;
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Write(" Enter Department (1-CS , 2- IS , 3- IT , 4- MM)  :");
            try
            {
                if (Enum.TryParse(Console.ReadLine(), out Department type1))
                {
                    s.Department = type1;
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write(" Enter Phone num. :");
            s.Number = long.Parse(Console.ReadLine());
            Console.Write(" Enter E-mail :");
            s.Email = Console.ReadLine();
            Console.Write(" Enter salary :");
            while ((s.Salary > 0))
            {
                s.Salary = int.Parse(Console.ReadLine());
            }
            lst.Add(s);
            Console.WriteLine("DONE");
        }
        public void searchInstructor()
        {
            long x;
            bool b = false;
            Console.Write(" Enter id :");
            x = long.Parse(Console.ReadLine());
            foreach (var item in lst)
            {
                if (item is instructor)
                {

                    if (x == item.Id)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    else
                    {
                        b = false;
                    }
                }
            }
            if (!b)
            {
                Console.WriteLine("wrong ID");
            }
        }
        public void deleteInstructor()
        {
            long x;
            bool b = false;
            Console.Write(" Enter id :");
            x = long.Parse(Console.ReadLine());
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] is instructor)
                {

                    if (x == lst[i].Id)
                    {
                        lst.RemoveAt(i);
                        Console.WriteLine("DONE");
                        break;
                    }
                    else
                    {
                        b = false;
                    }
                }
            }
            if (!b)
            {
                Console.WriteLine("wrong ID");
            }
        }
    }
}
