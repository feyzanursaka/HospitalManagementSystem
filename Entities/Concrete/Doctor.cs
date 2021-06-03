using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Doctor : IEntity
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Insurance { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }

    }
}
