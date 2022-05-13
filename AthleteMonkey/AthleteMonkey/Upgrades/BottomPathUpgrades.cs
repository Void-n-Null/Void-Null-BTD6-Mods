using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using Assets.Scripts.Models.Towers.Weapons.Behaviors;
using Assets.Scripts.Unity;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace VoidNull.AthleteMonkey.Upgrades
{
    public class BottomPathUpgrades
    {
        public class Tier1 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => BOTTOM; 
            public override int Tier => 1;
            public override string Name => "HelpinHand";
            public override string DisplayName => "Helpin' Hand";
            public override int Cost => 650;
            public override string Description => "Monkey can now generate bananas.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {

            }


        }
        public class Tier2 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => BOTTOM;
            public override int Tier => 2;
            public override string Name => "AthleteDealer";
            public override string DisplayName => "Athlete Dealer";
            public override int Cost => 900;
            public override string Description => "Monkey produces double the bananas.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }



        }
        public class Tier3 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => BOTTOM;
            public override int Tier => 3;
            public override string Name => "AthleteBanker";
            public override string DisplayName => "Athlete Banker";
            public override int Cost => 2700;
            public override string Description => "All farms and farmers in range get 15% more income.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }


        }
        public class Tier4 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => BOTTOM;
            public override int Tier => 4;
            public override string Name => "AthleteStockTrader";
            public override string DisplayName => "Athlete Stonks";
            public override int Cost => 6700;
            public override string Description => "Increases farm and farmer income in range by 50%";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }


        }
        public class Tier5 : ModUpgrade<AthleteMonkey>
        {
            public override int Path => BOTTOM;
            public override int Tier => 5;
            public override string Name => "WolfOfMonkeyWallstreet";
            public override string DisplayName => "The Wolf of Monkey Wall Street";
            public override int Cost => 65000;
            public override string Description => "Tripples worth of bananas in range!";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }
    }
}
