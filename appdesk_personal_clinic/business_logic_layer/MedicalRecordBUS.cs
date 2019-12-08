using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using database_access_layer;
using data_transfer_object;

namespace business_logic_layer
{
    public class MedicalRecordBUS
    {
        public MedicalRecordDAL medicalRecordDAL = new MedicalRecordDAL();

        #region Logical CRUD Methods

        public PersonalClinicDataSet.MEDICAL_RECORDDataTable getData()
        {
            PersonalClinicDataSet.MEDICAL_RECORDDataTable _tblMedicalRecord = medicalRecordDAL.getData();
            return _tblMedicalRecord;
        }

        public PersonalClinicDataSet.MEDICAL_RECORDDataTable getDataTarget(string contentSearch)
        {
            if(contentSearch != "")
            {
                PersonalClinicDataSet.MEDICAL_RECORDDataTable _tblMedicalRecord = medicalRecordDAL.getCoreDataTarget(contentSearch);
                return _tblMedicalRecord;
            }
            return null;
        }

        public int updateMedicalRecord(
                string idPatient,
                string idDoctor,
                string history,
                string dateInitMedical,
                string request,
                string originalIdMedicalRecord)
        {

            MedicalRecordDTO currentMedicalRecordrow = new MedicalRecordDTO();
            currentMedicalRecordrow.IdPatient = Convert.ToInt32(idPatient);
            currentMedicalRecordrow.IdDoctor = Convert.ToInt32(idDoctor);
            currentMedicalRecordrow.History = Convert.ToString(history);
            currentMedicalRecordrow.DateInitMedical = Convert.ToString(dateInitMedical);
            currentMedicalRecordrow.Request = Convert.ToString(request);
            currentMedicalRecordrow.IdMedicalRecord = Convert.ToInt32(originalIdMedicalRecord);

            return medicalRecordDAL.updateCoreMedicalRecord(currentMedicalRecordrow);
        }

        public int insertMedicalRecord(
                string idPatient,
                string idDoctor,
                string history,
                string dateInitMedical,
                string request)
        {

            MedicalRecordDTO currentMedicalRecordrow = new MedicalRecordDTO();
            currentMedicalRecordrow.IdPatient = Convert.ToInt32(idPatient);
            currentMedicalRecordrow.IdDoctor = Convert.ToInt32(idDoctor);
            currentMedicalRecordrow.History = Convert.ToString(history);
            currentMedicalRecordrow.DateInitMedical = Convert.ToString(dateInitMedical);
            currentMedicalRecordrow.Request = Convert.ToString(request);

            return medicalRecordDAL.insertCoreMedicalRecord(currentMedicalRecordrow);
        }

        #endregion Logical CRUD Methods
    }
}
