﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_transfer_object
{
    public class TechniqueDTO
    {
        public int idTechnique;
        public int idDoctor;
        public decimal price;

        public int IdTechnique { get => idTechnique; set => idTechnique = value; }
        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public decimal Price { get => price; set => price = value; }
    }
}