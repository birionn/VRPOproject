using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRPOproject
{
    public class Nurse
    {
        public int NurseId { get; private set; } // ID медсестры
        public string Name { get; private set; }   // Имя медсестры

        public Nurse(int id, string name)
        {
            NurseId = id;
            Name = name;
        }

        public void Administer(Patient patient, Prescription prescription)
        {
            prescription.Complete();
            Console.WriteLine($"Nurse {Name} administered: {prescription.GetPrescriptionInfo()} to {patient.Name}");
        }
    }
}