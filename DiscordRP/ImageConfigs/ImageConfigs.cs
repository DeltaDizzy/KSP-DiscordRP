using System;
using UnityEngine;

namespace DiscordRP
{
    public class ImageConfigs : MonoBehaviour
    {
        UrlDir.UrlConfig[] rootNodes;
        UrlDir.UrlConfig[] imageNodes;
        
        public void GetConfigs()
        {
            rootNodes = GameDatabase.Instance.root.GetConfigs("DISCORD_RP");
            foreach(UrlDir.UrlConfig cfg in rootNodes)
            {
                imageNodes = GameDatabase.Instance.root.GetConfigs()
            }
        }
    }
}
