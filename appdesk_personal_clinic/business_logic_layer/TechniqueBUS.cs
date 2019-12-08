using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using database_access_layer;
using data_transfer_object;

namespace business_logic_layer
{
    public class TechniqueBUS
    {
        public TechniqueDAL techniqueDal = new TechniqueDAL();

        #region Logical CRUD Methods

        public PersonalClinicDataSet.TECHNIQUEDataTable getData()
        {
            PersonalClinicDataSet.TECHNIQUEDataTable _tblTechnique = techniqueDal.getData();
            return _tblTechnique;
        }

        public int updateTechnique(
            string idDoctor,
            string price,
            string originalIdTechnique)
        {

            TechniqueDTO currentTechniqueDatarow = new TechniqueDTO();
            currentTechniqueDatarow.IdDoctor = Convert.ToInt32(idDoctor);
            currentTechniqueDatarow.Price = Convert.ToDecimal(price);
            currentTechniqueDatarow.IdTechnique = Convert.ToInt32(originalIdTechnique);

            return techniqueDal.updateCoreTechnique(currentTechniqueDatarow);
        }

        public int insertTechnique(
            string idDoctor,
            string price)
        {

            TechniqueDTO currentTechniqueDatarow = new TechniqueDTO();
            currentTechniqueDatarow.IdDoctor = Convert.ToInt32(idDoctor);
            currentTechniqueDatarow.Price = Convert.ToDecimal(price);

            return techniqueDal.insertCoreTechnique(currentTechniqueDatarow);
        }

        #endregion Logical CRUD Methods
    }
}
