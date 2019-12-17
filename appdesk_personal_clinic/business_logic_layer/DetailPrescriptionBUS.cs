using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using database_access_layer;
using data_transfer_object;

namespace business_logic_layer
{
    public class DetailPrescriptionBUS
    {
        public DetailPrescriptionDAL delPrescriptionDal = new DetailPrescriptionDAL();

        #region Logical CRUD Methods

        public PersonalClinicDataSet.DETAIL_PRESCRIPTIONDataTable getData()
        {
            PersonalClinicDataSet.DETAIL_PRESCRIPTIONDataTable _tblDelPrescription = delPrescriptionDal.getData();
            return _tblDelPrescription;
        }

        public PersonalClinicDataSet.DETAIL_PRESCRIPTIONDataTable getDataTarget(string _idPrescription)
        {
            PersonalClinicDataSet.DETAIL_PRESCRIPTIONDataTable _tblDelPrescription = delPrescriptionDal.getDataTarget(Convert.ToInt32(_idPrescription));
            return _tblDelPrescription;
        }

        public int updateDelPrescription(
            string idPrescription,
            string idMedicine,
            string number,
            string useHelp,
            string price,
            string originalIdDetailPrescription)
        {

            DetailPrescriptionDTO currentDelPrescriptionDatarow = new DetailPrescriptionDTO();
            currentDelPrescriptionDatarow.IdPrescription = Convert.ToInt32(idPrescription);
            currentDelPrescriptionDatarow.IdMedicine = Convert.ToInt32(idMedicine);
            currentDelPrescriptionDatarow.Number = Convert.ToInt32(number);
            currentDelPrescriptionDatarow.UseHelp = Convert.ToString(useHelp);
            currentDelPrescriptionDatarow.Price = Convert.ToDecimal(price);
            currentDelPrescriptionDatarow.IdDetailPrescription = Convert.ToInt32(originalIdDetailPrescription);

            return delPrescriptionDal.updateCoreDetailPrescription(currentDelPrescriptionDatarow);
        }

        public int insertDelPrescription(
            string idPrescription,
            string idMedicine,
            string number,
            string useHelp,
            string price)
        {

            DetailPrescriptionDTO currentDelPrescriptionDatarow = new DetailPrescriptionDTO();
            currentDelPrescriptionDatarow.IdPrescription = Convert.ToInt32(idPrescription);
            currentDelPrescriptionDatarow.IdMedicine = Convert.ToInt32(idMedicine);
            currentDelPrescriptionDatarow.Number = Convert.ToInt32(number);
            currentDelPrescriptionDatarow.UseHelp = Convert.ToString(useHelp);
            currentDelPrescriptionDatarow.Price = Convert.ToDecimal(price);

            return delPrescriptionDal.insertCoreDetailPrescription(currentDelPrescriptionDatarow);
        }

        public int deleteDelPrescription(string selectedIdDetailPrescription)
        {
            return delPrescriptionDal.deleteCoreDetailPrescription(Convert.ToInt32(selectedIdDetailPrescription));
        }

        #endregion Logical CRUD Methods
    }
}
