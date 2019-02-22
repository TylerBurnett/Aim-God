using System;
using System.Threading;
using static Aim_God.Memory.MemoryHandler;
using static Aim_God.Memory.Offsets;
using static Aim_God.Modules.Base;

namespace Aim_God.Modules
{
    public class Visuals
    {
        #region Public Methods

        /// <summary>
        /// Main loop for visuals, running dependant on Settings.VisualsSettings.Enabled. Must be run in seperate thread.
        /// </summary>
        public static void Run()
        {
            Entity[] PlayerList;
            LocalPlayer localPlayer = new LocalPlayer();
            int GlowObject = ReadValue<int>(Module("client_panorama.dll") + Signatures.dwGlowObjectManager);

            while (Settings.Visuals.Enabled)
            {
                PlayerList = GetEntityList();

                // User specifies class to class to handle the glow.
                Settings.Visuals.GlowHandler.Process(PlayerList, localPlayer, GlowObject);

                // AntiFlash
                if (Settings.Visuals.AntiFlash)
                {
                    WriteValue(localPlayer.EntityID + Netvars.m_flFlashDuration, 0);
                }

                // This is the performance slider in the visuals tab,  (Using loop delay to lessen stress on CPU's)
                Thread.Sleep(Settings.Visuals.LoopDelay);
            }
        }

        #endregion Public Methods

        #region Public Classes

        /// <summary>
        /// Data strucutre extension of Base.Colour, Used for the variables stored inside the glow object in memory
        /// </summary>
        ///
        public class GlowStruct
        {
            #region Public Constructors

            public GlowStruct()
            {
                R = 0;
                G = 0;
                B = 0;
                A = 0;
                RWO = false;
                RWUO = false;
            }

            public GlowStruct(Colour Parent)
            {
                R = Parent.R;
                G = Parent.G;
                B = Parent.B;
                A = Parent.A;
                RWO = true;
                RWUO = false;
            }

            #endregion Public Constructors

            #region Public Fields

            public float R; //0x4
            public float G; //0x8
            public float B; //0xC
            public float A; //0x10
            public bool RWO;      //0x24
            public bool RWUO;

            #endregion Public Fields
        }

        /// <summary>
        /// Method class for glow effects (Glow Effects are calculated on a player to player basis)
        /// </summary>
        public abstract class GlowEffect
        {
            #region Public Methods

            public abstract GlowStruct Calculate(Entity entity);

            public override string ToString()
            {
                return GetType().Name;
            }

            #endregion Public Methods
        }

        /// <summary>
        /// Method class for glow handling (Glow handling is calculated on a team basis)
        /// </summary>
        public abstract class GlowSelector
        {
            #region Public Methods

            public abstract void Process(Entity[] PlayerList, LocalPlayer localplayer, int GlowObject);

            public override string ToString()
            {
                return GetType().Name;
            }

            #endregion Public Methods
        }

        /// <summary>
        /// Glows when users crosshair is over an enemy team member In Red (Colour is not currently changeable.
        /// </summary>
        public class GlowInCrosshair : GlowSelector
        {
            #region Public Methods

