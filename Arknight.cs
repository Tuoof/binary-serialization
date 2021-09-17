using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

// With serialization you can store the state 
// of an object in a file stream, pass it to
// a remote network

namespace binary_serialization
{
    // Defines that you want to serialize this class
    [Serializable]
    public class Arknight : ISerializable
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Weapon { get; set; }
        public int ArknightID { get; set; }

        public Arknight() { }

        public Arknight(string name = "No Name", string Class = "No Class", string Weapon = "No Weapon")
        {
            this.Name = name;
            this.Class = Class;
            this.Weapon = Weapon;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Class: {1}, Weapon: {2} ",
                Name, Class, Weapon);
        }

        // Serialization function (Stores Object Data in File)
        // SerializationInfo holds the key value pairs
        // StreamingContext can hold additional info
        // but we aren't using it here
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("Name", Name);
            info.AddValue("Weight", Class);
            info.AddValue("Height", Weapon);
            info.AddValue("AnimalID", ArknightID);
        }

        // The deserialize function (Removes Object Data from File)
        public Arknight(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties
            Name = (string)info.GetValue("Name", typeof(string));
            Class = (string)info.GetValue("Weight", typeof(string));
            Weapon = (string)info.GetValue("Height", typeof(string));
            ArknightID = (int)info.GetValue("AnimalID", typeof(int));
        }
        public IList Add_Char()
        {
            
            List<Arknight> characters = new List<Arknight>
            {
                new Arknight("Savage", "Guard", "Hammer"),
                new Arknight("Angelina", "Support", "Staff"),
                new Arknight("Estelle", "Guard", "No Weapon"),
                new Arknight("Eunectes", "Defender", "Shield and tomahawk")
            };
            return characters;
        }
    }
}