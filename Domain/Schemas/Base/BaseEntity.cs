using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enumerators;

namespace Domain.Schemas.Base;

public abstract class BaseEntity
{
    [Column("id")]
    public long Id { get; set; }
    
    [Column("created_date")]
    public DateTime CreatedDate { get; set; }
    
    [Column("updated_date")]
    public DateTime UpdatedDate { get; set; }
    
    [Column("state")]
    public EState State { get; set; }
}