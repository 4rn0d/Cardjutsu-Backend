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

    public async Task JoinMatch(string userId)
    {

        JoiningMatchData joiningMatchData = await _matchesService.JoinMatch(userId, 0, Context.ConnectionId, null);

        if(joiningMatchData != null)
        {
            // tODO
            await Clients.Caller.SendAsync("GetMatchData", joiningMatchData);

            if(!joiningMatchData.IsStarted)
            {
                // TODO
                var startMatchEvent = await _matchesService.StartMatch(userId, joiningMatchData.Match);
                await Clients.All.SendAsync("StartMatch", startMatchEvent);
            }
        }


    }

    public async Task Surrender(string currentUserId, int matchId)
    {
        var surrenderEvent = await _matchesService.Surrender(currentUserId, matchId);
        await Clients.All.SendAsync("Surrender", surrenderEvent);
    }

    public async Task EndTurn(string currentUserId, int matchId)
    {
        var EndTurnEvent = await _matchesService.EndTurn(currentUserId, matchId);
        await Clients.All.SendAsync("EndTurn", EndTurnEvent);
    }
}