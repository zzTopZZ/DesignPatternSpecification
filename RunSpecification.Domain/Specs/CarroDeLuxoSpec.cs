using NetDevPack.Domain; // Namespace comum para Specification Pattern
using NetDevPack.Specification;
using RunSpecification.Domain.Entities;
using RunSpecification.Domain.Enums;
using System.Linq.Expressions;

namespace RunSpecification.Domain.Specs
{
    public class CarroDeLuxoSpec : Specification<Carro>
    {
        public override Expression<Func<Carro, bool>> ToExpression()
        {
            // Regra: Preto, Sedã e Ano >= (Ano Atual - 2)
            return carro => carro.Cor == Cor.Preto &&
                            carro.Carroceria == Carroceria.Seda &&
                            carro.AnoModelo >= (DateTime.Now.Year - 2);
        }
    }
}