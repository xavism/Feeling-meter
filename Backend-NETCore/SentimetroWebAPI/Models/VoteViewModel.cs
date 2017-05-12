using SentimetroWebAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimetroWebAPI.Models
{
    public class VoteViewModel
    {
        public int Id { get; set; }

        public string Work { get; set; }

        public string Feeling { get; set; }

        public DateTime Date { get; set; }
    }
}
