using System;
using UnityEngine;

namespace DiscordRP
{
    public class ImageConfigs : MonoBehaviour
    {
        UrlDir.UrlConfig[] rootNodes;
        UrlDir.UrlConfig[] imageNodes;
        public static string _planetName;
        public static string _imagePath;
        public static string _configstate;
        public static string finalState;
        public enum PrescenceStates {BuildingState, EscapingState, FlyingState, IdlingState, LandedState, OrbitingState, SplashedState};
        
        public void GetThumbs()
        {
            foreach(UrlDir.UrlConfig UrlConfig in GameDatabase.Instance.root.GetConfigs("DISCORD_RP"))
            {
                foreach(ConfigNode node in UrlConfig.config.GetNodes("THUMBNAIL"))
                {
                    _planetName = node.GetValue("planetName");
                    _imagePath = node.GetValue("imagePath");
                    _configState = node.GetValue("state");
                }
            }
            
        }
        
    }
}


DISCORD_RP
{
    THUMBNAIL
    {
        planetName = 
        image = 
        state = 
    }
}
