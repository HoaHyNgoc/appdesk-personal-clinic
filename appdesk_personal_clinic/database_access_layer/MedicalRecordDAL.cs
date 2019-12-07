using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using data_transfer_object;
using database_access_layer.PersonalClinicDataSetTableAdapters;

namespace database_access_layer
{
    public class MedicalRecordDAL: dbConnection
    {
        #region CRUD Methods

        public PersonalClinicDataSet.MEDICAL_RECORDDataTable getData()
        {
            PersonalClinicDataSet.MEDICAL_RECORDDataTable tblMedicalRecord = new MEDICAL_RECORDTableAdapter().GetData();
            return tblMedicalRecord;
        }

        public PersonalClinicDataSet.MEDICAL_RECORDDataTable getCoreDataTarget(string contentSearch)
        {
            PersonalClinicDataSet.MEDICAL_RECORDDataTable tblMedicalRecord = new MEDICAL_RECORDTableAdapter().GetDataByContentSearch(Convert.ToInt32(contentSearch));
            return tblMedicalRecord;
        }

        public int updateCoreMedicalRecord(MedicalRecordDTO originalMedicalRecord)
        {

            int flagUpdate = new MEDICAL_RECORDTableAdapter().updateMedicalRecordQuery(
                originalMedicalRecord.IdPatient,
                originalMedicalRecord.IdDoctor,
                originalMedicalRecord.History,
                originalMedicalRecord.DateInitMedical,
                originalMedicalRecord.Request,
                originalMedicalRecord.IdMedicalRecord
                );

            return flagUpdate;
        }

        public int insertCoreMedicalRecord(MedicalRecordDTO newMedicalRecord)
        {
            int flagInsert = new MEDICAL_RECORDTableAdapter().insertMedicalRecordQuery(
                newMedicalRecord.IdPatient,
                newMedicalRecord.IdDoctor,
                newMedicalRecord.History,
                newMedicalRecord.DateInitMedical,
                newMedicalRecord.Request
                );

            return flagInsert;
        }

        #endregion CRUD Methods
    }
}
