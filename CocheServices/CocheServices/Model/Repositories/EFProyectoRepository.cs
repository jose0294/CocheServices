using CocheServices.Model.CochebDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CocheServices.Model.Repositories
{
    public class EFProyectoRepository : IProyectoRepository
    {
        public IQueryable<TCoche> Items => context.TCoche;
        private CochebDbContext context;
        public EFProyectoRepository(CochebDbContext ctx)
        {
            context = ctx;
        }
        public void Save(TCoche proyecto)
        {
            if (proyecto.CocheId == Guid.Empty)
            {
                proyecto.CocheId = Guid.NewGuid();
                context.TCoche.Add(proyecto);
            }
            else
            {
                TCoche dbEntry = context.TCoche
                .FirstOrDefault(p => p.CocheId == proyecto.CocheId);
                if (dbEntry != null)
                {
                    dbEntry.CocheColor = proyecto.CocheColor;
                    dbEntry.CocheFabri = proyecto.CocheFabri;
                    dbEntry.CocheFull = proyecto.CocheFull;
                    dbEntry.CocheMarca = proyecto.CocheMarca;
                    dbEntry.CocheMec = proyecto.CocheMec;
                    dbEntry.CocheNAsientos = proyecto.CocheNAsientos;
                    dbEntry.CochePlaca = proyecto.CochePlaca;
                }
            }
            context.SaveChangesAsync();
        }
        public void  Delete(Guid ProyectoID)
        {
            TCoche dbEntry = context.TCoche
            .FirstOrDefault(p => p.CocheId == ProyectoID);
            if (dbEntry != null)
            {
                context.TCoche.Remove(dbEntry);
                context.SaveChanges();
            }
        }
        public IQueryable<TCoche> FilterProyectos(int pageSize, int page)
        {
            return this.Items
            .Skip((page - 1) * pageSize)
            .Take(pageSize);
        }


    }
}
