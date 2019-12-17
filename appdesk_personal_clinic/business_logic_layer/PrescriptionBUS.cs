using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using database_access_layer;
using data_transfer_object;

namespace business_logic_layer
{
    public class PrescriptionBUS
    {
        public PrescriptionDAL prescriptionDal = new PrescriptionDAL();

        #region Logical CRUD Methods

        public PersonalClinicDataSet.PRESCRIPTIONDataTable getData()
        {
            PersonalClinicDataSet.PRESCRIPTIONDataTable _tblPrescription = prescriptionDal.getData();
            return _tblPrescription;
        }

        public PersonalClinicDataSet.PRESCRIPTIONDataTable getDataTarget(string contentSearch)
        {
            if (contentSearch != "")
            {
                PersonalClinicDataSet.PRESCRIPTIONDataTable _tblPrescription = prescriptionDal.getCoreDataTarget(contentSearch);
                return _tblPrescription;
            }
            return null;
        }

        public int updatePrescription(
            string idPatient,
            string conclusionMedical,
            string price,
            string xtime,
            string originalIdPrescription)
        {

            PrescriptionDTO currentPrescriptionDatarow = new PrescriptionDTO();
            currentPrescriptionDatarow.IdPatient = Convert.ToInt32(idPatient);
            currentPrescriptionDatarow.ConclusionMedical = Convert.ToString(conclusionMedical);
            currentPrescriptionDatarow.Price = Convert.ToDecimal(price);
            currentPrescriptionDatarow.IdPrescription = Convert.ToInt32(originalIdPrescription);
            currentPrescriptionDatarow.DayTime = Convert.ToDateTime(xtime);

            return prescriptionDal.updateCorePrescription(currentPrescriptionDatarow);
        }

        public int insertPrescription(
            string idPatient,
            string conclusionMedical,
            string price,
            string xtime)
        {

            PrescriptionDTO currentPrescriptionDatarow = new PrescriptionDTO();
            currentPrescriptionDatarow.IdPatient = Convert.ToInt32(idPatient);
            currentPrescriptionDatarow.ConclusionMedical = Convert.ToString(conclusionMedical);
            currentPrescriptionDatarow.Price = Convert.ToDecimal(price);
            currentPrescriptionDatarow.DayTime = Convert.ToDateTime(xtime);

            return prescriptionDal.insertCorePrescription(currentPrescriptionDatarow);
        }

        #endregion Logical CRUD Methods
    }
}
