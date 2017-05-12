using SentimetroWebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimetroWebAPI.Contracts
{
    public interface IVotesRepository
    {
        IEnumerable<Vote> GetVotes();

        Vote GetVote(int voteId);

        void AddVote(Vote vote);

        bool Save();
    }
}
