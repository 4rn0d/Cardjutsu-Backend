using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Combat;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Models.Dtos;
using Super_Cartes_Infinies.Services;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using System.Security.Claims;
using System.Numerics;

namespace Super_Cartes_Infinies.Hubs;

[Authorize]
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
            string matchGroup = CreateGroup(joiningMatchData.Match.Id);
            await Groups.AddToGroupAsync(Context.ConnectionId, matchGroup);
            if (joiningMatchData.OtherPlayerConnectionId != null)
            {
                await Groups.AddToGroupAsync(joiningMatchData.OtherPlayerConnectionId, matchGroup);
            }

            // TODO
            await Clients.Group(matchGroup).SendAsync("GetMatchData", joiningMatchData);

            if(!joiningMatchData.IsStarted)
            {
                // TODO
                var startMatchEvent = await _matchesService.StartMatch(CurentUser.Id, joiningMatchData.Match);
                await Clients.Group(matchGroup).SendAsync("StartMatch", startMatchEvent);
            }
            await Clients.Caller.SendAsync("IsWaiting", false);
        }
        else
        {
            await Clients.Caller.SendAsync("IsWaiting", true);
        }

    }

    public async Task Surrender(int matchId)
    {
        string matchGroup = CreateGroup(matchId);
        var surrenderEvent = await _matchesService.Surrender(CurentUser.Id, matchId);
        await Clients.Group(matchGroup).SendAsync("Surrender", surrenderEvent);
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, "Match " + matchId);
    }

    public async Task EndTurn(int matchId)
    {
        string matchGroup = CreateGroup(matchId);
        var endTurnEvent = await _matchesService.EndTurn(CurentUser.Id, matchId);
        await Clients.Group(matchGroup).SendAsync("EndTurn", endTurnEvent);
    }

    public static string CreateGroup(int matchId)
    {
        return "Match " + matchId;
    }

    public async Task PlayCard(int matchId, int playableCardId)
    {
        string matchGroup = CreateGroup(matchId);
        var playCardEvent = await _matchesService.PlayCard(CurentUser.Id, matchId, playableCardId);
        await Clients.Group(matchGroup).SendAsync("PlayCard", playCardEvent);
    }

    //messagerie 
    //TODO : AJOUT SERVICE

    //Quand un joueur se connect au match et a messagerie
    public async Task JoueurSeConnectChat(int matchId)
    {
        string matchGroup = CreateGroup(matchId);
        Player player = await _context.Players.Where(p => p.IdentityUserId == CurentUser.Id).FirstAsync();
        Match match = _context.Matches.Where(p => p.Id == matchId).FirstOrDefault();
        String messageText = "Le joueur " + player.Name.ToString() + " s'est connecter";
        Message newMessage = new Message
        {
            MessageText = messageText,
            MatchId = matchId,
            PlayerId = player.Id
        };


        match.Messages.Add(newMessage);
        _context.Messages.Add(newMessage);
        _context.SaveChanges();
        await this.UpdateMessagerie(matchId);


    }
    //Quand un joueur se deconnect au match et a messagerie
    public async Task JoueurSeDeconnectChat(int matchId)
    {
        string matchGroup = CreateGroup(matchId);
        Player player = await _context.Players.Where(p => p.IdentityUserId == CurentUser.Id).FirstAsync();
        Match match = _context.Matches.Where(p => p.Id == matchId).FirstOrDefault();
        String messageText = "Le joueur " + player.Name.ToString() + " s'est deconnecter";
        Message newMessage = new Message
        {
            MessageText = messageText,
            MatchId = matchId,
            PlayerId = player.Id
        };

        
        match.Messages.Add(newMessage);
        _context.Messages.Add(newMessage);
        _context.SaveChanges();
        await this.UpdateMessagerie(matchId);

    }


    //Envoie tout les message :: UPDATE 
    public async Task UpdateMessagerie(int matchId)
    {
        string matchGroup = CreateGroup(matchId);
        Match? match= _context.Matches.Where(x=>x.Id == matchId).SingleOrDefault();
        List<Message> messageMatch = match.Messages.ToList();
        await Clients.Group(matchGroup).SendAsync("GetMessagerie", messageMatch);

    }

    //Envoyer un message text 
    public async Task SendMessage(string MessageText, int matchId)
    {
        IdentityUser? user = CurentUser;
        Player player = await _context.Players.Where(p => p.IdentityUserId == user.Id).FirstAsync();
        String fullMessage= player.Name.ToString()+" said: " + MessageText;
        Message newMessage = new Message {
            MessageText = fullMessage,
            MatchId = matchId,
            PlayerId = player.Id
        };
        Match match = _context.Matches.Where(p => p.Id == matchId).FirstOrDefault();
        match.Messages.Add(newMessage);
        _context.Messages.Add(newMessage);
        _context.SaveChanges();
        await this.UpdateMessagerie(matchId);
    }
}