using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Models
{
    public class Task
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Theme { get; set; }

        public bool IsDone { get; set; }

        public string Author { get; set; }
    }
}
