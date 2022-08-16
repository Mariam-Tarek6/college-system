using project;
using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    //interface IstudentOperation : IMainOperation<student>
    //{

    //}
    //}
    static class helper
    {

    }

    public class studentOperation : college
    {
        public static List<student> cs = new List<student>();
        public static List<student> Is = new List<student>();
        public static List<student> it = new List<student>();
        public static List<student> mm = new List<student>();
        public void store()
        {
            if (lst != null)
            {
                foreach (var item in lst)
                {

                    if (item is student)
                    {
                        student temp = item as student;
                        if (temp.Department == Department.CS)
                        {

                            cs.Add(temp);
                        }
                    }
                    if (item is student)
                    {
                        student temp = item as student;
                        if (temp.Department == Department.IS)
                        {

                            Is.Add(temp);
                        }
                    }
                    if (item is student)
                    {
                        student temp = item as student;
                        if (temp.Department == Department.IT)
                        {

                            it.Add(temp);



                        }
                    }
                    if (item is student)
                    {
                        student temp = item as student;
                        if (temp.Department == Department.MM)
                        {

                            mm.Add(temp);



                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }
        public void selectionSort()
        {
            store();

            for (int j = 0; j < cs.Count; j++)
            {
                int min_idx = j;
                for (int i = j + 1; i < cs.Count; i++)
                {

                    if (cs[i].Gpa > cs[min_idx].Gpa)
                        min_idx = i;


                }

                student temp = cs[j] as student;
                cs[j] = cs[min_idx];
                cs[min_idx] = temp;

            }
            for (int j = 0; j < Is.Count; j++)
            {
                int min_idx = j;
                for (int i = j + 1; i < Is.Count; i++)
                {

                    if (Is[i].Gpa > Is[min_idx].Gpa)
                        min_idx = i;


                }

                student temp = Is[j] as student;
                Is[j] = Is[min_idx];
                Is[min_idx] = temp;

            }
            for (int j = 0; j < it.Count; j++)
            {
                int min_idx = j;
                for (int i = j + 1; i < it.Count; i++)
                {

                    if (it[i].Gpa > it[min_idx].Gpa)
                        min_idx = i;


                }

                student temp = it[j] as student;
                it[j] = it[min_idx];
                it[min_idx] = temp;

            }
            for (int j = 0; j < mm.Count; j++)
            {
                int min_idx = j;
                for (int i = j + 1; i < mm.Count; i++)
                {

                    if (mm[i].Gpa > mm[min_idx].Gpa)
                        min_idx = i;


                }

                student temp = mm[j] as student;
                mm[j] = mm[min_idx];
                mm[min_idx] = temp;

            }
            if (cs != null)
                Console.WriteLine(cs[0].ToString());
            if (Is != null)
                Console.WriteLine(Is[0].ToString());
            if (it != null)
                Console.WriteLine(it[0].ToString());
            if (mm != null)
                Console.WriteLine(mm[0].ToString());
        }
        //return lst;

        public void Display()
        {

            store();
            Console.WriteLine(" CS:");
            foreach (var item in cs)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(" IS:");
            foreach (var item in Is)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(" IT:");
            foreach (var item in it)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(" MM:");
            foreach (var item in mm)
            {
                Console.WriteLine(item.ToString());
            }


        }

        public void add()
        {
            student s = new student();

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

            Console.Write(" Enter Gender (1-Male,2-Female) :");
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
            Console.Write(" Enter Department (1-CS , 2- IS , 3- IT , 4- MM) :");
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
            Console.Write(" Enter GPA :");
            while (!(s.Gpa >= 0.0 && s.Gpa <= 4.0))
            {
                s.Gpa = float.Parse(Console.ReadLine());
            }

            Console.Write(" Enter Grade :");
            while ((s.Grade > 0 && s.Gpa < 5))
            {
                s.Grade = int.Parse(Console.ReadLine());
            }
            Console.Write(" Enter Phone num. :");
            s.Number = long.Parse(Console.ReadLine());
            Console.Write(" Enter E-mail :");
            s.Email = Console.ReadLine();
            Console.WriteLine(s.ToString());
            lst.Add(s);

            Console.WriteLine("DONE");
        }
        public void search()
        {
            long x;
            bool b = false;
            Console.Write(" Enter id :");
            x = long.Parse(Console.ReadLine());
            foreach (var item in lst)
            {
                if (item is student)
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
        public void delete()
        {
            long x;
            bool b = false;
            Console.Write(" Enter id :");
            x = long.Parse(Console.ReadLine());
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] is student)
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



        //student IstudentOperation.delete()
        //    {
        //    long x;
        //    Console.Write(" Enter id :");
        //    x = long.Parse(Console.ReadLine());
        //    for (int i = 0; i < lst.Count; i++)
        //    {
        //        if (lst[i] is student)
        //        {

        //            if (x == lst[i].Id)
        //            {
        //                lst.RemoveAt(i);
        //                Console.WriteLine("DONE");
        //                break;
        //            }
        //        }
        //    }
        //    return null;
        //}

        //    student IstudentOperation.search()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void add(student item)
        //    {
        //        student s = new student();
        //        Console.Write(" Enter Name :");
        //        s.Name = Console.ReadLine();
        //        Console.Write(" Enter id :");
        //        s.Id = long.Parse(Console.ReadLine());
        //        Console.Write(" Enter Age :");

        //        s.Age = int.Parse(Console.ReadLine());
        //        Console.Write(" Enter Gender (M,F) :");
        //        try
        //        {
        //            if (Enum.TryParse(Console.ReadLine(), out personType type))
        //            {
        //                s.Gender = type;
        //            }
        //        }
        //        catch (System.IO.IOException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        Console.Write(" Enter Department (1-CS , 2- IS , 3- IT , 4- MM) :");
        //        try
        //        {
        //            if (Enum.TryParse(Console.ReadLine(), out Department type1))
        //            {
        //                s.Department = type1;
        //            }
        //        }
        //        catch (System.IO.IOException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        Console.Write(" Enter GPA :");
        //        s.Gpa = float.Parse(Console.ReadLine());
        //        Console.Write(" Enter Grade :");
        //        s.Grade = int.Parse(Console.ReadLine());
        //        Console.Write(" Enter Phone num. :");
        //        s.Number = long.Parse(Console.ReadLine());
        //        Console.Write(" Enter E-mail :");
        //        s.Email = Console.ReadLine();
        //    Console.WriteLine(s.ToString());
        //    lst.Add(s);
        //    Console.WriteLine(s.ToString());
        //        Console.WriteLine("DONE");
        //    }

        //    public void search(student item)
        //    {
        //        long x;
        //        Console.Write(" Enter id :");
        //        x = long.Parse(Console.ReadLine());
        //        foreach (var item1 in lst)
        //        {
        //            if (item1 is student)
        //            {

        //                if (x == item1.Id)
        //                {
        //                    Console.WriteLine(item1.ToString());
        //                }
        //            }
        //        }
        //    }

        //    public void delete(student item)
        //    {
        //        long x;
        //        Console.Write(" Enter id :");
        //        x = long.Parse(Console.ReadLine());
        //        for (int i = 0; i < lst.Count; i++)
        //        {
        //            if (lst[i] is student)
        //            {

        //                if (x == lst[i].Id)
        //                {
        //                    lst.RemoveAt(i);
        //                    Console.WriteLine("DONE");
        //                    break;
        //                }
        //            }
        //        }
    }
}

