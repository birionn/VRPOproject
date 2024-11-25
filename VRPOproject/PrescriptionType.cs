using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRPOproject
{
    public class PrescriptionType : Prescription
    {
        public int TypeId { get; set; }
        public string Name { get; set; }
    }
}