using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Helpers;

internal class ai : p
{
    [CompilerGenerated]
    private uint ft;
    [CompilerGenerated]
    private string fu;
    [CompilerGenerated]
    private byte fv;

    public ai(p A_0) : this(A_0.g9(), A_0.g2())
    {
    }

    public ai(af A_0, byte[] A_1) : base(A_0, A_1)
    {
        MemoryStream input = new MemoryStream(base.g6());
        BinaryReader br = new BinaryReader(input);
        this.f0(br.ReadUInt32WithEndian());
        this.f0(br.ReadString(this.f1()));
        this.f0(br.ReadByte());
    }

    [CompilerGenerated]
    public string f0()
    {
        return this.fu;
    }

    [CompilerGenerated]
    public void f0(byte A_0)
    {
        this.fv = A_0;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.fu = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.ft = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.ft;
    }

    [CompilerGenerated]
    public byte f2()
    {
        return this.fv;
    }
}

