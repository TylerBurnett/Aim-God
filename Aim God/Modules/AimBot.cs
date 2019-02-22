using GameMath;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading;
using static Aim_God.Modules.Base;

namespace Aim_God.Modules
{
    public class AimBot
    {
        #region Public Methods

        public static void Run()
        {
            Entity[] PlayerList;
            LocalPlayer localPlayer = new LocalPlayer();

            while (Settings.AimBot.Enabled)
            {
                if (Settings.AimBot.Toggled && localPlayer.Health > 0)
                {
                    // Pass down entity list
                    PlayerList = GetEntityList();

                    // Run the chosen player selection algorithm
                    Entity SelectedPlayer = Settings.AimBot.Selector.Run(PlayerList, localPlayer);

                    if (SelectedPlayer != null)
                    {
                        // Then pass that player to the chosen cursor lock behaviour.
                        Settings.AimBot.Lock.LookAt(localPlayer, SelectedPlayer);

                        // Shoots on lock per user specification.
                        if (Settings.AimBot.ShootOnLock) LeftClick();
                    }
                }
            }
        }

        #endregion Public Methods

        #region Private Methods

        // In transistion to GameMath, will be deleted
        private static Vector3 ClampAngle(Vector3 angle)
        {
            while (angle.Y > 180) angle.Y -= 360;
            while (angle.Y < -180) angle.Y += 360;

            if (angle.X > 89.0f) angle.X = 89.0f;
            if (angle.X < -89.0f) angle.X = -89.0f;

            angle.Z = 0f;

            return angle;
        }

        // In transistion to GameMath, will be deleted
        private static Vector3 NormalizeAngle(Vector3 angle)
        {
            while (angle.X < -180.0f) angle.X += 360.0f;
            while (angle.X > 180.0f) angle.X -= 360.0f;

            while (angle.Y < -180.0f) angle.Y += 360.0f;
            while (angle.Y > 180.0f) angle.Y -= 360.0f;

            while (angle.Z < -180.0f) angle.Z += 360.0f;
            while (angle.Z > 180.0f) angle.Z -= 360.0f;

            return angle;
        }

        #endregion Private Methods

        #region Public Classes

        /// <summary>
        /// Parent class for player selection classes
        /// </summary>
        public abstract class AimBotSelector
        {
            #region Public Methods

            public abstract Entity Run(Entity[] EntityList, LocalPlayer localPlayer);

            #endregion Public Methods
        }

        /// <summary>
        /// Parent class for Cursor Lock Behaviours
        /// </summary>
        public abstract class CursorLockBehaviour
        {
            #region Public Methods

            public abstract void LookAt(LocalPlayer localPlayer, Entity Target);

            #endregion Public Methods
        }

        /// <summary>
        /// Locks on to closest player when angular distance is small enough
        /// </summary>
        public class AssistedLock : AimBotSelector
        {
            #region Public Methods

            public override Entity Run(Entity[] EntityList, LocalPlayer localPlayer)
            {
                Dictionary<float, Entity> DistanceList = new Dictionary<float, Entity>();

                foreach (Entity player in EntityList)
                {
                    if (player.TeamNumber != localPlayer.TeamNumber && player.Health > 0)
                    {
                        float FOV = Math3.GetFov(localPlayer.ViewAngles, localPlayer.GetBonePosition(8), player.GetBonePosition(8));
                        DistanceList.Add(FOV, player);
                    }

                    if (Settings.AimBot.Toggled == false) break;
                }

                if (DistanceList.Count > 0 && Settings.AimBot.Toggled)
                {
                    KeyValuePair<float, Entity> KeyPair = DistanceList.OrderByDescending(x => x.Key).LastOrDefault();

                    if (KeyPair.Key < 10)
                    {
                        return KeyPair.Value;
                    }
                }
                return null;
            }

            #endregion Public Methods
        }

        /// <summary>
        /// Selects player after they come into contact with crosshair
        /// </summary>
        public class SelectOnCrosshair : AimBotSelector
        {
            #region Public Methods

            public override Entity Run(Entity[] EntityList, LocalPlayer localPlayer)
            {
                Entity InCrossEntity = new Entity(localPlayer.InCrossEntity);

                if (InCrossEntity.EntityID != 0 && localPlayer.TeamNumber != InCrossEntity.TeamNumber)
                {
                    return InCrossEntity;
                }

                return null;
            }

            #endregion Public Methods
        }

        /// <summary>
        ///  Smoothly locks onto selected player
        /// </summary>
        public class SmoothLock : CursorLockBehaviour
        {
            #region Public Methods

            public override void LookAt(LocalPlayer localPlayer, Entity Player)
            {
                while (Settings.AimBot.Toggled && Player.Health > 0)
                {
                    float FOV = Math3.GetFov(localPlayer.ViewAngles, localPlayer.GetBonePosition(8), Player.GetBonePosition(8));
                    Vector3 AimAngle = Math3.CalcAngle(localPlayer.VecView, Player.GetBonePosition(8));
                    AimAngle = NormalizeAngle(AimAngle);
                    AimAngle = ClampAngle(AimAngle);
                    Vector3 ViewAngles;

                    // Once it has reached its destination, speed up the movement to maintain the lock
                    if (FOV < 8)
                    {
                        ViewAngles = Vector3.Lerp(localPlayer.ViewAngles, AimAngle, 0.6f);
                    }
                    else
                    {
                        ViewAngles = Vector3.Lerp(localPlayer.ViewAngles, AimAngle, 0.3f);
                    }

                    localPlayer.ViewAngles = ViewAngles;

                    Thread.Sleep(Settings.AimBot.Speed);
                }
            }

            #endregion Public Methods
        }

        #endregion Public Classes
    }
}