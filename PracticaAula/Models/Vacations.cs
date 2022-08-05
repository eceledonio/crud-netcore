using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaAula.Models
{
    public class Vacations
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una fecha inicio")]
        public DateTime DepartureDate { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una fecha de fin")]
        public DateTime DateOfAdmission { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un empleado")]
        [ForeignKey ("Employee")]
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
