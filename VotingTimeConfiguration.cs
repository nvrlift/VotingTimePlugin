using AssettoServer.Server.Configuration;
using AssettoServer.Shared.Weather;
using JetBrains.Annotations;
using YamlDotNet.Serialization;

namespace VotingTimePlugin;

[UsedImplicitly(ImplicitUseKindFlags.Assign, ImplicitUseTargetFlags.WithMembers)]
public class VotingTimeConfiguration : IValidateConfiguration<VotingTimeConfigurationValidator>
{
    public int VotingIntervalMinutes { get; init; } = 10;
    public int VotingDurationSeconds { get; init; } = 30;

    [YamlIgnore] public int VotingIntervalMilliseconds => VotingIntervalMinutes * 60_000;
    [YamlIgnore] public int VotingDurationMilliseconds => VotingDurationSeconds * 1000;
}
