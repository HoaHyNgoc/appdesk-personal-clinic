using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_transfer_object
{
    public class UnitMedicineDTO
    {
        int _idUnitMedicine;
        string _fullNameUnit;

        public int IdUnitMedicine { get => _idUnitMedicine; set => _idUnitMedicine = value; }
        public string FullNameUnit { get => _fullNameUnit; set => _fullNameUnit = value; }
    }
}
