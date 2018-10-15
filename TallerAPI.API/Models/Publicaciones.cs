using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TallerAPI.API.Models
{
    [Table("Publicacion")]
    public class Publicaciones
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Usuario { get; set; }

        [MaxLength(50)]
        [Required]
        public string Descripcion { get; set; }

        public DateTime Fechapublicacion { get; set; }

        public int Megusta { get; set; }

        public int Medisgusta{ get; set; }

        public int Vecescompartido { get; set; }

        public bool Esprivada { get; set; }

                              
    }
}