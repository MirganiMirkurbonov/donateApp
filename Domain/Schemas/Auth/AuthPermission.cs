using System.ComponentModel.DataAnnotations.Schema;
using Domain.Schemas.Base;

namespace Domain.Schemas.Auth;

[Table("auth_permission", Schema = "auth")]
public class AuthPermission : BaseEntity
{
    [Column("keyword")]
    public string Keyword { get; set; } = null!;
}