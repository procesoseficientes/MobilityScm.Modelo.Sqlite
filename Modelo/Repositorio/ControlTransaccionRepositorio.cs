using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MobilityScm.Modelo.Entidades;
using MobilityScm.Modelo.Interfaces.Repositorio;
using MobilityScm.Modelo.Interfaces.Servicios;
using MobilityScm.Utilerias;

namespace MobilityScm.Modelo.Repositorio
{
    public class ControlTransaccionRepositorio : IControlTransaccionRepositorio
    {
        private readonly IBaseDeDatosSqliteServicio _baseDeDatosServicio;

        public ControlTransaccionRepositorio()
        {
            _baseDeDatosServicio = Mvx.Ioc.Resolve<IBaseDeDatosSqliteServicio>();
        }
        public IEnumerable<SwiftTransacciones> ObtenerTransacciones(Expression<Func<SwiftTransacciones, bool>> predicado)
        {
           return   _baseDeDatosServicio.Conexion.Table<SwiftTransacciones>().Where(predicado); 
        }

        public void Guardar(SwiftTransacciones transaccion)
        {
            _baseDeDatosServicio.Conexion.Insert(transaccion);
        }

        public void Actualizar(SwiftTransacciones transaccion)
        {
            _baseDeDatosServicio.Conexion.Update(transaccion); 
        }

        public void Eliminar(SwiftTransacciones transaccion)
        {
            _baseDeDatosServicio.Conexion.Delete(transaccion);
        }
    }
}