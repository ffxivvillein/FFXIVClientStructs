using FFXIVClientStructs.FFXIV.Application.Network.WorkDefinitions;

namespace FFXIVClientStructs.FFXIV.Client.Game.InstanceContent;

[StructLayout(LayoutKind.Explicit, Size = 0x1088)]
public unsafe partial struct PublicContentDirector {
    [FieldOffset(0x00)] public ContentDirector ContentDirector;

    [MemberFunction("48 89 5C 24 ?? 57 48 83 EC ?? 48 8B D9 48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8B F8 48 85 C0")]
    public static partial nint HandleEnterContentInfoPacket(EnterContentInfo* packet);
}
