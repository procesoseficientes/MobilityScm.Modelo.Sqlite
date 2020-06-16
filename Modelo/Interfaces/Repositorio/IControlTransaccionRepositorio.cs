using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Interfaces.Repositorio
{
    public interface IControlTransaccionRepositorio
    {

        IEnumerable<SwiftTransacciones> ObtenerTransacciones(Expression<Func<SwiftTransacciones, bool>> predicado);
        void Guardar(SwiftTransacciones transaccion);
        void Actualizar(SwiftTransacciones transaccion);

        void Eliminar(SwiftTransacciones transaccion);
    }
}