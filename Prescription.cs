using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRPOproject
{
    public class Prescription
    {
        public int PrescriptionId { get; private set; } // ID назначения
        public string Description { get; private set; } // Описание назначения
        public PrescriptionType Type { get; private set; } // Тип назначения
        public bool IsCompleted { get; private set; } // Статус выполнения назначения

        public Prescription(int id, string description, PrescriptionType type)
        {
            PrescriptionId = id;
            Description = description;
            Type = type;
            IsCompleted = false;
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