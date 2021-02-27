using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.World;

internal class m : p
{
    [CompilerGenerated]
    private uint bu;
    [CompilerGenerated]
    private uint bv;
    [CompilerGenerated]
    private uint bw;
    [CompilerGenerated]
    private uint bx;
    [CompilerGenerated]
    private uint by;

    public m(af A_0, Clan A_1) : base(A_0)
    {
        base.f1(0x5e2f);
        base.f0((ushort) 0);
        this.f0(2);
        this.f3(0x2a);
        this.f4(A_1.ClanId);
        this.f2(1);
        this.f1(uint.MaxValue);
        this.f3();
        base.f0(1);
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.bv;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.bu = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.by;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.by = A_0;
    }

    [CompilerGenerated]
    public uint f2()
    {
        return this.bw;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.bx = A_0;
    }

    public void f3()
    {
        List<byte> list = new List<byte>();
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f5())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f2())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f4())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f1())));
        base.f0(list.ToArray());
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.bv = A_0;
    }

    [CompilerGenerated]
    public uint f4()
    {
        return this.bx;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.bw = A_0;
    }

    [CompilerGenerated]
    public uint f5()
    {
        return this.bu;
    }
}

