using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPatientService
    {
        IDataResult<List<Patient>> GetAll();
        IDataResult<Patient> GetById(int patientId);
        IDataResult<List<Patient>> GetAllByDoktorId(int doctorId);
    }
}
