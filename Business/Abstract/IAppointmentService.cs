using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAppointmentService
    {
        IDataResult<List<Appointment>> GetAll();
        IDataResult<Appointment> GetById(int appointmentId);
        IDataResult<List<AppointmentDetailDto>> GetAppointmentDetails();
    }
}
