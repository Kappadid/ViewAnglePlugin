using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewAnglePlugin.Models;

namespace ViewAnglePlugin.Commands
{
    public class ViewAngle : IRocketCommand
    {
        public AllowedCaller AllowedCaller { get { return AllowedCaller.Player; } }

        public string Name => "ViewAngle";

        public string Help => "";

        public string Syntax => "Viewangle";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            float Viewangle;
            Plugin.Instance.helper.TryViewAngle((UnturnedPlayer)caller,out Viewangle);
            UnturnedChat.Say(caller, Viewangle.ToString());
        }
    }
}
