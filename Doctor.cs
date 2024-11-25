using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRPOproject
{
    public class Doctor
    {
        public int DoctorId { get; private set; } // ID врача
        public string Name { get; private set; }   // Имя врача
        public string Specialty { get; private set; } // Специализация врача

        public Doctor(int id, string name, string specialty)
        {
            DoctorId = id;
            Name = name;
            Specialty = specialty;
        }

        public void Diagnose(Patient patient, string diagnosis)
        {
            patient.SetDiagnosis(diagnosis);
        }

        public void Prescribe(Patient patient, Prescription prescription)
        {
            // Выписывает назначение для пациента
            prescription.Complete();
            Console.WriteLine($"Prescription given to {patient.Name}: {prescription.GetPrescriptionInfo()}");
        }
    }

}