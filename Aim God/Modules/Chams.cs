using static Aim_God.Memory.MemoryHandler;
using static Aim_God.Memory.Offsets;
using static Aim_God.Modules.Base;

namespace Aim_God.Modules
{
    public class Chams
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

                WriteValue(Player.EntityID + Netvars.m_clrRender, (byte)SelectedColour.R);
                WriteValue(Player.EntityID + Netvars.m_clrRender + 0x01, (byte)SelectedColour.G);
                WriteValue(Player.EntityID + Netvars.m_clrRender + 0x02, (byte)SelectedColour.B);
            }

            // My method of adding ambient min. It usually requires a XOR calculation, but i dont know the current pointer for the XOR Calc
            // so instead i read the values after i changed them via in game console (r_ModelAmbientMin)
            // Should only be a temporary fix till i find the real pointer.
            if (Settings.Chams.Brightness)
            {
                WriteValue(Module("engine.dll") + Signatures.model_ambient_min, 1185344752);
            }
            else
            {
                WriteValue(Module("engine.dll") + Signatures.model_ambient_min, 117894384);
            }
        }
    }

    #endregion Public Methods
}