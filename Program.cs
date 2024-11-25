using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<Patient> patients = new List<Patient>();
        List<Doctor> doctors = new List<Doctor>
        {
            new Doctor(1, "Иванов И.И.", "Терапевт")
        };

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=== Система Больница ===");
            Console.WriteLine("1. Добавить пациента");
            Console.WriteLine("2. Установить диагноз");
            Console.WriteLine("3. Показать информацию о пациентах");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите действие: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddPatient(patients);
                    break;
                case "2":
                    SetDiagnosis(doctors, patients);
                    break;
                case "3":
                    ShowPatientsInfo(patients);
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный ввод, попробуйте снова.");
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }

    static void AddPatient(List<Patient> patients)
    {
        Console.Write("Введите имя пациента: ");
        string name = Console.ReadLine();
        patients.Add(new Patient(patients.Count + 1, name));
        Console.WriteLine("Пациент добавлен.");
    }

    static void SetDiagnosis(List<Doctor> doctors, List<Patient> patients)
    {
        if (patients.Count == 0)
        {
            Console.WriteLine("Нет пациентов для назначения диагноза.");
            return;
        }

        Console.Write("Введите ID пациента: ");
        int patientId = int.Parse(Console.ReadLine());
        Patient patient = patients.Find(p => p.PatientId == patientId);

        if (patient == null)
        {
            Console.WriteLine("Пациент не найден.");
            return;
        }

        Console.Write("Введите диагноз: ");
        string diagnosis = Console.ReadLine();
        doctors[0].Diagnose(patient, diagnosis); // Используем первого врача для назначения
        Console.WriteLine("Диагноз установлен.");
    }

    static void ShowPatientsInfo(List<Patient> patients)
    {
        if (patients.Count == 0)
        {
            Console.WriteLine("Нет пациентов.");
            return;
        }

        foreach (var patient in patients)
        {
            Console.WriteLine(patient.GetPatientInfo());
        }
    }
}

// Класс для представления пациента
public class Patient
{
    public int PatientId { get; private set; }
    public string Name { get; private set; }
    public string Diagnosis { get; private set; }

    public Patient(int id, string name)
    {
        PatientId = id;
        Name = name;
    }

    public string GetPatientInfo()
    {
        return $"{Name} (ID: {PatientId}) - Diagnosis: {Diagnosis ?? "Нет диагноза"}";
    }

    public void SetDiagnosis(string diagnosis)
    {
        Diagnosis = diagnosis;
    }
}

// Класс для представления врача
public class Doctor
{
    public int DoctorId { get; private set; }
    public string Name { get; private set; }
    public string Specialty { get; private set; }

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
}