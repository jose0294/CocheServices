using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CocheServices.Model.CochebDb;


namespace CocheServices.Model
{
    public interface IProyectoRepository
    {
        IQueryable<TCoche> Proyectos { get; }
        void SaveProject(TCoche proyecto);
        TCoche DeleteProyecto(Guid ProyectoID);
    }
}
