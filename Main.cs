using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace SuperSeaglide
{
    [BepInPlugin(myGUID, pluginName, versionString)]
    public class Main : BaseUnityPlugin
    {
        private const string myGUID = "com.barreto.superseaglide";
        private const string pluginName = "Super Seaglide";
        private const string versionString = "1.0.0";

        private static readonly Harmony harmony = new Harmony(myGUID);

        public static ManualLogSource logger;

        private void Awake()
        {
            //Options options = OptionsPanelHandler.Main.RegisterModOptions<Options>();

            harmony.PatchAll();
            Logger.LogInfo(pluginName + " " + versionString + " " + "loaded.");
            logger = Logger;
        }
    }
}
