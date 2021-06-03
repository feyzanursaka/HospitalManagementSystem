using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DoctorTest();
            AppointmentDetailDtoTest();

        }
        private static void AppointmentDetailDtoTest()
        {
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointment());

            var result = appointmentManager.GetAppointmentDetails();

            if (result.Success == true)
            {
                foreach (var appointment in result.Data)
                {
                    Console.WriteLine(appointment.DoctorName + " " + appointment.PatientName + " " + appointment.AppointmentDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
        }
     

        private static void DoctorTest()
        {
            DoctorManager doctorManager = new DoctorManager(new EfDoctorDal());
            foreach (var doctor in doctorManager.GetAll().Data)
            {
                Console.WriteLine(doctor.FirstName);
            }
        }
    }
}
