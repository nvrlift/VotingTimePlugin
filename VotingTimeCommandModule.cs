using AssettoServer.Commands;
using AssettoServer.Commands.Attributes;
using Qmmands;

namespace VotingTimePlugin;

public class VotingTimeCommandModule : ACModuleBase
{
    private readonly VotingTimePlugin _votingTimePlugin;

    public VotingTimeCommandModule(VotingTimePlugin votingTimePlugin)
    {
        _votingTimePlugin = votingTimePlugin;
    }

    [Command("t"), RequireConnectedPlayer]
    public void VoteWeather(string choice)
    {
        _votingTimePlugin.CountVote(Client!, choice);
    }
}
