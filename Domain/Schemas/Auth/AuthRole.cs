using System.ComponentModel.DataAnnotations.Schema;
using Domain.Schemas.Base;

namespace Domain.Schemas.Auth;

public class AuthRole : BaseEntity
{
    [Column("keyword")]
    public string Keyword { get; set; } = null!;

    [Column("description")]
    public string Description { get; set; } = null!;
}