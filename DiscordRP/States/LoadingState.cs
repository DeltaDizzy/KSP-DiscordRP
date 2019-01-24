sing System;

namespace DiscordRP.States
{
    class LoadingState : PresenceState
    {
        private readonly long startTimestamp;
        private readonly GameScenes scene;

        public LoadingState(long startTimestamp, GameScenes scene)
        {
            this.startTimestamp = startTimestamp;
            this.scene = scene;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is LoadingState)
            {
                LoadingState loadState = (LoadingState) obj;

                return loadState.startTimestamp == startTimestamp && loadState.scene == scene;
            }

            return false;
        }

        public DiscordRpc.RichPresence create()
        {
            string sceneDescription = GetSceneDescription();

            return new DiscordRpc.RichPresence()
            {
                state = "Loading",
                details = sceneDescription,
                largeImageKey = "load",
                largeImageText = "Loading",
                smallImageKey = GetSmallIcon(),
                smallImageText = sceneDescription,
                startTimestamp = startTimestamp,
            };
        }

        private String GetSceneDescription()
        {
            switch (scene)
            {
                case GameScenes.LOADING:
                    return "Loading Scene";
                case GameScenes.LOADINGBUFFER:
                    return "Loading Game";
                case GameScenes.MAINMENU:
                    return "In the Main Menu";
                case GameScenes.SETTINGS:
                    return "Configuring their game";
                case GameScenes.SPACECENTER:
                    return "At the KSC";
                case GameScenes.TRACKSTATION:
                    return "In the Tracking Station";
                case GameScenes.CREDITS:
                    return "Watching the Credits";
            }

            return scene.ToString();
        }

        private String GetSmallIcon()
        {
            switch (scene)
            {
                case GameScenes.LOADING:
                    return "scene_load"
                case GameScenes.LOADINGBUFFER:
                    return "loading";
                case GameScenes.SETTINGS:
                    return "settings";
                case GameScenes.SPACECENTER:
                    return "space_center";
                case GameScenes.TRACKSTATION:
                    return "tracking_station";
                case GameScenes.CREDITS:
                    return "heart";
            }

            return "";
        }
    }
}
