using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoctorTest();
            //PatientTest();
            AppointmentDetailDtoTest();

        }
        private static void AppointmentDetailDtoTest()
        {
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointment());
            foreach (var appointment in appointmentManager.GetAppointmentDetails())
            {
                Console.WriteLine(appointment.DoctorName+" "+ appointment.PatientName+" "+appointment.AppointmentDate);
            }
        }
        private static void PatientTest()
        {
            PatientManager patientManager = new PatientManager(new EfPatientDal());
            foreach (var patient in patientManager.GetById(1))
            {
                Console.WriteLine(patient.FirstName);
            }
        }

        private static void DoctorTest()
        {
            DoctorManager doctorManager = new DoctorManager(new EfDoctorDal());
            foreach (var doctor in doctorManager.GetAll())
            {
                Console.WriteLine(doctor.FirstName);
            }
        }
    }
}
