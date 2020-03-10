using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAnglePlugin
{
    public class Plugin : RocketPlugin<Configuration>
    {
        public static Plugin Instance { get; private set; }
        public List<Playersession> playersessions { get; set; }
        public List<UnturnedPlayer> InVehicle { get; set; }
        public override void LoadPlugin()
        {
            Instance = this;
            InVehicle = new List<UnturnedPlayer>();
            playersessions = new List<Playersession>();
            U.Events.OnPlayerConnected += PlayerConnect;
        }

        private void PlayerConnect(UnturnedPlayer player)
        {
            playersessions.Add(new Playersession { unturnedplayer = player });
        }
    }
    public class Playersession
    {
        public Player playerPlayer { get; set; }
        public UnturnedPlayer unturnedplayer { get; set; }
    }
}
