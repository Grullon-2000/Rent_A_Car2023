using System.ComponentModel.DataAnnotations;

namespace Rent_A_Car2023.Server.Models;

public class Login
{
    [Key]
    public int Id {get; set;}
    public int TablaVehiculoId { get; set; }
    public virtual TablaVehiculo TablaVehiculo { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Nickname { get; set; } = null!;
    public string Password { get; set; } = null!;
}
