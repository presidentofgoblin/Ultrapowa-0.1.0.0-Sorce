using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ultrapowa_Clash_Server.World;

internal class g : p
{
    [CompilerGenerated]
    private byte a0;
    [CompilerGenerated]
    private string a1;
    [CompilerGenerated]
    private uint ao;
    [CompilerGenerated]
    private uint ap;
    [CompilerGenerated]
    private uint aq;
    [CompilerGenerated]
    private uint ar;
    [CompilerGenerated]
    private uint @as;
    [CompilerGenerated]
    private uint at;
    [CompilerGenerated]
    private uint au;
    [CompilerGenerated]
    private string av;
    [CompilerGenerated]
    private uint aw;
    [CompilerGenerated]
    private uint ax;
    [CompilerGenerated]
    private uint ay;
    [CompilerGenerated]
    private uint az;

    public g(af A_0, ClanChatMessage A_1) : base(A_0)
    {
        base.f1(0x5ef8);
        base.f0((ushort) 0);
        this.f9(A_1.Unknown1);
        this.f6(A_1.Unknown2);
        this.f0(A_1.ServerTick);
        this.f7(A_1.Region1);
        this.ga(A_1.PlayerId1);
        this.f1(A_1.Region2);
        this.f3(A_1.PlayerId2);
        this.f0(A_1.PlayerName);
        this.f5(A_1.Unknown3);
        this.f8(A_1.Unknown4);
        this.f2(A_1.MemberStatus);
        this.f4(A_1.TimeFromMessage);
        this.f0(A_1.Unknown5);
        this.f1(A_1.Message);
        this.f6();
        base.f0(1);
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.aq;
    }

    [CompilerGenerated]
    public void f0(byte A_0)
    {
        this.a0 = A_0;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.av = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.aq = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.at;
    }

    [CompilerGenerated]
    public void f1(string A_0)
    {
        this.a1 = A_0;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.at = A_0;
    }

    [CompilerGenerated]
    public uint f2()
    {
        return this.aw;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.ay = A_0;
    }

    [CompilerGenerated]
    public uint f3()
    {
        return this.ar;
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.au = A_0;
    }

    [CompilerGenerated]
    public uint f4()
    {
        return this.au;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.az = A_0;
    }

    [CompilerGenerated]
    public string f5()
    {
        return this.av;
    }

    [CompilerGenerated]
    public void f5(uint A_0)
    {
        this.aw = A_0;
    }

    public void f6()
    {
        List<byte> list = new List<byte>();
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.ga())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.ge())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f3())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f7())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f1())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f4())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f5().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f5()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f2())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gc())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f8())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f9())));
        list.Add(this.gb());
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.gd().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.gd()));
        base.f0(list.ToArray());
    }

    [CompilerGenerated]
    public void f6(uint A_0)
    {
        this.ap = A_0;
    }

    [CompilerGenerated]
    public uint f7()
    {
        return this.@as;
    }

    [CompilerGenerated]
    public void f7(uint A_0)
    {
        this.ar = A_0;
    }

    [CompilerGenerated]
    public uint f8()
    {
        return this.ay;
    }

    [CompilerGenerated]
    public void f8(uint A_0)
    {
        this.ax = A_0;
    }

    [CompilerGenerated]
    public uint f9()
    {
        return this.az;
    }

    [CompilerGenerated]
    public void f9(uint A_0)
    {
        this.ao = A_0;
    }

    [CompilerGenerated]
    public uint ga()
    {
        return this.ao;
    }

    [CompilerGenerated]
    public void ga(uint A_0)
    {
        this.@as = A_0;
    }

    [CompilerGenerated]
    public byte gb()
    {
        return this.a0;
    }

    [CompilerGenerated]
    public uint gc()
    {
        return this.ax;
    }

    [CompilerGenerated]
    public string gd()
    {
        return this.a1;
    }

    [CompilerGenerated]
    public uint ge()
    {
        return this.ap;
    }
}

