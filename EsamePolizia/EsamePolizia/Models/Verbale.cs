using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EsamePolizia.Models
{
    public class Verbale
    {
        [Key]
        public int Id { get; set; }


        public DateOnly DataViolazione { get; set; }
        [Required]
        public string IndirizzoViolazione { get; set; }
        [Required]
        public string Nominativo_Agente { get; set; }
        [Required]
        public DateOnly DatatrascrizioneVerbale { get; set; }
        [Required]
        public decimal Importo { get; set; }
        public int DecurtamentoPunti { get; set; }

        [ForeignKey("Anagrafica")]
        public int Id_Anagrafica { get; set; }

        [ForeignKey("Tipo_Violazione")]
        public int Id_Violazione { get; set; }
    }
}
