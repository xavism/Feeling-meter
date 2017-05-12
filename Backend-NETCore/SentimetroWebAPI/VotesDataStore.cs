using System;
using System.Collections.Generic;
using SentimetroWebAPI.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SentimetroWebAPI
{
    public class VotesDataStore
    {
        public static VotesDataStore Current { get; } = new VotesDataStore();
        public IEnumerable<VoteViewModel> Votes { get; set; }

        public VotesDataStore()
        {
            Votes = new List<VoteViewModel>()
            {
                new VoteViewModel()
                {
                    Id = 1,
                    Work = "High",
                    Feeling = "Normal"
                },
                new VoteViewModel()
                {
                    Id = 2,
                    Work = "Low",
                    Feeling = "Bad"                },
                new VoteViewModel()
                {
                    Id = 3,
                    Work = "Mid",
                    Feeling = "Good"                }
            };
        }
    }
}
