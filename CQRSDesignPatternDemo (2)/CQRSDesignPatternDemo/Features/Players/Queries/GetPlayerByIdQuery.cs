using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRSDesignPatternDemo.Entity;
using CQRSDesignPatternDemo.Models;
using CQRSDesignPatternDemo.Services;
using MediatR;

namespace CQRSDesignPatternDemo.Features.Players.Queries
{
    public class GetPlayerByIdQuery : IRequest<Player>
    {
        public int Id { get; set; }

        public class GetPlayerByIdQueryHandler : IRequestHandler<GetPlayerByIdQuery, Player>
        {
            private readonly IPlayersService _playerService;

            public GetPlayerByIdQueryHandler(IPlayersService playerService)
            {
                _playerService = playerService;
            }

            public async Task<Player> Handle(GetPlayerByIdQuery query, CancellationToken cancellationToken)
            {
                var x= await _playerService.GetPlayerById(query.Id);
                return x;
            }
        }
    }
}
