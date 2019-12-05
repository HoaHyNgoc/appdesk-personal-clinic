using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using database_access_layer;
using data_transfer_object;

namespace business_logic_layer
{
    public class PatientBUS
    {
        public PatientDAL patientDal = new PatientDAL();

        #region Logical CRUD Methods

        public PersonalClinicDataSet.PATIENTDataTable getData()
        {
            PersonalClinicDataSet.PATIENTDataTable _tblPatient = patientDal.getData();
            return _tblPatient;
        }

        public PersonalClinicDataSet.PATIENTDataTable getDataTarget(string contentSearch)
        {
            PersonalClinicDataSet.PATIENTDataTable _tblPatient = patientDal.getCoreDataTarget(contentSearch);
            return _tblPatient;
        }

        public int updatePatient(
                string idPassport,
                string fullName,
                string birthday,
                string healthStatus,
                string originalIdPatient)
        {

            PatientDTO currentPatientDatarow = new PatientDTO();
            currentPatientDatarow.IdPassport = Convert.ToString(idPassport);
            currentPatientDatarow.FullName = Convert.ToString(fullName);
            currentPatientDatarow.Birthday = Convert.ToString(birthday);
            currentPatientDatarow.HealthStatus = Convert.ToInt32(healthStatus);
            currentPatientDatarow.IdPatient = Convert.ToInt32(originalIdPatient);

            return patientDal.updateCorePatient(currentPatientDatarow);
        }

        public int insertPatient(
                string idPassport,
                string fullName,
                string birthday,
                string healthStatus)
        {

            PatientDTO currentPatientDatarow = new PatientDTO();
            currentPatientDatarow.IdPassport = Convert.ToString(idPassport);
            currentPatientDatarow.FullName = Convert.ToString(fullName);
            currentPatientDatarow.Birthday = Convert.ToString(birthday);
            currentPatientDatarow.HealthStatus = Convert.ToInt32(healthStatus);

            return patientDal.insertCorePatient(currentPatientDatarow);
        }

        #endregion Logical CRUD Methods
    }
}
