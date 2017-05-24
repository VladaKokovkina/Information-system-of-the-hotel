using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Information_system_of_the_hotel
{
    class Serialization
    {
        public static void Serialize(Client[] list)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("clients.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }

        public static void Deserialize(List<Client> clientlist)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("clients.dat", FileMode.Open))
            {
                clientlist = (List<Client>)formatter.Deserialize(fs);
            }
        }
    }
}
