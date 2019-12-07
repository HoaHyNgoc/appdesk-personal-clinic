using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using data_transfer_object;
using database_access_layer.PersonalClinicDataSetTableAdapters;

namespace database_access_layer
{
    public class DetailPrescriptionDAL: dbConnection
    {
        #region CRUD Methods

        public PersonalClinicDataSet.DETAIL_PRESCRIPTIONDataTable getData()
        {
            PersonalClinicDataSet.DETAIL_PRESCRIPTIONDataTable tblDelPrescription = new DETAIL_PRESCRIPTIONTableAdapter().GetData();
            return tblDelPrescription;
        }

        public int updateCoreDetailPrescription(DetailPrescriptionDTO originalDelPrescription)
        {

            int flagUpdate = new DETAIL_PRESCRIPTIONTableAdapter().updateDelPrescriptionQuery(
                originalDelPrescription.IdPrescription,
                originalDelPrescription.IdMedicine,
                originalDelPrescription.Number,
                originalDelPrescription.UseHelp,
                originalDelPrescription.Price,
                originalDelPrescription.IdDetailPrescription
                );

            return flagUpdate;
        }

        public int insertCoreDetailPrescription(DetailPrescriptionDTO newDelPrescription)
        {
            int flagInsert = new DETAIL_PRESCRIPTIONTableAdapter().insertDelPrescriptionQuery(
                newDelPrescription.IdPrescription,
                newDelPrescription.IdMedicine,
                newDelPrescription.Number,
                newDelPrescription.UseHelp,
                newDelPrescription.Price
                );

            return flagInsert;
        }

        #endregion CRUD Methods
    }
}
