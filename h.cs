using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Helpers;

internal class h : p
{
    [CompilerGenerated]
    private uint a2;
    [CompilerGenerated]
    private uint a3;

    public h(p A_0) : this(A_0.g9(), A_0.g2())
    {
    }

    public h(af A_0, byte[] A_1) : base(A_0, A_1)
    {
        MemoryStream input = new MemoryStream(base.g6());
        BinaryReader br = new BinaryReader(input);
        this.f1(br.ReadUInt32WithEndian());
        this.f0(br.ReadUInt32WithEndian());
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.a3;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.a3 = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.a2;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.a2 = A_0;
    }
}

