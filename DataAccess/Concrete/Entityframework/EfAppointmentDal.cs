using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.Entityframework
{
    public class EfAppointmentDal : EfEntityRepositoryBase<Appointment, HospitalContext>, IAppointmentDal
    {
        public List<AppointmentDetailDto> GetAppointmentDetails()
        {
            using (HospitalContext contex = new HospitalContext())
            {
                var result = from a in contex.Appointments
                             join d in contex.Doctors
                             on a.DoctorId equals d.DoctorId
                             join p in contex.Patients
                             on a.PatientId equals p.PatientId
                             select new AppointmentDetailDto
                             {
                                 DoctorName = d.FirstName+" " + d.LastName,
                                 PatientName = p.FirstName+" " + d.LastName,
                                 AppointmentDate = a.AppointmentDate
                             };

                return result.ToList();
            }
        }
    }
}
