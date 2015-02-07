namespace OGB
{
    partial class OGBForm
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
            this.BTN_Start = new System.Windows.Forms.Button();
            this.ogame = new System.Windows.Forms.WebBrowser();
            this.RTB_Debug = new System.Windows.Forms.RichTextBox();
            this.LBL_Debug = new System.Windows.Forms.Label();
            this.LBL_DebugLevel = new System.Windows.Forms.Label();
            this.CB_DLevel = new System.Windows.Forms.ComboBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.GB_Upgrade = new System.Windows.Forms.GroupBox();
            this.CB_AutoEnergy = new System.Windows.Forms.CheckBox();
            this.ADR_DeuteriumDen = new OGB.adjuster();
            this.ADR_CrystalDen = new OGB.adjuster();
            this.ADR_MetalDen = new OGB.adjuster();
            this.ADR_DeuteriumTank = new OGB.adjuster();
            this.ADR_CrystalStorage = new OGB.adjuster();
            this.ADR_MetalStorage = new OGB.adjuster();
            this.ADR_FusionReactor = new OGB.adjuster();
            this.ADR_SolarPlant = new OGB.adjuster();
            this.ADR_DeuteriumSyn = new OGB.adjuster();
            this.ADR_CrystalMine = new OGB.adjuster();
            this.ADR_MetalMine = new OGB.adjuster();
            this.GB_Upgrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(125, 332);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(107, 23);
            this.BTN_Start.TabIndex = 0;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // ogame
            // 
            this.ogame.Location = new System.Drawing.Point(12, 13);
            this.ogame.MinimumSize = new System.Drawing.Size(20, 20);
            this.ogame.Name = "ogame";
            this.ogame.Size = new System.Drawing.Size(376, 298);
            this.ogame.TabIndex = 1;
            this.ogame.Url = new System.Uri("http://en.ogame.gameforge.com/", System.UriKind.Absolute);
            // 
            // RTB_Debug
            // 
            this.RTB_Debug.Location = new System.Drawing.Point(702, 35);
            this.RTB_Debug.Name = "RTB_Debug";
            this.RTB_Debug.ReadOnly = true;
            this.RTB_Debug.Size = new System.Drawing.Size(305, 397);
            this.RTB_Debug.TabIndex = 2;
            this.RTB_Debug.Text = "";
            // 
            // LBL_Debug
            // 
            this.LBL_Debug.AutoSize = true;
            this.LBL_Debug.Location = new System.Drawing.Point(703, 13);
            this.LBL_Debug.Name = "LBL_Debug";
            this.LBL_Debug.Size = new System.Drawing.Size(78, 13);
            this.LBL_Debug.TabIndex = 3;
            this.LBL_Debug.Text = "Debug window";
            // 
            // LBL_DebugLevel
            // 
            this.LBL_DebugLevel.AutoSize = true;
            this.LBL_DebugLevel.Location = new System.Drawing.Point(856, 13);
            this.LBL_DebugLevel.Name = "LBL_DebugLevel";
            this.LBL_DebugLevel.Size = new System.Drawing.Size(67, 13);
            this.LBL_DebugLevel.TabIndex = 4;
            this.LBL_DebugLevel.Text = "Debug level:";
            // 
            // CB_DLevel
            // 
            this.CB_DLevel.FormattingEnabled = true;
            this.CB_DLevel.Items.AddRange(new object[] {
            "ALL",
            "INFO",
            "WARNING",
            "ERROR",
            "NONE"});
            this.CB_DLevel.Location = new System.Drawing.Point(929, 10);
            this.CB_DLevel.Name = "CB_DLevel";
            this.CB_DLevel.Size = new System.Drawing.Size(78, 21);
            this.CB_DLevel.TabIndex = 5;
            // 
            // BTN_Login
            // 
            this.BTN_Login.Location = new System.Drawing.Point(12, 332);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(107, 23);
            this.BTN_Login.TabIndex = 6;
            this.BTN_Login.Text = "Login";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // GB_Upgrade
            // 
            this.GB_Upgrade.Controls.Add(this.CB_AutoEnergy);
            this.GB_Upgrade.Controls.Add(this.ADR_DeuteriumDen);
            this.GB_Upgrade.Controls.Add(this.ADR_CrystalDen);
            this.GB_Upgrade.Controls.Add(this.ADR_MetalDen);
            this.GB_Upgrade.Controls.Add(this.ADR_DeuteriumTank);
            this.GB_Upgrade.Controls.Add(this.ADR_CrystalStorage);
            this.GB_Upgrade.Controls.Add(this.ADR_MetalStorage);
            this.GB_Upgrade.Controls.Add(this.ADR_FusionReactor);
            this.GB_Upgrade.Controls.Add(this.ADR_SolarPlant);
            this.GB_Upgrade.Controls.Add(this.ADR_DeuteriumSyn);
            this.GB_Upgrade.Controls.Add(this.ADR_CrystalMine);
            this.GB_Upgrade.Controls.Add(this.ADR_MetalMine);
            this.GB_Upgrade.Location = new System.Drawing.Point(470, 10);
            this.GB_Upgrade.Name = "GB_Upgrade";
            this.GB_Upgrade.Size = new System.Drawing.Size(226, 422);
            this.GB_Upgrade.TabIndex = 7;
            this.GB_Upgrade.TabStop = false;
            this.GB_Upgrade.Text = "Upgrade by";
            // 
            // CB_AutoEnergy
            // 
            this.CB_AutoEnergy.AutoSize = true;
            this.CB_AutoEnergy.Location = new System.Drawing.Point(10, 394);
            this.CB_AutoEnergy.Name = "CB_AutoEnergy";
            this.CB_AutoEnergy.Size = new System.Drawing.Size(108, 17);
            this.CB_AutoEnergy.TabIndex = 22;
            this.CB_AutoEnergy.Text = "Auto-energy build";
            this.CB_AutoEnergy.UseVisualStyleBackColor = true;
            // 
            // ADR_DeuteriumDen
            // 
            this.ADR_DeuteriumDen.Location = new System.Drawing.Point(10, 359);
            this.ADR_DeuteriumDen.Name = "ADR_DeuteriumDen";
            this.ADR_DeuteriumDen.Size = new System.Drawing.Size(200, 28);
            this.ADR_DeuteriumDen.TabIndex = 21;
            this.ADR_DeuteriumDen.Load += new System.EventHandler(this.ADR_DeuteriumDen_Load);
            // 
            // ADR_CrystalDen
            // 
            this.ADR_CrystalDen.Location = new System.Drawing.Point(10, 325);
            this.ADR_CrystalDen.Name = "ADR_CrystalDen";
            this.ADR_CrystalDen.Size = new System.Drawing.Size(200, 28);
            this.ADR_CrystalDen.TabIndex = 20;
            this.ADR_CrystalDen.Load += new System.EventHandler(this.ADR_CrystalDen_Load);
            // 
            // ADR_MetalDen
            // 
            this.ADR_MetalDen.Location = new System.Drawing.Point(10, 291);
            this.ADR_MetalDen.Name = "ADR_MetalDen";
            this.ADR_MetalDen.Size = new System.Drawing.Size(200, 28);
            this.ADR_MetalDen.TabIndex = 19;
            this.ADR_MetalDen.Load += new System.EventHandler(this.ADR_MetalDen_Load);
            // 
            // ADR_DeuteriumTank
            // 
            this.ADR_DeuteriumTank.Location = new System.Drawing.Point(10, 257);
            this.ADR_DeuteriumTank.Name = "ADR_DeuteriumTank";
            this.ADR_DeuteriumTank.Size = new System.Drawing.Size(200, 28);
            this.ADR_DeuteriumTank.TabIndex = 18;
            this.ADR_DeuteriumTank.Load += new System.EventHandler(this.ADR_DeuteriumTank_Load);
            // 
            // ADR_CrystalStorage
            // 
            this.ADR_CrystalStorage.Location = new System.Drawing.Point(10, 223);
            this.ADR_CrystalStorage.Name = "ADR_CrystalStorage";
            this.ADR_CrystalStorage.Size = new System.Drawing.Size(200, 28);
            this.ADR_CrystalStorage.TabIndex = 17;
            this.ADR_CrystalStorage.Load += new System.EventHandler(this.ADR_CrystalStorage_Load);
            // 
            // ADR_MetalStorage
            // 
            this.ADR_MetalStorage.Location = new System.Drawing.Point(10, 189);
            this.ADR_MetalStorage.Name = "ADR_MetalStorage";
            this.ADR_MetalStorage.Size = new System.Drawing.Size(200, 28);
            this.ADR_MetalStorage.TabIndex = 16;
            this.ADR_MetalStorage.Load += new System.EventHandler(this.ADR_MetalStorage_Load);
            // 
            // ADR_FusionReactor
            // 
            this.ADR_FusionReactor.Location = new System.Drawing.Point(10, 155);
            this.ADR_FusionReactor.Name = "ADR_FusionReactor";
            this.ADR_FusionReactor.Size = new System.Drawing.Size(200, 28);
            this.ADR_FusionReactor.TabIndex = 15;
            this.ADR_FusionReactor.Load += new System.EventHandler(this.ADR_FusionReactor_Load);
            // 
            // ADR_SolarPlant
            // 
            this.ADR_SolarPlant.Location = new System.Drawing.Point(10, 121);
            this.ADR_SolarPlant.Name = "ADR_SolarPlant";
            this.ADR_SolarPlant.Size = new System.Drawing.Size(200, 28);
            this.ADR_SolarPlant.TabIndex = 14;
            this.ADR_SolarPlant.Load += new System.EventHandler(this.ADR_SolarPlant_Load);
            // 
            // ADR_DeuteriumSyn
            // 
            this.ADR_DeuteriumSyn.Location = new System.Drawing.Point(10, 87);
            this.ADR_DeuteriumSyn.Name = "ADR_DeuteriumSyn";
            this.ADR_DeuteriumSyn.Size = new System.Drawing.Size(200, 28);
            this.ADR_DeuteriumSyn.TabIndex = 13;
            this.ADR_DeuteriumSyn.Load += new System.EventHandler(this.ADR_DeuteriumSyn_Load);
            // 
            // ADR_CrystalMine
            // 
            this.ADR_CrystalMine.Location = new System.Drawing.Point(10, 53);
            this.ADR_CrystalMine.Name = "ADR_CrystalMine";
            this.ADR_CrystalMine.Size = new System.Drawing.Size(202, 28);
            this.ADR_CrystalMine.TabIndex = 12;
            this.ADR_CrystalMine.Load += new System.EventHandler(this.ADR_CrystalMine_Load);
            // 
            // ADR_MetalMine
            // 
            this.ADR_MetalMine.Location = new System.Drawing.Point(10, 19);
            this.ADR_MetalMine.Name = "ADR_MetalMine";
            this.ADR_MetalMine.Size = new System.Drawing.Size(202, 28);
            this.ADR_MetalMine.TabIndex = 11;
            this.ADR_MetalMine.Load += new System.EventHandler(this.adjuster1_Load);
            // 
            // OGBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 441);
            this.Controls.Add(this.GB_Upgrade);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.CB_DLevel);
            this.Controls.Add(this.LBL_DebugLevel);
            this.Controls.Add(this.LBL_Debug);
            this.Controls.Add(this.RTB_Debug);
            this.Controls.Add(this.ogame);
            this.Controls.Add(this.BTN_Start);
            this.Name = "OGBForm";
            this.Text = "OGB v 0.1";
            this.Load += new System.EventHandler(this.OGBForm_Load);
            this.GB_Upgrade.ResumeLayout(false);
            this.GB_Upgrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.WebBrowser ogame;
        private System.Windows.Forms.Label LBL_Debug;
        private System.Windows.Forms.Label LBL_DebugLevel;
        private System.Windows.Forms.ComboBox CB_DLevel;
        public System.Windows.Forms.RichTextBox RTB_Debug;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.GroupBox GB_Upgrade;
        private adjuster ADR_CrystalMine;
        private adjuster ADR_MetalMine;
        private adjuster ADR_DeuteriumSyn;
        private adjuster ADR_SolarPlant;
        private adjuster ADR_FusionReactor;
        private adjuster ADR_MetalStorage;
        private adjuster ADR_CrystalStorage;
        private adjuster ADR_DeuteriumTank;
        private adjuster ADR_MetalDen;
        private adjuster ADR_CrystalDen;
        private adjuster ADR_DeuteriumDen;
        private System.Windows.Forms.CheckBox CB_AutoEnergy;
    }
}

