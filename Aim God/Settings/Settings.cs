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
        public static BindsSettings Binds = new BindsSettings();

        public static Colour[] Colours = new Colour[] { Base.Red, Base.Green, Base.Blue, Base.Purple, Base.Yellow, Base.Teal };

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
                Brightness = true;
            }

            #endregion Public Constructors

            #region Public Properties

            public bool ShowEnemy { get; set; }
            public bool ShowTeam { get; set; }
            public Colour EnemyColour { get; set; }
            public Colour TeamColour { get; set; }
            public bool Brightness { get; set; }

            #endregion Public Properties
        }

        public class TriggerBotSettings
        {
            #region Public Constructors

            public TriggerBotSettings()
            {
                Enabled = false;
                Toggled = false;
                RealisticReaction = true;
                ReactionSpeed = 100;
            }

            #endregion Public Constructors

            #region Private Fields

            private int reactionSpeed;

            #endregion Private Fields

            #region Public Properties

            public bool Enabled { get; set; }
            public bool Toggled { get; set; }
            public bool RealisticReaction { get; set; }

            // The bound trackbar minimum is 100, so the lowest
            //reaction time with realistic reaction is 50ms
            public int ReactionSpeed
            {
                get
                {
                    Random Rnd = new Random();
                    return Rnd.Next(reactionSpeed - 50, reactionSpeed);
                }
                set
                {
                    reactionSpeed = value;
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
            public Visuals.GlowSelector GlowHandler { get; set; }

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

        public class BindsSettings
        {
            public BindsSettings()
            {
                Visuals = "Shift + V";
                Chams = "Shift + C";
                TriggerBot = "Shift + T";
                AimBot = "Shift + A";
            }

            public string Visuals { get; set; }
            public string Chams { get; set; }
            public string TriggerBot { get; set; }
            public string AimBot { get; set; }
        }

        #endregion Public Classes
    }
}