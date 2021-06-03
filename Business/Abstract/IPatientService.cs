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
        IResult Add(Patient patient);
        IResult Delete(Patient patient);
        IResult Update(Patient patient);
        IResult GetCount();
        IDataResult<Patient> GetById(int patientId);
        IDataResult<List<Patient>> GetAllByDoktorId(int doctorId);
    }
}
