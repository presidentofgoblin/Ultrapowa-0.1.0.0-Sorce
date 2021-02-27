using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Helpers;

internal class u : p
{
    [CompilerGenerated]
    private uint es;

    public u(p A_0) : this(A_0.g9(), A_0.g2())
    {
    }

    public u(af A_0, byte[] A_1) : base(A_0, A_1)
    {
        MemoryStream input = new MemoryStream(base.g6());
        BinaryReader br = new BinaryReader(input);
        this.f0(br.ReadUInt32WithEndian());
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.es;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.es = A_0;
    }
}

