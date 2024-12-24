using eTicket.Models;

namespace eTicket.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor update(int id, Actor actor);
        void Delete(int id);
    }
}
