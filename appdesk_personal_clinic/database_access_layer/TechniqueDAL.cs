using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using data_transfer_object;
using database_access_layer.PersonalClinicDataSetTableAdapters;

namespace database_access_layer
{
    public class TechniqueDAL: dbConnection
    {
        #region CRUD Methods

        public PersonalClinicDataSet.TECHNIQUEDataTable getData()
        {
            PersonalClinicDataSet.TECHNIQUEDataTable tblTechnique = new TECHNIQUETableAdapter().GetData();
            return tblTechnique;
        }

        public int updateCoreTechnique(TechniqueDTO originalTechnique)
        {

            int flagUpdate = new TECHNIQUETableAdapter().updateTechniqueQuery(
                originalTechnique.IdDoctor,
                originalTechnique.Price,
                originalTechnique.IdTechnique
                );

            return flagUpdate;
        }

        public int insertCoreTechnique(TechniqueDTO newTechnique)
        {
            int flagInsert = new TECHNIQUETableAdapter().insertTechniqueQuery(
                newTechnique.IdDoctor,
                newTechnique.Price
                );

            return flagInsert;
        }

        #endregion CRUD Methods
    }
}
