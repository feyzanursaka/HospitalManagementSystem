using Business.Abstract;
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

        public List<Patient> GetAll()
        {
            return _patientDal.GetAll();
        }

        public List<Patient> GetAllByDoktorId(int doctorId)
        {
            return _patientDal.GetAll(p=>p.DoctorId==doctorId);
        }

        public List<Patient> GetById(int patientId)
        {
            return _patientDal.GetAll(p => p.PatientId == patientId);
        }
    }
}
