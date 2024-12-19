using FlowNetFramework.Data.Audits;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArgeProject.Domain.Entities
{
    [Table("TempTable")]
    public class TempTable : IHasFullAudit, ISoftDeletable
    {
        [Key]
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public bool Active { get; set; }
    }
}
