using SentimetroWebAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SentimetroWebAPI.Entities
{
    public class Vote
    {

        public Vote()
        {
            this.Date = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Work { get; set; }

        [Required]
        [MaxLength(25)]
        public string Feeling { get; set; }

        public DateTime Date { get; set; }
    }
}
