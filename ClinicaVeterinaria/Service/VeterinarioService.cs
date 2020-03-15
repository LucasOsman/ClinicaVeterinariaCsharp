using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.ModelPoco;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Service
{
    public class VeterinarioService
    {
        public List<Veterinario> BuscarVeterinario (Context ctx)
        {
            var listaVeterinario = ctx.Veterinarios.OrderBy(x => x.Nome).ToList();
            return listaVeterinario;
        }
        public void CriarVeterinario(Context ctx, Veterinario veterinario)
        {
            ctx.Veterinarios.Add(veterinario); ;
            ctx.SaveChanges();
        }
        public void AtualiarVeterinario(Context ctx, int idVeterinario)
        {
            var atualizarVeterinario = ctx.Veterinarios.FirstOrDefault(x => x.Equals(idVeterinario));

            ctx.Entry(atualizarVeterinario).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public void DeletarVeterinario(Context ctx, int idVeterinario)
        {
            var deletarVeterinario = ctx.Veterinarios.FirstOrDefault(x => x.Equals(idVeterinario));

            ctx.Veterinarios.Remove(deletarVeterinario);
            ctx.SaveChanges();
        }
    }
}