            public override void Process(Entity[] PlayerList, LocalPlayer localplayer, int GlowObject)
            {
                foreach (Entity Player in PlayerList)
                {
                    int InCrosshairEntity = localplayer.InCrossEntity;
                    int PlayerGI = Player.GlowIndex;

                    GlowStruct SelectedColour = new GlowStruct();

                    if (Player.TeamNumber == localplayer.TeamNumber && Settings.Visuals.ShowTeam)
                    {
                        SelectedColour = Settings.Visuals.TeamTheme.Calculate(Player);
                    }
                    else if (Player.TeamNumber != localplayer.TeamNumber && Settings.Visuals.ShowEnemy)
                    {
                        if (Player.EntityID == InCrosshairEntity)
                        {
                            SelectedColour = new Red().Calculate(Player);
                        }
                        else
                        {
                            SelectedColour = Settings.Visuals.EnemyTheme.Calculate(Player);
                        }
                    }
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0x4), SelectedColour.R);
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0x8), SelectedColour.G);
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0xC), SelectedColour.B);
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0x10), SelectedColour.A);
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0x24), SelectedColour.RWO);
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0x25), SelectedColour.RWUO);
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0x2C), Settings.Visuals.ChamsMode);
                }
            }

            #endregion Public Methods
        }

        /// <summary>
        /// Static glow, child of Glow Handler
        /// </summary>
        public class StaticGlow : GlowSelector
        {
            #region Public Methods

            public override void Process(Entity[] PlayerList, LocalPlayer localplayer, int GlowObject)
            {
                foreach (Entity Player in PlayerList)
                {
                    int PlayerGI = Player.GlowIndex;

                    GlowStruct SelectedColour = new GlowStruct();

                    if (Player.TeamNumber == localplayer.TeamNumber && Settings.Visuals.ShowTeam)
                    {
                        SelectedColour = Settings.Visuals.TeamTheme.Calculate(Player);
                    }
                    else if (Player.TeamNumber != localplayer.TeamNumber && Settings.Visuals.ShowEnemy)
                    {
                        SelectedColour = Settings.Visuals.EnemyTheme.Calculate(Player);
                    }

                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0x4), SelectedColour.R);
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0x8), SelectedColour.G);
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0xC), SelectedColour.B);
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0x10), SelectedColour.A);
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0x24), SelectedColour.RWO);
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0x25), SelectedColour.RWUO);
                    WriteValue(GlowObject + (PlayerGI * 0x38 + 0x2C), Settings.Visuals.ChamsMode);
                }
            }

            #endregion Public Methods
        }

        /// <summary>
        /// Blue, child of GlowEffect
        /// </summary>
        public class Blue : GlowEffect
        {
            #region Public Methods

            public override GlowStruct Calculate(Entity entity)
            {
                return new GlowStruct(Base.Blue);
            }

            #endregion Public Methods
        }

        /// <summary>
        /// Green, child of GlowEffect
        /// </summary>
        public class Green : GlowEffect
        {
            #region Public Methods

            public override GlowStruct Calculate(Entity entity)
            {
                return new GlowStruct(Base.Green);
            }

            #endregion Public Methods
        }

        /// <summary>
        /// Purple, child of GlowEffect
        /// </summary>
        public class Purple : GlowEffect
        {
            #region Public Methods

            public override GlowStruct Calculate(Entity entity)
            {
                return new GlowStruct(Base.Purple);
            }

            #endregion Public Methods
        }

        /// <summary>
        /// Red, child of GlowEffect
        /// </summary>
        public class Red : GlowEffect
        {
            #region Public Methods

            public override GlowStruct Calculate(Entity entity)
            {
                return new GlowStruct(Base.Red);
            }

            #endregion Public Methods
        }

        /// <summary>
        /// Teal, child of GlowEffect
        /// </summary>
        public class Teal : GlowEffect
        {
            #region Public Methods

            public override GlowStruct Calculate(Entity entity)
            {
                return new GlowStruct(Base.Teal);
            }

            #endregion Public Methods
        }

        /// <summary>
        /// Yellow, child of GlowEffect
        /// </summary>
        public class Yellow : GlowEffect
        {
            #region Public Methods

            public override GlowStruct Calculate(Entity entity)
            {
                return new GlowStruct(Base.Yellow);
            }

            #endregion Public Methods
        }

        /// <summary>
        /// Randomly cycles through colours, child of GlowEffect
        /// </summary>
        public class EyeFuck : GlowEffect
        {
            #region Public Methods

            public override GlowStruct Calculate(Entity entity)
            {
                Random Rnd = new Random();

                switch (Rnd.Next(0, 3))
                {
                    case 0:
                        return new GlowStruct(Base.Red);

                    case 1:
                        return new GlowStruct(Base.Green);

                    case 2:
                        return new GlowStruct(Base.Yellow);

                    case 3:
                        return new GlowStruct(Base.Blue);
                }

                return null;
            }

            #endregion Public Methods
        }

        /// <summary>
        /// Glows Yellow / red dependant on player health
        /// </summary>
        public class PlayerHealth : GlowEffect
        {
            #region Public Methods

            public override GlowStruct Calculate(Entity entity)
            {
                int Health = entity.Health;

                return new GlowStruct { R = 255 - Health * 2.55f, G = Health * 2.55f, B = 0, A = 255 };
            }

            #endregion Public Methods
        }

        #endregion Public Classes
    }
}