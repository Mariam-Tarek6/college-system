using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project
{
    class workerOperation : worker
    {
        public void addWorker()
        {
            worker s = new worker();
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
            Console.Write(" Enter Gender (M,F):");
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

            Console.Write(" Enter Phone num. :");
            s.Number = long.Parse(Console.ReadLine());
            while ((s.Salary > 0))
            {
                s.Salary = int.Parse(Console.ReadLine());
            }
            lst.Add(s);
            Console.WriteLine("DONE");

        }
        public void searchWorker()
        {
            long x;
            bool b = false;
            Console.Write(" Enter id :");
            x = long.Parse(Console.ReadLine());
            foreach (var item in lst)
            {
                if (item is worker)
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
        public void deleteWorker()
        {
            long x;
            bool b = false;
            Console.Write(" Enter id :");
            x = long.Parse(Console.ReadLine());
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] is worker)
                {

                    if (x == lst[i].Id)
                    {
                        b = true;
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
        public void largestSalary()
        {
            if (lst != null)
            {
                List<worker> dec = new List<worker>();
                foreach (var item in lst)
                {
                    if (item is worker)
                    {
                        worker temp1 = item as worker;
                        dec.Add(temp1);
                    }
                }

                for (int j = 0; j < dec.Count; j++)
                {
                    int min_idx = j;
                    for (int i = j + 1; i < dec.Count; i++)
                    {
                        if (dec[i].Salary > dec[min_idx].Salary)
                            min_idx = i;
                    }
                    worker temp = dec[j] as worker;
                    dec[j] = dec[min_idx];
                    dec[min_idx] = temp;
                }
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(dec[j].ToString());
                }
            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }
    }
}
