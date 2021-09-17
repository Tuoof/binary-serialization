using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
 
// Used for writing to a file
using System.IO;
 
// Used to serialize an object to binary format
using System.Runtime.Serialization.Formatters.Binary;
 
namespace binary_serialization
{
    [Serializable]
    public class Serialization
    {
        public Arknight waifu = new Arknight("Savage", "Guard", "Hammer");
        public void Start()
        {
            

            // Serialize the object data to a file
            Stream stream = File.Open("ArknightData.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
 
            // Send the object data to the file
            bf.Serialize(stream, waifu);
            stream.Close();        
        }
    }
}