#region imports
using Assets.Scripts.Models.GenericBehaviors;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using MelonLoader;
using BTD_Mod_Helper.Api.Display;
using Assets.Scripts.Unity.Display;
using static BananaFarmerTower.Helper;
using static BananaFarmerTower.Displays.Towers;
#endregion

[assembly: MelonInfo(typeof(BananaFarmerTower.MainMod), "Banana Farmer Tower", "1.0.0", "Void & Null")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace BananaFarmerTower
{
    public class MainMod : BloonsTD6Mod
    {
        public class BananaFarmer : ModTower
        {
            public override string Name => "Banana Farmer";
            public override string TowerSet => "Support";
            public override string BaseTower => TowerType.DartMonkey;
            public override int Cost => 1900;
            public override string Description => "Collects Bananas from Banana Farms";
            public override string DisplayName => "Banana Farmer";
            public override int TopPathUpgrades =>5;
            public override int MiddlePathUpgrades =>5;
            public override int BottomPathUpgrades =>5;
            public override ParagonMode ParagonMode => ParagonMode.Base555;
            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<BaseFarmerDisplay>();
                //towerModel.ApplyDisplay<JustTheGun>();
                towerModel.RemoveBehavior<AttackModel>();
                towerModel.GetBehavior<DisplayModel>().display = towerModel.display;
                towerModel.range = 45;
                towerModel.AddBehavior(new CollectCashZoneModel("CollectCashZoneModel_", 45, 10, 2, null, true));   
            }


        }
    }
}
