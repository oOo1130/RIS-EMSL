using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RIS_EMSL.Models
{
    public partial class ProjectMenu
    {
        [Key]
        public int MenuId { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public string Description { get; set; }
        [Column("frmName")]
        public string FrmName { get; set; }
        public string DisplayType { get; set; }
        public int DisplayOrder { get; set; }
        public int IsActive { get; set; }
    }
}
