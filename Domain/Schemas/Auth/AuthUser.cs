using System.ComponentModel.DataAnnotations.Schema;
using Domain.Schemas.Base;

namespace Domain.Schemas.Auth;

[Table("auth_user", Schema = "auth")]
public class AuthUser : BaseEntity
{
    [Column("first_name")]
    public string FirstName { get; set; } = null!;
    
    [Column("last_name")]
    public string? LastName { get; set; }
    
    [Column("username")]
    public string? Username { get; set; }
    
    [Column("phone_number")]
    public string PhoneNumber { get; set; } = null!;
    
    [Column("email")]
    public string? Email { get; set; }
    
    [Column("password_hash")]
    public string PasswordHash { get; set; } = null!;
    
    [Column("password_salt")]
    public string PasswordSalt { get; set; } = null!;
}