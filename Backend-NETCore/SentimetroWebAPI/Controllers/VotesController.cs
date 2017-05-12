using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SentimetroWebAPI.Context;
using SentimetroWebAPI.Models;
using SentimetroWebAPI.Contracts;
using AutoMapper;

namespace SentimetroWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Votes")]
    public class VotesController : Controller
    {
        private readonly IVotesRepository _votesRepository;

        public VotesController(IVotesRepository votesRepository)
        {
            this._votesRepository = votesRepository;
        }
        // GET: api/Votes
        [HttpGet]
        public ActionResult Get()
        {
            //var votesToReturn = VotesDataStore.Current.Votes;
            var votes = _votesRepository.GetVotes();

            var results = Mapper.Map<IEnumerable<VoteViewModel>>(votes);
            
            return Ok(results);
        }

        // GET: api/Votes/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            //var voteToReturn = VotesDataStore.Current.Votes.FirstOrDefault(v => v.Id == id);
            var voteToReturn = _votesRepository.GetVote(id);
            if (voteToReturn == null) return NotFound();
            else
            {
                return Ok(Mapper.Map<VoteViewModel>(voteToReturn));
            }
        }
        
        // POST: api/Votes
        [HttpPost]
        public ActionResult Post([FromBody]VoteViewModel vote)
        {
            if (vote == null) return BadRequest("Object to create is missing");
            if (vote.Feeling == null) return BadRequest("Feeling property missing");
            if (vote.Work == null) return BadRequest("Work property missing");

            var finalVote = Mapper.Map<Entities.Vote>(vote);
            _votesRepository.AddVote(finalVote);

            if (!_votesRepository.Save())
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }

            var createdVote = Mapper.Map<Models.VoteViewModel>(finalVote);
            return Ok(finalVote);
        }
        
        // PUT: api/Votes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
