using RunSpecification.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace RunSpecification.Domain.Entities
{
    public class Carro
    {
        public int AnoModelo { get; set; }
        public string Modelo { get; set; }
        public Cor Cor { get; set; }
        public Carroceria Carroceria { get; set; }
    }
}
