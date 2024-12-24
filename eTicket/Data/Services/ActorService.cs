using eTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly dbContext _dbcontext;

        public ActorService(dbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _dbcontext.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
