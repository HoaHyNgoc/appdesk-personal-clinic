using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using data_transfer_object;
using database_access_layer.PersonalClinicDataSetTableAdapters;

namespace database_access_layer
{
    public class DetailTechniqueDAL: dbConnection
    {
        #region CRUD Methods

        public PersonalClinicDataSet.DETAIL_TECHNIQUEDataTable getData()
        {
            PersonalClinicDataSet.DETAIL_TECHNIQUEDataTable tblDelTechnique = new DETAIL_TECHNIQUETableAdapter().GetData();
            return tblDelTechnique;
        }

        public PersonalClinicDataSet.DETAIL_TECHNIQUEDataTable getDataTarget(int _idTechnique)
        {
            PersonalClinicDataSet.DETAIL_TECHNIQUEDataTable tblDelTechnique = new DETAIL_TECHNIQUETableAdapter().GetDataByIdTechnique(_idTechnique);
            return tblDelTechnique;
        }

        public int updateCoreDetailTechnique(DetailTechniqueDTO originalDelTechnique)
        {

            int flagUpdate = new DETAIL_TECHNIQUETableAdapter().updateDelTechniqueQuery(
                originalDelTechnique.IdTechnique,
                originalDelTechnique.IdDiagnostic,
                originalDelTechnique.Result,
                originalDelTechnique.Price,
                originalDelTechnique.IdDetailTechnique
                );

            return flagUpdate;
        }

        public int insertCoreDetailTechnique(DetailTechniqueDTO newDelTechnique)
        {
            int flagInsert = new DETAIL_TECHNIQUETableAdapter().insertDelTechniqueQuery(
                newDelTechnique.IdTechnique,
                newDelTechnique.IdDiagnostic,
                newDelTechnique.Result,
                newDelTechnique.Price
                );

            return flagInsert;
        }

        #endregion CRUD Methods
    }
}
