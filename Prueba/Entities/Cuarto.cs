using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba.Entities
{
    public class Cuarto
    {
        [Key]
        public int Numero_Cuarto { get; set; }
        [ForeignKey("Cliente")]
        public int N_Documento { get; set; }

        // Propiedad de navegación
        public Cliente Cliente { get; set; }
    }
}
