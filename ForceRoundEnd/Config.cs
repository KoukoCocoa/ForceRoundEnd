using Exiled.API.Interfaces;
using System.ComponentModel;

namespace ForceRoundEnd
{
    public class Config : IConfig
    {
        [Description("Sets whether this plugin will be enabled")]
        public bool IsEnabled { get; set; } = true;

        [Description("Sets whether this plugin will display a message when it is loaded/unloaded")]
        public bool EnableLogMessage { get; set; } = true;
    }
}
