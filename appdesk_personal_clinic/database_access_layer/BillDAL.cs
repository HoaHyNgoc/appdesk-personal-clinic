using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using data_transfer_object;
using database_access_layer.PersonalClinicDataSetTableAdapters;


namespace database_access_layer
{
    public class BillDAL
    {
        #region CRUD Methods

        public PersonalClinicDataSet.BILLDataTable getData()
        {
            PersonalClinicDataSet.BILLDataTable tblBill = new BILLTableAdapter().GetData();
            return tblBill;
        }

        public int updateCoreBill(BillDTO originalBill)
        {

            int flagUpdate = new BILLTableAdapter().updateBillQuery(
                originalBill.IdPrescription,
                originalBill.IdTechnique,
                originalBill.IdPharmacist,
                originalBill.ValuePayBill,
                originalBill.dateInit,
                originalBill.IdBill,
                originalBill.IdPrescription
                );

            return flagUpdate;
        }

        public int insertCoreBill(BillDTO newBill)
        {
            int flagInsert = new BILLTableAdapter().insertBillQuery(
                newBill.IdPrescription,
                newBill.IdTechnique,
                newBill.IdPharmacist,
                newBill.ValuePayBill,
                newBill.dateInit
                );

            return flagInsert;
        }

        #endregion CRUD Methods
    }
}
