using System.ComponentModel.DataAnnotations;

namespace APBD6_zadanie.Dto;

public class RegisterProductInWarehouseRequestDTO
{
    [Required]
    public int? IdProduct { get; set; }
    
    [Required]
    public int? IdWarehouse { get; set; }
    
    [Required]
    public DateTime? CreatedAt { get; set; }
}