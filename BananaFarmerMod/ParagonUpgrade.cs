using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Assets.Scripts.Models.Towers.Filters;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using Assets.Scripts.Models.Towers.Weapons;
using Assets.Scripts.Models.Towers.Weapons.Behaviors;
using Assets.Scripts.Unity;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using static BananaFarmerTower.MainMod;
using static BananaFarmerTower.Helper;
using static BananaFarmerTower.Displays.Projectiles;
using static BananaFarmerTower.Displays.Towers;

namespace BananaFarmerTower
{
    public class ParagonUpgrade
    {
        public class Paragon : ModParagonUpgrade<BananaFarmer>
        {
            //public override string Name => "PotassiumSupreme";
            public override string DisplayName => "Potassium Supreme";
            public override int Cost => 700000;
            public override string Description => "The embodiment of the monkey economy itself.";

            public override string Icon => "Paragon-Icon";
            public override string Portrait => "Paragon-Portrait";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                //Set Display
                towerModel.ApplyDisplay<ParagonDisplay>();

                //Remove Original Attack Model
                towerModel.RemoveBehaviors<AttackModel>();

                //Create Banana Gun
                var BananaGun = Game.instance.model.GetTowerFromId("SpikeFactory").GetAttackModel().Duplicate();
                WeaponModel BananaGunWeapon = BananaGun.weapons[0];
                ProjectileModel BananaGunProj = BananaGun.weapons[0].projectile;

                //Edit Banana Gun Attack Model
                BananaGun.RemoveBehavior<TargetTrackModel>();
                BananaGun.AddBehavior(new TargetFirstModel("TargetFirstModel_", true, false));
                BananaGun.AddBehavior(new TargetStrongModel("TargetStrongModel_", true, false));
                BananaGun.AddBehavior(new TargetCloseModel("TargetCloseModel_", true, false));
                BananaGun.AddBehavior(new TargetLastModel("TargetLastModel_", true, false));
                BananaGun.AddBehavior(new RotateToTargetModel("RotateToTargetModel_", true, true, true, 0, true, true));
                BananaGun.attackThroughWalls = true;

                //Edit Banana Gun Weapon Model
                BananaGunWeapon.fireWithoutTarget = false;
                BananaGunWeapon.rate = .175f;
                BananaGunProj.RemoveBehavior<DamageModel>();
                BananaGunProj.RemoveBehavior<SetSpriteFromPierceModel>();
                BananaGunProj.AddBehavior(new DamageModel("DamageModel_", 6, 10, true, true, true, BloonProperties.None));
                BananaGunProj.AddBehavior(new WindModel("WindModel_", 0, 200, 100, true, null, 0));
                BananaGunProj.GetBehavior<ArriveAtTargetModel>().timeToTake = 0.075f;
                BananaGunProj.pierce = 9;
                BananaGunProj.ApplyDisplay<GoldenBananaProjectileDisplay>();


                var BananaFarmAttackModel = Game.instance.model.GetTowerFromId("BananaFarm").GetAttackModel().Duplicate();
                BananaFarmAttackModel.name = "BananaFarm_";
                BananaFarmAttackModel.weapons[0].GetBehavior<EmissionsPerRoundFilterModel>().count = 40;
                BananaFarmAttackModel.weapons[0].projectile.GetBehavior<CashModel>().maximum = 140;
                BananaFarmAttackModel.weapons[0].projectile.GetBehavior<CashModel>().minimum = 140;
                towerModel.range = 114;
                BananaGun.range = towerModel.range;
                towerModel.isGlobalRange = true;
                towerModel.GetBehavior<CollectCashZoneModel>().useTowerRange = false;
                towerModel.GetBehavior<CollectCashZoneModel>().attractRange = float.MaxValue;
                towerModel.AddBehavior(BananaGun);
                towerModel.AddBehavior(BananaFarmAttackModel);
                towerModel.AddBehavior(new OverrideCamoDetectionModel("OverrideCamoDetectionModel_", true));
                towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
                UpdateAttackModelRange(towerModel);
            }
        }
    }
}
