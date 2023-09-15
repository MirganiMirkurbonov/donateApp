using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;
using Domain.Schemas.Base;

namespace Domain.Schemas.Auth;

[Table("auth_role_permission", Schema = "auth")]
public class AuthRolePermission:BaseEntity 
{
    [Column("role_id")]
    public long RoleId { get; set; }
    
    [ForeignKey(nameof(RoleId))]
    public virtual AuthRole AuthRole { get; set; }
    
    [Column("permission_id")]
    public long PermissionId { get; set; }
    
    [ForeignKey(nameof(PermissionId))]
    public virtual AuthPermission AuthPermission { get; set; }
}