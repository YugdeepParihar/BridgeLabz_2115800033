using System;
using System.Collections.Generic;

// Patient Class
class Patient
{
    public string PatientName { get; set; }
    public int PatientId { get; set; }

    public Patient(int patientId, string patientName)
    {
        PatientId = patientId;
        PatientName = patientName;
    }

    // Method to communicate a consultation request
    public void RequestConsultation(Doctor doctor)
    {
        doctor.Consult(this); // The patient requests consultation with a doctor
    }
}

// Doctor Class
class Doctor
{
    public string DoctorName { get; set; }
    public int DoctorId { get; set; }

    public Doctor(int doctorId, string doctorName)
    {
        DoctorId = doctorId;
        DoctorName = doctorName;
    }

    // Method for the doctor to consult a patient
    public void Consult(Patient patient)
    {
        Console.WriteLine($"Doctor {DoctorName} (ID: {DoctorId}) is consulting with Patient {patient.PatientName} (ID: {patient.PatientId}).");
    }
}

// Hospital Class
class Hospital
{
    public string HospitalName { get; set; }
    public int HospitalId { get; set; }
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }

    public Hospital(int hospitalId, string hospitalName)
    {
        HospitalId = hospitalId;
        HospitalName = hospitalName;
        Doctors = new List<Doctor>();
        Patients = new List<Patient>();
    }

    // Method to add a doctor to the hospital
    public void AddDoctor(Doctor doctor)
    {
        Doctors.Add(doctor);
    }

    // Method to add a patient to the hospital
    public void AddPatient(Patient patient)
    {
        Patients.Add(patient);
    }

    // Display all doctors and patients in the hospital
    public void DisplayHospitalInfo()
    {
        Console.WriteLine($"Hospital: {HospitalName} (ID: {HospitalId})");
        Console.WriteLine("Doctors:");
        foreach (var doctor in Doctors)
        {
            Console.WriteLine($"- Dr. {doctor.DoctorName} (ID: {doctor.DoctorId})");
        }
        Console.WriteLine("Patients:");
        foreach (var patient in Patients)
        {
            Console.WriteLine($"- {patient.PatientName} (ID: {patient.PatientId})");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create a Hospital
        Hospital myHospital = new Hospital(101, "City Health Hospital");

        // Create Doctors
        Doctor doctor1 = new Doctor(1, "Manish");
        Doctor doctor2 = new Doctor(2, "Raman");

        // Add Doctors to the Hospital
        myHospital.AddDoctor(doctor1);
        myHospital.AddDoctor(doctor2);

        // Create Patients
        Patient patient1 = new Patient(1, "Ram");
        Patient patient2 = new Patient(2, "Vansh");

        // Add Patients to the Hospital
        myHospital.AddPatient(patient1);
        myHospital.AddPatient(patient2);

        // Display Hospital Info (Doctors and Patients)
        myHospital.DisplayHospitalInfo();

        // Simulate consultations between doctors and patients
        patient1.RequestConsultation(doctor1);
        patient2.RequestConsultation(doctor1);

        patient1.RequestConsultation(doctor2);
        patient2.RequestConsultation(doctor2);
    }
}