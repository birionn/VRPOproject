using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRPOproject
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Diagnosis { get; set; }
        public bool IsDischarged { get; private set; }
        public string FinalDiagnosis { get; private set; }

        public string GetPatientInfo()
        {
            return $"{Name} (ID: {PatientId}) - Diagnosis: {Diagnosis}, Discharged: {IsDischarged}";
        }

        public void Discharge(string finalDiagnosis)
        {
            IsDischarged = true;
            FinalDiagnosis = finalDiagnosis;
        }
    }
}