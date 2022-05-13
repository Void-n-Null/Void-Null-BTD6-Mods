﻿#region imports

using Assets.Scripts.Models.GenericBehaviors;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

#endregion

namespace VoidNull.BananaFarmer
{
    public class BananaFarmer : ModTower
    {
        public override string Name => "Banana Farmer";
        public override string TowerSet => "Support";
        public override string BaseTower => TowerType.DartMonkey;
        public override int Cost => 1900;
        public override string Description => "Collects bananas from Banana Farms.";
        public override string DisplayName => "Banana Farmer";
        public override int TopPathUpgrades =>5;
        public override int MiddlePathUpgrades =>5;
        public override int BottomPathUpgrades =>5;
        public override ParagonMode ParagonMode => ParagonMode.Base555;
        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<Displays.TowerDisplays.BaseFarmerDisplay>();
            towerModel.RemoveBehavior<AttackModel>();
            towerModel.GetBehavior<DisplayModel>().display = towerModel.display;
            towerModel.range = 45;
            towerModel.AddBehavior(new CollectCashZoneModel("CollectCashZoneModel_",45,19,3,"",true,true,true,true));
        }
    }
}