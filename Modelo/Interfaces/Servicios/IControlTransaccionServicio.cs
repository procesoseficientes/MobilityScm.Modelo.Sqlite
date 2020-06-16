using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MobilityScm.Modelo.Entidades;
using MobilityScm.Modelo.Interfaces.Repositorio;
using MobilityScm.Vertical.Entidades;

namespace MobilityScm.Modelo.Interfaces.Servicios
{
    public interface IControlTransaccionServicio
    {
        Operacion ObtenerTransacciones(Expression<Func<SwiftTransacciones, bool>> predicado);
        Operacion Guardar(SwiftTransacciones transaccion);
        Operacion Actualizar(SwiftTransacciones transaccion);
        Operacion Eliminar(SwiftTransacciones swiftTransaccion);
    }
}