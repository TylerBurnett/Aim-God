using Aim_God.Memory;
using Aim_God.Modules;
using Gma.System.MouseKeyHook;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Aim_God
{
    public partial class MainForm : MetroForm
    {
        #region Private Fields

        private IKeyboardMouseEvents m_GlobalHook;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Form intialization
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Gets the colours and glow handling classes for user selection
            Visuals_FriendlyColourControl.DataSource = ReflectionHelper.GetAllNonabstractClassesOf<Visuals.GlowEffect>();
            Visuals_EnemyColourControl.DataSource = ReflectionHelper.GetAllNonabstractClassesOf<Visuals.GlowEffect>();
            Visuals_FriendlyRenderControl.DataSource = ReflectionHelper.GetAllNonabstractClassesOf<Visuals.GlowHandler>();

            // Visuals Binds
            Visuals_FriendlyRenderControl.DataBindings.Add("SelectedItem", Settings.Visuals, "GlowHandler", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_FriendlyColourControl.DataBindings.Add("SelectedItem", Settings.Visuals, "TeamTheme", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_EnemyColourControl.DataBindings.Add("SelectedItem", Settings.Visuals, "EnemyTheme", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_ShowFriendlyTeamControl.DataBindings.Add("Checked", Settings.Visuals, "ShowTeam", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_ShowEnemyTeamControl.DataBindings.Add("Checked", Settings.Visuals, "ShowEnemy", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_AntiFlashControl.DataBindings.Add("Checked", Settings.Visuals, "AntiFlash", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_LoopDelayControl.DataBindings.Add("Value", Settings.Visuals, "LoopDelay", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_ChamsModeControl.DataBindings.Add("Checked", Settings.Visuals, "ChamsMode", true, DataSourceUpdateMode.OnPropertyChanged);

            //Trigger Bot Binds
            TriggerBot_ReactionSpeedControl.DataBindings.Add("value", Settings.TriggerBot, "ReactionSpeed", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        #endregion Public Constructors

        #region Private Methods

        private void InitializeMouseKeyHooks()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseDown += GlobalHookMouseDown;
            m_GlobalHook.MouseUp += GlobalHookMouseUp;
            m_GlobalHook.KeyDown += GlobalHookKeyDown;
            m_GlobalHook.KeyUp += GlobalHookKeyUp;

            Hook.GlobalEvents().OnCombination(new Dictionary<Combination, Action>
            {
              {Combination.FromString("Shift+V"), () => Visuals_EnableControl_Click(null, null)},
              {Combination.FromString("Shift+T"), () => TriggerBot_EnableControl_Click(null, null)},
              {Combination.FromString("Shift+A"), () => AimBot_EnableControl_Click(null, null)},
            });
        }

        private void UnsubscribeKeyHooks()
        {
            m_GlobalHook.MouseDown -= GlobalHookMouseDown;
            m_GlobalHook.MouseUp -= GlobalHookMouseUp;
            m_GlobalHook.KeyDown -= GlobalHookKeyDown;
            m_GlobalHook.KeyUp -= GlobalHookKeyUp;
            m_GlobalHook.Dispose();
        }

        private void GlobalHookKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                Settings.AimBot.Toggled = true;
                e.Handled = true;
            }
        }

        private void GlobalHookKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                Settings.AimBot.Toggled = false;
                e.Handled = true;
            }
        }

        private void GlobalHookMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle) Settings.TriggerBot.Toggled = true;
        }

        private void GlobalHookMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle) Settings.TriggerBot.Toggled = false;
        }

        private void TriggerBot_EnableControl_Click(object sender, EventArgs e)
        {
            if (Settings.TriggerBot.Enabled == false)
            {
                TriggerBot_EnableControl.Text = "Trigger Bot is enabled";
                Settings.TriggerBot.Enabled = true;
                Thread TriggerBotThread = new Thread(() => TriggerBot.Run());
                TriggerBotThread.Start();
            }
            else
            {
                TriggerBot_EnableControl.Text = "Trigger Bot is disabled";
                Settings.TriggerBot.Enabled = false;
            }
        }

        private void Visuals_EnableControl_Click(object sender, EventArgs e)
        {
            if (Settings.Visuals.Enabled == false)
            {
                Visuals_EnableControl.Text = "Visuals is enabled";
                Settings.Visuals.Enabled = true;
                Thread VisualsThread = new Thread(() => Visuals.Run());
                VisualsThread.Start();
            }
            else
            {
                Visuals_EnableControl.Text = "Visuals is disabled";
                Settings.Visuals.Enabled = false;
            }
        }

        /// <summary>
        /// Fix this
        /// </summary>
        private void Chams_EnableControl_Click(object sender, EventArgs e)
        {
            if (Settings.Chams.Enabled == false)
            {
                Chams_EnableButton.Text = "Chams is enabled";
                Settings.Chams.Enabled = true;
                Thread ChamsThread = new Thread(() => Chams.Run());
                ChamsThread.Start();
            }
            else
            {
                Chams_EnableButton.Text = "Chams is disabled";
                Settings.Chams.Enabled = false;
            }
        }

        private void AimBot_EnableControl_Click(object sender, EventArgs e)
        {
            if (Settings.AimBot.Enabled == false)
            {
                AimBot_EnableControl.Text = "Aim Bot is enabled";
                Settings.AimBot.Enabled = true;
                Thread AimBotThread = new Thread(() => AimBot.Run());
                AimBotThread.Start();
            }
            else
            {
                AimBot_EnableControl.Text = "Aim Bot is disabled";
                Settings.AimBot.Enabled = false;
            }
        }

        /// <summary>
        /// Shuts down hack and keyhooks when Cs:Go isnt running
        /// </summary>
        private void WaitForGame()
        {
            UnsubscribeKeyHooks();

            if (Settings.Visuals.Enabled) Visuals_EnableControl_Click(null, null);
            if (Settings.TriggerBot.Enabled) TriggerBot_EnableControl_Click(null, null);

            while (MemoryHandler.Initialize("csgo", WaitForGame))
            {
                DialogResult dr = MetroMessageBox.Show(this, "Please open CounterStrike Global Offensive before continuing.",
                    "Cannot connect to Counter Strike", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

                if (dr == DialogResult.No) Application.Exit();
            }

            InitializeMouseKeyHooks();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //User protection for Offsets and application not open errors
            while (MemoryHandler.Initialize("csgo", WaitForGame) == false)
            {
                DialogResult dr = MetroMessageBox.Show(this, "Please open CounterStrike Global Offensive before continuing.",
                    "Cannot connect to Counter Strike", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

                if (dr == DialogResult.No) Application.Exit();
            }

            while (OffsetHandler.LoadOffsets() == false)
            {
                DialogResult dr = MetroMessageBox.Show(this, "Unable to download or access cached offsets. Please connect to internet to continue.",
                    "Cannot access offsets", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

                if (dr == DialogResult.No) Application.Exit();
            }

            InitializeMouseKeyHooks();
        }

        #endregion Private Methods

        #region Private Classes

        private static class ReflectionHelper
        {
            #region Public Methods

            public static List<T> GetAllNonabstractClassesOf<T>()
            {
                Object[] args = new Object[0];
                return GetAllNonabstractClassesOf<T>(args);
            }

            public static List<T> GetAllNonabstractClassesOf<T>(Object[] args)
            {
                List<T> retVal = new List<T>();
                IEnumerable<object> instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                                                where t.IsSubclassOf(typeof(T)) && !t.IsAbstract
                                                select Activator.CreateInstance(t, args) as object;
                foreach (T instance in instances)
                {
                    retVal.Add(instance);
                }
                return retVal;
            }

            #endregion Public Methods
        }

        #endregion Private Classes
    }
}