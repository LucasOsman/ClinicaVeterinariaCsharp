using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.ModelPoco;
using ClinicaVeterinaria.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeterinarioController : Controller
    {
        [HttpGet]
        public List<Veterinario> Index()
        {
            using var ctx = new Context();

            var veterinarioService = new VeterinarioService();
            var lista = veterinarioService.BuscarVeterinario(ctx);

            return lista;
        }
        [HttpPost]
        public void CriarCliente(Veterinario veterinario)
        {
            using var ctx = new Context();

            var veterinarioService = new VeterinarioService();
            veterinarioService.CriarVeterinario(ctx, veterinario);
        }
        [HttpPut]
        public void AtualizarVeterinario(int idVeterinario)
        {
            using var ctx = new Context();

            var veterinarioService = new VeterinarioService();
            veterinarioService.AtualiarVeterinario(ctx, idVeterinario);
        }
        [HttpDelete]
        public void DeletarVeterinario(int idVeterinario)
        {
            using var ctx = new Context();

            var veterinariaService = new VeterinarioService();
            veterinariaService.DeletarVeterinario(ctx, idVeterinario);
        }
    }
}
