using HarmonyLib;
using SMLHelper.V2.Commands;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Interfaces;
using SMLHelper.V2.Json;
using SMLHelper.V2.Json.Attributes;
using SMLHelper.V2.Options;
using SMLHelper.V2.Options.Attributes;
using System;
using UnityEngine;
using UnityEngine.UI;
using BepInEx;
using BepInEx.Logging;

namespace SuperSeaglide
{
    /*
    [Menu("Super Seaglide Options")]
    public class Options : ConfigFile
    {
        [Slider("Seaglide Backward Max Speed", 6.35f, 50f, DefaultValue = 6.35f, Format = "{0:F2}"), OnChange(nameof(BackwardSpeedChange))]
        public float backwardSpeedSlider;
        [Slider("Seaglide Forward Max Speed", 25f, 500f, DefaultValue = 50f, Format = "{0:F2}"), OnChange(nameof(ForwardSpeedChange))]
        public float forwardSpeedSlider;
        [Slider("Seaglide Strafe Max Speed", 6.35f, 50f, DefaultValue = 6.35f, Format = "{0:F2}"), OnChange(nameof(StrafeSpeedChange))]
        public float strafeSpeedSlider;
        [Slider("Seaglide Swim Drag Max Speed", 2.35f, 5f, DefaultValue = 2.35f, Format = "{0:F2}"), OnChange(nameof(SwimDragSpeedChange))]
        public float swimDragSlider;
        [Slider("Seaglide Vertical Max Speed", 6.34f, 500f, DefaultValue = 6.34f, Format = "{0:F2}"), OnChange(nameof(VerticalMaxSpeedChange))]
        public float verticalMaxSpeedSlider;
        [Slider("Seaglide Water Accel Max Speed", 36.56f, 500f, DefaultValue = 100f, Format = "{0:F2}"), OnChange(nameof(waterAccelSpeedChange))]
        public float waterAccelSpeedSlider;

        public void BackwardSpeedChange()
        {
            PlayerController_Patch.SetMotorMode(Player.MotorMode.Seaglide, backwardSpeedSlider, forwardSpeedSlider, strafeSpeedSlider, swimDragSlider, verticalMaxSpeedSlider, waterAccelSpeedSlider);
        }
        public void ForwardSpeedChange()
        {
            PlayerController_Patch.SetMotorMode(Player.MotorMode.Seaglide, backwardSpeedSlider, forwardSpeedSlider, strafeSpeedSlider, swimDragSlider, verticalMaxSpeedSlider, waterAccelSpeedSlider);            
        }
        public void StrafeSpeedChange()
        {
            PlayerController_Patch.SetMotorMode(Player.MotorMode.Seaglide, backwardSpeedSlider, forwardSpeedSlider, strafeSpeedSlider, swimDragSlider, verticalMaxSpeedSlider, waterAccelSpeedSlider);
        }
        public void SwimDragSpeedChange()
        {
            PlayerController_Patch.SetMotorMode(Player.MotorMode.Seaglide, backwardSpeedSlider, forwardSpeedSlider, strafeSpeedSlider, swimDragSlider, verticalMaxSpeedSlider, waterAccelSpeedSlider);
        }
        public void VerticalMaxSpeedChange()
        {
            PlayerController_Patch.SetMotorMode(Player.MotorMode.Seaglide, backwardSpeedSlider, forwardSpeedSlider, strafeSpeedSlider, swimDragSlider, verticalMaxSpeedSlider, waterAccelSpeedSlider);
        }
        public void waterAccelSpeedChange()
        {
            PlayerController_Patch.SetMotorMode(Player.MotorMode.Seaglide, backwardSpeedSlider, forwardSpeedSlider, strafeSpeedSlider, swimDragSlider, verticalMaxSpeedSlider, waterAccelSpeedSlider);
        }
    }
    */
}
