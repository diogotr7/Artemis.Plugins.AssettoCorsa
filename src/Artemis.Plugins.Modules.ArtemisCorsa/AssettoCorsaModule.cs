using System;
using System.Collections.Generic;
using Artemis.Core.Modules;
using Artemis.Plugins.Modules.ArtemisCorsa.DataModels;
using JetBrains.Annotations;
using Graphics = Artemis.Plugins.Modules.ArtemisCorsa.Graphics;
using Physics = Artemis.Plugins.Modules.ArtemisCorsa.Physics;
using StaticInfo = Artemis.Plugins.Modules.ArtemisCorsa.StaticInfo;

[UsedImplicitly]
public class AssettoCorsaModule : Module<ArtemisCorsaDataModel>
{
    private const string SharedMemoryPhysics = @"Local\acpmf_physics";
    private const string SharedMemoryGraphics = @"Local\acpmf_graphics";
    private const string SharedMemoryStaticInfo = @"Local\acpmf_static";

    public override List<IModuleActivationRequirement> ActivationRequirements { get; } = new()
    {
        new ProcessActivationRequirement("acs")
    };

    private MemoryReader<Physics>? _physics;
    private MemoryReader<Graphics>? _graphics;
    private MemoryReader<StaticInfo>? _staticInfo;

    public override void ModuleActivated(bool isOverride)
    {
        _physics = new MemoryReader<Physics>(SharedMemoryPhysics);
        _graphics = new MemoryReader<Graphics>(SharedMemoryGraphics);
        _staticInfo = new MemoryReader<StaticInfo>(SharedMemoryStaticInfo);
    }

    public override void ModuleDeactivated(bool isOverride)
    {
        _physics?.Dispose();
        _graphics?.Dispose();
        _staticInfo?.Dispose();
    }

    public override void Enable()
    {
    }

    public override void Disable()
    {
    }

    private void UpdatePhysicsInfo(in Physics e)
    {
        DataModel.SpeedKMH = e.SpeedKmh;
        DataModel.Gear = e.Gear - 1;
        DataModel.Rpm = e.Rpms;
        DataModel.Gas = e.Gas;
        DataModel.Brake = e.Brake;
        DataModel.Clutch = e.Clutch;
    }

    private void UpdateGraphicsInfo(in Graphics e)
    {
        DataModel.LeftTurnSignal = Convert.ToBoolean(e.DirectionLightsLeft);
        DataModel.RightTurnSignal = Convert.ToBoolean(e.DirectionLightsRight);
        DataModel.Hazards = Convert.ToBoolean(e.FlashingLights);
        DataModel.LowBeam = Convert.ToBoolean(e.LightsStage);
        DataModel.Position = e.Position;
        DataModel.isInPit = Convert.ToBoolean(e.IsInPit);
    }

    private void UpdateStaticInfo(in StaticInfo e)
    {
        DataModel.CarRedLine = e.MaxRpm;
        DataModel.CarModel = e.CarModel;
        DataModel.Track = e.Track;
        DataModel.PlayerName = e.PlayerName;
        DataModel.PlayerSurname = e.PlayerSurname;
    }

    public override void Update(double deltaTime)
    {
        var physics = _physics!.Read();
        var graphics = _graphics!.Read();
        var staticInfo = _staticInfo!.Read();

        UpdatePhysicsInfo(in physics);
        UpdateGraphicsInfo(in graphics);
        UpdateStaticInfo(in staticInfo);
    }
}