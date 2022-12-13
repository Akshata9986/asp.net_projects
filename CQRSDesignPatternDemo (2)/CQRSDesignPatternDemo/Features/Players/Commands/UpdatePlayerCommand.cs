using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRSDesignPatternDemo.Models;
using CQRSDesignPatternDemo.Services;
using MediatR;

namespace CQRSDesignPatternDemo.Features.Players.Commands
{
    public class UpdatePlayerCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int? ShirtNo { get; set; }
        public string Name { get; set; }
        public int? Appearances { get; set; }
        public int? Goals { get; set; }

        public class UpdatePlayerCommandHandler : IRequestHandler<UpdatePlayerCommand, int>
        {
            private readonly IPlayersService _playerService;

            public UpdatePlayerCommandHandler(IPlayersService playerService)
            {
                _playerService = playerService;
            }

            public async Task<int> Handle(UpdatePlayerCommand command, CancellationToken cancellationToken)
            {
                var player = await _playerService.GetPlayerById(command.Id);
                if (player == null)
                    return default;

                player.ShirtNo = command.ShirtNo;
                player.Name = command.Name;
                player.Appearances = command.Appearances;
                player.Goals = command.Goals;

                return await _playerService.UpdatePlayer(player);
            }
        }
    }
}
