using Business.Abstract;
using Core.Utilities.Results;
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
 
        public IDataResult<List<Appointment>> GetAll()
        {
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll(), "Randevular Listelendi");
        }
        public IDataResult<List<AppointmentDetailDto>> GetAppointmentDetails()
        {
            return new SuccessDataResult<List<AppointmentDetailDto>>(_appointmentDal.GetAppointmentDetails(), "Randevu Detayları Listelendi");
        }

        public IDataResult<Appointment> GetById(int appointmentId)
        {
            return new SuccessDataResult<Appointment>(_appointmentDal.Get(a => a.AppointmentId == appointmentId));
        }
    }
}
