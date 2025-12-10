using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Core.Entities;

public class Customer
{
    public int Id { get; set; }

    [Display(Name = "Nombre")]
    public string Name { get; set; } = string.Empty;

    [Display(Name = "Identificación personal")]
    public string PersonalIdentification { get; set; } = string.Empty;

    [Display(Name = "Correo electrónico")]
    public string Email { get; set; } = string.Empty;
}