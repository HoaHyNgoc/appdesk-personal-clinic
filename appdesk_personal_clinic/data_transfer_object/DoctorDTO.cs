using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_transfer_object
{
    public class DoctorDTO
    {
        public int _idDoctor;
        public string _idSpecialist;
        public string _idPassport;
        public string _fullName;
        public int _isGeneral;

        public int IdDoctor { get => _idDoctor; set => _idDoctor = value; }
        public string IdSpecialist { get => _idSpecialist; set => _idSpecialist = value; }
        public string IdPassport { get => _idPassport; set => _idPassport = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public int IsGeneral { get => _isGeneral; set => _isGeneral = value; }
    }
}
