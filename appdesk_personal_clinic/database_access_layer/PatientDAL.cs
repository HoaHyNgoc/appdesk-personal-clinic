using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using data_transfer_object;
using database_access_layer.PersonalClinicDataSetTableAdapters;

namespace database_access_layer
{
    public class PatientDAL: dbConnection
    {
        #region CRUD Methods

        public PersonalClinicDataSet.PATIENTDataTable getData()
        {
            PersonalClinicDataSet.PATIENTDataTable tblPatient = new PATIENTTableAdapter().GetData();
            return tblPatient;
        }

        public PersonalClinicDataSet.PATIENTDataTable getCoreDataTarget(string contentSearch)
        {
            PersonalClinicDataSet.PATIENTDataTable tblPatient = new PATIENTTableAdapter().GetDataByContentSearch(contentSearch);
            return tblPatient;
        }

        public int updateCorePatient(PatientDTO originalPatient)
        {

            int flagUpdate = new PATIENTTableAdapter().updatePatientQuery(
                originalPatient.IdPassport,
                originalPatient.FullName,
                originalPatient.Birthday,
                originalPatient.HealthStatus,
                originalPatient.IdPatient
                );

            return flagUpdate;
        }

        public int insertCorePatient(PatientDTO newPatient)
        {
            int flagInsert = new PATIENTTableAdapter().insertPatientQuery(
                newPatient.IdPassport,
                newPatient.FullName,
                newPatient.Birthday,
                newPatient.HealthStatus
                );

            return flagInsert;
        }

        #endregion CRUD Methods
    }
}
