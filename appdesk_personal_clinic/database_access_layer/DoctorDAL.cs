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
    public class DoctorDAL: dbConnection
    {
        #region CRUD Methods

        public PersonalClinicDataSet.DOCTORDataTable getData()
        {
            PersonalClinicDataSet.DOCTORDataTable tblDoctor = new DOCTORTableAdapter().GetData();
            return tblDoctor;
        }

        public int updateCoreDoctor(DoctorDTO originalDoctor) {

            int flagUpdate = new DOCTORTableAdapter().updateDoctorQuery(
                originalDoctor.IdSpecialist,
                originalDoctor.IdPassport,
                originalDoctor.FullName,
                originalDoctor.IsGeneral,
                originalDoctor.IdDoctor
            );

            return flagUpdate;
        }

        #endregion CRUD Methods
    }
}
