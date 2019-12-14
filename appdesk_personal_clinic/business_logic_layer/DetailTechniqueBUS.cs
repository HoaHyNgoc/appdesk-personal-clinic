using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using database_access_layer;
using data_transfer_object;

namespace business_logic_layer
{
    public class DetailTechniqueBUS
    {
        public DetailTechniqueDAL delTechniqueDal = new DetailTechniqueDAL();

        #region Logical CRUD Methods

        public PersonalClinicDataSet.DETAIL_TECHNIQUEDataTable getData()
        {
            PersonalClinicDataSet.DETAIL_TECHNIQUEDataTable _tblDelTechnique = delTechniqueDal.getData();
            return _tblDelTechnique;
        }

        public PersonalClinicDataSet.DETAIL_TECHNIQUEDataTable getDataTarget(string _idTechnique)
        {
            PersonalClinicDataSet.DETAIL_TECHNIQUEDataTable _tblDelTechnique = delTechniqueDal.getDataTarget(Convert.ToInt32(_idTechnique));
            return _tblDelTechnique;
        }

        public int updateDelTechnique(
            string idTechnique,
            string idDiagnostic,
            string result,
            string price,
            string originalIdDetailTechnique)
        {

            DetailTechniqueDTO currentDelTechniqueDatarow = new DetailTechniqueDTO();
            currentDelTechniqueDatarow.IdTechnique = Convert.ToInt32(idTechnique);
            currentDelTechniqueDatarow.IdDiagnostic = Convert.ToInt32(idDiagnostic);
            currentDelTechniqueDatarow.Result = Convert.ToString(result);
            currentDelTechniqueDatarow.Price = Convert.ToDecimal(price);
            currentDelTechniqueDatarow.IdDetailTechnique = Convert.ToInt32(originalIdDetailTechnique);

            return delTechniqueDal.updateCoreDetailTechnique(currentDelTechniqueDatarow);
        }

        public int insertDelTechnique(
            string idTechnique,
            string idDiagnostic,
            string result,
            string price)
        {

            DoctorDTO currentDoctorDatarow = new DoctorDTO();
            DetailTechniqueDTO currentDelTechniqueDatarow = new DetailTechniqueDTO();
            currentDelTechniqueDatarow.IdTechnique = Convert.ToInt32(idTechnique);
            currentDelTechniqueDatarow.IdDiagnostic = Convert.ToInt32(idDiagnostic);
            currentDelTechniqueDatarow.Result = Convert.ToString(result);
            currentDelTechniqueDatarow.Price = Convert.ToDecimal(price);

            return delTechniqueDal.insertCoreDetailTechnique(currentDelTechniqueDatarow);
        }

        #endregion Logical CRUD Methods
    }
}
