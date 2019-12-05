using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_transfer_object
{
    public class PatientDTO
    {
        int _idPatient;
        string _idPassport;
        string _fullName;
        string _birthday;
        int _healthStatus;

        public int IdPatient { get => _idPatient; set => _idPatient = value; }
        public string IdPassport { get => _idPassport; set => _idPassport = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string Birthday { get => _birthday; set => _birthday = value; }
        public int HealthStatus { get => _healthStatus; set => _healthStatus = value; }
    }
}
