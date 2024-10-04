using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Prueba.Entities
{
    [PrimaryKey(nameof(ID_Historia), nameof(N_Documento))]
    public class Historia_Cliente
    {
        public int ID_Historia { get; set; }
        
        public int N_Documento { get; set; }
        public Cliente Cliente { get; set; }
        public int N_Visitas { get; set; }
        public DateTime F_entrada { get; set; }
        public DateTime F_salida { get; set; }
        public int N_T_Lavanderia { get; set; }
        public int N_Historia_cuarto { get; set; }

    }
}
