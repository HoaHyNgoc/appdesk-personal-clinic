using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_transfer_object
{
    public class BillDTO
    {
        public int idBill;
        public int idPrescription;
        public int idTechnique;
        public int idPharmacist;
        public decimal valuePayBill;
        public DateTime dateInit;

        public int IdBill { get => idBill; set => idBill = value; }
        public int IdPrescription { get => idPrescription; set => idPrescription = value; }
        public int IdTechnique { get => idTechnique; set => idTechnique = value; }
        public int IdPharmacist { get => idPharmacist; set => idPharmacist = value; }
        public decimal ValuePayBill { get => valuePayBill; set => valuePayBill = value; }
        public DateTime DateInit { get => dateInit; set => dateInit = value; }
    }
}
