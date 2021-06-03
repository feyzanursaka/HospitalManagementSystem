using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPatientService
    {
        List<Patient> GetAll();
        List<Patient> GetById(int patientId);
        List<Patient> GetAllByDoktorId(int doctorId);
    }
}
