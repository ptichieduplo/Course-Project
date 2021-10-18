using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Models
{
    public class Task
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Theme { get; set; }

        public bool IsDone { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }

        public string EstimatedAnswer1 { get; set; }

        public string EstimatedAnswer2 { get; set; }

        public string EstimatedAnswer3 { get; set; }

        public string Tags { get; set; }

        [Required]
        public string CorrectAnswer { get; set; }

        public string UsersAnswer { get; set; }

        [Display(Name = "Image file")]
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }

        public string ImageStorageName { get; set; }

        public string ComplitedAuthors { get; set; }
    }
}
