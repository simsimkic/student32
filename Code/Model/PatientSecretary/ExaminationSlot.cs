using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospPatient.Code.Model.PatientSecretary
{
    public class ExaminationSlot
    {

        public string time { get; set; }
        public bool isFree { get; set; }

        public ExaminationSlot(string time, bool isFree)
        {
            this.time = time;
            this.isFree = isFree;
        }

        public ExaminationSlot(string time)
        {
            this.time = time;
            this.isFree = true;
        }

        public bool takeSlot()
        {
            if (this.isFree == false)
                return false;

            this.isFree = false;
            return true;
        }

        public bool makeSlotFree()
        {
            if (this.isFree == true)
                return false;

            this.isFree = true;
            return true;
        }



    }
}
