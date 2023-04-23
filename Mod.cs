using HarmonyLib;
using UnityEngine;

namespace SuperSeaglide
{
    //Patching the seaglide speed
    [HarmonyPatch(typeof(PlayerController))]
    public class PlayerController_Patch
    {
        [HarmonyPatch(nameof(SetMotorMode)), HarmonyPrefix]
        /*
        public static void SetMotorMode(Player.MotorMode newMotorMode, float backward, float forward, float strafe, float drag, float vertical, float water)
        {
            PlayerController playerController = Player.main.GetComponent<PlayerController>();
            if (newMotorMode == Player.MotorMode.Seaglide)
            {

                playerController.seaglideBackwardMaxSpeed = backward;
                playerController.seaglideForwardMaxSpeed = forward;
                playerController.seaglideStrafeMaxSpeed = strafe;
                playerController.seaglideSwimDrag = drag;
                playerController.seaglideVerticalMaxSpeed = vertical;
                playerController.seaglideWaterAcceleration = water;
            }
        }
        */
        public static void SetMotorMode(Player.MotorMode newMotorMode, PlayerController __instance)
        {            
            if (newMotorMode == Player.MotorMode.Seaglide)
            {
                __instance.seaglideBackwardMaxSpeed = 12.7f;
                __instance.seaglideForwardMaxSpeed = 50f;
                __instance.seaglideStrafeMaxSpeed = 12.7f;
                __instance.seaglideSwimDrag = 2.5f;
                __instance.seaglideVerticalMaxSpeed = 12.68f;
                __instance.seaglideWaterAcceleration = 73.12f;
            }
        }
    }
    //Patching the damage of Drooping Stingers
    [HarmonyPatch(typeof(HangingStinger))]
    public class HangingStinger_Patch
    {
        [HarmonyPatch(nameof(OnCollisionEnter)), HarmonyPrefix]
        private static void OnCollisionEnter(Collision other, HangingStinger __instance)
        {
            if (__instance._venomAmount >= 1f && Player.main.motorMode == Player.MotorMode.Seaglide && other.gameObject.GetComponentInChildren<LiveMixin>() != null)
            {
                __instance._venomAmount = 0f;
            }
        }
    }
    //Patching the attack of Crash Fish
    [HarmonyPatch(typeof(AggressiveWhenSeeTarget))]
    public class CrashFish_Patch
    {
        [HarmonyPatch(nameof(ScanForAggressionTarget)), HarmonyPrefix]
        private static void ScanForAggressionTarget(AggressiveWhenSeeTarget __instance)
        {            
            
            if (__instance.creature is Crash)
            {
                if (Player.main.motorMode == Player.MotorMode.Seaglide)
                {
                    __instance.aggressionPerSecond = 0f;
                }
                else __instance.aggressionPerSecond = 1f;
            }
        }
    }
}