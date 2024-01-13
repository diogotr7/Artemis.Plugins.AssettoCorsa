using Artemis.Core.Modules;

namespace Artemis.Plugins.Modules.ArtemisCorsa.DataModels;

public class ArtemisCorsaDataModel : DataModel
{
    //StaticData
    public string? CarModel { get; set; }
    public string? Track { get; set; }
    public float CarRedLine { get; set; }
    public string? PlayerName { get; set; }
    public string? PlayerSurname { get; set; }

    //PhysicsData
    public float Rpm { get; set; }
    public int Gear { get; set; }
    public float SpeedKMH { get; set; }
    public float Gas { get; set; }
    public float Brake { get; set; }
    public float Clutch { get; set; }
    public float Fuel { get; set; }
    public float SteerAngle { get; set; }
    public float Drs { get; set; }
    public float TC { get; set; }
    public bool PitLimiterOn { get; set; }
    public float Abs { get; set; }
    public float KersCharge { get; set; }
    public float KersInput { get; set; }
    public float TurboBoost { get; set; }
    public int ErsPowerLevel { get; set; }
    public bool DrsEnabled { get; set; }
    public bool IsEngineRunning { get; set; }


    //Graphics
    public bool LeftTurnSignal { get; set; }
    public bool RightTurnSignal { get; set; }
    public bool Hazards { get; set; }
    public bool LowBeam { get; set; }
    public int Position { get; set; }
    public bool isInPit { get; set; }
}