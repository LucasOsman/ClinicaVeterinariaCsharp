using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.ModelPoco;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ClinicaVeterinaria.Service
{
    public class ClienteService
    {
        public List<Cliente> BuscarClientes(Context ctx)
        {
            var listaCliente = ctx.Clientes.OrderBy(x => x.Nome).ToList();
            return listaCliente;
        }
        public void CriarCliente(Context ctx, Cliente cliente)
        {
            ctx.Clientes.Add(cliente);
            ctx.SaveChanges();
        }
        public void AtualizarCliente(Context ctx, int idCliente)
        {
            var clienteEncontrado = ctx.Clientes.FirstOrDefault(x => x.Equals(idCliente));

            ctx.Entry(clienteEncontrado).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public void DeletarCliente (Context ctx, int idCliente)
        {
            var deletarCliente = ctx.Clientes.FirstOrDefault(x => x.Equals(idCliente));

            ctx.Clientes.Remove(deletarCliente);
            ctx.SaveChanges();
        }
       
    }
}
