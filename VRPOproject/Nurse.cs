using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRPOproject
{
    public class Nurse : Patient
    {
        public int NurseId { get; set; }
        public string Name { get; set; }

        public void Administer(Patient patient, Prescription prescription)
        {
            prescription.Complete();
            Console.WriteLine($"Nurse {Name} administered: {prescription.GetPrescriptionInfo()} to {patient.Name}");
        }
    }
}