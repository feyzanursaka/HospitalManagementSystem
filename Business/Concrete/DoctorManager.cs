﻿using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Doctor doctor)
        {
            _doctorDal.Add(doctor);
            return new SuccessResult("Doktor Eklendi");
        }

        public IDataResult<List<Doctor>> GetAll()
        {
            return new SuccessDataResult<List<Doctor>>(_doctorDal.GetAll(), "Doktorlar Listelendi");
        }

        public IDataResult<Doctor> GetById(int doctorId)
        {
            return new SuccessDataResult<Doctor>(_doctorDal.Get(d => d.DoctorId == doctorId));
        }
    }
}
