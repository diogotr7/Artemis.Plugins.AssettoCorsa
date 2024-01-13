using System.Runtime.InteropServices;

namespace Artemis.Plugins.Modules.ArtemisCorsa;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public readonly struct TyreStat
{
    public readonly float FrontLeft;
    public readonly float FrontRight;
    public readonly float RearLeft;
    public readonly float RearRight;
}