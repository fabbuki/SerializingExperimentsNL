using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Note myNote = new Note();
            myNote.outputNote();

            Console.WriteLine("Press any key to exit."); 
            Console.ReadKey(); 

        }
    }
}
