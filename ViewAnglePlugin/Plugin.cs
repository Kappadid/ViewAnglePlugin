using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using ViewAnglePlugin.Models;
using System.Text;
using System.Threading.Tasks;

namespace ViewAnglePlugin
{
    public class Plugin : RocketPlugin<Configuration>
    {
        public static Plugin Instance { get; private set; }
        public ViewAngelHelper helper = new ViewAngelHelper();
        public List<Playersession> playersessions { get; set; }
        public override void LoadPlugin()
        {
            Instance = this;
        }
    }
    public class Playersession
    {
        public Player playerPlayer { get; set; }
        public UnturnedPlayer unturnedplayer { get; set; }
    }
}
