using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRPOproject
{
    public class Patient
    {
        public int PatientId { get; private set; } // ID пациента
        public string Name { get; private set; }   // Имя пациента
        public string Diagnosis { get; private set; } // Текущий диагноз
        public bool IsDischarged { get; private set; } // Статус выписки
        public string FinalDiagnosis { get; private set; } // Окончательный диагноз

        public Patient(int id, string name)
        {
            PatientId = id;
            Name = name;
            IsDischarged = false;
        }

        public string GetPatientInfo()
        {
            return $"{Name} (ID: {PatientId}) - Diagnosis: {Diagnosis}, Discharged: {IsDischarged}";
        }

        public void Discharge(string finalDiagnosis)
        {
            IsDischarged = true;
            FinalDiagnosis = finalDiagnosis;
        }

        public void SetDiagnosis(string diagnosis)
        {
            Diagnosis = diagnosis;
        }
    }
}