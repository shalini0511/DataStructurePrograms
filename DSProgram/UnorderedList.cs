using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DSProgram
{
    class UnorderedList
    {
        public static void Unordered()
        {
            string text = File.ReadAllText(@"C:\Users\HP\source\repos\DSProgram\DSProgram\WordFile.txt");
            string[] textArray = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomLinkedList<string> list = new CustomLinkedList<string>();
            for (int i = textArray.Length - 1; i >= 0; i--)
            {
                list.InsertFront(textArray[i]);
            }
            list.Display();
            Console.WriteLine("\nEnter a string which you want to search");
            string searchStr = Console.ReadLine();
            if (list.Search(searchStr))
            {
                list.DeleteElement(searchStr);
            }
            else
            {
                list.InsertFront(searchStr);
            }
            string textFile = list.ReturnString();
            File.WriteAllText(@"C:\Users\HP\source\repos\DSProgram\DSProgram\WordFile.txt", textFile);
            list.Display();
        }
    }
}
