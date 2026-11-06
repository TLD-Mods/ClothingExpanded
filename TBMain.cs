using ChooseStartingGear;
using Il2Cpp;
using Il2CppHoloville.HOTween.Core.Easing;
using Il2CppMS.Internal.Xml.XPath;
using Il2CppNodeCanvas.BehaviourTrees;
using Il2CppTLD.Gameplay.Condition;
using Il2CppTLD.Gear;
using JetBrains.Annotations;
using MelonLoader;
using System.Net.NetworkInformation;
using Toolbelts;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace ModNamespace
{
    internal sealed class LWMain : MelonMod
    {
        public static bool isLoaded;

        private static bool addedCustomComponents;

        public override void OnInitializeMelon()
        {
            MelonLoader.MelonLogger.Msg(System.ConsoleColor.Green, "Clothing Expanded Loaded!");
        }
        public override void OnSceneWasInitialized(int level, string name)
        {


            if (ToolbeltsUtils.IsScenePlayable(name))
            {
                isLoaded = true;

                DoStuffWithGear();

            }

        }

        private static void DoStuffWithGear()
        {
            if (!addedCustomComponents)
            {
                GameObject gear;
                GearItem itemGear;
                var validtools = GearPrefabs.Load("GEAR_Toolbelt").GetComponent<WeightReductionBuff>().m_ValidTargets;
                var tools = GearPrefabs.Load("GEAR_Toolbelt").GetComponent<WeightReductionBuff>().m_Targets;
                var tools2 = GearPrefabs.Load("GEAR_Toolbelt").GetComponent<WeightReductionBuff>().m_OperationHandle;

                var cramponssprain = GearPrefabs.Load("GEAR_Crampons").GetComponent<ClimbingBuff>().m_SprainModifier;
                var cramponssprainroll = GearPrefabs.Load("GEAR_Crampons").GetComponent<ClimbingBuff>().m_SprainRollOddsModifier;
                var cramponsstamina = GearPrefabs.Load("GEAR_Crampons").GetComponent<ClimbingBuff>().m_StaminaModifier;
                var cramponsstaminasec = GearPrefabs.Load("GEAR_Crampons").GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier;
                var cramponsice = GearPrefabs.Load("GEAR_Crampons").GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier;

                var Icramponssprain = GearPrefabs.Load("GEAR_ImprovisedCrampons").GetComponent<ClimbingBuff>().m_SprainModifier;
                var Icramponssprainroll = GearPrefabs.Load("GEAR_ImprovisedCrampons").GetComponent<ClimbingBuff>().m_SprainRollOddsModifier;
                var Icramponsstamina = GearPrefabs.Load("GEAR_ImprovisedCrampons").GetComponent<ClimbingBuff>().m_StaminaModifier;
                var Icramponsstaminasec = GearPrefabs.Load("GEAR_ImprovisedCrampons").GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier;
                var Icramponsice = GearPrefabs.Load("GEAR_ImprovisedCrampons").GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier;

                var scabbardvtarget = GearPrefabs.Load("GEAR_RifleScabbardA").GetComponent<WeightReductionBuff>().m_ValidTargets;
                var scabbardtargets = GearPrefabs.Load("GEAR_RifleScabbardA").GetComponent<WeightReductionBuff>().m_Targets;
                var scabbardophandle = GearPrefabs.Load("GEAR_RifleScabbardA").GetComponent<WeightReductionBuff>().m_OperationHandle;
                var moosebag = GearPrefabs.Load("GEAR_MooseHideBag").GetComponent<CarryingCapacityBuff>().m_CarryingCapacityBuffValues;

                string gear13u = "JeansToolbelt";
                string gear14u = "CombatToolbelt";
                string gear15u = "CargoToolbelt";
                string gear16u = "WorkToolbelt";
                string gear17u = "InsulatedToolbelt";
                string gear18u = "MinerToolbelt";
                string gear19u = "DeerskinToolbelt";

                string gear21 = "WorkNCrampons";
                string gear21i = "WorkICrampons";
                string gear22 = "CombatNCrampons";
                string gear22i = "CombatICrampons";
                string gear23 = "DeerskinNCrampons";
                string gear23i = "DeerskinICrampons";
                string gear24 = "InsulatedNCrampons";
                string gear24i = "InsulatedICrampons";
                string gear25 = "DressingNCrampons";
                string gear25i = "DressingICrampons";
                string gear26 = "MuklukNCrampons";
                string gear26i = "MuklukICrampons";
                string gear27 = "RunningNCrampons";
                string gear27i = "RunningICrampons";
                string gear28 = "SkiNCrampons";
                string gear28i = "SkiICrampons";
                string gear29 = "TrailNCrampons";
                string gear29i = "TrailICrampons";
                string gear31 = "ChemicalNCrampons";
                string gear31i = "ChemicalICrampons";

                string gear30 = "MooseBagPlusScabbard";


                gear = GearPrefabs.Load("GEAR_" + gear13u).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear13u);

                gear.AddComponent<WeightReductionBuff>();
                gear.GetComponent<WeightReductionBuff>().m_GearItem = itemGear;
                gear.GetComponent<WeightReductionBuff>().m_ValidTargets = validtools;
                gear.GetComponent<WeightReductionBuff>().m_Targets = tools;
                gear.GetComponent<WeightReductionBuff>().m_OperationHandle = tools2;
                gear.GetComponent<WeightReductionBuff>().m_AffectedItems = 3;
                gear.GetComponent<WeightReductionBuff>().m_WeightReduction = 0.5f;


                gear = GearPrefabs.Load("GEAR_" + gear14u).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear14u);

                gear.AddComponent<WeightReductionBuff>();
                gear.GetComponent<WeightReductionBuff>().m_GearItem = itemGear;
                gear.GetComponent<WeightReductionBuff>().m_ValidTargets = validtools;
                gear.GetComponent<WeightReductionBuff>().m_Targets = tools;
                gear.GetComponent<WeightReductionBuff>().m_OperationHandle = tools2;
                gear.GetComponent<WeightReductionBuff>().m_AffectedItems = 3;
                gear.GetComponent<WeightReductionBuff>().m_WeightReduction = 0.5f;


                gear = GearPrefabs.Load("GEAR_" + gear15u).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear15u);

                gear.AddComponent<WeightReductionBuff>();
                gear.GetComponent<WeightReductionBuff>().m_GearItem = itemGear;
                gear.GetComponent<WeightReductionBuff>().m_ValidTargets = validtools;
                gear.GetComponent<WeightReductionBuff>().m_Targets = tools;
                gear.GetComponent<WeightReductionBuff>().m_OperationHandle = tools2;
                gear.GetComponent<WeightReductionBuff>().m_AffectedItems = 3;
                gear.GetComponent<WeightReductionBuff>().m_WeightReduction = 0.5f;


                gear = GearPrefabs.Load("GEAR_" + gear16u).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear16u);

                gear.AddComponent<WeightReductionBuff>();
                gear.GetComponent<WeightReductionBuff>().m_GearItem = itemGear;
                gear.GetComponent<WeightReductionBuff>().m_ValidTargets = validtools;
                gear.GetComponent<WeightReductionBuff>().m_Targets = tools;
                gear.GetComponent<WeightReductionBuff>().m_OperationHandle = tools2;
                gear.GetComponent<WeightReductionBuff>().m_AffectedItems = 3;
                gear.GetComponent<WeightReductionBuff>().m_WeightReduction = 0.5f;


                gear = GearPrefabs.Load("GEAR_" + gear17u).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear17u);

                gear.AddComponent<WeightReductionBuff>();
                gear.GetComponent<WeightReductionBuff>().m_GearItem = itemGear;
                gear.GetComponent<WeightReductionBuff>().m_ValidTargets = validtools;
                gear.GetComponent<WeightReductionBuff>().m_Targets = tools;
                gear.GetComponent<WeightReductionBuff>().m_OperationHandle = tools2;
                gear.GetComponent<WeightReductionBuff>().m_AffectedItems = 3;
                gear.GetComponent<WeightReductionBuff>().m_WeightReduction = 0.5f;


                gear = GearPrefabs.Load("GEAR_" + gear18u).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear18u);

                gear.AddComponent<WeightReductionBuff>();
                gear.GetComponent<WeightReductionBuff>().m_GearItem = itemGear;
                gear.GetComponent<WeightReductionBuff>().m_ValidTargets = validtools;
                gear.GetComponent<WeightReductionBuff>().m_Targets = tools;
                gear.GetComponent<WeightReductionBuff>().m_OperationHandle = tools2;
                gear.GetComponent<WeightReductionBuff>().m_AffectedItems = 3;
                gear.GetComponent<WeightReductionBuff>().m_WeightReduction = 0.5f;


                gear = GearPrefabs.Load("GEAR_" + gear19u).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear19u);

                gear.AddComponent<WeightReductionBuff>();
                gear.GetComponent<WeightReductionBuff>().m_GearItem = itemGear;
                gear.GetComponent<WeightReductionBuff>().m_ValidTargets = validtools;
                gear.GetComponent<WeightReductionBuff>().m_Targets = tools;
                gear.GetComponent<WeightReductionBuff>().m_OperationHandle = tools2;
                gear.GetComponent<WeightReductionBuff>().m_AffectedItems = 3;
                gear.GetComponent<WeightReductionBuff>().m_WeightReduction = 0.5f;


                gear = GearPrefabs.Load("GEAR_" + gear21).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear21);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = cramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = cramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = cramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = cramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = cramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear21i).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear21i);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = Icramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = Icramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = Icramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = Icramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = Icramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear22).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear22);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = cramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = cramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = cramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = cramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = cramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear22i).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear22i);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = Icramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = Icramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = Icramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = Icramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = Icramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear23).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear23);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = cramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = cramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = cramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = cramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = cramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear23i).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear23i);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = Icramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = Icramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = Icramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = Icramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = Icramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear24).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear24);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = cramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = cramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = cramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = cramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = cramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear24i).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear24i);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = Icramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = Icramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = Icramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = Icramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = Icramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear25).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear25);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = cramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = cramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = cramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = cramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = cramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear25i).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear25i);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = Icramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = Icramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = Icramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = Icramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = Icramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear26).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear26);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = cramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = cramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = cramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = cramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = cramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear26i).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear26i);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = Icramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = Icramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = Icramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = Icramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = Icramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear27).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear27);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = cramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = cramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = cramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = cramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = cramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear27i).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear27i);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = Icramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = Icramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = Icramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = Icramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = Icramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear28).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear28);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = cramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = cramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = cramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = cramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = cramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear28i).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear28i);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = Icramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = Icramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = Icramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = Icramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = Icramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear29).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear29);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = cramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = cramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = cramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = cramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = cramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear29i).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear29i);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = Icramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = Icramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = Icramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = Icramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = Icramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear31).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear31);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = cramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = cramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = cramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = cramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = cramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear31i).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear31i);

                gear.AddComponent<ClimbingBuff>();
                gear.GetComponent<ClimbingBuff>().m_SprainModifier = Icramponssprain;
                gear.GetComponent<ClimbingBuff>().m_SprainRollOddsModifier = Icramponssprainroll;
                gear.GetComponent<ClimbingBuff>().m_StaminaModifier = Icramponsstamina;
                gear.GetComponent<ClimbingBuff>().m_StaminaPerSecondModifier = Icramponsstaminasec;
                gear.GetComponent<ClimbingBuff>().m_WeakIceTimeSecondsModifier = Icramponsice;

                gear = GearPrefabs.Load("GEAR_" + gear30).gameObject;
                itemGear = GearPrefabs.Load("GEAR_" + gear30);

                gear.AddComponent<WeightReductionBuff>();
                gear.GetComponent<WeightReductionBuff>().m_GearItem = itemGear;
                gear.GetComponent<WeightReductionBuff>().m_ValidTargets = scabbardvtarget;
                gear.GetComponent<WeightReductionBuff>().m_Targets = scabbardtargets;
                gear.GetComponent<WeightReductionBuff>().m_OperationHandle = scabbardophandle;
                gear.GetComponent<WeightReductionBuff>().m_AffectedItems = 1;
                gear.GetComponent<WeightReductionBuff>().m_WeightReduction = 0.5f;

                gear.AddComponent<CarryingCapacityBuff>();
                gear.GetComponent<CarryingCapacityBuff>().m_IsWorn = true;
                gear.GetComponent<CarryingCapacityBuff>().m_CarryingCapacityBuffValues = moosebag;

                addedCustomComponents = true;
            }

        }

    }
}