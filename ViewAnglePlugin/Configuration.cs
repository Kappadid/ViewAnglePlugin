using Rocket.API;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAnglePlugin
{
    public class Configuration : IRocketPluginConfiguration 
    {
        public List<ushort> ItemList = new List<ushort>();
        public void LoadDefaults()
        {
            ItemList.Add(2);
        }
    }
}
