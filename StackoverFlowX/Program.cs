using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StackoverFlowX
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Steplist));
            string[] Documents = System.IO.Directory.GetFiles("../../Data/");
            string DocumentPath = Documents[0];
            try
            {
                //using (var filestream = new FileStream(@"\\Data\\Steplist.xml", FileMode.Open))
                using (var filestream = new FileStream(DocumentPath, FileMode.Open))
                {
                    Steplist result = (Steplist)serializer.Deserialize(filestream);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception file not found", e);
            }
            Console.WriteLine("Enter to Exit!");
            Console.ReadLine();
        }
    }
}
