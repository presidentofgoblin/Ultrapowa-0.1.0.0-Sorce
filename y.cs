using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Helpers;

internal class y : p
{
    [CompilerGenerated]
    private uint ev;
    [CompilerGenerated]
    private string ew;

    public y(p A_0) : this(A_0.g9(), A_0.g2())
    {
    }

    public y(af A_0, byte[] A_1) : base(A_0, A_1)
    {
        MemoryStream input = new MemoryStream(base.g6());
        BinaryReader br = new BinaryReader(input);
        this.f0(br.ReadUInt32WithEndian());
        if (this.f1() != uint.MaxValue)
        {
            this.f0(br.ReadString(this.f1()));
        }
    }

    [CompilerGenerated]
    public string f0()
    {
        return this.ew;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.ew = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.ev = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.ev;
    }
}

