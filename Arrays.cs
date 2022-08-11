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

/*        public static void NewArray()
        {

            List<int> empIdLinkedList = new LinkedList<Int64>();

            Console.WriteLine("The Size of LinkedList While Initiation: " + empIdLinkedList.Count());

            empIdLinkedList.Add(0065);
            empIdLinkedList.Add(0098);
            empIdLinkedList.Add(0078);
            empIdLinkedList.Add(9987);
            empIdLinkedList.Add(8765);
            empIdLinkedList.Add(5);
            empIdLinkedList.Add(9989);

           Console.WriteLine(empIdLinkedList);
           Console.WriteLine("The Size of LinkedList While Initiation: " + empIdLinkedList.Count());


        }*/

    }

}
