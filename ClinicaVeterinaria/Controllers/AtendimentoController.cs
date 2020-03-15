using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.ModelPoco;
using ClinicaVeterinaria.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtendimentoController : Controller
    {
        [HttpGet]
        public List<Atendimento> Index()
        {
            using var ctx = new Context();

            var atendimentoService = new AtendimentoService();
            var lista = atendimentoService.BuscarAtendimento(ctx);

            return lista;
        }

        [HttpPost]
        public void CriarAtendimento(Atendimento Atendimento)
        {
            using var ctx = new Context();

            var criarAtendimento = new AtendimentoService();
            criarAtendimento.CriarAtendimento(ctx, Atendimento);
        }
        [HttpPut]
        public void AtualizarAtendimento(int idAtendimento)
        {
            using var ctx = new Context();

            var atualizarAtendimento = new AtendimentoService();
            atualizarAtendimento.AtualizarAtendimento(ctx, idAtendimento);
        }
        [HttpDelete]
        public void DeletarAtendimento(int idAtendimento)
        {
            using var ctx = new Context();

            var deletarAtendimento = new AtendimentoService();
            deletarAtendimento.DeletarAtendimento(ctx, idAtendimento);
        }
    }
}
