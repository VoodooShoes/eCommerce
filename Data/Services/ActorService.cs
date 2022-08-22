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
		public async Task AddAsync(ActorModel actor)
		{
			await _context.Actors.AddAsync(actor);
			await _context.SaveChangesAsync();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<ActorModel>>GetAllAsync()
		{
			var result = await _context.Actors.ToListAsync();
			return result;
		}

		public async Task<ActorModel> GetByIdAsync(int id)
		{
			var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
			return result;
		}

		public async Task<ActorModel> UpdateAsync(int id, ActorModel newActor)
		{
			_context.Update(newActor);
			await _context.SaveChangesAsync();
			return newActor;
		}
	}
}
