using Assets.Scripts.Models.Towers;
using Assets.Scripts.Unity;
using Assets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper.Extensions.DisplayNodeExtensions;
using MelonLoader;
using UnityEngine;
using static VoidNull.Helper;

namespace VoidNull.AthleteMonkey
{
    public class Displays
    {
        public class ProjectileDisplays
        {
            public class Baseketball : ModDisplay
            {
                public override string BaseDisplay => Generic2dDisplay;

                public override void ModifyDisplayNode(UnityDisplayNode node)
                {
                    Set2DTexture(node, "Basketball");
                    foreach (var rend in node.genericRenderers)
                    {
                        foreach (var trans in node.gameObject.GetComponentsInChildren<Transform>())
                        {
                            trans.localScale *= 0.6f;
                        }
                    }
                }
            }
            
            public class Baseball : ModDisplay
            {
                public override string BaseDisplay => Generic2dDisplay;

                public override void ModifyDisplayNode(UnityDisplayNode node)
                {
                    Set2DTexture(node, "Baseball");
                    foreach (var rend in node.genericRenderers)
                    {
                        foreach (var trans in node.gameObject.GetComponentsInChildren<Transform>())
                        {
                            trans.localScale *= 0.3f;
                        }
                    }
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
                    for (var index = 0; index < node.genericRenderers.Count; index++)
                    {
                        var rend = node.genericRenderers[index];
                        MelonLogger.Msg(index + " - " + rend.gameObject.name);
                    }
                    node.genericRenderers[1].enabled = false;
                    node.SetTexture("AthleteMonkeyTexture");
                }
            }
        }
    }
}
