using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRPOproject
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }

        public Patient Patient
        {
            get => default;
            set
            {
            }
        }

        public void Diagnose(Patient patient, string diagnosis)
        {
            patient.Diagnosis = diagnosis;
        }

        public void Prescribe(Patient patient, Prescription prescription)
        {
            prescription.Complete();
            Console.WriteLine($"Prescription given to {patient.Name}: {prescription.GetPrescriptionInfo()}");
        }
    }
}