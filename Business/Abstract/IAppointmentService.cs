using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAppointmentService
    {
        List<Appointment> GetAll();
        List<Appointment> GetById(int appointmentId);
        List<AppointmentDetailDto> GetAppointmentDetails();
    }
}
