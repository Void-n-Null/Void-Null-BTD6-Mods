using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Unity;
using Assets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using UnityEngine;
using static VoidNull.Helper;

namespace VoidNull.AthleteMonkey.Upgrades
{
    public class TopPathUpgrades
    {
        public class Tier1 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => TOP;
            public override int Tier => 1;
            public override string Name => "10 ft Pitch Fork";
            public override string DisplayName => "10 ft Pitch Fork";
            public override int Cost => 350;
            public override string Description => "Increase Monkey's range slightly.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }

        public class Tier2 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => TOP;
            public override int Tier => 2;
            public override string Name => "BananOcculars";
            public override string DisplayName => "Banan-Occulars";
            public override int Cost => 600;
            public override string Description => "Increase Monkey's range greatly. Allows banana gun to see camo.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {

            }
        }

        public class Tier3 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => TOP;
            public override int Tier => 3;
            public override string Name => "AthletePhone";
            public override string DisplayName => "Athlete Phone";
            public override int Cost => 1500;
            public override string Description => "Increase farmers range. Allows banana gun to shoot over obstacles.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {

            }
        }

        public class Tier4 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => TOP;
            public override int Tier => 4;
            public override string Name => "CyborgMonkey";
            public override string DisplayName => "Cyborg Monkey";
            public override int Cost => 4000;
            public override string Description => "Partially robotic farmer. Has even more range.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {

            }
            public class CyborgMonkeyDisplay : ModDisplay
            {
                public override string BaseDisplay => AthleteMonkeyDisplay;
                public override void ModifyDisplayNode(UnityDisplayNode node)
                {

                }
            }
        }

        public class Tier5 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => TOP;
            public override int Tier => 5;
            public override string Name => "Robo Monkey";
            public override string DisplayName => "Robo Monkey";
            public override int Cost => 22000;
            public override string Description => "Fully mechanical farmer. Has infinite banana collection range (and no arms).";
            public override void ApplyUpgrade(TowerModel towerModel)
            {

            }
        }
    }
}
