using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Helpers;

internal class j : p
{
    [CompilerGenerated]
    private uint a4;
    [CompilerGenerated]
    private string a5;

    public j(p A_0) : this(A_0.g9(), A_0.g2())
    {
    }

    public j(af A_0, byte[] A_1) : base(A_0, A_1)
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
        return this.a5;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.a5 = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.a4 = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.a4;
    }
}

