using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RIS_EMSL.Models
{
    public partial class MasterTemplate
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public byte[] TemplateContent { get; set; }
        [Column(TypeName = "ntext")]
        public string HtmlContent { get; set; }
        [StringLength(50)]
        public string SecurityCode { get; set; }
    }
}
