using System;
using System.Collections.Generic;
using Artemis.Core;
using Artemis.Core.Modules;
using Artemis.Plugins.Modules.ArtemisCorsa.DataModels;
using Thomsen.AccTools.SharedMemory;
using Thomsen.AccTools.SharedMemory.Models;

public class ArtemisCorsa : Module<ArtemisCorsaDataModel>
{
    
    public override List<IModuleActivationRequirement> ActivationRequirements { get; } = new() {new ProcessActivationRequirement("acs")};
    private AccSharedMemory acc = new AccSharedMemory();
    System.Threading.CancellationTokenSource cts = new();
    public override void ModuleActivated(bool isOverride)
    {
        acc.ConnectAsync(cts.Token);
        acc.PhysicsUpdateInterval = 6.94;
        acc.GraphicsUpdateInterval = 6.94;
        acc.PhysicsUpdated += UpdatePhysicsInfo;
        acc.GraphicsUpdated += UpdateGraphicsInfo;
        acc.StaticInfoUpdated += UpdateStaticInfo;
    }
    public override void ModuleDeactivated(bool isOverride)
    {
        acc.PhysicsUpdated -= UpdatePhysicsInfo;
        acc.GraphicsUpdated -= UpdateGraphicsInfo;
        acc.StaticInfoUpdated -= UpdateStaticInfo;
        cts.Cancel();
    }
    public override void Enable() 
    { 

    }
    public override void Disable() 
    { 

    }
    private void UpdatePhysicsInfo(object sender, UpdatedEventArgs<Physics> e)
    {
        DataModel.SpeedKMH = e.Data.SpeedKmh;
        DataModel.Gear = e.Data.Gear - 1;
        DataModel.Rpm = e.Data.Rpms;
        DataModel.Gas = e.Data.Gas;
        DataModel.Brake = e.Data.Brake;
        DataModel.Clutch = e.Data.Clutch;
    }
    private void UpdateGraphicsInfo(object sender, UpdatedEventArgs<Graphics> e)
    {
        DataModel.LeftTurnSignal = Convert.ToBoolean(e.Data.DirectionLightsLeft);
        DataModel.RightTurnSignal = Convert.ToBoolean(e.Data.DirectionLightsRight);
        DataModel.Hazards = Convert.ToBoolean(e.Data.FlashingLights);
        DataModel.LowBeam = Convert.ToBoolean(e.Data.LightsStage);
        DataModel.Position = e.Data.Position;
        DataModel.isInPit = Convert.ToBoolean(e.Data.IsInPit);
    }
    private void UpdateStaticInfo(object sender, UpdatedEventArgs<StaticInfo> e)
    {
        DataModel.CarRedLine = e.Data.MaxRpm;
        DataModel.CarModel = e.Data.CarModel;
        DataModel.Track = e.Data.Track;
        DataModel.PlayerName = e.Data.PlayerName;
        DataModel.PlayerSurname = e.Data.PlayerSurname;
    }
    public override void Update(double deltaTime) 
    { 
    }
}