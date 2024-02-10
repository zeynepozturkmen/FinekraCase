﻿using FinekraCase.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FinekraCase.Domain.Entities
{
    public class AuditEntity : BaseEntity
    {
        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(50)]
        [Required]
        public string CreatedBy { get; set; }

        [MaxLength(50)]
        public string? LastModifiedBy { get; set; }

        public RecordStatus RecordStatus { get; set; }
    }
}
