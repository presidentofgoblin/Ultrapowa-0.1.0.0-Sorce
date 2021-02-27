using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Helpers;

internal class al
{
    [CompilerGenerated]
    private uint a;
    [CompilerGenerated]
    private uint b;

    public al(BinaryReader A_0)
    {
        uint num = A_0.ReadUInt32WithEndian();
        this.c(num - 0x1dcd6500);
        this.d(A_0.ReadUInt32WithEndian());
    }

    [CompilerGenerated]
    public uint c()
    {
        return this.b;
    }

    [CompilerGenerated]
    public void c(uint A_0)
    {
        this.a = A_0;
    }

    [CompilerGenerated]
    public uint d()
    {
        return this.a;
    }

    [CompilerGenerated]
    public void d(uint A_0)
    {
        this.b = A_0;
    }
}

