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

        public IResult Add(Appointment appointment)
        {
            _appointmentDal.Add(appointment);
            return new SuccessResult("Randevu Eklendi");
        }

        public IResult Delete(Appointment appointment)
        {
            _appointmentDal.Add(appointment);
            return new SuccessResult("Randevu Silindi");
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

        public IResult GetCount ()
        {
            return new SuccessDataResult<int>(_appointmentDal.GetAll().Count);
        }

        public IResult Update(Appointment appointment)
        {
            _appointmentDal.Update(appointment);
            return new SuccessResult("Randevu Güncellendi"); ;
        }
    }
}
