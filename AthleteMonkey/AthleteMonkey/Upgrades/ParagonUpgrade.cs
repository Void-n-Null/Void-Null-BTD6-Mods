using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Assets.Scripts.Models.Towers.Filters;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using Assets.Scripts.Models.Towers.Weapons.Behaviors;
using Assets.Scripts.Unity;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using static VoidNull.AthleteMonkey.Displays;
using static VoidNull.Helper;
namespace VoidNull.AthleteMonkey.Upgrades
{
    public class ParagonUpgrade
    {
        public class Paragon : ModParagonUpgrade<AthleteMonkey>
        {
            //public override string Name => "PotassiumSupreme";
            public override string DisplayName => "Potassium Supreme";
            public override int Cost => 700000;
            public override string Description => "The embodiment of the monkey economy itself.";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
               
            }
        }
    }
}