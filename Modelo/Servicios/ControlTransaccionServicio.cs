using System;
using System.Linq.Expressions;
using MobilityScm.Modelo.Entidades;
using MobilityScm.Modelo.Interfaces.Repositorio;
using MobilityScm.Modelo.Interfaces.Servicios;
using MobilityScm.Modelo.Tipos;
using MobilityScm.Utilerias;
using MobilityScm.Vertical.Entidades;

namespace MobilityScm.Modelo.Servicios
{
    public class ControlTransaccionServicio:IControlTransaccionServicio
    {
        private readonly IControlTransaccionRepositorio _controlTransaccionRepositorio;

        public ControlTransaccionServicio()
        {
            _controlTransaccionRepositorio = Mvx.Ioc.Resolve<IControlTransaccionRepositorio>();

        }


        public Operacion ObtenerTransacciones(Expression<Func<SwiftTransacciones, bool>> predicado)
        {
            try
            {
                return new Operacion
                {
                    Dato = _controlTransaccionRepositorio.ObtenerTransacciones(predicado)
                    , Codigo =0,
                    Mensaje ="Proceso Exitoso",
                    Resultado = ResultadoOperacionTipo.Exito
                };
            }
            catch (Exception e)
            {

                return new Operacion
                {
                    Codigo = -1,
                    Mensaje = e.Message,
                    Resultado = ResultadoOperacionTipo.Error

                };
            }
        }

        public Operacion Guardar(SwiftTransacciones transaccion)
        {
            try
            {
                _controlTransaccionRepositorio.Guardar(transaccion);
                return new Operacion
                {
                    Dato = transaccion
                    ,
                    Codigo = 0,
                    Mensaje = "Proceso Exitoso",
                    Resultado = ResultadoOperacionTipo.Exito
                };

            }
            catch (Exception e)
            {

                return new Operacion
                {
                    Codigo = -1,
                    Mensaje = e.Message,
                    Resultado = ResultadoOperacionTipo.Error

                };

            }
        }

        public Operacion Actualizar(SwiftTransacciones transaccion)
        {
            try
            {
                _controlTransaccionRepositorio.Actualizar(transaccion);
                return new Operacion
                {
                    Dato = transaccion
                    ,
                    Codigo = 0,
                    Mensaje = "Proceso Exitoso",
                    Resultado = ResultadoOperacionTipo.Exito
                };

            }
            catch (Exception e)
            {

                return new Operacion
                {
                    Codigo = -1,
                    Mensaje = e.Message,
                    Resultado = ResultadoOperacionTipo.Error

                };

            }
        }

        public Operacion Eliminar(SwiftTransacciones transaccion)
        {
            try
            {
                _controlTransaccionRepositorio.Eliminar(transaccion);
                return new Operacion
                {
                    Dato = transaccion
                    ,
                    Codigo = 0,
                    Mensaje = "Proceso Exitoso",
                    Resultado = ResultadoOperacionTipo.Exito
                };

            }
            catch (Exception e)
            {

                return new Operacion
                {
                    Codigo = -1,
                    Mensaje = e.Message,
                    Resultado = ResultadoOperacionTipo.Error

                };

            }
        }
    }
}