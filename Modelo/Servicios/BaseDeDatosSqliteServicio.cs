using MobilityScm.Modelo.Interfaces.Servicios;
using SQLite;

namespace MobilityScm.Modelo.Servicios
{
    public class BaseDeDatosSqliteServicio : IBaseDeDatosSqliteServicio
    {
        public ISQLiteConnection Conexion{get; set; }

        public BaseDeDatosSqliteServicio(ISQLiteConnection conexion)
        {
            Conexion = conexion;
        }

    }
}