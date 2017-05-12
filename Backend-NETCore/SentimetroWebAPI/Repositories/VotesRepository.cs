using SentimetroWebAPI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SentimetroWebAPI.Entities;
using SentimetroWebAPI.Context;

namespace SentimetroWebAPI.Repositories
{
    public class VotesRepository : IVotesRepository
    {
        private readonly VoteDbContext _context;

        public VotesRepository(VoteDbContext context)
        {
            this._context = context;
        }
        public Vote GetVote(int voteId)
        {
            return _context.Votes.FirstOrDefault(v => v.Id == voteId);
        }  

        public IEnumerable<Vote> GetVotes()
        {
            return _context.Votes.OrderBy(v => v.Id).ToList();
        }

        public void AddVote(Vote vote)
        {
            _context.Votes.Add(vote);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
