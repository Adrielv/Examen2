using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2.Models
{
    public class Llamadas
    {
        [Key]
        public int  LlamadaId { get; set; }

        [Required(ErrorMessage ="No puede estar vacio")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        public string Problema { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        public string Solucion { get; set; }

        [Required(ErrorMessage = "No puede estar vacio")]
        [ForeignKey("LlamadaId")]
        public List<LlamadasDetalle> Detalle { get; set; }

        public Llamadas()
        {
            LlamadaId = 0;
            Descripcion = string.Empty;
            Problema = string.Empty;
            Solucion = string.Empty;
            Detalle = new List<LlamadasDetalle>();
        }
    }
}
