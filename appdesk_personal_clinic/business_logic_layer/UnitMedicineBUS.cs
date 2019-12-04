using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using database_access_layer;
using data_transfer_object;

namespace business_logic_layer
{
    public class UnitMedicineBUS
    {
        public UnitMedicineDAL unitMedicineDal = new UnitMedicineDAL();

        #region Logical CRUD Methods

        public PersonalClinicDataSet.UNIT_MEDICINEDataTable getData()
        {
            PersonalClinicDataSet.UNIT_MEDICINEDataTable _tblUnitMedicine = unitMedicineDal.getData();
            return _tblUnitMedicine;
        }

        public int updateUnitMedicine(
            string fullNameUnit,
            string originalIdUnitMedicine)
        {

            UnitMedicineDTO currentUnitMedicineDatarow = new UnitMedicineDTO();
            currentUnitMedicineDatarow.FullNameUnit = Convert.ToString(fullNameUnit);
            currentUnitMedicineDatarow.IdUnitMedicine = Convert.ToInt32(originalIdUnitMedicine);

            return unitMedicineDal.updateCoreUnitMedicine(currentUnitMedicineDatarow);
        }

        public int insertUnitMedicine(
            string fullNameUnit)
        {

            UnitMedicineDTO currentUnitMedicineDatarow = new UnitMedicineDTO();
            currentUnitMedicineDatarow.FullNameUnit = Convert.ToString(fullNameUnit);

            return unitMedicineDal.insertCoreUnitMedicine(currentUnitMedicineDatarow);
        }

        #endregion Logical CRUD Methods
    }
}
