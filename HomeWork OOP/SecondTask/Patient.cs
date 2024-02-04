using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP.SecondTask
{
    public class Patient
    {
       public string Name { get; set; }
       public PlanOfTreatment planoftreatment { get; set; }

        public Patient(string name) 
        {
            Name = name;
        }

        public Patient(string name, PlanOfTreatment planoftreatment)

        {
            this.Name = name;
            this.planoftreatment = planoftreatment;
        }
        public void TreatPatient()
        {
            Doctor resultdoc = planoftreatment.AppointDoctor();
            resultdoc.Healing();
        }
    }

}
