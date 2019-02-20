namespace Aim_God
{
    public partial class  MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GlobalStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChamsTab = new MetroFramework.Controls.MetroTabPage();
            this.Chams_ShowEnemyTeamControl = new MetroFramework.Controls.MetroToggle();
            this.Chams_BrightnessLabel = new MetroFramework.Controls.MetroLabel();
            this.Chams_BrightnessControl = new MetroFramework.Controls.MetroToggle();
            this.Chams_EnemyTeamColourLabel = new MetroFramework.Controls.MetroLabel();
            this.Chams_FriendlyTeamColorLabel = new MetroFramework.Controls.MetroLabel();
            this.Chams_EnemyColourControl = new MetroFramework.Controls.MetroComboBox();
            this.Chams_FriendlyColourControl = new MetroFramework.Controls.MetroComboBox();
            this.Chams_ShowEnemyTeamLabel = new MetroFramework.Controls.MetroLabel();
            this.Chams_ShowFriendlyTeamLabel = new MetroFramework.Controls.MetroLabel();
            this.Chams_ShowFriendlyTeamControl = new MetroFramework.Controls.MetroToggle();
            this.Chams_EnableButton = new MetroFramework.Controls.MetroButton();
            this.TriggerBotTab = new MetroFramework.Controls.MetroTabPage();
            this.TriggerBot_ReactionSpeedControl = new MetroFramework.Controls.MetroTrackBar();
            this.TriggerBot_EnableControl = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TriggerBot_RealisticReactionLabel = new MetroFramework.Controls.MetroLabel();
            this.TriggerBot_RealisticReactionControl = new MetroFramework.Controls.MetroToggle();
            this.VisualsTab = new MetroFramework.Controls.MetroTabPage();
            this.Visuals_ChamsModeLabel = new MetroFramework.Controls.MetroLabel();
            this.Visuals_ChamsModeControl = new MetroFramework.Controls.MetroToggle();
            this.Visuals_LoopDelayControl = new MetroFramework.Controls.MetroTrackBar();
            this.Visuals_LoopDelayLabel = new MetroFramework.Controls.MetroLabel();
            this.Visuals_AntiFlashLabel = new MetroFramework.Controls.MetroLabel();
            this.Visuals_AntiFlashControl = new MetroFramework.Controls.MetroToggle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Visuals_FriendlyRenderControl = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Visuals_EnemyColourControl = new MetroFramework.Controls.MetroComboBox();
            this.Visuals_FriendlyColourControl = new MetroFramework.Controls.MetroComboBox();
            this.Visuals_EnableControl = new MetroFramework.Controls.MetroButton();
            this.Visuals_ShowEnemyTeamLabel = new MetroFramework.Controls.MetroLabel();
            this.Visuals_ShowEnemyTeamControl = new MetroFramework.Controls.MetroToggle();
            this.Visuals_ShowFriendlyTeamLabel = new MetroFramework.Controls.MetroLabel();
            this.Visuals_ShowFriendlyTeamControl = new MetroFramework.Controls.MetroToggle();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.AimBotPage = new MetroFramework.Controls.MetroTabPage();
            this.AimBot_EnableControl = new MetroFramework.Controls.MetroButton();
            this.visualsSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamsSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.triggerBotSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GlobalStyleManager)).BeginInit();
            this.ChamsTab.SuspendLayout();
            this.TriggerBotTab.SuspendLayout();
            this.VisualsTab.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.AimBotPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualsSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamsSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerBotSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GlobalStyleManager
            // 
            this.GlobalStyleManager.Owner = this;
            this.GlobalStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
            this.GlobalStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(94, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "God";
            // 
            // ChamsTab
            // 
            this.ChamsTab.Controls.Add(this.Chams_ShowEnemyTeamControl);
            this.ChamsTab.Controls.Add(this.Chams_BrightnessLabel);
            this.ChamsTab.Controls.Add(this.Chams_BrightnessControl);
            this.ChamsTab.Controls.Add(this.Chams_EnemyTeamColourLabel);
            this.ChamsTab.Controls.Add(this.Chams_FriendlyTeamColorLabel);
            this.ChamsTab.Controls.Add(this.Chams_EnemyColourControl);
            this.ChamsTab.Controls.Add(this.Chams_FriendlyColourControl);
            this.ChamsTab.Controls.Add(this.Chams_ShowEnemyTeamLabel);
            this.ChamsTab.Controls.Add(this.Chams_ShowFriendlyTeamLabel);
            this.ChamsTab.Controls.Add(this.Chams_ShowFriendlyTeamControl);
            this.ChamsTab.Controls.Add(this.Chams_EnableButton);
            this.ChamsTab.HorizontalScrollbarBarColor = true;
            this.ChamsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ChamsTab.HorizontalScrollbarSize = 10;
            this.ChamsTab.Location = new System.Drawing.Point(4, 41);
            this.ChamsTab.Name = "ChamsTab";
            this.ChamsTab.Size = new System.Drawing.Size(746, 330);
            this.ChamsTab.Style = MetroFramework.MetroColorStyle.Orange;
            this.ChamsTab.TabIndex = 3;
            this.ChamsTab.Text = "Chams";
            this.ChamsTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ChamsTab.VerticalScrollbarBarColor = true;
            this.ChamsTab.VerticalScrollbarHighlightOnWheel = false;
            this.ChamsTab.VerticalScrollbarSize = 10;
            // 
            // Chams_ShowEnemyTeamControl
            // 
            this.Chams_ShowEnemyTeamControl.AutoSize = true;
            this.Chams_ShowEnemyTeamControl.Checked = true;
            this.Chams_ShowEnemyTeamControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chams_ShowEnemyTeamControl.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.visualsSettingsBindingSource, "ShowEnemy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Chams_ShowEnemyTeamControl.Location = new System.Drawing.Point(3, 125);
            this.Chams_ShowEnemyTeamControl.Name = "Chams_ShowEnemyTeamControl";
            this.Chams_ShowEnemyTeamControl.Size = new System.Drawing.Size(80, 17);
            this.Chams_ShowEnemyTeamControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Chams_ShowEnemyTeamControl.TabIndex = 23;
            this.Chams_ShowEnemyTeamControl.Text = "On";
            this.Chams_ShowEnemyTeamControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Chams_ShowEnemyTeamControl.UseSelectable = true;
            this.Chams_ShowEnemyTeamControl.UseStyleColors = true;
            // 
            // Chams_BrightnessLabel
            // 
            this.Chams_BrightnessLabel.AutoSize = true;
            this.Chams_BrightnessLabel.Location = new System.Drawing.Point(3, 163);
            this.Chams_BrightnessLabel.Name = "Chams_BrightnessLabel";
            this.Chams_BrightnessLabel.Size = new System.Drawing.Size(88, 19);
            this.Chams_BrightnessLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.Chams_BrightnessLabel.TabIndex = 22;
            this.Chams_BrightnessLabel.Text = "Bright Chams";
            this.Chams_BrightnessLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Chams_BrightnessLabel.UseStyleColors = true;
            // 
            // Chams_BrightnessControl
            // 
            this.Chams_BrightnessControl.AutoSize = true;
            this.Chams_BrightnessControl.Checked = true;
            this.Chams_BrightnessControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chams_BrightnessControl.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.chamsSettingsBindingSource, "Brightness", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Chams_BrightnessControl.Location = new System.Drawing.Point(3, 194);
            this.Chams_BrightnessControl.Name = "Chams_BrightnessControl";
            this.Chams_BrightnessControl.Size = new System.Drawing.Size(80, 17);
            this.Chams_BrightnessControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Chams_BrightnessControl.TabIndex = 21;
            this.Chams_BrightnessControl.Text = "On";
            this.Chams_BrightnessControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Chams_BrightnessControl.UseSelectable = true;
            this.Chams_BrightnessControl.UseStyleColors = true;
            // 
            // Chams_EnemyTeamColourLabel
            // 
            this.Chams_EnemyTeamColourLabel.AutoSize = true;
            this.Chams_EnemyTeamColourLabel.Location = new System.Drawing.Point(304, 94);
            this.Chams_EnemyTeamColourLabel.Name = "Chams_EnemyTeamColourLabel";
            this.Chams_EnemyTeamColourLabel.Size = new System.Drawing.Size(120, 19);
            this.Chams_EnemyTeamColourLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.Chams_EnemyTeamColourLabel.TabIndex = 20;
            this.Chams_EnemyTeamColourLabel.Text = "Enemy Team Color";
            this.Chams_EnemyTeamColourLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Chams_EnemyTeamColourLabel.UseStyleColors = true;
            // 
            // Chams_FriendlyTeamColorLabel
            // 
            this.Chams_FriendlyTeamColorLabel.AutoSize = true;
            this.Chams_FriendlyTeamColorLabel.Location = new System.Drawing.Point(304, 27);
            this.Chams_FriendlyTeamColorLabel.Name = "Chams_FriendlyTeamColorLabel";
            this.Chams_FriendlyTeamColorLabel.Size = new System.Drawing.Size(127, 19);
            this.Chams_FriendlyTeamColorLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.Chams_FriendlyTeamColorLabel.TabIndex = 19;
            this.Chams_FriendlyTeamColorLabel.Text = "Friendly Team Color";
            this.Chams_FriendlyTeamColorLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Chams_FriendlyTeamColorLabel.UseStyleColors = true;
            // 
            // Chams_EnemyColourControl
            // 
            this.Chams_EnemyColourControl.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.chamsSettingsBindingSource, "EnemyColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Chams_EnemyColourControl.FormattingEnabled = true;
            this.Chams_EnemyColourControl.ItemHeight = 23;
            this.Chams_EnemyColourControl.Location = new System.Drawing.Point(304, 125);
            this.Chams_EnemyColourControl.Name = "Chams_EnemyColourControl";
            this.Chams_EnemyColourControl.Size = new System.Drawing.Size(127, 29);
            this.Chams_EnemyColourControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Chams_EnemyColourControl.TabIndex = 18;
            this.Chams_EnemyColourControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Chams_EnemyColourControl.UseSelectable = true;
            this.Chams_EnemyColourControl.UseStyleColors = true;
            // 
            // Chams_FriendlyColourControl
            // 
            this.Chams_FriendlyColourControl.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.chamsSettingsBindingSource, "ShowTeam", true));
            this.Chams_FriendlyColourControl.DataSource = this.chamsSettingsBindingSource;
            this.Chams_FriendlyColourControl.FormattingEnabled = true;
            this.Chams_FriendlyColourControl.ItemHeight = 23;
            this.Chams_FriendlyColourControl.Location = new System.Drawing.Point(304, 58);
            this.Chams_FriendlyColourControl.Name = "Chams_FriendlyColourControl";
            this.Chams_FriendlyColourControl.Size = new System.Drawing.Size(127, 29);
            this.Chams_FriendlyColourControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Chams_FriendlyColourControl.TabIndex = 17;
            this.Chams_FriendlyColourControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Chams_FriendlyColourControl.UseSelectable = true;
            this.Chams_FriendlyColourControl.UseStyleColors = true;
            // 
            // Chams_ShowEnemyTeamLabel
            // 
            this.Chams_ShowEnemyTeamLabel.AutoSize = true;
            this.Chams_ShowEnemyTeamLabel.Location = new System.Drawing.Point(0, 94);
            this.Chams_ShowEnemyTeamLabel.Name = "Chams_ShowEnemyTeamLabel";
            this.Chams_ShowEnemyTeamLabel.Size = new System.Drawing.Size(118, 19);
            this.Chams_ShowEnemyTeamLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.Chams_ShowEnemyTeamLabel.TabIndex = 16;
            this.Chams_ShowEnemyTeamLabel.Text = "Show Enemy Team";
            this.Chams_ShowEnemyTeamLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Chams_ShowEnemyTeamLabel.UseStyleColors = true;
            // 
            // Chams_ShowFriendlyTeamLabel
            // 
            this.Chams_ShowFriendlyTeamLabel.AutoSize = true;
            this.Chams_ShowFriendlyTeamLabel.Location = new System.Drawing.Point(3, 27);
            this.Chams_ShowFriendlyTeamLabel.Name = "Chams_ShowFriendlyTeamLabel";
            this.Chams_ShowFriendlyTeamLabel.Size = new System.Drawing.Size(125, 19);
            this.Chams_ShowFriendlyTeamLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.Chams_ShowFriendlyTeamLabel.TabIndex = 14;
            this.Chams_ShowFriendlyTeamLabel.Text = "Show Friendly Team";
            this.Chams_ShowFriendlyTeamLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Chams_ShowFriendlyTeamLabel.UseStyleColors = true;
            // 
            // Chams_ShowFriendlyTeamControl
            // 
            this.Chams_ShowFriendlyTeamControl.AutoSize = true;
            this.Chams_ShowFriendlyTeamControl.Checked = true;
            this.Chams_ShowFriendlyTeamControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chams_ShowFriendlyTeamControl.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.chamsSettingsBindingSource, "ShowTeam", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Chams_ShowFriendlyTeamControl.Location = new System.Drawing.Point(3, 58);
            this.Chams_ShowFriendlyTeamControl.Name = "Chams_ShowFriendlyTeamControl";
            this.Chams_ShowFriendlyTeamControl.Size = new System.Drawing.Size(80, 17);
            this.Chams_ShowFriendlyTeamControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Chams_ShowFriendlyTeamControl.TabIndex = 13;
            this.Chams_ShowFriendlyTeamControl.Text = "On";
            this.Chams_ShowFriendlyTeamControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Chams_ShowFriendlyTeamControl.UseSelectable = true;
            this.Chams_ShowFriendlyTeamControl.UseStyleColors = true;
            // 
            // Chams_EnableButton
            // 
            this.Chams_EnableButton.Location = new System.Drawing.Point(3, 289);
            this.Chams_EnableButton.Name = "Chams_EnableButton";
            this.Chams_EnableButton.Size = new System.Drawing.Size(148, 38);
            this.Chams_EnableButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.Chams_EnableButton.TabIndex = 12;
            this.Chams_EnableButton.Text = "Set colours";
            this.Chams_EnableButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Chams_EnableButton.UseSelectable = true;
            this.Chams_EnableButton.UseStyleColors = true;
            this.Chams_EnableButton.Click += new System.EventHandler(this.Chams_EnableControl_Click);
            // 
            // TriggerBotTab
            // 
            this.TriggerBotTab.Controls.Add(this.TriggerBot_ReactionSpeedControl);
            this.TriggerBotTab.Controls.Add(this.TriggerBot_EnableControl);
            this.TriggerBotTab.Controls.Add(this.metroLabel3);
            this.TriggerBotTab.Controls.Add(this.TriggerBot_RealisticReactionLabel);
            this.TriggerBotTab.Controls.Add(this.TriggerBot_RealisticReactionControl);
            this.TriggerBotTab.HorizontalScrollbarBarColor = true;
            this.TriggerBotTab.HorizontalScrollbarHighlightOnWheel = false;
            this.TriggerBotTab.HorizontalScrollbarSize = 10;
            this.TriggerBotTab.Location = new System.Drawing.Point(4, 41);
            this.TriggerBotTab.Name = "TriggerBotTab";
            this.TriggerBotTab.Size = new System.Drawing.Size(746, 330);
            this.TriggerBotTab.Style = MetroFramework.MetroColorStyle.Orange;
            this.TriggerBotTab.TabIndex = 2;
            this.TriggerBotTab.Text = "Trigger Bot";
            this.TriggerBotTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TriggerBotTab.UseStyleColors = true;
            this.TriggerBotTab.UseVisualStyleBackColor = true;
            this.TriggerBotTab.VerticalScrollbarBarColor = true;
            this.TriggerBotTab.VerticalScrollbarHighlightOnWheel = false;
            this.TriggerBotTab.VerticalScrollbarSize = 10;
            // 
            // TriggerBot_ReactionSpeedControl
            // 
            this.TriggerBot_ReactionSpeedControl.BackColor = System.Drawing.Color.Transparent;
            this.TriggerBot_ReactionSpeedControl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triggerBotSettingsBindingSource, "ReactionSpeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TriggerBot_ReactionSpeedControl.Location = new System.Drawing.Point(0, 140);
            this.TriggerBot_ReactionSpeedControl.Maximum = 200;
            this.TriggerBot_ReactionSpeedControl.Minimum = 100;
            this.TriggerBot_ReactionSpeedControl.Name = "TriggerBot_ReactionSpeedControl";
            this.TriggerBot_ReactionSpeedControl.Size = new System.Drawing.Size(127, 23);
            this.TriggerBot_ReactionSpeedControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.TriggerBot_ReactionSpeedControl.TabIndex = 20;
            this.TriggerBot_ReactionSpeedControl.Tag = "";
            this.TriggerBot_ReactionSpeedControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TriggerBot_ReactionSpeedControl.Value = 100;
            // 
            // TriggerBot_EnableControl
            // 
            this.TriggerBot_EnableControl.Location = new System.Drawing.Point(3, 289);
            this.TriggerBot_EnableControl.Name = "TriggerBot_EnableControl";
            this.TriggerBot_EnableControl.Size = new System.Drawing.Size(148, 38);
            this.TriggerBot_EnableControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.TriggerBot_EnableControl.TabIndex = 11;
            this.TriggerBot_EnableControl.Text = "Trigger Bot is Disabled";
            this.TriggerBot_EnableControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TriggerBot_EnableControl.UseSelectable = true;
            this.TriggerBot_EnableControl.UseStyleColors = true;
            this.TriggerBot_EnableControl.Click += new System.EventHandler(this.TriggerBot_EnableControl_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Reaction Speed";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // TriggerBot_RealisticReactionLabel
            // 
            this.TriggerBot_RealisticReactionLabel.AutoSize = true;
            this.TriggerBot_RealisticReactionLabel.Location = new System.Drawing.Point(3, 24);
            this.TriggerBot_RealisticReactionLabel.Name = "TriggerBot_RealisticReactionLabel";
            this.TriggerBot_RealisticReactionLabel.Size = new System.Drawing.Size(95, 19);
            this.TriggerBot_RealisticReactionLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.TriggerBot_RealisticReactionLabel.TabIndex = 6;
            this.TriggerBot_RealisticReactionLabel.Text = "Reaction Delay";
            this.TriggerBot_RealisticReactionLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TriggerBot_RealisticReactionLabel.UseStyleColors = true;
            // 
            // TriggerBot_RealisticReactionControl
            // 
            this.TriggerBot_RealisticReactionControl.AutoSize = true;
            this.TriggerBot_RealisticReactionControl.Checked = true;
            this.TriggerBot_RealisticReactionControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TriggerBot_RealisticReactionControl.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.triggerBotSettingsBindingSource, "RealisticReaction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TriggerBot_RealisticReactionControl.Location = new System.Drawing.Point(3, 55);
            this.TriggerBot_RealisticReactionControl.Name = "TriggerBot_RealisticReactionControl";
            this.TriggerBot_RealisticReactionControl.Size = new System.Drawing.Size(80, 17);
            this.TriggerBot_RealisticReactionControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.TriggerBot_RealisticReactionControl.TabIndex = 5;
            this.TriggerBot_RealisticReactionControl.Text = "On";
            this.TriggerBot_RealisticReactionControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TriggerBot_RealisticReactionControl.UseSelectable = true;
            this.TriggerBot_RealisticReactionControl.UseStyleColors = true;
            // 
            // VisualsTab
            // 
            this.VisualsTab.Controls.Add(this.Visuals_ChamsModeLabel);
            this.VisualsTab.Controls.Add(this.Visuals_ChamsModeControl);
            this.VisualsTab.Controls.Add(this.Visuals_LoopDelayControl);
            this.VisualsTab.Controls.Add(this.Visuals_LoopDelayLabel);
            this.VisualsTab.Controls.Add(this.Visuals_AntiFlashLabel);
            this.VisualsTab.Controls.Add(this.Visuals_AntiFlashControl);
            this.VisualsTab.Controls.Add(this.metroLabel4);
            this.VisualsTab.Controls.Add(this.Visuals_FriendlyRenderControl);
            this.VisualsTab.Controls.Add(this.metroLabel1);
            this.VisualsTab.Controls.Add(this.metroLabel2);
            this.VisualsTab.Controls.Add(this.Visuals_EnemyColourControl);
            this.VisualsTab.Controls.Add(this.Visuals_FriendlyColourControl);
            this.VisualsTab.Controls.Add(this.Visuals_EnableControl);
            this.VisualsTab.Controls.Add(this.Visuals_ShowEnemyTeamLabel);
            this.VisualsTab.Controls.Add(this.Visuals_ShowEnemyTeamControl);
            this.VisualsTab.Controls.Add(this.Visuals_ShowFriendlyTeamLabel);
            this.VisualsTab.Controls.Add(this.Visuals_ShowFriendlyTeamControl);
            this.VisualsTab.HorizontalScrollbarBarColor = true;
            this.VisualsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.VisualsTab.HorizontalScrollbarSize = 10;
            this.VisualsTab.Location = new System.Drawing.Point(4, 41);
            this.VisualsTab.Name = "VisualsTab";
            this.VisualsTab.Size = new System.Drawing.Size(746, 330);
            this.VisualsTab.Style = MetroFramework.MetroColorStyle.Orange;
            this.VisualsTab.TabIndex = 1;
            this.VisualsTab.Text = "Visuals";
            this.VisualsTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VisualsTab.UseStyleColors = true;
            this.VisualsTab.VerticalScrollbarBarColor = true;
            this.VisualsTab.VerticalScrollbarHighlightOnWheel = false;
            this.VisualsTab.VerticalScrollbarSize = 10;
            // 
            // Visuals_ChamsModeLabel
            // 
            this.Visuals_ChamsModeLabel.AutoSize = true;
            this.Visuals_ChamsModeLabel.Location = new System.Drawing.Point(167, 23);
            this.Visuals_ChamsModeLabel.Name = "Visuals_ChamsModeLabel";
            this.Visuals_ChamsModeLabel.Size = new System.Drawing.Size(82, 19);
            this.Visuals_ChamsModeLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_ChamsModeLabel.TabIndex = 21;
            this.Visuals_ChamsModeLabel.Text = "Glow Chams";
            this.Visuals_ChamsModeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_ChamsModeLabel.UseStyleColors = true;
            // 
            // Visuals_ChamsModeControl
            // 
            this.Visuals_ChamsModeControl.AutoSize = true;
            this.Visuals_ChamsModeControl.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.visualsSettingsBindingSource, "ChamsMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Visuals_ChamsModeControl.Location = new System.Drawing.Point(167, 54);
            this.Visuals_ChamsModeControl.Name = "Visuals_ChamsModeControl";
            this.Visuals_ChamsModeControl.Size = new System.Drawing.Size(80, 17);
            this.Visuals_ChamsModeControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_ChamsModeControl.TabIndex = 20;
            this.Visuals_ChamsModeControl.Text = "Off";
            this.Visuals_ChamsModeControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_ChamsModeControl.UseCustomForeColor = true;
            this.Visuals_ChamsModeControl.UseSelectable = true;
            this.Visuals_ChamsModeControl.UseStyleColors = true;
            // 
            // Visuals_LoopDelayControl
            // 
            this.Visuals_LoopDelayControl.BackColor = System.Drawing.Color.Transparent;
            this.Visuals_LoopDelayControl.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visualsSettingsBindingSource, "LoopDelay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Visuals_LoopDelayControl.Location = new System.Drawing.Point(304, 184);
            this.Visuals_LoopDelayControl.Maximum = 50;
            this.Visuals_LoopDelayControl.Name = "Visuals_LoopDelayControl";
            this.Visuals_LoopDelayControl.Size = new System.Drawing.Size(127, 23);
            this.Visuals_LoopDelayControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_LoopDelayControl.TabIndex = 19;
            this.Visuals_LoopDelayControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_LoopDelayControl.Value = 0;
            // 
            // Visuals_LoopDelayLabel
            // 
            this.Visuals_LoopDelayLabel.AutoSize = true;
            this.Visuals_LoopDelayLabel.Location = new System.Drawing.Point(304, 157);
            this.Visuals_LoopDelayLabel.Name = "Visuals_LoopDelayLabel";
            this.Visuals_LoopDelayLabel.Size = new System.Drawing.Size(84, 19);
            this.Visuals_LoopDelayLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_LoopDelayLabel.TabIndex = 18;
            this.Visuals_LoopDelayLabel.Text = "Performance";
            this.Visuals_LoopDelayLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_LoopDelayLabel.UseStyleColors = true;
            // 
            // Visuals_AntiFlashLabel
            // 
            this.Visuals_AntiFlashLabel.AutoSize = true;
            this.Visuals_AntiFlashLabel.Location = new System.Drawing.Point(3, 157);
            this.Visuals_AntiFlashLabel.Name = "Visuals_AntiFlashLabel";
            this.Visuals_AntiFlashLabel.Size = new System.Drawing.Size(95, 19);
            this.Visuals_AntiFlashLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_AntiFlashLabel.TabIndex = 16;
            this.Visuals_AntiFlashLabel.Text = "Anti Flashbang";
            this.Visuals_AntiFlashLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_AntiFlashLabel.UseStyleColors = true;
            // 
            // Visuals_AntiFlashControl
            // 
            this.Visuals_AntiFlashControl.AutoSize = true;
            this.Visuals_AntiFlashControl.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.visualsSettingsBindingSource, "AntiFlash", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Visuals_AntiFlashControl.Location = new System.Drawing.Point(3, 190);
            this.Visuals_AntiFlashControl.Name = "Visuals_AntiFlashControl";
            this.Visuals_AntiFlashControl.Size = new System.Drawing.Size(80, 17);
            this.Visuals_AntiFlashControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_AntiFlashControl.TabIndex = 15;
            this.Visuals_AntiFlashControl.Text = "Off";
            this.Visuals_AntiFlashControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_AntiFlashControl.UseCustomForeColor = true;
            this.Visuals_AntiFlashControl.UseSelectable = true;
            this.Visuals_AntiFlashControl.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(479, 23);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(130, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Character Rendering";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // Visuals_FriendlyRenderControl
            // 
            this.Visuals_FriendlyRenderControl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visualsSettingsBindingSource, "GlowHandler", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Visuals_FriendlyRenderControl.FormattingEnabled = true;
            this.Visuals_FriendlyRenderControl.ItemHeight = 23;
            this.Visuals_FriendlyRenderControl.Location = new System.Drawing.Point(479, 54);
            this.Visuals_FriendlyRenderControl.Name = "Visuals_FriendlyRenderControl";
            this.Visuals_FriendlyRenderControl.Size = new System.Drawing.Size(130, 29);
            this.Visuals_FriendlyRenderControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_FriendlyRenderControl.TabIndex = 12;
            this.Visuals_FriendlyRenderControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_FriendlyRenderControl.UseSelectable = true;
            this.Visuals_FriendlyRenderControl.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(304, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Enemy Team Color";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(304, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Friendly Team Color";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // Visuals_EnemyColourControl
            // 
            this.Visuals_EnemyColourControl.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.visualsSettingsBindingSource, "EnemyTheme", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Visuals_EnemyColourControl.FormattingEnabled = true;
            this.Visuals_EnemyColourControl.ItemHeight = 23;
            this.Visuals_EnemyColourControl.Location = new System.Drawing.Point(304, 121);
            this.Visuals_EnemyColourControl.Name = "Visuals_EnemyColourControl";
            this.Visuals_EnemyColourControl.Size = new System.Drawing.Size(127, 29);
            this.Visuals_EnemyColourControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_EnemyColourControl.TabIndex = 9;
            this.Visuals_EnemyColourControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_EnemyColourControl.UseSelectable = true;
            this.Visuals_EnemyColourControl.UseStyleColors = true;
            // 
            // Visuals_FriendlyColourControl
            // 
            this.Visuals_FriendlyColourControl.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.visualsSettingsBindingSource, "TeamTheme", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Visuals_FriendlyColourControl.DisplayMember = "Name";
            this.Visuals_FriendlyColourControl.FormattingEnabled = true;
            this.Visuals_FriendlyColourControl.ItemHeight = 23;
            this.Visuals_FriendlyColourControl.Location = new System.Drawing.Point(304, 54);
            this.Visuals_FriendlyColourControl.Name = "Visuals_FriendlyColourControl";
            this.Visuals_FriendlyColourControl.Size = new System.Drawing.Size(127, 29);
            this.Visuals_FriendlyColourControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_FriendlyColourControl.TabIndex = 8;
            this.Visuals_FriendlyColourControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_FriendlyColourControl.UseSelectable = true;
            this.Visuals_FriendlyColourControl.UseStyleColors = true;
            // 
            // Visuals_EnableControl
            // 
            this.Visuals_EnableControl.Location = new System.Drawing.Point(3, 289);
            this.Visuals_EnableControl.Name = "Visuals_EnableControl";
            this.Visuals_EnableControl.Size = new System.Drawing.Size(148, 38);
            this.Visuals_EnableControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_EnableControl.TabIndex = 7;
            this.Visuals_EnableControl.Text = "Visuals is Disabled";
            this.Visuals_EnableControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_EnableControl.UseSelectable = true;
            this.Visuals_EnableControl.UseStyleColors = true;
            this.Visuals_EnableControl.Click += new System.EventHandler(this.Visuals_EnableControl_Click);
            // 
            // Visuals_ShowEnemyTeamLabel
            // 
            this.Visuals_ShowEnemyTeamLabel.AutoSize = true;
            this.Visuals_ShowEnemyTeamLabel.Location = new System.Drawing.Point(0, 90);
            this.Visuals_ShowEnemyTeamLabel.Name = "Visuals_ShowEnemyTeamLabel";
            this.Visuals_ShowEnemyTeamLabel.Size = new System.Drawing.Size(118, 19);
            this.Visuals_ShowEnemyTeamLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_ShowEnemyTeamLabel.TabIndex = 6;
            this.Visuals_ShowEnemyTeamLabel.Text = "Show Enemy Team";
            this.Visuals_ShowEnemyTeamLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_ShowEnemyTeamLabel.UseStyleColors = true;
            // 
            // Visuals_ShowEnemyTeamControl
            // 
            this.Visuals_ShowEnemyTeamControl.AutoSize = true;
            this.Visuals_ShowEnemyTeamControl.Checked = true;
            this.Visuals_ShowEnemyTeamControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Visuals_ShowEnemyTeamControl.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.visualsSettingsBindingSource, "ShowEnemy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Visuals_ShowEnemyTeamControl.Location = new System.Drawing.Point(0, 121);
            this.Visuals_ShowEnemyTeamControl.Name = "Visuals_ShowEnemyTeamControl";
            this.Visuals_ShowEnemyTeamControl.Size = new System.Drawing.Size(80, 17);
            this.Visuals_ShowEnemyTeamControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_ShowEnemyTeamControl.TabIndex = 5;
            this.Visuals_ShowEnemyTeamControl.Text = "On";
            this.Visuals_ShowEnemyTeamControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_ShowEnemyTeamControl.UseSelectable = true;
            this.Visuals_ShowEnemyTeamControl.UseStyleColors = true;
            // 
            // Visuals_ShowFriendlyTeamLabel
            // 
            this.Visuals_ShowFriendlyTeamLabel.AutoSize = true;
            this.Visuals_ShowFriendlyTeamLabel.Location = new System.Drawing.Point(3, 23);
            this.Visuals_ShowFriendlyTeamLabel.Name = "Visuals_ShowFriendlyTeamLabel";
            this.Visuals_ShowFriendlyTeamLabel.Size = new System.Drawing.Size(125, 19);
            this.Visuals_ShowFriendlyTeamLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_ShowFriendlyTeamLabel.TabIndex = 4;
            this.Visuals_ShowFriendlyTeamLabel.Text = "Show Friendly Team";
            this.Visuals_ShowFriendlyTeamLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_ShowFriendlyTeamLabel.UseStyleColors = true;
            // 
            // Visuals_ShowFriendlyTeamControl
            // 
            this.Visuals_ShowFriendlyTeamControl.AutoSize = true;
            this.Visuals_ShowFriendlyTeamControl.Checked = true;
            this.Visuals_ShowFriendlyTeamControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Visuals_ShowFriendlyTeamControl.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.visualsSettingsBindingSource, "ShowTeam", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Visuals_ShowFriendlyTeamControl.Location = new System.Drawing.Point(3, 54);
            this.Visuals_ShowFriendlyTeamControl.Name = "Visuals_ShowFriendlyTeamControl";
            this.Visuals_ShowFriendlyTeamControl.Size = new System.Drawing.Size(80, 17);
            this.Visuals_ShowFriendlyTeamControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.Visuals_ShowFriendlyTeamControl.TabIndex = 3;
            this.Visuals_ShowFriendlyTeamControl.Text = "On";
            this.Visuals_ShowFriendlyTeamControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Visuals_ShowFriendlyTeamControl.UseSelectable = true;
            this.Visuals_ShowFriendlyTeamControl.UseStyleColors = true;
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.VisualsTab);
            this.TabControl.Controls.Add(this.ChamsTab);
            this.TabControl.Controls.Add(this.TriggerBotTab);
            this.TabControl.Controls.Add(this.AimBotPage);
            this.TabControl.Location = new System.Drawing.Point(23, 63);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 1;
            this.TabControl.Size = new System.Drawing.Size(754, 375);
            this.TabControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.TabControl.TabIndex = 1;
            this.TabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabControl.UseSelectable = true;
            this.TabControl.UseStyleColors = true;
            // 
            // AimBotPage
            // 
            this.AimBotPage.Controls.Add(this.AimBot_EnableControl);
            this.AimBotPage.HorizontalScrollbarBarColor = true;
            this.AimBotPage.HorizontalScrollbarHighlightOnWheel = false;
            this.AimBotPage.HorizontalScrollbarSize = 10;
            this.AimBotPage.Location = new System.Drawing.Point(4, 41);
            this.AimBotPage.Name = "AimBotPage";
            this.AimBotPage.Size = new System.Drawing.Size(746, 330);
            this.AimBotPage.Style = MetroFramework.MetroColorStyle.Orange;
            this.AimBotPage.TabIndex = 4;
            this.AimBotPage.Text = "Aim Bot";
            this.AimBotPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AimBotPage.VerticalScrollbarBarColor = true;
            this.AimBotPage.VerticalScrollbarHighlightOnWheel = false;
            this.AimBotPage.VerticalScrollbarSize = 10;
            // 
            // AimBot_EnableControl
            // 
            this.AimBot_EnableControl.Location = new System.Drawing.Point(3, 289);
            this.AimBot_EnableControl.Name = "AimBot_EnableControl";
            this.AimBot_EnableControl.Size = new System.Drawing.Size(148, 38);
            this.AimBot_EnableControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.AimBot_EnableControl.TabIndex = 13;
            this.AimBot_EnableControl.Text = "Aim Bot is disabled";
            this.AimBot_EnableControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AimBot_EnableControl.UseSelectable = true;
            this.AimBot_EnableControl.UseStyleColors = true;
            this.AimBot_EnableControl.Click += new System.EventHandler(this.AimBot_EnableControl_Click);
            // 
            // visualsSettingsBindingSource
            // 
            this.visualsSettingsBindingSource.DataSource = typeof(Aim_God.Settings.VisualsSettings);
            // 
            // chamsSettingsBindingSource
            // 
            this.chamsSettingsBindingSource.DataSource = typeof(Aim_God.Settings.ChamsSettings);
            // 
            // triggerBotSettingsBindingSource
            // 
            this.triggerBotSettingsBindingSource.DataSource = typeof(Aim_God.Settings.TriggerBotSettings);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabControl);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GlobalStyleManager)).EndInit();
            this.ChamsTab.ResumeLayout(false);
            this.ChamsTab.PerformLayout();
            this.TriggerBotTab.ResumeLayout(false);
            this.TriggerBotTab.PerformLayout();
            this.VisualsTab.ResumeLayout(false);
            this.VisualsTab.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.AimBotPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visualsSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamsSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerBotSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Components.MetroStyleManager GlobalStyleManager;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage VisualsTab;
        private MetroFramework.Controls.MetroTrackBar Visuals_LoopDelayControl;
        private MetroFramework.Controls.MetroLabel Visuals_LoopDelayLabel;
        private MetroFramework.Controls.MetroLabel Visuals_AntiFlashLabel;
        private MetroFramework.Controls.MetroToggle Visuals_AntiFlashControl;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox Visuals_FriendlyRenderControl;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox Visuals_EnemyColourControl;
        private MetroFramework.Controls.MetroComboBox Visuals_FriendlyColourControl;
        private MetroFramework.Controls.MetroButton Visuals_EnableControl;
        private MetroFramework.Controls.MetroLabel Visuals_ShowEnemyTeamLabel;
        private MetroFramework.Controls.MetroToggle Visuals_ShowEnemyTeamControl;
        private MetroFramework.Controls.MetroLabel Visuals_ShowFriendlyTeamLabel;
        private MetroFramework.Controls.MetroToggle Visuals_ShowFriendlyTeamControl;
        private MetroFramework.Controls.MetroTabPage TriggerBotTab;
        private MetroFramework.Controls.MetroTrackBar TriggerBot_ReactionSpeedControl;
        private MetroFramework.Controls.MetroButton TriggerBot_EnableControl;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel TriggerBot_RealisticReactionLabel;
        private MetroFramework.Controls.MetroToggle TriggerBot_RealisticReactionControl;
        private MetroFramework.Controls.MetroTabPage ChamsTab;
        private MetroFramework.Controls.MetroButton Chams_EnableButton;
        private MetroFramework.Controls.MetroLabel Visuals_ChamsModeLabel;
        private MetroFramework.Controls.MetroToggle Visuals_ChamsModeControl;
        private MetroFramework.Controls.MetroTabPage AimBotPage;
        private MetroFramework.Controls.MetroButton AimBot_EnableControl;
        private MetroFramework.Controls.MetroLabel Chams_EnemyTeamColourLabel;
        private MetroFramework.Controls.MetroLabel Chams_FriendlyTeamColorLabel;
        private MetroFramework.Controls.MetroComboBox Chams_EnemyColourControl;
        private MetroFramework.Controls.MetroComboBox Chams_FriendlyColourControl;
        private MetroFramework.Controls.MetroLabel Chams_ShowEnemyTeamLabel;
        private MetroFramework.Controls.MetroLabel Chams_ShowFriendlyTeamLabel;
        private MetroFramework.Controls.MetroToggle Chams_ShowFriendlyTeamControl;
        private MetroFramework.Controls.MetroLabel Chams_BrightnessLabel;
        private MetroFramework.Controls.MetroToggle Chams_BrightnessControl;
        private MetroFramework.Controls.MetroToggle Chams_ShowEnemyTeamControl;
        private System.Windows.Forms.BindingSource visualsSettingsBindingSource;
        private System.Windows.Forms.BindingSource chamsSettingsBindingSource;
        private System.Windows.Forms.BindingSource triggerBotSettingsBindingSource;
    }
}

