using System.Runtime.InteropServices;

namespace Artemis.Plugins.Modules.ArtemisCorsa;

[StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
public struct StaticInfo
{
    public AcString15 SMVersion;
    public AcString15 ACVersion;
    public int NumberOfSessions;
    public int NumCars;
    public AcString33 CarModel;
    public AcString33 Track;
    public AcString33 PlayerName;
    public AcString33 PlayerSurname;
    public AcString33 PlayerNick;
    public int SectorCount;
    public float MaxTorque;
    public float MaxPower;
    public int MaxRpm;
    public float MaxFuel;
    public TyreStat SuspensionMaxTravel;
    public TyreStat TyreRadius;
    public float MaxTurboBoost;
    public float Deprecated1;
    public float Deprecated2;
    public int PenaltiesEnabled;
    public float AidFuelRate;
    public float AidTireRate;
    public float AidMechanicalDamage;
    public int AidAllowTyreBlankets;
    public float AidStability;
    public int AidAutoClutch;
    public int AidAutoBlip;
    public int HasDRS;
    public int HasERS;
    public int HasKERS;
    public float KersMaxJoules;
    public int EngineBrakeSettingsCount;
    public int ErsPowerControllerCount;
    public float TrackSPlineLength;
    public AcString15 TrackConfiguration;
    public float ErsMaxJ;
    public int IsTimedRace;
    public int HasExtraLap;
    public AcString33 CarSkin;
    public int ReversedGridPositions;
    public int PitWindowStart;
    public int PitWindowEnd;
    public int IsOnline;
    public AcString33 DryTyresName;
    public AcString33 WetTyresName;
}