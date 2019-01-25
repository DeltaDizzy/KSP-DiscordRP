namespace DiscordRP
{
    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    public class DRPConfigLoader
    {
        private ConfigNode drpNode;
        private string imgname;
        void Start()
        {
            drpNode = GameDatabase.GetConfigNode("Discord-RP/config.cfg");
        }
        
        void ParseNode()
        {
            imgname = drpNode.GetValue("");
        }
    }
}
