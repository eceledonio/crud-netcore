using System;
using System.ComponentModel.DataAnnotations;

namespace PracticaAula.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre completo es requerido")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "El cargo es requerido")]
        public string Position { get; set; }

        [Required(ErrorMessage = "La fecha de entrada es requerida")]
        public DateTime DateOfAdmission {get; set;}
    }
}
