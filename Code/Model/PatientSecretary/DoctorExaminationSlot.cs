using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospPatient.Code.Model.PatientSecretary
{
    public class DoctorExaminationSlot
    {
        //Dictionary<string, List<ExaminationSlot>>

        public string doctorUsername { get; set; }
        public List<string> dates { get; set; }
        public List<SlotList> examSlots { get; set; }

        public DoctorExaminationSlot(string doctorUsername, List<string> dates, List<SlotList> examSlots)
        {
            this.doctorUsername = doctorUsername;
            this.dates = dates;
            this.examSlots = examSlots;
        }


       
    }

    public class SlotList
    {
        public List<ExaminationSlot> examSlots { get; set; }

        public SlotList(List<ExaminationSlot> examSlots)
        {
            this.examSlots = examSlots;
        }
    }





}
