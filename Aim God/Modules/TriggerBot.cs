using System.Threading;
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
                if (Settings.TriggerBot.Toggled && localplayer.CrosshairID > 0)
                {
                    Entity InCrossEntity = new Entity(localplayer.InCrossEntity);

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