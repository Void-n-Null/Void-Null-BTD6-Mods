using Assets.Scripts.Models.Towers;
using Assets.Scripts.Unity;
using Assets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using UnityEngine;
using static VoidNull.Helper;

namespace VoidNull.AthleteMonkey
{
    public class Displays
    {
        public class ProjectileDisplays
        {
            public class BaseProjectileDisplay : ModDisplay
            {
                public override string BaseDisplay => Generic2dDisplay;

                public override void ModifyDisplayNode(UnityDisplayNode node)
                {
                    Set2DTexture(node, "AthletePeel");
                }
            }
        }

        public class TowerDisplays
        {
            public class BaseMonkeyDisplay : ModDisplay
            {
                public override string BaseDisplay => Game.instance.model.GetTowerWithName("DartMonkey-020").display;
                public override void ModifyDisplayNode(UnityDisplayNode node)
                {
                    node.SetTexture("AthleteMonkeyTexture");
                }
            }
        }
    }
}
