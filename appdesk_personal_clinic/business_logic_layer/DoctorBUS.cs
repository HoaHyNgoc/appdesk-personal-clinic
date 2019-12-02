using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using database_access_layer;
using data_transfer_object;

namespace business_logic_layer
{
    public class DoctorBUS
    {
        public DoctorDAL doctorDal = new DoctorDAL();

        #region Logical CRUD Methods

        public PersonalClinicDataSet.DOCTORDataTable getData()
        {
            PersonalClinicDataSet.DOCTORDataTable _tblDoctor = doctorDal.getData();
            return _tblDoctor;
        }

        public int updateDoctor(
            string idSpecialist,
            string idPassport,
            string fullName,
            string isGeneral,
            string originalIdDoctor) {

            DoctorDTO currentDoctorDatarow = new DoctorDTO();
            currentDoctorDatarow.IdSpecialist = Convert.ToInt32(idSpecialist);
            currentDoctorDatarow.IdPassport = Convert.ToString(idPassport);
            currentDoctorDatarow.FullName = Convert.ToString(fullName);
            currentDoctorDatarow.IsGeneral = Convert.ToInt32(isGeneral);
            currentDoctorDatarow.IdDoctor = Convert.ToInt32(originalIdDoctor);

            return doctorDal.updateCoreDoctor(currentDoctorDatarow);
        }

        #endregion Logical CRUD Methods
    }
}
