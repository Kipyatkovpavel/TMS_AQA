using HomeWork_OOP.SecondTask.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP.SecondTask
{
    public class PlanOfTreatment
    {
        public int treatmentID;

        public PlanOfTreatment(int treatmentId)
        {
            this.treatmentID = treatmentId;
        }

        public Doctor AppointDoctor()
        {
            switch (treatmentID) 
            {
                case 1: return new Surgeon();
                case 2: return new Dentist();
                default: return new Therapist();
            }

        }

    }
}
