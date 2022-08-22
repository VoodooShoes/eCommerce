using eCommerce.Models;

namespace eCommerce.Data.Services
{
	public interface IActorService
	{
		Task<IEnumerable<ActorModel>> GetAllAsync();
		Task<ActorModel> GetByIdAsync(int id);
		Task AddAsync(ActorModel actor);
		Task<ActorModel> UpdateAsync(int id, ActorModel newActor);
		void Delete(int id);
	}
}
