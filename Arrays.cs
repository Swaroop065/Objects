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

        public static void Main()
        {
            ArrayMethods();
        }
    }
}
