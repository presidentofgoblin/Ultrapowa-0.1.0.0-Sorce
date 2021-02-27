using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Helpers;

internal class ah : p
{
    [CompilerGenerated]
    private uint fm;
    [CompilerGenerated]
    private string fn;
    [CompilerGenerated]
    private uint fo;
    [CompilerGenerated]
    private string fp;
    [CompilerGenerated]
    private uint fq;
    [CompilerGenerated]
    private uint fr;
    [CompilerGenerated]
    private uint fs;

    public ah(p A_0) : this(A_0.g9(), A_0.g2())
    {
    }

    public ah(af A_0, byte[] A_1) : base(A_0, A_1)
    {
        MemoryStream input = new MemoryStream(base.g6());
        BinaryReader br = new BinaryReader(input);
        this.f3(br.ReadUInt32WithEndian());
        this.f0(br.ReadString(this.f3()));
        this.f2(br.ReadUInt32WithEndian());
        this.f1(br.ReadString(this.f5()));
        this.f4(br.ReadUInt32WithEndian());
        this.f1(br.ReadUInt32WithEndian());
        this.f0(br.ReadUInt32WithEndian());
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.fr;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.fn = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.fs = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.fs;
    }

    [CompilerGenerated]
    public void f1(string A_0)
    {
        this.fp = A_0;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.fr = A_0;
    }

    [CompilerGenerated]
    public string f2()
    {
        return this.fn;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.fo = A_0;
    }

    [CompilerGenerated]
    public uint f3()
    {
        return this.fm;
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.fm = A_0;
    }

    [CompilerGenerated]
    public string f4()
    {
        return this.fp;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.fq = A_0;
    }

    [CompilerGenerated]
    public uint f5()
    {
        return this.fo;
    }

    [CompilerGenerated]
    public uint f6()
    {
        return this.fq;
    }
}

