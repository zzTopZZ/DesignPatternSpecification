using NetDevPack.Domain;
using NetDevPack.Specification;
using RunSpecification.Domain.Entities;
using RunSpecification.Domain.Specs;

namespace SeuProjeto.Domain.Validations
{
    public class CarroValidation : SpecValidator<Carro>
    {
        public CarroValidation()
        {
            // Instanciamos as regras (Specs)
            var luxoSpec = new CarroDeLuxoSpec();
            var doAnoSpec = new CarroDoAnoSpec();

            // Adicionamos as regras ao validador com suas respectivas mensagens
            // O primeiro parâmetro é um nome/chave para a regra
            // O segundo é a Regra (Spec + Mensagem de erro)

            Add("carroLuxo", new Rule<Carro>(luxoSpec, "Este veículo não atende aos critérios de um carro de luxo (deve ser Sedã, Preto e seminovo)."));

            Add("carroNovo", new Rule<Carro>(doAnoSpec, "O veículo informado não é do ano atual."));
        }
    }
}