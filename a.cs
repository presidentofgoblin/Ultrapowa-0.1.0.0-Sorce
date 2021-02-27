using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Helpers;

internal class a : p
{
    [CompilerGenerated]
    private uint a;
    [CompilerGenerated]
    private uint b;

    public a(p A_0) : this(A_0.g9(), A_0.g2())
    {
    }

    public a(af A_0, byte[] A_1) : base(A_0, A_1)
    {
        MemoryStream input = new MemoryStream(base.g6());
        BinaryReader br = new BinaryReader(input);
        this.f0(br.ReadUInt32WithEndian());
        this.f1(br.ReadUInt32WithEndian());
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.a;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.a = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.b;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.b = A_0;
    }
}

