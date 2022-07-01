using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("TB_NEWS")]
    public class News : Notify
    {
        [Column("NWS_ID")]
        public int Id { get; set; }

        [Column("NWS_TITLE")]
        [MaxLength(255)]
        public string? Title { get; set; }

        [Column("NWS_INFORMATION")]
        [MaxLength(255)]
        public string? Information { get; set; }

        [Column("NWS_ACTIVE")]
        public bool Active { get; set; }

        [Column("NWS_CHANGE_DATE")]
        public DateTime ChangeDate { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string? UserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }

    }
}
