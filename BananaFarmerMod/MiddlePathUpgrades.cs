using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using Assets.Scripts.Models.Towers.Weapons;
using Assets.Scripts.Unity;
using Assets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using static BananaFarmerTower.MainMod;
using static BananaFarmerTower.Helper;
using Assets.Scripts.Unity.UI_New.InGame;
using Assets.Scripts.Simulation.Display;
using UnityEngine;
using MelonLoader;
using static BananaFarmerTower.Displays.Projectiles;
using static BananaFarmerTower.Displays.Towers;

namespace BananaFarmerTower
{


    public static class MiddlePathUpgrades
    {



        //public static UnityDisplayNode BananaGun;
        //public class JustTheGun : ModDisplay
        //{
        //    public override string BaseDisplay => "b86ee66981bfcc14b964b9731264cddf";
        //    public override void ModifyDisplayNode(UnityDisplayNode node)
        //    {
        //        BananaGun = node;
        //    }
        //}






        public class Tier1 : ModUpgrade<BananaFarmer>
        {
            public override int Path => MIDDLE;
            public override int Tier => 1;
            public override string Name => "BananaGun";
            public override string DisplayName => "Banana Gun";
            public override int Cost => 350;
            public override string Description => "Farmer can now shoot bananas";
            public override string Icon => "BananaGun-Icon";
            public override string Portrait => "RedHat-Portrait";
            public override void ApplyUpgrade(TowerModel towerModel)
            {

                towerModel.ApplyDisplay<BananaGunDisplay>();
                var BananaGun = Game.instance.model.GetTowerFromId("SpikeFactory").GetAttackModel().Duplicate();
                WeaponModel GunWeaponModel = BananaGun.weapons[0];
                ProjectileModel projectileModel = BananaGun.weapons[0].projectile;
                BananaGun.range = towerModel.range;
                BananaGun.RemoveBehavior<TargetTrackModel>();
                BananaGun.AddBehavior(new TargetFirstModel("TargetFirstModel_", true, false));
                BananaGun.AddBehavior(new TargetStrongModel("TargetStrongModel_", true, false));
                BananaGun.AddBehavior(new TargetCloseModel("TargetCloseModel_", true, false));
                BananaGun.AddBehavior(new TargetLastModel("TargetLastModel_", true, false));
                BananaGun.AddBehavior(new RotateToTargetModel("RotateToTargetModel_", true, true, true, 0, true, true));
                GunWeaponModel.fireWithoutTarget = false;
                projectileModel.RemoveBehavior<DamageModel>();
                projectileModel.AddBehavior(new WindModel("WindModel_", 0, 200, 100, false, null, 0));
                projectileModel.RemoveBehavior<SetSpriteFromPierceModel>();
                projectileModel.pierce = 1;
                projectileModel.GetBehavior<ArriveAtTargetModel>().timeToTake = .5f;
                projectileModel.ApplyDisplay<BaseBananaProjectileDisplay>();
                towerModel.AddBehavior(BananaGun);
            }




        }
        public class Tier2 : ModUpgrade<BananaFarmer>
        {
            public override int Path => MIDDLE;
            public override int Tier => 2;
            public override string Name => "SubBananaGun";
            public override string DisplayName => "Sub Banana Gun";
            public override int Cost => 650;
            public override string Description => "Doubles Banana Fire Speed";
            public override string Icon => "Bananananananananana";
            public override string Portrait => "RedHat-Portrait";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<BananaGunDisplay>();
                if (towerModel.HasBehavior<AttackModel>())
                {
                    towerModel.GetAttackModel().weapons[0].rate = 1.75f / 2f;
                    towerModel.GetAttackModel().weapons[0].projectile.GetBehavior<ArriveAtTargetModel>().timeToTake = .3f;
                }
            }
        }
        public class Tier3 : ModUpgrade<BananaFarmer>
        {
            public override int Path => MIDDLE;
            public override int Tier => 3;
            public override string Name => "RottenBananas";
            public override string DisplayName => "Rotten Bananas";
            public override int Cost => 1200;
            public override string Description => "Bananas now do damage on hit";
            public override string Icon => "RottenBananananananananana";
            public override string Portrait => "RedHatYellorRim-Portrait";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<BananaGunDisplay>();
                if (towerModel.HasBehavior<AttackModel>())
                {
                    towerModel.GetAttackModel().weapons[0].projectile.ApplyDisplay<RottenBananaProjectileDisplay>();
                    towerModel.GetAttackModel().weapons[0].projectile.AddBehavior(new DamageModel("DamageModel_", 2, 3, true, true, true, BloonProperties.Frozen | BloonProperties.Lead));
                }
            }


        }
        public class Tier4 : ModUpgrade<BananaFarmer>
        {
            public override int Path => MIDDLE;
            public override int Tier => 4;
            public override string Name => "PotassiumSpeed";
            public override string DisplayName => "Potassium Speed";
            public override int Cost => 5000;
            public override string Description => "Doubles Banana Gun speed again";
            public override string Icon => "BananaSight-Icon";
            public override string Portrait => "RedHat-Portrait";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<BananaGunDisplay>();

                towerModel.GetAttackModel().weapons[0].rate = 1.75f / 4f;
                if (towerModel.HasBehavior<AttackModel>())
                {


                }
            }
        }
        public class Tier5 : ModUpgrade<BananaFarmer>
        {
            public override int Path => MIDDLE;
            public override int Tier => 5;
            public override string Name => "SuperSlipperyBananas";
            public override string DisplayName => "Super Slippery Bananas";
            public override int Cost => 45000;
            public override string Description => "Bananas can now affect moabs";
            public override string Icon => "SlipperyBananananananananana";
            public override string Portrait => "RedHatYellowRim-Portrait";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<SlipperyBananaDisplay>();
                if (towerModel.HasBehavior<AttackModel>())
                {
                    towerModel.GetAttackModel().weapons[0].projectile.GetBehavior<ArriveAtTargetModel>().timeToTake = .3f;
                    towerModel.GetAttackModel().weapons[0].projectile.GetBehavior<WindModel>().affectMoab = true;
                }
            }
        }
    }
}
