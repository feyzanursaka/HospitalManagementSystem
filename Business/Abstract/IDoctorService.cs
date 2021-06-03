using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDoctorService
    {
        IDataResult<List<Doctor>> GetAll();
        IResult Add(Doctor doctor);
        IDataResult<Doctor> GetById(int doctorId);

    }
}
