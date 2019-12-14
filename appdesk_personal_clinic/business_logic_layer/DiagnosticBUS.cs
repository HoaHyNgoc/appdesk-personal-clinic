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

        public int getDataTargetIdDiagnostic(string _idDiagnostic)
        {
            int _priceDiagnostic = diagnosticDal.getPriceByIdDiagnostic(Convert.ToInt32(_idDiagnostic));
            return _priceDiagnostic;
        }

        public int updateDiagnostic(
            string idSpecialist,
            string numberRoom,
            string fullName,
            string price,
            string originalIdDiagnostic)
        {

            DiagnosticDTO currentDiagnosticDatarow = new DiagnosticDTO();
            currentDiagnosticDatarow.IdSpecialist = Convert.ToInt32(idSpecialist);
            currentDiagnosticDatarow.NumberRoom = Convert.ToString(numberRoom);
            currentDiagnosticDatarow.FullName = Convert.ToString(fullName);
            currentDiagnosticDatarow.Price = Convert.ToDecimal(price);
            currentDiagnosticDatarow.IdDiagnostic = Convert.ToInt32(originalIdDiagnostic);

            return diagnosticDal.updateCoreDiagnostic(currentDiagnosticDatarow);
        }

        public int insertDiagnostic(
            string idSpecialist,
            string numberRoom,
            string fullName,
            string price)
        {

            DiagnosticDTO currentDiagnosticDatarow = new DiagnosticDTO();
            currentDiagnosticDatarow.IdSpecialist = Convert.ToInt32(idSpecialist);
            currentDiagnosticDatarow.NumberRoom = Convert.ToString(numberRoom);
            currentDiagnosticDatarow.FullName = Convert.ToString(fullName);
            currentDiagnosticDatarow.Price = Convert.ToDecimal(price);

            return diagnosticDal.insertCoreDiagnostic(currentDiagnosticDatarow);
        }

        #endregion Logical CRUD Methods
    }
}
