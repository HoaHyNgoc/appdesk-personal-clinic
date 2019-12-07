using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using data_transfer_object;
using database_access_layer.PersonalClinicDataSetTableAdapters;

namespace database_access_layer
{
    public class DiagnosticDAL: dbConnection
    {
        #region CRUD Methods

        public PersonalClinicDataSet.DIAGNOSTICDataTable getData()
        {
            PersonalClinicDataSet.DIAGNOSTICDataTable tblDiagnostic = new DIAGNOSTICTableAdapter().GetData();
            return tblDiagnostic;
        }

        public int updateCoreDiagnostic(DiagnosticDTO originalDiagnostic)
        {

            int flagUpdate = new DIAGNOSTICTableAdapter().updateDiagnosticQuery(
                originalDiagnostic.IdSpecialist,
                originalDiagnostic.NumberRoom,
                originalDiagnostic.FullName,
                originalDiagnostic.IdDiagnostic
                );

            return flagUpdate;
        }

        public int insertCoreDiagnostic(DiagnosticDTO newDiagnostic)
        {
            int flagInsert = new DIAGNOSTICTableAdapter().insertDiagnosticQuery(
                newDiagnostic.IdSpecialist,
                newDiagnostic.NumberRoom,
                newDiagnostic.FullName
                );

            return flagInsert;
        }

        #endregion CRUD Methods
    }
}
