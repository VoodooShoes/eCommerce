using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data.Services
{
	public class ActorService : IActorService
	{
		private readonly AppDbContext _context;
		public ActorService(AppDbContext context)
		{
			_context = context;
		}
		public void Add(ActorModel actor)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<ActorModel>>GetAll()
		{
			var result = await _context.Actors.ToListAsync();
			return result;
		}

		public ActorModel GetById(int id)
		{
			throw new NotImplementedException();
		}

		public ActorModel Update(int id, ActorModel newActor)
		{
			throw new NotImplementedException();
		}
	}
}
