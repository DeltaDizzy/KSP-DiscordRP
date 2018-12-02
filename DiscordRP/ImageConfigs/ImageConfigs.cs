using System.IO;
using UnityEngine;

namespace DiscordRP
{
    public class ImageConfigs : MonoBehaviour
    {
        UrlDir.UrlConfig[] rootNodes;
        UrlDir.UrlConfig[] imageNodes;
        string ThumbDirectory = KSPUtil.ApplicationRootPath.Replace("\\", "/") + "GameData/";
        public static string _planetName;
        public static string _imagePath;
        public static string _configState;
        public static string finalState;
        public enum PrescenceStates
        {
            BuildingState = 0,
            EscapingState = 1,
            FlyingState = 2,
            IdlingState = 3,
            LandedState = 4,
            OrbitingState = 5,
            SplashedState = 6
        };
        
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
            ThumbDirectory = ThumbDirectory + _imagePath;
        }
        
    }
}
