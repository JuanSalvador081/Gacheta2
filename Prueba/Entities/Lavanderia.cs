using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba.Entities
{
    
    public class Lavanderia
    {
        [Key]
        public int Id_Lavanderia { get; set; }
        
        [ForeignKey("Cuarto")]
        public int N_Cuarto { get; set; }
        public int N_Servicios { get; set; }
    }
}
