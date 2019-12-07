using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_transfer_object
{
    public class DetailPrescriptionDTO
    {
        public int idDetailPrescription;
        public int idPrescription;
        public int idMedicine;
        public int number;
        public string useHelp;
        public decimal price;

        public int IdDetailPrescription { get => idDetailPrescription; set => idDetailPrescription = value; }
        public int IdPrescription { get => idPrescription; set => idPrescription = value; }
        public int IdMedicine { get => idMedicine; set => idMedicine = value; }
        public int Number { get => number; set => number = value; }
        public string UseHelp { get => useHelp; set => useHelp = value; }
        public decimal Price { get => price; set => price = value; }
    }
}
