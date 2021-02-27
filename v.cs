using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Helpers;

internal class v : p
{
    [CompilerGenerated]
    private uint et;
    [CompilerGenerated]
    private string eu;

    public v(p A_0) : this(A_0.g9(), A_0.g2())
    {
    }

    public v(af A_0, byte[] A_1) : base(A_0, A_1)
    {
        MemoryStream input = new MemoryStream(base.g6());
        BinaryReader br = new BinaryReader(input);
        this.f0(br.ReadUInt32WithEndian());
        this.f0(br.ReadString(this.f0()));
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.et;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.eu = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.et = A_0;
    }

    [CompilerGenerated]
    public string f1()
    {
        return this.eu;
    }
}

