using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ultrapowa_Clash_Server.World;

internal class o : p
{
    [CompilerGenerated]
    private uint b0;
    [CompilerGenerated]
    private uint b1;
    [CompilerGenerated]
    private string b2;
    [CompilerGenerated]
    private uint b3;
    [CompilerGenerated]
    private byte b4;
    [CompilerGenerated]
    private uint b5;
    [CompilerGenerated]
    private uint b6;
    [CompilerGenerated]
    private uint bz;

    public o(af A_0, Clan A_1) : base(A_0)
    {
        base.f1(0x5e2f);
        base.f0((ushort) 0);
        this.f2(1);
        this.f3(0x2a);
        this.f0(A_1.ClanId);
        this.f0(A_1.ClanName);
        this.f1(A_1.Shield);
        this.f0((byte) 1);
        this.f5(2);
        this.f4(uint.MaxValue);
        this.f5();
        base.f0(1);
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.b6;
    }

    [CompilerGenerated]
    public void f0(byte A_0)
    {
        this.b4 = A_0;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.b2 = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.b1 = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.b5;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.b3 = A_0;
    }

    [CompilerGenerated]
    public uint f2()
    {
        return this.b1;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.bz = A_0;
    }

    [CompilerGenerated]
    public string f3()
    {
        return this.b2;
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.b0 = A_0;
    }

    [CompilerGenerated]
    public byte f4()
    {
        return this.b4;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.b6 = A_0;
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
        this.b5 = A_0;
    }

    [CompilerGenerated]
    public uint f6()
    {
        return this.bz;
    }

    [CompilerGenerated]
    public uint f7()
    {
        return this.b0;
    }

    [CompilerGenerated]
    public uint f8()
    {
        return this.b3;
    }
}

