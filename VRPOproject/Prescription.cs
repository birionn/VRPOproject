using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRPOproject
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public string Description { get; set; }
        public PrescriptionType Type { get; set; }
        public bool IsCompleted { get; private set; }

        public Doctor Doctor
        {
            get => default;
            set
            {
            }
        }

        public void Complete()
        {
            IsCompleted = true;
        }

        public string GetPrescriptionInfo()
        {
            return $"{Description} (Type: {Type.Name}, Completed: {IsCompleted})";
        }
    }
}