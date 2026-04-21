using NetDevPack.Domain;
using NetDevPack.Specification;
using RunSpecification.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace RunSpecification.Domain.Specs
{
    public class CarroDoAnoSpec : Specification<Carro>
    {
        public override Expression<Func<Carro, bool>> ToExpression()
        {
            // Regra: O modelo deve ser igual ou superior ao ano corrente
            return carro => carro.AnoModelo >= DateTime.Now.Year;
        }
    }
}