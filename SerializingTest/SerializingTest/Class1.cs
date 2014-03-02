using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization; 

namespace SerializingTest
{
    using System;
    public class Note
    {
       public string title;
       public string body;
       public string dateCreated;
       public string lastModified;

        public Note()
        {
            title = "Untitled";
            body = "This is a test note.";

            dateCreated = DateTime.Today.ToString("MMMM dd, yyyy");
            lastModified = DateTime.Today.ToString("MMMM dd, yyyy");

        }

        public void outputNote()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Body: {0}", body);
            Console.WriteLine("Date Created: {0}", dateCreated);
            Console.WriteLine("Date last modified: {0}", lastModified);
        }

        public string SerializeXMLReturnURL()
        {

            //create the serializer 
            XmlSerializer xs = new XmlSerializer(typeof(Note)); 

            //create file URL myPath 
            string myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myPath = Path.Combine(myPath, "SerializationOverview.xml"); 
            
            //test
            this.outputNote(); 

            //serialize yourself and close file 
            using (Stream s = File.Create(myPath))
                xs.Serialize(s, this); 
            
            return myPath; 
        }

        public Note DeserializeXMLatURL(string URL)
        {
            Note noteClone; 
            XmlSerializer xs = new XmlSerializer(typeof(Note));

            using (Stream s = File.OpenRead(URL))
                noteClone = (Note)xs.Deserialize(s);

            return noteClone; 
            
        }

    }

}
