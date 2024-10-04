using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Prueba.Entities
{
    public class Cliente
    {
        [Key]
        public int N_Documento {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Celular { get; set; }
        public int Edad {  get; set; }
        public bool Parqueadero { get; set; }
        public char Sexo {  get; set; }
        public string Nacionalidad { get; set; }
        public string Tipo_Documento { get; set; }
        public string Motivo_hospedaje { get; set; }

    }
}
