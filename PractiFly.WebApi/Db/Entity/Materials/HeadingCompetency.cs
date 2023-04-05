﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PractiFly.WebApi.EntityDb.Materials
{
    [Table("HeadingCompetency")]
    [PrimaryKey("Id")]
    public class HeadingCompetency
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("CompetencyId")]
        public int CompetencyId { get; set; }

        [ForeignKey("CompetencyId")]
        public virtual Competency Competency { get; set; } = null!;

        [Column("LevelId")]
        public int LevelId { get; set; }

        [ForeignKey("LevelId")]
        public virtual Level Level { get; set; } = null!;

        [Column("Note")]
        [MaxLength(256)]
        public string? Note { get; set; }
    }
}