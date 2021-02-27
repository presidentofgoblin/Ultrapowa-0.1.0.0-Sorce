using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ultrapowa_Clash_Server.World;

internal class b : p
{
    [CompilerGenerated]
    private uint c;
    [CompilerGenerated]
    private uint d;
    [CompilerGenerated]
    private uint e;
    [CompilerGenerated]
    private string f;
    [CompilerGenerated]
    private uint g;
    [CompilerGenerated]
    private byte h;
    [CompilerGenerated]
    private uint i;
    [CompilerGenerated]
    private uint j;

    public b(af A_0, Clan A_1) : base(A_0)
    {
        base.f1(0x5e2f);
        base.f0((ushort) 0);
        this.f2(1);
        this.f3(0x2a);
        this.f0(A_1.ClanId);
        this.f0(A_1.ClanName);
        this.f1(A_1.Shield);
        this.f0((byte) 0);
        this.f5(1);
        this.f4(uint.MaxValue);
        this.f5();
        base.f0(1);
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.j;
    }

    [CompilerGenerated]
    public void f0(byte A_0)
    {
        this.h = A_0;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.f = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.e = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.i;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.g = A_0;
    }

    [CompilerGenerated]
    public uint f2()
    {
        return this.e;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.c = A_0;
    }

    [CompilerGenerated]
    public string f3()
    {
        return this.f;
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.d = A_0;
    }

    [CompilerGenerated]
    public byte f4()
    {
        return this.h;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.j = A_0;
    }

    public void f5()
    {
        List<byte> list = new List<byte>();
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f6())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f7())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f2())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f3().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f3()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f8())));
        list.Add(this.f4());
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f1())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0())));
        base.f0(list.ToArray());
    }

    [CompilerGenerated]
    public void f5(uint A_0)
    {
        this.i = A_0;
    }

    [CompilerGenerated]
    public uint f6()
    {
        return this.c;
    }

    [CompilerGenerated]
    public uint f7()
    {
        return this.d;
    }

    [CompilerGenerated]
    public uint f8()
    {
        return this.g;
    }
}

