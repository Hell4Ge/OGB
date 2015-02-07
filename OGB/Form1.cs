using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using OGB.Globals;
using System.Collections.Generic;

namespace OGB
{
    public partial class OGBForm : Form
    {
        List<adjuster> ADRs = new List<adjuster>();

        public OGBForm()
        {
            InitializeComponent();
            var currentForm = this;
            Functions.DebugPrinter.setForm(ref currentForm);
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            Functions.Builder.Build(Resources.MINE_CRYSTAL, ref ogame);
            Functions.DebugPrinter.print(Const.DEBUG_INFO, "Mine crystal is building now...");
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            using (var LD = new LoginDialog())
            {
                LD.ShowDialog();
                
                Functions.Login.setCredentials(LD.username, LD.password, LD.server);
                Functions.Login.Proceed(ref ogame);
                Functions.DebugPrinter.print(Const.DEBUG_INFO, "Logged in");
            }

            goToLocation(Url.Resources, 2500);
            Functions.DebugPrinter.print(Const.DEBUG_INFO, "Moved to resource panel");
        }

        public Task goToLocation(Uri url, int delay)
        {
            return Task.Run(() => {
                System.Threading.Thread.Sleep(delay);
                ogame.Navigate(url);

            });
        }

        public Task WIP()
        {
            return Task.Run(() =>
            {
                while(true)
                {
                    if(Functions.Navigator.getLocation(ref ogame).Equals("Resources"))
                    {
                        List<adjuster> queue = new List<adjuster>();
                        // find what-to-build
                        foreach(var ADR in ADRs)
                        {
                            if (int.Parse(ADR.TB_Value.Text) > 0)
                                queue.Add(ADR);
                        }

                        foreach(var ADR in queue)
                        {
                            Functions.Builder.Build(ADR.BID, ref ogame);
                            int seconds = 0;
                            while (Functions.Clock.inProgress(ref ogame))
                            {
                                
                                //System.Threading.Thread.Sleep(5000);
                                seconds += 5;
                                Functions.DebugPrinter.print(Const.DEBUG_INFO, "WIP: " + seconds.ToString() + 's');
                            }

                            Functions.DebugPrinter.print(Const.DEBUG_INFO, "A " + ADR.LBL_Desc.Text + " has been made");
                            //ADR.TB_Value.Text = (int.Parse(ADR.TB_Value.Text) - 1).ToString();
                        }
                    }
                    else
                    {
                        goToLocation(Url.Resources, 2500);
                        System.Threading.Thread.Sleep(3000);
                    }
                }
            });
        }

        private void adjuster1_Load(object sender, EventArgs e)
        {
            ADR_MetalMine.LBL_Desc.Text = "Metal Mine";
            ADR_MetalMine.BID = Resources.MINE_METAL;
            ADRs.Add(ADR_MetalMine);
        }

        private void ADR_CrystalMine_Load(object sender, EventArgs e)
        {
            ADR_CrystalMine.LBL_Desc.Text = "Crystal Mine";
            ADR_CrystalMine.BID = Resources.MINE_CRYSTAL;
            ADRs.Add(ADR_CrystalMine);
        }

        private void ADR_DeuteriumSyn_Load(object sender, EventArgs e)
        {
            ADR_DeuteriumSyn.LBL_Desc.Text = "Deuterium Synth";
            ADR_DeuteriumSyn.BID = Resources.MINE_DEUTER;
            ADRs.Add(ADR_DeuteriumSyn);
        }

        private void ADR_SolarPlant_Load(object sender, EventArgs e)
        {
            ADR_SolarPlant.LBL_Desc.Text = "Solar Plant";
            ADR_SolarPlant.BID = Resources.SOLAR_PLANT;
            ADRs.Add(ADR_SolarPlant);
        }

        private void ADR_FusionReactor_Load(object sender, EventArgs e)
        {
            ADR_FusionReactor.LBL_Desc.Text = "Fusion Reactor";
            ADR_FusionReactor.BID = Resources.FUSION_REACTOR;
            ADRs.Add(ADR_FusionReactor);
        }

        private void ADR_MetalStorage_Load(object sender, EventArgs e)
        {
            ADR_MetalStorage.LBL_Desc.Text = "Metal Storage";
            ADR_MetalStorage.BID = Resources.STORAGE_METAL;
            ADRs.Add(ADR_MetalStorage);
        }

        private void ADR_CrystalStorage_Load(object sender, EventArgs e)
        {
            ADR_CrystalStorage.LBL_Desc.Text = "Crystal Storage";
            ADR_CrystalStorage.BID = Resources.STORAGE_CRYSTAL;
            ADRs.Add(ADR_CrystalStorage);
        }

        private void ADR_DeuteriumTank_Load(object sender, EventArgs e)
        {
            ADR_DeuteriumTank.LBL_Desc.Text = "Deuterium Tank";
            ADR_DeuteriumTank.BID = Resources.STORAGE_DEUTER;
            ADRs.Add(ADR_DeuteriumTank);
        }

        private void ADR_MetalDen_Load(object sender, EventArgs e)
        {
            ADR_MetalDen.LBL_Desc.Text = "Metal Den";
            ADR_MetalDen.BID = Resources.DEN_METAL;
            ADRs.Add(ADR_MetalDen);
        }

        private void ADR_CrystalDen_Load(object sender, EventArgs e)
        {
            ADR_CrystalDen.LBL_Desc.Text = "Crystal Den";
            ADR_CrystalDen.BID = Resources.DEN_CRYSTAL;
            ADRs.Add(ADR_CrystalDen);
        }

        private void ADR_DeuteriumDen_Load(object sender, EventArgs e)
        {
            ADR_DeuteriumDen.LBL_Desc.Text = "Deuterium Den";
            ADR_DeuteriumDen.BID = Resources.DEN_DEUTER;
            ADRs.Add(ADR_DeuteriumDen);
        }

        private void OGBForm_Load(object sender, EventArgs e)
        {

        }
    }


}
