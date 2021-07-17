using System;

namespace DSProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Programs!");
            Console.WriteLine("1.Unordered List");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    UnorderedList.Unordered();
                    break;

            }

        }
    }
}
