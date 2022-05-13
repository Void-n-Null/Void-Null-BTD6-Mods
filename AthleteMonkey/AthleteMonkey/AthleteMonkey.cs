#region imports

using Assets.Scripts.Models.GenericBehaviors;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

#endregion

namespace VoidNull.AthleteMonkey
{
    public class AthleteMonkey : ModTower
    {
        public override string Name => "Athlete Monkey";
        public override string TowerSet => "Support";
        public override string BaseTower => TowerType.DartMonkey;
        public override int Cost => 1900;
        public override string Description => "Collects bananas from Athlete Farms.";
        public override string DisplayName => "Athlete Monkey";
        public override int TopPathUpgrades =>5;
        public override int MiddlePathUpgrades =>5;
        public override int BottomPathUpgrades =>5;
        public override ParagonMode ParagonMode => ParagonMode.Base555;
        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<Displays.TowerDisplays.BaseMonkeyDisplay>();
        }
    }
}