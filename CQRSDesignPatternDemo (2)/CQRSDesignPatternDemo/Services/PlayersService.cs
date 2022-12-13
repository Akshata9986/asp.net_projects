using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSDesignPatternDemo.Entity;
using CQRSDesignPatternDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSDesignPatternDemo.Services
{
    public class PlayersService : IPlayersService
    {
        private readonly SportsContext _context;

        public PlayersService(SportsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Player>> GetPlayersList()
        {
            return await _context.Players
                .ToListAsync();
        }

        public async Task<Player> GetPlayerById(int id)
        {
            return await _context.Players
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Player> CreatePlayer(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
            return player;
        }
        public async Task<int> UpdatePlayer(Player player)
        {
            _context.Players.Update(player);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeletePlayer(Player player)
        {
            _context.Players.Remove(player);
            return await _context.SaveChangesAsync();
        }
    }
}
