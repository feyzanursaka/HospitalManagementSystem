using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;
        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }
        public List<Appointment> GetAll()
        {
            return _appointmentDal.GetAll();
        }

        public List<AppointmentDetailDto> GetAppointmentDetails()
        {
            return _appointmentDal.GetAppointmentDetails();
        }

        public List<Appointment> GetById(int appointmentId)
        {
            return _appointmentDal.GetAll(a => a.AppointmentId == appointmentId);
        }
    }
}
