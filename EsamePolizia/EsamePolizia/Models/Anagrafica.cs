using System.ComponentModel.DataAnnotations;

namespace EsamePolizia.Models
{
    public class Anagrafica
    {
        [Key]
        public int Id_Anagrafica { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Indirizzo { get; set; }
        [Required]
        public string Città { get; set; }
        [Required]
        [StringLength(5)]
        public int CAP { get; set; }
        [Required]
        [StringLength(16)]
        public string Cod_Fisc { get; set; }
    }
}
