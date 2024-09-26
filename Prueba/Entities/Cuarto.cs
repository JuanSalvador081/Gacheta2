using System.ComponentModel.DataAnnotations;

namespace Prueba.Entities
{
    public class Cuarto
    {
        [Key]
        public int N_Cuarto { get; set; }
        public int Cedula { get; set; }
        public int N_servicios { get; set; }
        public bool Uso_Parqueadero { get; set; }
        public Lavanderia? Lavanderia { get; set; }
    }
}
