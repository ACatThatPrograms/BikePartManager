using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace BikePartManager
{

    [Serializable]

    public static class BikePartList
    {

        public static List<dynamic> PartList = new List<dynamic>();
        public static string serializeFile = "partlist.bin";

        public static void AddPart(dynamic partToAdd)
        {

            PartList.Add(partToAdd);

        }

        public static void RemPart(dynamic partToRemove)
        {

            PartList.Remove(partToRemove);

        }

        public static List<dynamic> GetPartList()
        {

            return PartList;

        }

        public static void savePartList()
        {

            using (Stream stream = File.Open(serializeFile, FileMode.OpenOrCreate))
            {

                var binFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                binFormatter.Serialize(stream , BikePartList.PartList);

            }

        }

        public static void loadPartList()
        {


                using (Stream stream = File.Open(serializeFile, FileMode.Open))
                {

                var binFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                List<dynamic> LoadedPartList = (List<dynamic>)binFormatter.Deserialize(stream);

                PartList.Clear();

                foreach (dynamic x in LoadedPartList)
                {

                    PartList.Add(x);

                }

            }

           
        }

    }


}
