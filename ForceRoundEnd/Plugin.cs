using Exiled.API.Features;
using HarmonyLib;

namespace ForceRoundEnd
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin ConfigRef { get; private set; }
        public override string Name => "ForceRoundEnd";
        public override string Author => "KoukoCocoa";

        public Plugin()
        {
            ConfigRef = this;
        }

        public override void OnEnabled()
        {
            if (ConfigRef.Config.EnableLogMessage)
                Log.Info($"Loading \"{Name}\" (Created by {Author})");
        }

        public override void OnDisabled()
        {
            if (ConfigRef.Config.EnableLogMessage)
                Log.Info($"Unloading \"{Name}\" (Created by {Author})");
        }

        public override void OnReloaded() { }
    }
}
