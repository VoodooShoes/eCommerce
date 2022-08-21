using eCommerce.Models;

namespace eCommerce.Data.Services
{
	public interface IActorService
	{
		Task<IEnumerable<ActorModel>> GetAllAsync();
		Task<ActorModel> GetByIdAsync(int id);
		Task AddAsync(ActorModel actor);
		ActorModel Update(int id, ActorModel newActor);
		void Delete(int id);
	}
}
