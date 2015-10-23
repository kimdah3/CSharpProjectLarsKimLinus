using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataSerializer
    {
       string filepath;
      
        
        public DataSerializer()
        {
            var folder = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            filepath = System.IO.Path.Combine(folder, "Feeds");
        }   

        public void SaveToFile(IFeed feed)
        {
            var onePod = feed;
            Console.WriteLine(onePod.Title);/*
            var xml = new System.Xml.Serialization.XmlSerializer(typeof(IFeed));
            using(var f = System.IO.File.Open(filepath, System.IO.FileMode.Create))
            {
               
                xml.Serialize(f, feed);
                f.Flush();
                f.Close();
            }*/
        }

        
    }
}
