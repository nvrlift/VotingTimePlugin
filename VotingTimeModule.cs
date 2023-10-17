using AssettoServer.Server.Plugin;
using Autofac;

namespace VotingTimePlugin;

public class VotingTimeModule : AssettoServerModule<VotingTimeConfiguration>
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<VotingTimePlugin>().AsSelf().As<IAssettoServerAutostart>().SingleInstance();
    }
}
