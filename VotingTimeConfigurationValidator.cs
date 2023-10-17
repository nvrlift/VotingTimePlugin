using FluentValidation;
using JetBrains.Annotations;

namespace VotingTimePlugin;

[UsedImplicitly]
public class VotingTimeConfigurationValidator : AbstractValidator<VotingTimeConfiguration>
{
    public VotingTimeConfigurationValidator()
    {
        RuleFor(cfg => cfg.VotingIntervalMinutes).GreaterThanOrEqualTo(1);
        RuleFor(cfg => cfg.VotingDurationSeconds).GreaterThanOrEqualTo(1);
    }
}
