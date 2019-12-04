using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using data_transfer_object;
using database_access_layer.PersonalClinicDataSetTableAdapters;

namespace database_access_layer
{
    public class MedicineDAL: dbConnection
    {
        public PersonalClinicDataSet.MEDICINEDataTable getData()
        {
            PersonalClinicDataSet.MEDICINEDataTable tblMedicine = new MEDICINETableAdapter().GetData();
            return tblMedicine;
        }

        public int updateCoreMedicine(MedicineDTO originalMedicine)
        {
            int flagUpdate = new MEDICINETableAdapter().updateMedicineQuery(
                originalMedicine.IdUnitMedicine,
                originalMedicine.FullName,
                originalMedicine.Symbol,
                originalMedicine.Ingredient,
                originalMedicine.PriceUnit,
                originalMedicine.IdMedicine
                );

            return flagUpdate;
        }

        public int insertCoreMedicine(MedicineDTO newMedicine)
        {
            int flagInsert = new MEDICINETableAdapter().insertMedicineQuery(
                newMedicine.IdUnitMedicine,
                newMedicine.FullName,
                newMedicine.Symbol,
                newMedicine.Ingredient,
                newMedicine.PriceUnit
                );

            return flagInsert;
        }
    }
}
