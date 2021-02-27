using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Helpers;

internal class ak : p
{
    [CompilerGenerated]
    private uint f0;
    [CompilerGenerated]
    private uint f1;
    private byte[] fw;
    private MemoryStream fx;
    private BinaryReader fy;
    [CompilerGenerated]
    private uint fz;

    public ak(p A_0) : this(A_0.g9(), A_0.g2())
    {
    }

    public ak(af A_0, byte[] A_1) : base(A_0, A_1)
    {
        MemoryStream input = new MemoryStream(base.g6());
        BinaryReader br = new BinaryReader(input);
        this.f2(br.ReadUInt32WithEndian());
        this.f0(br.ReadUInt32WithEndian());
        this.f1(br.ReadUInt32WithEndian());
        if (this.f1() > 0)
        {
            this.fw = br.ReadBytes(base.g6().Length - 12);
            this.fx = new MemoryStream(this.fw);
            this.fy = new BinaryReader(this.fx);
        }
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.f0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.f0 = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.f1;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.f1 = A_0;
    }

    public BinaryReader f2()
    {
        return this.fy;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.fz = A_0;
    }

    [CompilerGenerated]
    public uint f3()
    {
        return this.fz;
    }
}

