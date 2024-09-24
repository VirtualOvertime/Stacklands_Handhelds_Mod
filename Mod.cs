using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace HandheldsNS
{
    public class Handhelds : Mod
    {
        public override void Ready()
        {
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicResources, "handhelds_gameboy", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedResources, "handhelds_psp", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedResources, "handhelds_3ds", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedResources, "handhelds_switch", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedResources, "handhelds_steamdeck", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.AdvancedResources, "handhelds_playdate", 1);

            Logger.Log("Mod is Ready!");
        }
    }
}