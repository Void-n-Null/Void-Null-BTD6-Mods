#region imports

using System;
using BananaFarmerTower.TowerAgents;
using BTD_Mod_Helper;
using MelonLoader;

#endregion

/*
Credits:
Kosmic#4494 on Discord for some great sprite work,
1330 Studios discord for help with recommending and explaining certain behaviors (https://discord.gg/BxauzvUUjE),
BTD6 Mods & Discussion discord for great and efficient problem solving and debugging (https://discord.gg/dV682SPepR)
*/

[assembly: MelonInfo(typeof(MainMod), "Agent Towers", "1.0.0", "Void & Null")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
[assembly: MelonColor(ConsoleColor.DarkBlue)]
namespace BananaFarmerTower.TowerAgents
{
    public class MainMod : BloonsTD6Mod
    {

    }
}
