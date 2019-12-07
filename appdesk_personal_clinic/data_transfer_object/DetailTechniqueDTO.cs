using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_transfer_object
{
    public class DetailTechniqueDTO
    {
        public int idDetailTechnique;
        public int idTechnique;
        public int idDiagnostic;
        public string result;
        public decimal price;

        public int IdDetailTechnique { get => idDetailTechnique; set => idDetailTechnique = value; }
        public int IdTechnique { get => idTechnique; set => idTechnique = value; }
        public int IdDiagnostic { get => idDiagnostic; set => idDiagnostic = value; }
        public string Result { get => result; set => result = value; }
        public decimal Price { get => price; set => price = value; }
    }
}
