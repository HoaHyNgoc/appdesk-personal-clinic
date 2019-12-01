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

        public PersonalClinicDataSet.DOCTORDataTable getData()
        {
            PersonalClinicDataSet.DOCTORDataTable _tblDoctor = doctorDal.getData();
            return _tblDoctor;
        }
    }
}
