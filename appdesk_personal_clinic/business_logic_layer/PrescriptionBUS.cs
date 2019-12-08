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

        public int updatePrescription(
            string idPatient,
            string conclusionMedical,
            string price,
            string originalIdPrescription)
        {

            PrescriptionDTO currentPrescriptionDatarow = new PrescriptionDTO();
            currentPrescriptionDatarow.IdPatient = Convert.ToInt32(idPatient);
            currentPrescriptionDatarow.ConclusionMedical = Convert.ToString(conclusionMedical);
            currentPrescriptionDatarow.Price = Convert.ToDecimal(price);
            currentPrescriptionDatarow.IdPrescription = Convert.ToInt32(originalIdPrescription);

            return prescriptionDal.updateCorePrescription(currentPrescriptionDatarow);
        }

        public int insertPrescription(
            string idPatient,
            string conclusionMedical,
            string price)
        {

            PrescriptionDTO currentPrescriptionDatarow = new PrescriptionDTO();
            currentPrescriptionDatarow.IdPatient = Convert.ToInt32(idPatient);
            currentPrescriptionDatarow.ConclusionMedical = Convert.ToString(conclusionMedical);
            currentPrescriptionDatarow.Price = Convert.ToDecimal(price);

            return prescriptionDal.insertCorePrescription(currentPrescriptionDatarow);
        }

        #endregion Logical CRUD Methods
    }
}
