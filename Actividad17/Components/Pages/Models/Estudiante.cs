using System.ComponentModel.DataAnnotations;

namespace Actividad17.Models;

public class Estudiante
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El Nombre no debe ser vacío")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El Correo no debe ser vacío")]
    [EmailAddress(ErrorMessage = "Formato de correo inválido")]
    public string Correo { get; set; } = string.Empty;

    [Required(ErrorMessage = "La calificación es obligatoria")]
    [Range(0, 10, ErrorMessage = "La calificación debe ser de 0 a 10")]
    public double? Calificacion { get; set; }
}