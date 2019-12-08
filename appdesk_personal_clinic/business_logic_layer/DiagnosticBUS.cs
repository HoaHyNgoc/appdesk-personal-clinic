using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using database_access_layer;
using data_transfer_object;

namespace business_logic_layer
{
    public class DiagnosticBUS
    {
        public DiagnosticDAL diagnosticDal = new DiagnosticDAL();

        #region Logical CRUD Methods

        public PersonalClinicDataSet.DIAGNOSTICDataTable getData()
        {
            PersonalClinicDataSet.DIAGNOSTICDataTable _tblDiagnostic = diagnosticDal.getData();
            return _tblDiagnostic;
        }

        public int updateDiagnostic(
            string idSpecialist,
            string numberRoom,
            string fullName,
            string originalIdDiagnostic)
        {

            DiagnosticDTO currentDiagnosticDatarow = new DiagnosticDTO();
            currentDiagnosticDatarow.IdSpecialist = Convert.ToInt32(idSpecialist);
            currentDiagnosticDatarow.NumberRoom = Convert.ToString(numberRoom);
            currentDiagnosticDatarow.FullName = Convert.ToString(fullName);
            currentDiagnosticDatarow.IdDiagnostic = Convert.ToInt32(originalIdDiagnostic);

            return diagnosticDal.updateCoreDiagnostic(currentDiagnosticDatarow);
        }

        public int insertDiagnostic(
            string idSpecialist,
            string numberRoom,
            string fullName)
        {

            DiagnosticDTO currentDiagnosticDatarow = new DiagnosticDTO();
            currentDiagnosticDatarow.IdSpecialist = Convert.ToInt32(idSpecialist);
            currentDiagnosticDatarow.NumberRoom = Convert.ToString(numberRoom);
            currentDiagnosticDatarow.FullName = Convert.ToString(fullName);

            return diagnosticDal.insertCoreDiagnostic(currentDiagnosticDatarow);
        }

        #endregion Logical CRUD Methods
    }
}
