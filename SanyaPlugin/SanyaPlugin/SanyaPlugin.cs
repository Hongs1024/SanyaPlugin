﻿using System;
using Smod2;
using Smod2.API;
using Smod2.Attributes;
using Smod2.EventHandlers;
using Smod2.Events;
using Smod2.Config;

namespace SanyaPlugin
{
    [PluginDetails(
    author = "sanyae2439",
    name = "SanyaPlugin",
    description = "nya",
    id = "sanyae2439.sanyaplugin",
    version = "5.1",
    SmodMajor = 3,
    SmodMinor = 1,
    SmodRevision = 10
    )]

    class SanyaPlugin : Plugin

    {
        public override void OnDisable()
        {

        }

        public override void OnEnable()
        {
            this.Info("さにゃぷらぐいん Loaded [Ver" + this.Details.version + "]");
            this.Info("ずりずり");
        }

        public override void Register()
        {
            //小物系
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_escape_spawn", true, Smod2.Config.SettingType.BOOL, true, "sanya_escape_spawn"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_infect_by_scp049_2", true, Smod2.Config.SettingType.BOOL, true, "sanya_infect"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_infect_limit_time", 4, Smod2.Config.SettingType.NUMERIC, true, "sanya_infect_limit_time"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_warhead_dontlock", true, Smod2.Config.SettingType.BOOL, true, "sanya_warhead_dontlock"));
            //this.AddConfig(new Smod2.Config.ConfigSetting("sanya_warhead_forceopen", false, Smod2.Config.SettingType.BOOL, true, "sanya_warhead_forceopen"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_pocket_cleanup", false, Smod2.Config.SettingType.BOOL, true, "sanya_pocket_cleanup"));

            //複製config
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp173_duplicate", false, Smod2.Config.SettingType.BOOL, true, "sanya_scp173_duplicate"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp173_duplicate_hp", 200, Smod2.Config.SettingType.NUMERIC, true, "sanya_scp173_duplicate_hp"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp049_duplicate", false, Smod2.Config.SettingType.BOOL, true, "sanya_scp049_duplicate"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp049_duplicate_hp", 200, Smod2.Config.SettingType.NUMERIC, true, "sanya_scp049_duplicate_hp"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp049_2_duplicate", false, Smod2.Config.SettingType.BOOL, true, "sanya_scp049_2_duplicate"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp049_2_duplicate_hp", 200, Smod2.Config.SettingType.NUMERIC, true, "sanya_scp049_2_duplicate_hp"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp939_duplicate", false, Smod2.Config.SettingType.BOOL, true, "sanya_scp939_duplicate"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp939_duplicate_hp", 200, Smod2.Config.SettingType.NUMERIC, true, "sanya_scp939_duplicate_hp"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp106_duplicate", false, Smod2.Config.SettingType.BOOL, true, "sanya_scp106_duplicate"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp106_duplicate_hp", 50, Smod2.Config.SettingType.NUMERIC, true, "sanya_scp106_duplicate_hp"));

            this.AddEventHandlers(new EscapeHandler(this));
            this.AddEventHandlers(new SpawnChecker(this));
            this.AddEventHandlers(new HurtChanger(this));
            this.AddEventHandlers(new InfectChecker(this));
            this.AddEventHandlers(new PocketDimensionCleaner(this));

            //this.AddEventHandlers(new Player106Lure(this));
            //this.AddEventHandlers(new WarheadActivator(this));

            this.AddEventHandlers(new NukeDontLock(this));
            //this.AddEventHandlers(new NukeDoorsOpener(this));

            this.AddEventHandlers(new ConfigChecker(this));
            this.AddEventHandlers(new EndChecker(this));
            this.AddEventHandlers(new EndEventer(this));
        }
    }
}
