using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObjectClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The Object Type
            // Every class is derived from Object.
            Book bk = new Book();

            Diary dy = new Diary(38);

            int i = 9;

            Object o1 = bk;
            Object o2 = dy;
            Object o3 = i;

            // Object Members
            Book b = new Book();
            Diary d = new Diary(38);
            Random r = new Random();

            Object[] ArrayO = new Object[] { b, d, r, i };

            foreach (Object o in ArrayO)
            {
                Console.WriteLine(o.GetType());
            }

            //Overriding Object Members
            Book bkk = new Book("Ta-Nehisi Coates", "Between the World and Me");
            Console.WriteLine(bk.ToString());

            // Object in Plain Sight
            Diary diary1 = new Diary();
            Console.WriteLine(diary1);


            //to keep console open
            Console.ReadLine();

        }
    }
}
