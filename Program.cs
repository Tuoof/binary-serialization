using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
 
// Used for writing to a file
using System.IO;
 
// Used to serialize an object to binary format
using System.Runtime.Serialization.Formatters.Binary;
 
// Used to serialize into XML
using System.Xml.Serialization;
 
namespace binary_serialization
{
    class Program
    {
        static void Main()
        {
            //Arknight bowser = new Arknight("Savage", "Guard", "Hammer");
            List<Arknight> Characters = new List<Arknight>
            {
                new Arknight("Savage", "Guard", "Hammer"),
                new Arknight("Angelina", "Support", "Staff"),
                new Arknight("Estelle", "Guard", "No Weapon"),
                new Arknight("Eunectes", "Defender", "Shield and tomahawk")
            };

            // Serialize the object data to a file
            Stream stream = File.Open("ArknightData.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
 
            // Send the object data to the file
            bf.Serialize(stream, Characters);
            stream.Close();
 
            // Read object data from the file
            stream = File.Open("ArknightData.dat", FileMode.Open);
            bf = new BinaryFormatter();
 
            Characters = (List<Arknight>)bf.Deserialize(stream);
            stream.Close();
 
            foreach (Arknight a in Characters)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}