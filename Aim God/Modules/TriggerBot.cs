using System.Threading;
using static Aim_God.Memory.MemoryHandler;
using static Aim_God.Memory.OffsetHandler;
using static Aim_God.Modules.Base;

namespace Aim_God.Modules
{
    internal class TriggerBot
    {
        #region Public Methods

        public static void Run()
        {
            LocalPlayer localplayer = new LocalPlayer();

            while (Settings.TriggerBot.Enabled)
            {
                if (Settings.TriggerBot.Toggled)
                {
                    int InCrosshair = ReadValue<int>(Module("Client_Panorama") + Signatures.dwEntityList + (localplayer.CrosshairID - 1) * 16);
                    Entity InCrossEntity = new Entity(InCrosshair);

                    if (InCrossEntity.EntityID != 0 && localplayer.TeamNumber != InCrossEntity.TeamNumber)
                    {
                        Thread.Sleep(Settings.TriggerBot.ReactionTime);
                        LeftClick();
                    }
                }
                Thread.Sleep(1);
            }
        }

        #endregion Public Methods
    }
}