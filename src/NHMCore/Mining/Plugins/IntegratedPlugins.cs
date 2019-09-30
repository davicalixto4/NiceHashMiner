﻿using MinerPlugin;

// This is just a list of miners that are intergated in the nhm client
namespace NHMCore.Mining.Plugins
{
    public interface IntegratedPlugin : IMinerPlugin
    {
        bool Is3rdParty { get; }
    }

    #region TESTING
#if INTEGRATE_BrokenMiner_PLUGIN
    class BrokenPluginIntegratedPlugin : BrokenMiner.BrokenMinerPlugin, IntegratedPlugin
    {
        public bool Is3rdParty => false;
    }
#endif
#if INTEGRATE_ExamplePlugin_PLUGIN
    class ExamplePluginIntegratedPlugin : Example.ExamplePlugin, IntegratedPlugin
    {
        public bool Is3rdParty => false;
    }
#endif
#endregion TESTING

#region Open Source

#if INTEGRATE_CCMinerMTP_PLUGIN
    class CCMinerMTPIntegratedPlugin : CCMinerMTP.CCMinerMTPPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "CCMinerMTP";

        public bool Is3rdParty => false;
    }
#endif

#if INTEGRATE_CCMinerTpruvot_PLUGIN
    class CCMinerTpruvotIntegratedPlugin : CCMinerTpruvot.CCMinerTpruvotPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "CCMinerTpruvot";

        public bool Is3rdParty => false;
    }
#endif

#if INTEGRATE_SGminerAvemore_PLUGIN
    class SGminerAvemoreIntegratedPlugin : SgminerAvemore.SgminerAvemorePlugin, IntegratedPlugin
    {
        public override string PluginUUID => "SGminerAvemore";

        public bool Is3rdParty => false;
    }
#endif

#if INTEGRATE_SGminerGM_PLUGIN
    class SGminerGMIntegratedPlugin : SgminerGM.SgminerGMPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "SGminerGM";

        public bool Is3rdParty => false;
    }
#endif

#if INTEGRATE_XmrStak_PLUGIN
    class XmrStakIntegratedPlugin : XmrStak.XmrStakPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "XmrStak";

        public bool Is3rdParty => false;
    }
#endif

#if INTEGRATE_CpuMinerOpt_PLUGIN

    class CPUMinerOptIntegratedPlugin : CpuMinerOpt.CPUMinerPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "cpuminer-opt";

        public bool Is3rdParty => false;
    }
#endif


#if INTEGRATE_Ethminer_PLUGIN
    class EthminerIntegratedPlugin : Ethminer.EthminerPlugin, IntegratedPlugin
    {
        public override string PluginUUID => Name;

        public bool Is3rdParty => false;
    }
#endif
#endregion Open Source

#region Closed source / 3rd party

#if INTEGRATE_ClaymoreDual_PLUGIN
    class ClaymoreDual14IntegratedPlugin : ClaymoreDual14.ClaymoreDual14Plugin, IntegratedPlugin
    {
        public override string PluginUUID => "ClaymoreDual";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_BMiner_PLUGIN
    class BMinerIntegratedPlugin : BMiner.BMinerPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "BMiner";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_WildRig_PLUGIN
    class WildRigIntegratedPlugin : WildRig.WildRigPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "WildRig";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_TTMiner_PLUGIN
    class TTMinerIntegratedPlugin : TTMiner.TTMinerPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "TTMiner";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_TRex_PLUGIN
    class TRexIntegratedPlugin : TRex.TRexPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "TRex";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_TeamRedMiner_PLUGIN
    class TeamRedMinerIntegratedPlugin : TeamRedMiner.TeamRedMinerPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "TeamRedMiner";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_NBMiner_PLUGIN
    class NBMinerIntegratedPlugin : NBMiner.NBMinerPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "NBMiner";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_Phoenix_PLUGIN
    class PhoenixIntegratedPlugin : Phoenix.PhoenixPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "Phoenix";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_NanoMiner_PLUGIN
    class NanoMinerIntegratedPlugin : NanoMiner.NanoMinerPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "NanoMiner";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_GMiner_PLUGIN
    class GMinerIntegratedPlugin : GMinerPlugin.GMinerPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "GMiner";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_EWBF_PLUGIN
    class EWBFIntegratedPlugin : EWBF.EwbfPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "Ewbf";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_CryptoDredge_PLUGIN
    class CryptoDredgeIntegratedPlugin : CryptoDredge.CryptoDredgePlugin, IntegratedPlugin
    {
        public override string PluginUUID => "CryptoDredge";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_ZEnemy_PLUGIN
    class ZEnemyIntegratedPlugin : ZEnemy.ZEnemyPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "ZEnemy";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_LolMinerBeam_PLUGIN
    class LolMinerIntegratedPlugin : LolMinerBeam.LolMinerBeamPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "LolMinerBeam";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_SRBMiner_PLUGIN
    class SRBMinerIntegratedPlugin : SRBMiner.SRBMinerPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "SRBMiner";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_XMRig_PLUGIN
    class XMRigIntegratedPlugin : XMRig.XMRigPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "XMRig";

        public bool Is3rdParty => true;
    }
#endif

#if INTEGRATE_MiniZ_PLUGIN
    class MiniZIntegratedPlugin : MiniZ.MiniZPlugin, IntegratedPlugin
    {
        public override string PluginUUID => "MiniZ";

        public bool Is3rdParty => true;
    }
#endif

    public class EthlargementIntegratedPlugin : Ethlargement.Ethlargement, IntegratedPlugin
    {
        public static EthlargementIntegratedPlugin Instance { get; } = new EthlargementIntegratedPlugin();

        public override string PluginUUID => "Ethlargement";

        public bool Is3rdParty => true;
    }

#endregion Closed source / 3rd party
}
