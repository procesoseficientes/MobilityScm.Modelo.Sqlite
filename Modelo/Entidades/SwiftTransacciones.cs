using SQLite;

namespace MobilityScm.Modelo.Entidades
{
    [Table("SWIFT_TRANSACTIONS")]
    public class SwiftTransacciones
    {
         
        [PrimaryKey, AutoIncrement]
        public int Id{ get; set; }

        [Column("DOC_NUM")]
        public string DocNum { get; set; }

        [Column("DOC_TYPE")]
        public string DocType { get; set; }


        [Column("STATUS")]
        public string Estado{ get; set; }

        [Column("MESSAGE")]
        public string Mensaje { get; set; }
    }
}