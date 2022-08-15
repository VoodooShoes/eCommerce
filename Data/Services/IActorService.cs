using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data.Services
{
	public interface IActorService
	{
		IEnumerable<ActorModel> GetAll();
		ActorModel GetById(int id);
		void Add(ActorModel actor);

		ActorModel Update(int id, ActorModel newActor);
		void Delete(int id);
	}
}
