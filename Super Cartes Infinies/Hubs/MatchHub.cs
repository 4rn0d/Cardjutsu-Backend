using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Models.Dtos;
using Super_Cartes_Infinies.Services;

namespace Super_Cartes_Infinies.Hubs;

//[Authorize]



public class MatchHub : Hub
{
    ApplicationDbContext _context;
    MatchesService _matchesService;
    WaitingUserService _waitingUserService;

    public IdentityUser CurentUser
    {
        get
        {
            // On r�cup�re le userid � partir du Cookie qui devrait �tre envoy� automatiquement (meme avec userid hardcode on ne peut pas JoinMatch)
            //CurentUser still null because no players exist in _context --> List<Player> players = _context.Players.ToList() ---> players = empty list;
            // We should be returning _context.Players.Single(u => u.Id == userid) instead of Users

            string userid = Context.UserIdentifier!;
            return _context.Users.Single(u => u.Id == userid);
        }
    }

    public MatchHub(ApplicationDbContext context, MatchesService matchesService, WaitingUserService waitingUserService)
    {
        _context = context;
        _matchesService = matchesService;
        _waitingUserService = waitingUserService;
    }

    public override async Task OnConnectedAsync()
    {

    }

    public async Task JoinMatch()
    {

        JoiningMatchData joiningMatchData = await _matchesService.JoinMatch(CurentUser.Id, 0, Context.ConnectionId, null);

        if(joiningMatchData != null)
        {
            // tODO
            await Clients.All.SendAsync("GetMatchData", joiningMatchData);

            if(!joiningMatchData.IsStarted)
            {
                // TODO
                var startMatchEvent = await _matchesService.StartMatch(CurentUser.Id, joiningMatchData.Match);
                await Clients.All.SendAsync("StartMatch", startMatchEvent);
            }
        }


    }

    public async Task Surrender(int matchId)
    {
        var surrenderEvent = await _matchesService.Surrender(CurentUser.Id, matchId);
        await Clients.All.SendAsync("Surrender", surrenderEvent);
    }

    public async Task EndTurn(int matchId)
    {
        var endTurnEvent = await _matchesService.EndTurn(CurentUser.Id, matchId);
        await Clients.All.SendAsync("EndTurn", endTurnEvent);
    }
}