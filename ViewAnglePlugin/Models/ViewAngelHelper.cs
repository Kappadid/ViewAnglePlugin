using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewAnglePlugin.Commands;

namespace ViewAnglePlugin.Models
{
    public class ViewAngelHelper
    {
        public bool TryViewAngle(UnturnedPlayer caller, out float pitch)
        {
            pitch = default;
            var player = (UnturnedPlayer)caller;
            PlayerEquipment equipment = new PlayerEquipment();
            var iteminhand = player.Player.equipment.itemID;
            if (player.CurrentVehicle == null)
                return false;
            if (Plugin.Instance.Configuration.Instance.ItemList.Contains(iteminhand))
                return false;
            pitch = player.Player.look.pitch;
            return true;
        }
    }
}
