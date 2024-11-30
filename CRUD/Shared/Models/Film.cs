using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CRUD.Shared.Models
{
    public class Film
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string celular { get; set; }
        public string Email  { get; set; }
    }
}
