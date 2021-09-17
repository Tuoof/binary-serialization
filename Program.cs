using System;

namespace binary_serialization
{
    class Program
    {
        static public void Main()
        {
            var serial = new Serialization();
            var deserial = new Deserialization();

            serial.Start();
            deserial.Start();
        }
    }
}