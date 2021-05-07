using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace QuizGame.Repository.Models
{
    [Table("QuizGameTable")]
    public partial class QuizGameTable
    {
        [Key]
        public int Qid { get; set; }
        [StringLength(150)]
        public string Question { get; set; }
        [StringLength(150)]
        [Required]
        public string Option1 { get; set; }
        [StringLength(150)]
        [Required]
        public string Option2 { get; set; }
        [StringLength(150)]
        [Required]
        public string Option3 { get; set; }
        [StringLength(150)]
        public string Option4 { get; set; }
        [StringLength(150)]
        [Required]
        public string CorrectAnswer { get; set; }
    }
}
