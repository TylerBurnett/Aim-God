using Aim_God.Memory;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static Aim_God.Memory.Offsets;

namespace Aim_God.Modules
{
    /// <summary>
    /// WIP, Bones are dynamic for entities depending on the map. Find a workaround.
    /// </summary>
    public static class Bone
    {
        #region Public Fields

        public const int Head = 8;

        #endregion Public Fields
    }

    public class Base
    {
        #region Public Fields

        public static Colour Red = new Colour(255, 0, 0, 1, "Red");

        public static Colour Green = new Colour(0, 255, 0, 1, "Green");

        public static Colour Blue = new Colour(0, 0, 255, 1, "Blue");

        public static Colour Purple = new Colour(255, 0, 255, 1, "Purple");

        public static Colour Yellow = new Colour(255, 255, 0, 1, "Yellow");

        public static Colour Teal = new Colour(0, 255, 255, 1, "Teal");

        public static Colour Opauqe = new Colour(-1, 16777215, 65535, 1, "Opauqe");

        #endregion Public Fields

        #region Public Methods

        /// <summary>
        /// Returns all player entities
        /// </summary>
        /// <returns>A Entity array</returns>
        public static Entity[] GetEntityList()
        {
            List<Entity> PlayerList = new List<Entity>();

            for (int i = 0; i != 64; i++)
            {
                int selectedEntity = MemoryHandler.ReadValue<int>(MemoryHandler.Module("client_panorama.dll") + Signatures.dwEntityList + i * 0x10);

                if (selectedEntity != 0)
                {
                    Entity entity = new Entity(selectedEntity);
                    PlayerList.Add(entity);
                }
            }
            return PlayerList.ToArray();
        }

        /// <summary>
        /// Used for firing in Trigger Bot and Aim Bot, I heard rumors that the offset for: ForceAttack1 is watched by VAC
        /// </summary>
        public static void LeftClick()
        {
            NativeMethods.mouse_event(0x02 | 0x04, (uint)Cursor.Position.X,
                (uint)Cursor.Position.Y, 0, 0);
        }

        #endregion Public Methods

        #region Private Classes

        // Native Methods container
        private class NativeMethods
        {
            #region Private Constructors

            private NativeMethods()
            {
            }

            #endregion Private Constructors

            #region Public Methods

            [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
            public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

            #endregion Public Methods
        }

        #endregion Private Classes
    }

    /// <summary>
    /// Master class for accessing the Local Player (Client)
    /// </summary>
    public class LocalPlayer
    {
        #region Public Properties

        public int EntityID
        {
            get => MemoryHandler.ReadValue<int>(MemoryHandler.Module("client_panorama.dll") + Signatures.dwLocalPlayer);
        }

        public int Health
        {
            get => MemoryHandler.ReadValue<int>(EntityID + Netvars.m_iHealth);
        }

        public float FlashDuration
        {
            get => MemoryHandler.ReadValue<float>(EntityID + Netvars.m_flFlashDuration);
            set => MemoryHandler.WriteValue(EntityID + Netvars.m_flFlashDuration, value);
        }

        public int TeamNumber
        {
            get => MemoryHandler.ReadValue<int>(EntityID + Netvars.m_iTeamNum);
        }

        public int CrosshairID
        {
            get => MemoryHandler.ReadValue<int>(EntityID + Netvars.m_iCrosshairId);
        }

        public int InCrossEntity
        {
            get => MemoryHandler.ReadValue<int>(MemoryHandler.Module("client_panorama.dll") + Signatures.dwEntityList + (CrosshairID - 1) * 16);
        }

        public Vector3 AimPunch
        {
            get => MemoryHandler.ReadClass<Vector3>(EntityID + Netvars.m_aimPunchAngle);
        }

        public Vector3 ViewAngles
        {
            get => MemoryHandler.ReadClass<Vector3>(ClientState + Signatures.dwClientState_ViewAngles);

            set => MemoryHandler.WriteClass(ClientState + Signatures.dwClientState_ViewAngles, value);
        }

        public Vector3 VecView
        {
            get
            {
                Vector3 VecView = MemoryHandler.ReadClass<Vector3>(EntityID + Netvars.m_vecViewOffset);
                Vector3 VecOrigin = MemoryHandler.ReadClass<Vector3>(EntityID + Netvars.m_vecOrigin);
                return Vector3.Add(VecView, VecOrigin);
            }
        }

        #endregion Public Properties

        #region Private Properties

        private static int ClientState
        {
            get => MemoryHandler.ReadValue<int>(MemoryHandler.Module("engine.dll") + Signatures.dwClientState);
        }

        #endregion Private Properties

        #region Public Methods

        public Vector3 GetBonePosition(int TargetBone)
        {
            int BoneMatrix = MemoryHandler.ReadValue<int>(EntityID + Netvars.m_dwBoneMatrix);

            float[] Bone = MemoryHandler.ReadArray<float>(BoneMatrix + 0x30 * TargetBone + 0x0C, 9);

            if (Bone.Length == 0) return Vector3.Zero;

            return new Vector3(Bone[0], Bone[4], Bone[8]);
        }

        #endregion Public Methods
    }

    /// <summary>
    /// Colour Parent
    /// </summary>
    public class Colour
    {
        #region Public Constructors

        public Colour(float R, float G, float B, float A, string Name)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A;
            this.Name = Name;
        }

        #endregion Public Constructors

        #region Public Properties

        public float R { get; set; }

        public float G { get; set; }

        public float B { get; set; }

        public float A { get; set; }

        #endregion Public Properties

        #region Private Properties

        private string Name { get; set; }

        #endregion Private Properties

        #region Public Methods

        public override string ToString()
        {
            return Name;
        }

        #endregion Public Methods
    }

    /// <summary>
    /// Master class for accessing information on the specified Entity ID
    /// </summary>
    public class Entity
    {
        #region Public Constructors

        public Entity(int entityID)
        {
            EntityID = entityID;
        }

        #endregion Public Constructors

        #region Public Properties

        public int EntityID { get; set; }

        public int TeamNumber
        {
            get => MemoryHandler.ReadValue<int>(EntityID + Netvars.m_iTeamNum);
        }

        public int Health
        {
            get => MemoryHandler.ReadValue<int>(EntityID + Netvars.m_iHealth);
        }

        public int GlowIndex
        {
            get => MemoryHandler.ReadValue<int>(EntityID + Netvars.m_iGlowIndex);
        }

        #endregion Public Properties

        #region Public Methods

        public Vector3 GetBonePosition(int TargetBone)
        {
            int BoneMatrix = MemoryHandler.ReadValue<int>(EntityID + Netvars.m_dwBoneMatrix);

            float[] position = MemoryHandler.ReadArray<float>(BoneMatrix + 0x30 * TargetBone + 0x0C, 9);

            if (position.Length == 0) return Vector3.Zero;

            return new Vector3(position[0], position[4], position[8]);
        }

        #endregion Public Methods
    }
}