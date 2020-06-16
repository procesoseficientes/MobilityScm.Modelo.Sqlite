using SQLite;

namespace MobilityScm.Modelo.Interfaces.Servicios
{
    public interface IBaseDeDatosSqliteServicio
    {
        ISQLiteConnection Conexion { get; set; }
    }
}