using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.ModelPoco;
using ClinicaVeterinaria.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteContoller : Controller
    {
        [HttpGet]
        public List<Cliente> Index()
        {
            using var ctx = new Context();

            var clienteService = new ClienteService();
            var lista = clienteService.BuscarClientes(ctx);

            return lista;
        }

        [HttpPost]
        public void CriarCliente(Cliente cliente)
        {
            using var ctx = new Context();

            var criarCliente = new ClienteService();
            criarCliente.CriarCliente(ctx, cliente);
        }

        [HttpPut]
        public void AtualizarCliente (int idCliente)
        {
            using var ctx = new Context();

            var atualizarCliente = new ClienteService();
            atualizarCliente.AtualizarCliente(ctx, idCliente);
        }
        [HttpDelete]
        public void DeletarCliente (int idCliente)
        {
            using var ctx = new Context();

            var deletarCliente = new ClienteService();
            deletarCliente.DeletarCliente(ctx, idCliente);
        }
    }
}
