using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RIS_EMSL.Models
{
    [Table("ProcedureStatus")]
    public partial class ProcedureStatus
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
    }
}
