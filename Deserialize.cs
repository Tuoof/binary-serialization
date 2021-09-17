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
    public class Deserialization
    {
        public Arknight character = new Arknight();
        public void Start()
        {

            //List<Arknight> Characters = new List<Arknight>();
            

            // Read object data from the file
            Stream stream = File.Open("ArknightData.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            //Characters = (List<Arknight>)bf.Deserialize(stream);
            character = (Arknight)bf.Deserialize(stream);
            stream.Close();

            Console.WriteLine(character.ToString());
            /*foreach (Arknight a in Characters)
            {
                Console.WriteLine(a.ToString());
            }*/
        }
    }
}