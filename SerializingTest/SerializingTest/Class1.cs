using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializingTest
{
    using System;
    public class Note
    {
        string title;
        string body;
        string dateCreated;
        string lastModified;

        public Note()
        {
            title = "Untitled";
            body = "This is a test note.";

            dateCreated = DateTime.Today.ToString("MMMM dd, yyyy");
            lastModified = DateTime.Today.ToString("MMMM dd, yyyy");

        }

        public void outputNote()
        {
            Console.WriteLine("Titlte: {0}", title);
            Console.WriteLine("Body: {0}", body);
            Console.WriteLine("Date Created: {0}", dateCreated);
            Console.WriteLine("Date last modified: {0}", lastModified);
        }

    }

}
