using System.Runtime.InteropServices;
using UnmanagedArrayGenerator;

namespace Artemis.Plugins.Modules.ArtemisCorsa;

[StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
public struct Physics
{
    public int PacketId;
    public float Gas;
    public float Brake;
    public float Fuel;
    public int Gear;
    public int Rpms;
    public float SteerAngle;
    public float SpeedKmh;
    public Coordinates Velocity;
    public Coordinates AccG;
    public TyreStat WheelSlip;
    public TyreStat WheelLoad;
    public TyreStat WheelsPressure;
    public TyreStat WheelAngularSpeed;
    public TyreStat TyreWear;
    public TyreStat TyreDirtyLevel;
    public TyreStat TyreCoreTemperature;
    public TyreStat CamberRad;
    public TyreStat SuspensionTravel;
    public float Drs;
    public float TC;
    public float Heading;
    public float Pitch;
    public float Roll;
    public float CgHeight;
    public Float5 CarDamage;
    public int NumberOfTyresOut;
    public int PitLimiterOn;
    public float Abs;
    public float KersCharge;
    public float KersInput;
    public int AutoShifterOn;
    public Float2 RideHeight;
    public float TurboBoost;
    public float Ballast;
    public float AirDensity;
    public float AirTemp;
    public float RoadTemp;
    public Coordinates LocalAngularVelocity;
    public float FinalFF;
    public float PerformanceMeter;
    public int EngineBrake;
    public int ErsRecoveryLevel;
    public int ErsPowerLevel;
    public int ErsHeatCharging;
    public int ErsisCharging;
    public float KersCurrentKJ;
    public int DrsAvailable;
    public int DrsEnabled;
    public TyreStat BrakeTemp;
    public float Clutch;
    public TyreStat TyreTempI;
    public TyreStat TyreTempM;
    public TyreStat TyreTempO;
    public int IsAIControlled;
    public Coordinates4 TyreContactPoint;
    public Coordinates4 TyreContactNormal;
    public Coordinates4 TyreContactHeading;
    public float BrakeBias;
    public Coordinates LocalVelocity;
    public int P2PActivation;
    public int P2PStatus;
    public float CurrentMaxRpm;
    public TyreStat Mz;
    public TyreStat Fx;
    public TyreStat Fy;
    public TyreStat SlipRatio;
    public TyreStat SlipAngle;
    public int TcinAction;
    public int AbsInAction;
    public TyreStat SuspensionDamage;
    public TyreStat TyreTemp;
    public float WaterTemp;
    public TyreStat BrakePressure;
    public int FrontBrakeCompound;
    public int RearBrakeCompound;
    public TyreStat PadLife;
    public TyreStat DiscLife;
    public int IgnitionOn;
    public int StarterEngineOn;
    public int IsEngineRunning;
    public float KerbVibration;
    public float SlipVibrations;
    public float GVibrations;
    public float AbsVibrations;
}

[UnmanagedArray(typeof(float), 5)]
public partial struct Float5 { }

[UnmanagedArray(typeof(float), 2)]
public partial struct Float2 { }

[UnmanagedArray(typeof(Coordinates), 4)]
public partial struct Coordinates4 { }