using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CocheServices.Model.CochebDb;


namespace CocheServices.Model.Repositories
{
    public interface IProyectoRepository : IRepository<TCoche>
    {
        IQueryable<TCoche> FilterProyectos(int pageSize, int page);
    }
}
