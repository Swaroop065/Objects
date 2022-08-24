using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Constructers
    {

        public string model;



        public Constructers()
        {
            model = "TATA";
        }

        public static void Main()
        {
            Constructers con = new Constructers();
            Console.WriteLine(con.model);
            Console.WriteLine(con.model);
        }

    }
}

