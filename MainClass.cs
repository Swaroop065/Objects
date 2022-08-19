using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Object
{
    public class MainClass
    {

        //constructer injection 
        private readonly ArraysTest _arraysTest;

        public MainClass( ArraysTest arraysTest)
        {
           _arraysTest = arraysTest;   
        }
        public void Print()
        {
            _arraysTest.


        }
    }

}
