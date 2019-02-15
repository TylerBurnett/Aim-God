using System.Threading;
using static Aim_God.Memory.MemoryHandler;
using static Aim_God.Memory.OffsetHandler;
using static Aim_God.Modules.Base;

/// <summary>
/// Functional, but colours do not work TBF
/// </summary>
namespace Aim_God.Modules
{
    internal class Chams
    {
        #region Public Methods

        // <summary>
        /// Main loop for Chams, running dependant on Settings.ChamsSettings.Enabled. Must be run in seperate thread.
        /// </summary>
        public static void Run()
        {
            
            while (Settings.Chams.Enabled == true)
            {
                LocalPlayer localplayer = new LocalPlayer();

                Entity[] PlayerList = GetEntityList();

                foreach (Entity Player in PlayerList)
                {
                    if (Player.TeamNumber == localplayer.TeamNumber)
                    {
                        WriteValue(Player.EntityID + Netvars.m_clrRender, Settings.Chams.TeamColour.R);
                        WriteValue(Player.EntityID + Netvars.m_clrRender + 0x01, Settings.Chams.TeamColour.G);
                        WriteValue(Player.EntityID + Netvars.m_clrRender + 0x02, Settings.Chams.TeamColour.B);
                    }
                    else
                    {
                        WriteValue(Player.EntityID + Netvars.m_clrRender, Settings.Chams.EnemyColour.R);
                        WriteValue(Player.EntityID + Netvars.m_clrRender + 0x01, Settings.Chams.EnemyColour.G);
                        WriteValue(Player.EntityID + Netvars.m_clrRender + 0x02, Settings.Chams.EnemyColour.B);
                    }

                    int ThisPointer = Module("engine.dll") + Signatures.model_ambient_min - 0x2C;
                    int xored = 5 ^ ThisPointer;
                    WriteValue(Module("engine.dll") + Signatures.model_ambient_min - 0x2C, xored);
                }
                Thread.Sleep(2000);
            }
        }

        #endregion Public Methods
    }
}