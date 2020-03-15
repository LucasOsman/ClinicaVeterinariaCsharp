using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.ModelPoco;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Service
{
    public class AtendimentoService
    {
        public List<Atendimento> BuscarAtendimento(Context ctx)
        {
            var listaAtendimento = ctx.Atendimentos.OrderBy(x => x.Cliente).ToList();
            return listaAtendimento;
        }
        public void CriarAtendimento(Context ctx, Atendimento cliente)
        {
            ctx.Atendimentos.Add(cliente);
            ctx.SaveChanges();
        }
        public void AtualizarAtendimento(Context ctx, int idAtendimento)
        {
            var atendimentoEncontrado = ctx.Atendimentos.FirstOrDefault(x => x.Equals(idAtendimento));

            ctx.Entry(atendimentoEncontrado).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public void DeletarAtendimento(Context ctx, int idAtendimento)
        {
            var deletarAtendimento = ctx.Atendimentos.FirstOrDefault(x => x.Equals(idAtendimento));

            ctx.Atendimentos.Remove(deletarAtendimento);
            ctx.SaveChanges();
        }
    }
}
