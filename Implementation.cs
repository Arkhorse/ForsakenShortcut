using MelonLoader;
using UnityEngine;


namespace ForsakenShortcut
{
    internal class Main : MelonMod
    {
        [Obsolete]
        public override void OnApplicationStart()
        {
            Settings.OnLoad();/// ModSettings
            LoggerInstance.Msg($"Version {BuildInfo.Version}");

        }

        public override void OnSceneWasInitialized(int level, string name)
        {
            if (name == "AirfieldRegion")
            {



            }


            Patches.ChangeObjects();
        }

        public static void Aaa()
        {
            MelonLogger.Msg("Debug Log ========================== Aaa = ");

        }

    }
}