using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_transfer_object
{
    public class MedicalRecordDTO
    {
        public int idMedicalRecord;
        public int idPatient;
        public int idDoctor;
        public string history;
        public string dateInitMedical;
        public string request;

        public int IdMedicalRecord { get => idMedicalRecord; set => idMedicalRecord = value; }
        public int IdPatient { get => idPatient; set => idPatient = value; }
        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string History { get => history; set => history = value; }
        public string DateInitMedical { get => dateInitMedical; set => dateInitMedical = value; }
        public string Request { get => request; set => request = value; }
    }
}
