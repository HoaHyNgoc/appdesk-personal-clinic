using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using database_access_layer;
using data_transfer_object;

namespace business_logic_layer
{
    public class MedicineBUS
    {
        public MedicineDAL medicineDal = new MedicineDAL();

        #region Logical CRUD Methods

        public PersonalClinicDataSet.MEDICINEDataTable getData()
        {
            PersonalClinicDataSet.MEDICINEDataTable _tblMedicine = medicineDal.getData();
            return _tblMedicine;
        }

        public int updateMedicine(
            string idUnitMedicine,
            string fullName,
            string symbol,
            string ingredient,
            string priceUnit,
            string originalIdMedicine)
        {

            MedicineDTO currentMedicineDatarow = new MedicineDTO();
            currentMedicineDatarow.IdUnitMedicine = Convert.ToInt32(idUnitMedicine);
            currentMedicineDatarow.FullName = Convert.ToString(fullName);
            currentMedicineDatarow.Symbol = Convert.ToString(symbol);
            currentMedicineDatarow.Ingredient = Convert.ToString(ingredient);
            currentMedicineDatarow.PriceUnit = Convert.ToDecimal(priceUnit);
            currentMedicineDatarow.IdMedicine = Convert.ToInt32(originalIdMedicine);

            return medicineDal.updateCoreMedicine(currentMedicineDatarow);
        }

        public int insertDoctor(
            string idUnitMedicine,
            string fullName,
            string symbol,
            string ingredient,
            string priceUnit)
        {

            MedicineDTO currentMedicineDatarow = new MedicineDTO();
            currentMedicineDatarow.IdUnitMedicine = Convert.ToInt32(idUnitMedicine);
            currentMedicineDatarow.FullName = Convert.ToString(fullName);
            currentMedicineDatarow.Symbol = Convert.ToString(symbol);
            currentMedicineDatarow.Ingredient = Convert.ToString(ingredient);
            currentMedicineDatarow.PriceUnit = Convert.ToDecimal(priceUnit);

            return medicineDal.insertCoreMedicine(currentMedicineDatarow);
        }

        #endregion Logical CRUD Methods
    }
}
