using System.Runtime.InteropServices;
using System.Text;
using UnmanagedArrayGenerator;

namespace Artemis.Plugins.Modules.ArtemisCorsa;

[StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
public struct Graphics
{
    public int PacketId;
    public GameStatus Status;
    public SessionType Session;
    public AcString15 CurrentTimeString;
    public AcString15 LastTimeString;
    public AcString15 BestTimeString;
    public AcString15 SplitString;
    public int CompletedLaps;
    public int Position;
    public int CurrentTime;
    public int LastTime;
    public int BestTime;
    public float SessionTimeLeft;
    public float DistanceTraveled;
    public int IsInPit;
    public int CurrentSectorIndex;
    public int LastSectorTime;
    public int NumberOfLaps;
    public AcString33 TyreCompound;
    public float ReplayTimeMultiplier;
    public float NormalizedCarPosition;
    public int ActiveCars;
    public Coordinates60 CarCoordinates;
    public Integers60 CarIDs;
    public int PlayerCarID;
    public float PenaltyTime;
    public FlagType Flag;
    public PenaltyType Penalty;
    public int IdealLineOn;
    public int IsInPitLane;
    public float SurfaceGrip;
    public int MandatoryPitDone;
    public float WindSpeed;
    public float WindDirection;
    public int IsSetupMenuVisible;
    public int MainDisplayIndex;
    public int SecondaryDisplyIndex;
    public int TC;
    public int TCCUT;
    public int EngineMap;
    public int ABS;
    public float FuelXLap;
    public int RainLights;
    public int FlashingLights;
    public int LightsStage;
    public float ExhaustTemperature;
    public int WiperLV;
    public int DriverStintTotalTimeLeft;
    public int DriverStintTimeLeft;
    public int RainTyres;
    public int SessionIndex;
    public float UsedFuel;
    public AcString15 DeltaLapTimeString;
    public int DeltaLapTime;
    public AcString15 EstimatedLapTimeString;
    public int EstimatedLapTime;
    public int IsDeltaPositive;
    public int Split;
    public int IsValidLap;
    public float FuelEstimatedLaps;
    public AcString33 TrackStatus;
    public int MissingMandatoryPits;
    public float Clock;
    public int DirectionLightsLeft;
    public int DirectionLightsRight;
    public int GlobalYellow;
    public int GlobalYellow1;
    public int GlobalYellow2;
    public int GlobalYellow3;
    public int GlobalWhite;
    public int GlobalGreen;
    public int GlobalChequered;
    public int GlobalRed;
    public int MfdTyreSet;
    public float MfdFuelToAdd;
    public float MfdTyrePressureLF;
    public float MfdTyrePressureRF;
    public float MfdTyrePressureLR;
    public float MfdTyrePressureRR;
    public TrackGripStatus TrackGripStatus;
    public RainIntensity RainIntensity;
    public RainIntensity RainIntensityIn10min;
    public RainIntensity RainIntensityIn30min;
    public int CurrentTyreSet;
    public int StrategyTyreSet;
    public int GapAhead;
    public int GapBehind;
}

//TODO: byte or char?, 1 or 2 bytes?
[UnmanagedArray(typeof(byte), 33)]
public partial struct AcString33
{
    public override string ToString()
    {
        var sb = new StringBuilder();

        foreach (ref readonly var c in AsSpan())
        {
            //ascii only
            if (c == 0)
                break;

            sb.Append((char)c);
        }
        
        return sb.ToString();
    }

    public static implicit operator string(in AcString33 str) => str.ToString();
}

[UnmanagedArray(typeof(byte), 15)]
public partial struct AcString15
{
    public override string ToString()
    {
        var sb = new StringBuilder();

        foreach (ref readonly var c in AsSpan())
        {
            //ascii only
            if (c == 0)
                break;

            sb.Append((char)c);
        }
        
        return sb.ToString();
    }

    public static implicit operator string(in AcString15 str) => str.ToString();
}

[UnmanagedArray(typeof(Coordinates), 60)]
public partial struct Coordinates60 { }

[UnmanagedArray(typeof(int), 60)]
public partial struct Integers60 { }