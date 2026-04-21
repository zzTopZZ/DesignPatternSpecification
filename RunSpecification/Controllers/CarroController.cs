using Microsoft.AspNetCore.Mvc;
using RunSpecification.Domain.Entities;
using SeuProjeto.Domain.Validations;
using System.Linq;

namespace SeuProjeto.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarrosController : ControllerBase
    {
        /// <summary>
        /// Valida se um carro pode ser aceito no inventário de luxo
        /// </summary>
        [HttpPost("validar-estoque")]
        public IActionResult ValidarEntradaEstoque([FromBody] Carro carro)
        {
            if (carro == null) return BadRequest("Dados do carro não informados.");

            var validador = new CarroValidation();

            var resultado = validador.Validate(carro);

            if (!resultado.IsValid)
            {
                // Retorna 400 com a lista de mensagens de erro das Specs que falharam
                return BadRequest(new
                {
                    sucesso = false,
                    erros = resultado.Errors.Select(e => e.ErrorMessage)
                });
            }

            // 4. Se passou em todas as Specs
            return Ok(new
            {
                sucesso = true,
                mensagem = "Veículo validado com sucesso pelas regras de negócio!"
            });
        }
    }
}