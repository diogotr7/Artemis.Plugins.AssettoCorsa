using System.Runtime.InteropServices;

namespace Artemis.Plugins.Modules.ArtemisCorsa;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public readonly struct Coordinates
{
    public readonly float X;
    public readonly float Y;
    public readonly float Z;
}