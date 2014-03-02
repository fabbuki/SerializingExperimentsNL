using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization; 

namespace SerializingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Note myNote = new Note();
            myNote.outputNote();

            Console.WriteLine("Press a key to move to next phase."); 
            Console.ReadKey(); 

            //serialize the object with inception 
            string theURL = myNote.SerializeXMLReturnURL(); 
            Console.WriteLine("The serialized XML file should be located at {0}", theURL); 

            Console.WriteLine("Press a key to move to next phase.");
            Console.ReadKey(); 

            //de-serialize the object
            Note noteClone; 
            XmlSerializer xs = new XmlSerializer(typeof(Note));

            using (Stream s = File.OpenRead(theURL))
                noteClone = (Note)xs.Deserialize(s); 

            //output the object 
            Console.WriteLine("I have de-serialized and cloned the note. This is the note's properties:");
            noteClone.outputNote();

            Console.WriteLine("Press a key to move to next phase.");
            Console.ReadKey(); 

        }
    }
}
