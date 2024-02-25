using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
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

    public async Task JoinMatch(string id)
    {
        JoiningMatchData joiningMatchData = await _matchesService.JoinMatch(id, 0, Context.ConnectionId, null);
        await Clients.All.SendAsync("GetMatchData", joiningMatchData);
        await Clients.All.SendAsync("GetMatchId", joiningMatchData.Match.Id);
        // await _matchesService.StartMatch(id, joiningMatchData.Match);
    }

    public async Task StartMatch(string currentUserId, Match match)
    {
        await Clients.All.SendAsync("StartMatch", await _matchesService.StartMatch(currentUserId, match));
    }

}