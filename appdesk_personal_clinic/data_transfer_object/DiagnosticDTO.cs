using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_transfer_object
{
    public class DiagnosticDTO
    {
        public int idDiagnostic;
        public int idSpecialist;
        public string numberRoom;
        public string fullName;

        public int IdDiagnostic { get => idDiagnostic; set => idDiagnostic = value; }
        public int IdSpecialist { get => idSpecialist; set => idSpecialist = value; }
        public string NumberRoom { get => numberRoom; set => numberRoom = value; }
        public string FullName { get => fullName; set => fullName = value; }
    }
}
