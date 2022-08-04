using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public  class Arrays
    {
      public static void ArrayMethods()
        {
            string[] books = { "TextBook", "NoteBook", "DrawingBook" };
            int[] bookId = {1,2,3};
            Console.WriteLine(books[0]);
            Console.WriteLine(bookId[1]);
        }
        public static void ArrayLoop()
        {
            string[] books = { "TextBook", "NoteBook", "DrawingBook" };
            for (int i=0; i<books.Length;i++)
            {
                Console.WriteLine(books[i]);
            }
        }

        public static void ArrayForEachLoop()
        {
            string[] books = { "TextBook", "NoteBook", "DrawingBook" };
            foreach(string book in books)
            {
                Console.WriteLine(book);
            }
        }
        public static void Main()
        {
            ArrayMethods();
            ArrayLoop();
            ArrayForEachLoop();
        }
    }
}
