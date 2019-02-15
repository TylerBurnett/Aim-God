using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace Aim_God.Memory
{
    public static class OffsetHandler
    {
        #region Public Fields

        public static netvars Netvars = new netvars();
        public static signatures Signatures = new signatures();

        #endregion Public Fields

        #region Public Methods

        public static bool LoadOffsets()
        {
            try
            {
                const string OffsetsUrl = "https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.json";

                bool Exists = File.Exists("Offsets.json");

                string Data = GetOffsets(new Uri(OffsetsUrl));

                if (Data != null)
                {
                    File.WriteAllText("Offsets.json", Data);
                    ParentObject Parent = JsonConvert.DeserializeObject<ParentObject>(Data);
                    Netvars = Parent.Netvars;
                    Signatures = Parent.Signatures;
                }
                else
                {
                    ParentObject Parent = JsonConvert.DeserializeObject<ParentObject>(File.ReadAllText("Offsets.json"));
                    Netvars = Parent.Netvars;
                    Signatures = Parent.Signatures;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion Public Methods

        #region Private Methods

        private static string GetOffsets(Uri Url)
        {
            string Data = null;
            try
            {
                WebClient web = new WebClient();
                Data = web.DownloadString(Url);
                web.Dispose();
            }
            catch
            {
            }

            return Data;
        }

        #endregion Private Methods

        #region Public Classes

        public class ParentObject
        {
            #region Public Properties

            public netvars Netvars { get; set; }
            public signatures Signatures { get; set; }
            public int timestamp { get; set; }

            #endregion Public Properties
        }

        public class signatures
        {
            public int clientstate_choked_commands { get; set; }
            public int clientstate_delta_ticks { get; set; }
            public int clientstate_last_outgoing_command { get; set; }
            public int clientstate_net_channel { get; set; }
            public int convar_name_hash_table { get; set; }
            public int dwClientState { get; set; }
            public int dwClientState_GetLocalPlayer { get; set; }
            public int dwClientState_IsHLTV { get; set; }
            public int dwClientState_Map { get; set; }
            public int dwClientState_MapDirectory { get; set; }
            public int dwClientState_MaxPlayer { get; set; }
            public int dwClientState_PlayerInfo { get; set; }
            public int dwClientState_State { get; set; }
            public int dwClientState_ViewAngles { get; set; }
            public int dwEntityList { get; set; }
            public int dwForceAttack { get; set; }
            public int dwForceAttack2 { get; set; }
            public int dwForceBackward { get; set; }
            public int dwForceForward { get; set; }
            public int dwForceJump { get; set; }
            public int dwForceLeft { get; set; }
            public int dwForceRight { get; set; }
            public int dwGameDir { get; set; }
            public int dwGameRulesProxy { get; set; }
            public int dwGetAllClasses { get; set; }
            public int dwGlobalVars { get; set; }
            public int dwGlowObjectManager { get; set; }
            public int dwInput { get; set; }
            public int dwInterfaceLinkList { get; set; }
            public int dwLocalPlayer { get; set; }
            public int dwMouseEnable { get; set; }
            public int dwMouseEnablePtr { get; set; }
            public int dwPlayerResource { get; set; }
            public int dwRadarBase { get; set; }
            public int dwSensitivity { get; set; }
            public int dwSensitivityPtr { get; set; }
            public int dwSetClanTag { get; set; }
            public int dwViewMatrix { get; set; }
            public int dwWeaponTable { get; set; }
            public int dwWeaponTableIndex { get; set; }
            public int dwYawPtr { get; set; }
            public int dwZoomSensitivityRatioPtr { get; set; }
            public int dwbSendPackets { get; set; }
            public int dwppDirect3DDevice9 { get; set; }
            public int interface_engine_cvar { get; set; }
            public int m_bDormant { get; set; }
            public int m_pStudioHdr { get; set; }
            public int m_pitchClassPtr { get; set; }
            public int m_yawClassPtr { get; set; }
            public int model_ambient_min { get; set; }
        }

        public class netvars
        {
            public int cs_gamerules_data { get; set; }
            public int m_ArmorValue { get; set; }
            public int m_Collision { get; set; }
            public int m_CollisionGroup { get; set; }
            public int m_Local { get; set; }
            public int m_MoveType { get; set; }
            public int m_OriginalOwnerXuidHigh { get; set; }
            public int m_OriginalOwnerXuidLow { get; set; }
            public int m_SurvivalGameRuleDecisionTypes { get; set; }
            public int m_SurvivalRules { get; set; }
            public int m_aimPunchAngle { get; set; }
            public int m_aimPunchAngleVel { get; set; }
            public int m_bBombPlanted { get; set; }
            public int m_bFreezePeriod { get; set; }
            public int m_bGunGameImmunity { get; set; }
            public int m_bHasDefuser { get; set; }
            public int m_bHasHelmet { get; set; }
            public int m_bInReload { get; set; }
            public int m_bIsDefusing { get; set; }
            public int m_bIsQueuedMatchmaking { get; set; }
            public int m_bIsScoped { get; set; }
            public int m_bIsValveDS { get; set; }
            public int m_bSpotted { get; set; }
            public int m_bSpottedByMask { get; set; }
            public int m_clrRender { get; set; }
            public int m_dwBoneMatrix { get; set; }
            public int m_fAccuracyPenalty { get; set; }
            public int m_fFlags { get; set; }
            public int m_flC4Blow { get; set; }
            public int m_flDefuseCountDown { get; set; }
            public int m_flDefuseLength { get; set; }
            public int m_flFallbackWear { get; set; }
            public int m_flFlashDuration { get; set; }
            public int m_flFlashMaxAlpha { get; set; }
            public int m_flNextPrimaryAttack { get; set; }
            public int m_flTimerLength { get; set; }
            public int m_hActiveWeapon { get; set; }
            public int m_hMyWeapons { get; set; }
            public int m_hObserverTarget { get; set; }
            public int m_hOwner { get; set; }
            public int m_hOwnerEntity { get; set; }
            public int m_iAccountID { get; set; }
            public int m_iClip1 { get; set; }
            public int m_iCompetitiveRanking { get; set; }
            public int m_iCompetitiveWins { get; set; }
            public int m_iCrosshairId { get; set; }
            public int m_iEntityQuality { get; set; }
            public int m_iFOV { get; set; }
            public int m_iFOVStart { get; set; }
            public int m_iGlowIndex { get; set; }
            public int m_iHealth { get; set; }
            public int m_iItemDefinitionIndex { get; set; }
            public int m_iItemIDHigh { get; set; }
            public int m_iObserverMode { get; set; }
            public int m_iShotsFired { get; set; }
            public int m_iState { get; set; }
            public int m_iTeamNum { get; set; }
            public int m_lifeState { get; set; }
            public int m_nFallbackPaintKit { get; set; }
            public int m_nFallbackSeed { get; set; }
            public int m_nFallbackStatTrak { get; set; }
            public int m_nForceBone { get; set; }
            public int m_nTickBase { get; set; }
            public int m_rgflCoordinateFrame { get; set; }
            public int m_szCustomName { get; set; }
            public int m_szLastPlaceName { get; set; }
            public int m_thirdPersonViewAngles { get; set; }
            public int m_vecOrigin { get; set; }
            public int m_vecVelocity { get; set; }
            public int m_vecViewOffset { get; set; }
            public int m_viewPunchAngle { get; set; }
        }

        #endregion Public Classes
    }
}