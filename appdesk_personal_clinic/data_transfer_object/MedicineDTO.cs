using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_transfer_object
{
    public class MedicineDTO
    {
        int _idMedicine;
        int _idUnitMedicine;
        string _fullName;
        string _symbol;
        string _ingredient;
        decimal _priceUnit;

        public int IdMedicine { get => _idMedicine; set => _idMedicine = value; }
        public int IdUnitMedicine { get => _idUnitMedicine; set => _idUnitMedicine = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string Symbol { get => _symbol; set => _symbol = value; }
        public string Ingredient { get => _ingredient; set => _ingredient = value; }
        public decimal PriceUnit { get => _priceUnit; set => _priceUnit = value; }
    }
}
