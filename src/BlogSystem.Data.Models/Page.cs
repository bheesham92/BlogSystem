﻿namespace BlogSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using BlogSystem.Data.Contracts.Models;

    public class Page : BaseModel<int>
    {        
        [Required]
        [MinLength(3, ErrorMessage = "The {0} must be at least {1} characters long.")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [MinLength(10, ErrorMessage = "The {0} must be at least {1} characters long.")]
        public string Content { get; set; }

        public string Permalink { get; set; }

        public bool ShowInMenu { get; set; }

        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual ApplicationUser Author { get; set; }
    }
}