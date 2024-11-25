using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRPOproject
{
    public class PrescriptionType
    {
        public int TypeId { get; private set; } // ID типа назначения
        public string Name { get; private set; } // Название типа назначения

        public PrescriptionType(int id, string name)
        {
            TypeId = id;
            Name = name;
        }
    }
}