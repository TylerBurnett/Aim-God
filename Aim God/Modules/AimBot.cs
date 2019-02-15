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
                if (Settings.AimBot.Toggled == true && localPlayer.Health > 0)
                {
                    PlayerList = GetEntityList();
                    Settings.AimBot.Selector.Run(PlayerList, localPlayer);

                    if (Settings.AimBot.ShootOnLock) LeftClick();
                }
            }
        }

        #endregion Public Methods

        #region Private Methods

        private static Vector3 ClampAngle(Vector3 angle)
        {
            while (angle.Y > 180) angle.Y -= 360;
            while (angle.Y < -180) angle.Y += 360;

            if (angle.X > 89.0f) angle.X = 89.0f;
            if (angle.X < -89.0f) angle.X = -89.0f;

            angle.Z = 0f;

            return angle;
        }

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

        private static float AngularDistance(Vector3 To, Vector3 From)
        {
            Vector3 Difference = Vector3.Subtract(To, From);
            return Difference.LengthSquared();
        }

        #endregion Private Methods

        #region Public Classes

        public abstract class AimBotSelector
        {
            #region Public Methods

            public abstract void Run(Entity[] EntityList, LocalPlayer localPlayer);

            #endregion Public Methods
        }

        public abstract class CursorLockBehaviour
        {
            #region Public Methods

            public abstract void LookAt(LocalPlayer localPlayer, Entity Target);

            #endregion Public Methods
        }

        public class AssistedLock : AimBotSelector
        {
            #region Public Methods

            public override void Run(Entity[] EntityList, LocalPlayer localPlayer)
            {
                Dictionary<float, Entity> DistanceList = new Dictionary<float, Entity>();

                foreach (Entity player in EntityList)
                {
                    if (player.TeamNumber != localPlayer.TeamNumber && player.Health > 0)
                    {
                        Vector3 AimAngle = Math3.CalcAngle(localPlayer.VecView, player.GetBonePosition(8));
                        DistanceList.Add(AngularDistance(localPlayer.ViewAngles, AimAngle), player);
                    }

                    if (Settings.AimBot.Toggled == false) break;
                }

                if (DistanceList.Count > 0 && Settings.AimBot.Toggled)
                {
                    Entity Player = DistanceList.OrderByDescending(x => x.Key).LastOrDefault().Value;
                    Vector3 AimAngle = Math3.CalcAngle(localPlayer.ViewAngles, Player.GetBonePosition(8));

                    if (AngularDistance(localPlayer.ViewAngles, AimAngle) < 90)
                    {
                        Settings.AimBot.Lock.LookAt(localPlayer, Player);
                    }
                }
            }

            #endregion Public Methods
        }

        public class SelectOnCrosshair : AimBotSelector
        {
            #region Public Methods

            public override void Run(Entity[] EntityList, LocalPlayer localPlayer)
            {
                Entity InCrossEntity = new Entity(localPlayer.InCrossEntity);

                if (InCrossEntity.EntityID != 0 && localPlayer.TeamNumber != InCrossEntity.TeamNumber)
                {
                    Vector3 PlayerHead = InCrossEntity.GetBonePosition(8);
                    Vector3 VecView = localPlayer.VecView;

                    if (PlayerHead != Vector3.Zero || VecView != Vector3.Zero)
                    {
                        Vector3 AimAngle = Math3.CalcAngle(VecView, PlayerHead);
                        AimAngle = NormalizeAngle(AimAngle);
                        AimAngle = ClampAngle(AimAngle);

                        Settings.AimBot.Lock.LookAt(localPlayer, InCrossEntity);

                        //LeftClick();
                        Thread.Sleep(300);
                    }
                }
            }
        }

        public class SmoothLock : CursorLockBehaviour
        {
            #region Public Methods

            public override void LookAt(LocalPlayer localPlayer, Entity Player)
            {
                while (Settings.AimBot.Toggled && Player.Health > 0)
                {
                    Vector3 AimAngle = Math3.CalcAngle(localPlayer.VecView, Player.GetBonePosition(8));
                    AimAngle = NormalizeAngle(AimAngle);
                    AimAngle = ClampAngle(AimAngle);
                    Vector3 ViewAngles;

                    if (AngularDistance(localPlayer.VecView, AimAngle) < 4)
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

        #endregion Public Methods

        #endregion Public Classes
    }
}