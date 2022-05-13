using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using Assets.Scripts.Models.Towers.Weapons;
using Assets.Scripts.Unity;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using static VoidNull.AthleteMonkey.Displays;
namespace VoidNull.AthleteMonkey.Upgrades
{


    public static class MiddlePathUpgrades
    {
        public class Tier1 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => MIDDLE;
            public override int Tier => 1;
            public override string Name => "AthleteGun";
            public override string DisplayName => "Athlete Gun";
            public override int Cost => 350;
            public override string Description => "Enables farmer to shoot slippery athlete peels.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }
        public class Tier2 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => MIDDLE;
            public override int Tier => 2;
            public override string Name => "SubAthleteGun";
            public override string DisplayName => "Sub Athlete Gun";
            public override int Cost => 650;
            public override string Description => "Doubles athlete fire speed.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }
        public class Tier3 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => MIDDLE;
            public override int Tier => 3;
            public override string Name => "RottenAthletes";
            public override string DisplayName => "Rotten Athletes";
            public override int Cost => 1200;
            public override string Description => "Athletes now do damage on hit.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }
        public class Tier4 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => MIDDLE;
            public override int Tier => 4;
            public override string Name => "PotassiumSpeed";
            public override string DisplayName => "Potassium Speed";
            public override int Cost => 5000;
            public override string Description => "Doubles athlete fire speed again.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }
        public class Tier5 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => MIDDLE;
            public override int Tier => 5;
            public override string Name => "SuperSlipperyAthletes";
            public override string DisplayName => "Super Slippery Athletes";
            public override int Cost => 45000;
            public override string Description => "Athletes can now affect moabs!";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }
    }
}