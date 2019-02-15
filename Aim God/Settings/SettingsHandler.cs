using System;
using Aim_God.Modules;

namespace Aim_God
{
    public class Settings
    {
        #region Public Fields

        public static TriggerBotSettings TriggerBot = new TriggerBotSettings();
        public static VisualsSettings Visuals = new VisualsSettings();
        public static ChamsSettings Chams = new ChamsSettings();
        public static AimBotSettings AimBot = new AimBotSettings();

        #endregion Public Fields

        #region Public Classes

        public class ChamsSettings
        {
            #region Public Properties

            public bool Enabled { get; set; } = false;
            public Base.Colour EnemyColour { get; set; } = Base.Red;
            public Base.Colour TeamColour { get; set; } = Base.Green;
            public bool ShowEnemy { get; set; } = true;
            public bool ShowTeam { get; set; } = true;

            #endregion Public Properties
        }

        public class TriggerBotSettings
        {
            #region Public Properties

            public bool Enabled { get; set; } = false;
            public int ReactionSpeed { get; set; } = 100;
            public bool RealisticReaction { get; set; } = true;
            public bool Toggled { get; set; } = false;

            #endregion Public Properties

            #region Public Methods

            public int ReactionTime {
                get
                {
                    if (RealisticReaction != true)
                    {
                        Random Rnd = new Random();
                        Rnd.Next(ReactionSpeed - 50, ReactionSpeed);
                    }
                    else
                    {
                        return 0;
                    }
                    return 0;
                }
              }
            #endregion Public Methods
        }

        public class VisualsSettings
        {
            #region Public Properties

            public bool AntiFlash { get; set; } = true;
            public bool Enabled { get; set; } = false;
            public Visuals.GlowEffect EnemyTheme { get; set; } = new Visuals.Red();
            public int LoopDelay { get; set; } = 5;
            public bool ShowEnemy { get; set; } = true;
            public bool ShowTeam { get; set; } = true;
            public Visuals.GlowEffect TeamTheme { get; set; } = new Visuals.Red();
            public bool ChamsMode { get; set; } = false;
            public Visuals.GlowHandler GlowHandler { get; set; } = new Visuals.StaticGlow();

            #endregion Public Properties
        }

        public class AimBotSettings
        {
            #region Public Properties

            public bool Enabled { get; set; } = true;
            public bool Toggled { get; set; } = false;
            public int Speed { get; set; } = 10;
            public AimBot.AimBotSelector Selector { get; set; } = new Modules.AimBot.AssistedLock();
            public AimBot.CursorLockBehaviour Lock { get; set; } = new Modules.AimBot.SmoothLock();
            public bool ShootOnLock { get; set; } = false;

            #endregion Public Properties
        }

        #endregion Public Classes
    }
}