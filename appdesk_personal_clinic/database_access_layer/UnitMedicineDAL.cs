using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using data_transfer_object;
using database_access_layer.PersonalClinicDataSetTableAdapters;

namespace database_access_layer
{
    public class UnitMedicineDAL: dbConnection
    {
        public PersonalClinicDataSet.UNIT_MEDICINEDataTable getData()
        {
            PersonalClinicDataSet.UNIT_MEDICINEDataTable tblUnitMedicine = new UNIT_MEDICINETableAdapter().GetData();
            return tblUnitMedicine;
        }

        public int updateCoreUnitMedicine(UnitMedicineDTO originalUnitMedicine)
        {
            int flagUpdate = new UNIT_MEDICINETableAdapter().updateUnitMedicineQuery(
                originalUnitMedicine.FullNameUnit,
                originalUnitMedicine.IdUnitMedicine
                );

            return flagUpdate;
        }

        public int insertCoreUnitMedicine(UnitMedicineDTO newUnitMedicine)
        {
            int flagInsert = new UNIT_MEDICINETableAdapter().insertUnitMedicineQuery(
                newUnitMedicine.FullNameUnit
                );

            return flagInsert;
        }
    }
}
