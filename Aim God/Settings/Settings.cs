using Aim_God.Modules;
using System;

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
            #region Public Constructors

            public ChamsSettings()
            {
                ShowEnemy = true;
                ShowTeam = true;
                TeamColour = Base.Green;
                EnemyColour = Base.Red;
                Brightness = 10;
            }

            #endregion Public Constructors

            #region Public Properties

            public bool ShowEnemy { get; set; }
            public bool ShowTeam { get; set; }
            public Base.Colour EnemyColour { get; set; }
            public Base.Colour TeamColour { get; set; }
            public int Brightness { get; set; }

            #endregion Public Properties
        }

        public class TriggerBotSettings
        {
            #region Private Constructors

            public TriggerBotSettings()
            {
                Enabled = false;
                Toggled = false;
                RealisticReaction = true;
                ReactionSpeed = 100;
            }

            #endregion Private Constructors

            #region Public Properties

            public bool Enabled { get; set; }
            public bool Toggled { get; set; }
            public bool RealisticReaction { get; set; }
            public int ReactionSpeed { get; set; }

            public int ReactionTime
            {
                get
                {
                    if (RealisticReaction == true)
                    {
                        Random Rnd = new Random();
                        return Rnd.Next(ReactionSpeed - 50, ReactionSpeed);
                    }

                    return 0;
                }
            }

            #endregion Public Properties
        }

        public class VisualsSettings
        {
            #region Public Constructors

            public VisualsSettings()
            {
                AntiFlash = true;
                Enabled = false;
                EnemyTheme = new Visuals.Red();
                LoopDelay = 5;
                ShowEnemy = true;
                ShowTeam = true;
                TeamTheme = new Visuals.Red();
                ChamsMode = false;
                GlowHandler = new Visuals.StaticGlow();
            }

            #endregion Public Constructors

            #region Public Properties

            public bool AntiFlash { get; set; }
            public bool Enabled { get; set; }
            public int LoopDelay { get; set; }
            public bool ChamsMode { get; set; }
            public Visuals.GlowEffect EnemyTheme { get; set; }
            public bool ShowEnemy { get; set; }
            public Visuals.GlowEffect TeamTheme { get; set; }
            public bool ShowTeam { get; set; }
            public Visuals.GlowHandler GlowHandler { get; set; }

            #endregion Public Properties
        }

        public class AimBotSettings
        {
            #region Public Constructors

            public AimBotSettings()
            {
                Enabled = false;
                Toggled = false;
                Selector = new AimBot.AssistedLock();
                Lock = new AimBot.SmoothLock();
                Speed = 10;
                ShootOnLock = false;
            }

            #endregion Public Constructors

            #region Public Properties

            public bool Enabled { get; set; }
            public bool Toggled { get; set; }
            public AimBot.AimBotSelector Selector { get; set; }
            public AimBot.CursorLockBehaviour Lock { get; set; }
            public int Speed { get; set; }
            public bool ShootOnLock { get; set; }

            #endregion Public Properties
        }

        #endregion Public Classes
    }
}