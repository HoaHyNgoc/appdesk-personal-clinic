using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_transfer_object
{
    public class PrescriptionDTO
    {
        public int idPrescription;
        public int idPatient;
        public string conclusionMedical;
        public decimal price;
        public DateTime dateTime;

        public int IdPrescription { get => idPrescription; set => idPrescription = value; }
        public int IdPatient { get => idPatient; set => idPatient = value; }
        public string ConclusionMedical { get => conclusionMedical; set => conclusionMedical = value; }
        public decimal Price { get => price; set => price = value; }
        public DateTime DayTime { get => dateTime; set => dateTime = value; }
    }
}
