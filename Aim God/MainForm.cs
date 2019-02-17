using Aim_God.Memory;
using Aim_God.Modules;
using Gma.System.MouseKeyHook;
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

            // Visuals Binds
            Visuals_FriendlyRenderControl.DataBindings.Add("SelectedItem", Settings.Visuals, "GlowHandler", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_FriendlyColourControl.DataBindings.Add("SelectedItem", Settings.Visuals, "TeamTheme", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_EnemyColourControl.DataBindings.Add("SelectedItem", Settings.Visuals, "EnemyTheme", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_ShowFriendlyTeamControl.DataBindings.Add("Checked", Settings.Visuals, "ShowTeam", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_ShowEnemyTeamControl.DataBindings.Add("Checked", Settings.Visuals, "ShowEnemy", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_AntiFlashControl.DataBindings.Add("Checked", Settings.Visuals, "AntiFlash", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_LoopDelayControl.DataBindings.Add("Value", Settings.Visuals, "LoopDelay", true, DataSourceUpdateMode.OnPropertyChanged);
            Visuals_ChamsModeControl.DataBindings.Add("Checked", Settings.Visuals, "ChamsMode", true, DataSourceUpdateMode.OnPropertyChanged);
            // Gets the colours and glow handling classes for user selection
            Visuals_FriendlyColourControl.DataSource = ReflectionHelper.GetAllNonabstractClassesOf<Visuals.GlowEffect>();
            Visuals_EnemyColourControl.DataSource = ReflectionHelper.GetAllNonabstractClassesOf<Visuals.GlowEffect>();
            Visuals_FriendlyRenderControl.DataSource = ReflectionHelper.GetAllNonabstractClassesOf<Visuals.GlowHandler>();

            //Trigger Bot Binds
            TriggerBot_ReactionSpeedControl.DataBindings.Add("value", Settings.TriggerBot, "ReactionSpeed", true, DataSourceUpdateMode.OnPropertyChanged);

            //Chams Binds
            Chams_FriendlyColourControl.DataBindings.Add("SelectedItem", Settings.Chams, "TeamColour", true, DataSourceUpdateMode.OnPropertyChanged);
            Chams_EnemyColourControl.DataBindings.Add("SelectedItem", Settings.Chams, "EnemyColour", true, DataSourceUpdateMode.OnPropertyChanged);
            Chams_ShowFriendlyTeamControl.DataBindings.Add("Checked", Settings.Chams, "ShowTeam", true, DataSourceUpdateMode.OnPropertyChanged);
            Chams_ShowEnemyTeamControl.DataBindings.Add("Checked", Settings.Chams, "ShowEnemy", true, DataSourceUpdateMode.OnPropertyChanged);
            // Gets the colour classes for user selection, Temporary fix
            Chams_FriendlyColourControl.DataSource = new Base.Colour[] { Base.Red, Base.Green, Base.Blue, Base.Purple, Base.Yellow, Base.Teal }; // Colour class is a little
            Chams_EnemyColourControl.DataSource = new Base.Colour[] { Base.Red, Base.Green, Base.Blue, Base.Purple, Base.Yellow, Base.Teal }; // broken atm, working on it.
        }

        #endregion Public Constructors

        #region Private Methods

        private void StartMouseKeyHooks()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseDown += MouseDownHook;
            m_GlobalHook.MouseUp += MouseUpHook;
            m_GlobalHook.KeyDown += KeyDownHook;
            m_GlobalHook.KeyUp += KeyUpHook;

            Hook.GlobalEvents().OnCombination(new Dictionary<Combination, Action>
            {
              {Combination.FromString("Shift+V"), () => Visuals_EnableControl_Click(null, null)},
              {Combination.FromString("Shift+T"), () => TriggerBot_EnableControl_Click(null, null)},
              {Combination.FromString("Shift+C"), () => Chams_EnableControl_Click(null, null)},
              {Combination.FromString("Shift+A"), () => AimBot_EnableControl_Click(null, null)},
            });
        }

        private void RemoveMouseKeyHooks()
        {
            m_GlobalHook.MouseDown -= MouseDownHook;
            m_GlobalHook.MouseUp -= MouseUpHook;
            m_GlobalHook.KeyDown -= KeyDownHook;
            m_GlobalHook.KeyUp -= KeyUpHook;
            m_GlobalHook.Dispose();
        }

        private void KeyDownHook(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                Settings.AimBot.Toggled = true;
                e.Handled = true;
            }
        }

        private void KeyUpHook(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                Settings.AimBot.Toggled = false;
                e.Handled = true;
            }
        }

        private void MouseDownHook(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle) Settings.TriggerBot.Toggled = true;
        }

        private void MouseUpHook(object sender, MouseEventArgs e)
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

        private void Chams_EnableControl_Click(object sender, EventArgs e)
        {
            Thread ChamsThread = new Thread(() => Chams.Run());
            ChamsThread.Start();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            // This function is also used for the application close callback
            if (m_GlobalHook != null) RemoveMouseKeyHooks();
            if (Settings.Visuals.Enabled) Visuals_EnableControl_Click(null, null);
            if (Settings.TriggerBot.Enabled) TriggerBot_EnableControl_Click(null, null);
            if (Settings.AimBot.Enabled) TriggerBot_EnableControl_Click(null, null);

            // Got sick of having cs:go open whislt working with UI
#if DEBUG
            MemoryHandler.Initialize(() => MainForm_Load(null, null));
            Offsets.LoadOffsets();
#endif

#if !DEBUG
            while (MemoryHandler.Initialize(() => MainForm_Load(null, null)) == false)
            {
                DialogResult Result = MetroMessageBox.Show(this,
                    "Please open CounterStrike Global Offensive before continuing.",
                    "Cannot connect to Counter Strike",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

                if (Result == DialogResult.No) Environment.Exit(0);
            }

            while (Offsets.LoadOffsets() == false)
            {
                DialogResult dr = MetroMessageBox.Show(this,
                    "Unable to download or access cached offsets.",
                    "Cannot access offsets",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

                if (dr == DialogResult.No) Environment.Exit(0);
            }
#endif
            StartMouseKeyHooks();
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