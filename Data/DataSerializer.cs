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

        public void SaveToFile(List<IFeed> feed)
        {            
            List<SerializerItem> Items = feed.Select(x => new SerializerItem(x)).ToList();
            var xml = new System.Xml.Serialization.XmlSerializer(typeof(List<SerializerItem>));
            using(var f = System.IO.File.Open(filepath, System.IO.FileMode.Create))
            {
               
                xml.Serialize(f, Items);
                f.Flush();
                f.Close();
            }
        }

        public delegate void Del(SerializerItem returFeed);


        public void LoadFromFile(Del Callback)
        {
            if (System.IO.File.Exists(filepath))
            {
                List<SerializerItem> returFeed;

                var xml = new System.Xml.Serialization.XmlSerializer(typeof(List<SerializerItem>));
                using (var s = System.IO.File.Open(filepath, System.IO.FileMode.Open))
                {
                    returFeed = xml.Deserialize(s) as List<SerializerItem>;
                    s.Flush();
                    s.Close();
                }

                returFeed.ForEach(x => Callback(x));

            }
        }

        
    }
}
