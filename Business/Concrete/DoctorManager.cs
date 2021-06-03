using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DoctorManager : IDoctorService
    {
        IDoctorDal _doctorDal;
        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal=doctorDal;
        }
        public List<Doctor> GetAll()
        {
            return _doctorDal.GetAll();
        }
    }
}
