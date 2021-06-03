using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PatientManager : IPatientService
    {
        IPatientDal _patientDal;
        public PatientManager(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }

        public IResult Add(Patient patient)
        {
            _patientDal.Add(patient);
            return new SuccessResult("Hasta Eklendi");
        }

        public IResult Delete(Patient patient)
        {
            _patientDal.Delete(patient);
            return new SuccessResult("Hasta Silindi");
        }

        public IDataResult<List<Patient>> GetAll()
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetAll(), "Hastalar Listelendi");
        }
       
        public IDataResult<List<Patient>> GetAllByDoktorId(int doctorId)
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetAll(p => p.DoctorId == doctorId), "Doktorun Hastaları Listelendi");
        }

        public IDataResult<Patient> GetById(int patientId)
        {
            return new SuccessDataResult<Patient>(_patientDal.Get(p => p.PatientId == patientId));
        }

        public IResult GetCount()
        {
            return new SuccessDataResult<int>(_patientDal.GetAll().Count);
        }

        public IResult Update(Patient patient)
        {
            _patientDal.Update(patient);
            return new SuccessResult("Hasta Güncellendi");
        }
    }
}
