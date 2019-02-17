using static Aim_God.Memory.MemoryHandler;
using static Aim_God.Memory.Offsets;
using static Aim_God.Modules.Base;

namespace Aim_God.Modules
{
    internal class Chams
    {
        #region Public Methods

        // <summary>
        /// Colour set function for chams. m_clrRender only changes when entites are Perminantly destroyed, E.G. New game.
        /// therefore no need to loop the call.
        /// </summary>
        public static void Run()
        {
            LocalPlayer localplayer = new LocalPlayer();
            Entity[] PlayerList = GetEntityList();

            foreach (Entity Player in PlayerList)
            {
                Colour SelectedColour = Opauqe;

                if (Settings.Chams.ShowTeam && Player.TeamNumber == localplayer.TeamNumber)
                {
                    SelectedColour = Settings.Chams.TeamColour;                  
                }
                else if (Settings.Chams.ShowEnemy && Player.TeamNumber != localplayer.TeamNumber)
                {
                    SelectedColour = Settings.Chams.EnemyColour;
                }

                WriteValue(Player.EntityID + Netvars.m_clrRender, (byte)SelectedColour.R); // YOU MUST WRITE THESE AS BYTES
                WriteValue(Player.EntityID + Netvars.m_clrRender + 0x01, (byte)SelectedColour.G); // Took me like 2 months to finally check the SDK
                WriteValue(Player.EntityID + Netvars.m_clrRender + 0x02, (byte)SelectedColour.B);
            }

            // I honestly have no idea how this works
            uint Pointer = (uint)(Module("engine.dll") + Signatures.model_ambient_min - 0x2c);
            uint CalcualtedValue = (uint)Settings.Chams.Brightness ^ Pointer;
            WriteValue(Module("engine.dll") + Signatures.model_ambient_min, CalcualtedValue);
        }
    }

    #endregion Public Methods
}