using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ultrapowa_Clash_Server.World;

internal class s : p
{
    [CompilerGenerated]
    private uint d0;
    [CompilerGenerated]
    private uint d1;
    [CompilerGenerated]
    private uint d2;
    [CompilerGenerated]
    private uint d3;
    [CompilerGenerated]
    private uint d4;
    [CompilerGenerated]
    private string d5;
    [CompilerGenerated]
    private uint d6;
    [CompilerGenerated]
    private uint d7;
    [CompilerGenerated]
    private uint d8;
    [CompilerGenerated]
    private uint d9;
    [CompilerGenerated]
    private uint dk;
    [CompilerGenerated]
    private uint dl;
    [CompilerGenerated]
    private string dm;
    [CompilerGenerated]
    private uint dn;
    [CompilerGenerated]
    private uint @do;
    [CompilerGenerated]
    private uint dp;
    [CompilerGenerated]
    private uint dq;
    [CompilerGenerated]
    private uint dr;
    [CompilerGenerated]
    private uint ds;
    [CompilerGenerated]
    private uint dt;
    [CompilerGenerated]
    private uint du;
    [CompilerGenerated]
    private string dv;
    [CompilerGenerated]
    private uint dw;
    [CompilerGenerated]
    private byte dx;
    [CompilerGenerated]
    private uint dy;
    [CompilerGenerated]
    private uint dz;
    [CompilerGenerated]
    private uint ea;
    [CompilerGenerated]
    private uint eb;
    [CompilerGenerated]
    private uint ec;
    [CompilerGenerated]
    private uint ed;
    [CompilerGenerated]
    private byte ee;
    [CompilerGenerated]
    private uint ef;
    [CompilerGenerated]
    private byte eg;
    [CompilerGenerated]
    private uint eh;
    [CompilerGenerated]
    private uint ei;
    [CompilerGenerated]
    private uint ej;
    [CompilerGenerated]
    private uint ek;

    public s(af A_0) : base(A_0)
    {
        this.f7(1);
        this.gd(0x20e);
        this.f5(0);
        this.go(0);
        this.gm(0);
        this.gl(0);
        this.f0((byte) 0);
        this.gr(1);
        this.gs(13);
        this.gk(0x1de9a6);
        this.gg(uint.MaxValue);
        this.f1("Ultrapowa");
        this.gh((uint) this.gv().Length);
        this.f0((uint) 2);
        this.f1((uint) 0x2b);
        this.gt(0);
        this.gu(0xffff);
        this.f3(0);
        this.f4(0);
        this.gp(1);
        this.gq(1);
        this.f2((byte) 0);
        this.gf(0);
        this.f1((byte) 1);
        this.gb(13);
        this.gn(0x1de9a6);
    }

    public s(af A_0, Clan A_1, uint A_2) : this(A_0)
    {
        base.f1(0x5eed);
        base.f0((ushort) 0);
        this.gi(A_2);
        this.f8(A_1.ClanId);
        this.f0(A_1.ClanName);
        this.ga(A_1.Shield);
        this.gj(A_1.ClanStatus);
        this.f9(A_1.RequiredTrophies);
        this.f2(A_1.ClanMessage);
        this.gj();
        base.f0(1);
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.d6;
    }

    [CompilerGenerated]
    public void f0(byte A_0)
    {
        this.dx = A_0;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.dm = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.d6 = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.d7;
    }

    [CompilerGenerated]
    public void f1(byte A_0)
    {
        this.eg = A_0;
    }

    [CompilerGenerated]
    public void f1(string A_0)
    {
        this.d5 = A_0;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.d7 = A_0;
    }

    [CompilerGenerated]
    public string f2()
    {
        return this.dv;
    }

    [CompilerGenerated]
    public void f2(byte A_0)
    {
        this.ee = A_0;
    }

    [CompilerGenerated]
    public void f2(string A_0)
    {
        this.dv = A_0;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.ek = A_0;
    }

    [CompilerGenerated]
    public uint f3()
    {
        return this.d3;
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.ea = A_0;
    }

    [CompilerGenerated]
    public uint f4()
    {
        return this.d0;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.eb = A_0;
    }

    [CompilerGenerated]
    public uint f5()
    {
        return this.d1;
    }

    [CompilerGenerated]
    public void f5(uint A_0)
    {
        this.ds = A_0;
    }

    [CompilerGenerated]
    public byte f6()
    {
        return this.eg;
    }

    [CompilerGenerated]
    public void f6(uint A_0)
    {
        this.ej = A_0;
    }

    [CompilerGenerated]
    public uint f7()
    {
        return this.ea;
    }

    [CompilerGenerated]
    public void f7(uint A_0)
    {
        this.dp = A_0;
    }

    [CompilerGenerated]
    public uint f8()
    {
        return this.dz;
    }

    [CompilerGenerated]
    public void f8(uint A_0)
    {
        this.dl = A_0;
    }

    [CompilerGenerated]
    public uint f9()
    {
        return this.d4;
    }

    [CompilerGenerated]
    public void f9(uint A_0)
    {
        this.dr = A_0;
    }

    [CompilerGenerated]
    public uint g0()
    {
        return this.d8;
    }

    [CompilerGenerated]
    public uint g1()
    {
        return this.d9;
    }

    [CompilerGenerated]
    public uint ga()
    {
        return this.@do;
    }

    [CompilerGenerated]
    public void ga(uint A_0)
    {
        this.dn = A_0;
    }

    [CompilerGenerated]
    public uint gb()
    {
        return this.ei;
    }

    [CompilerGenerated]
    public void gb(uint A_0)
    {
        this.eh = A_0;
    }

    [CompilerGenerated]
    public uint gc()
    {
        return this.ej;
    }

    [CompilerGenerated]
    public void gc(uint A_0)
    {
        this.dz = A_0;
    }

    [CompilerGenerated]
    public uint gd()
    {
        return this.eb;
    }

    [CompilerGenerated]
    public void gd(uint A_0)
    {
        this.dq = A_0;
    }

    [CompilerGenerated]
    public uint ge()
    {
        return this.dq;
    }

    [CompilerGenerated]
    public void ge(uint A_0)
    {
        this.dy = A_0;
    }

    [CompilerGenerated]
    public byte gf()
    {
        return this.ee;
    }

    [CompilerGenerated]
    public void gf(uint A_0)
    {
        this.ef = A_0;
    }

    [CompilerGenerated]
    public uint gg()
    {
        return this.ef;
    }

    [CompilerGenerated]
    public void gg(uint A_0)
    {
        this.d3 = A_0;
    }

    [CompilerGenerated]
    public uint gh()
    {
        return this.ec;
    }

    [CompilerGenerated]
    public void gh(uint A_0)
    {
        this.d4 = A_0;
    }

    [CompilerGenerated]
    public uint gi()
    {
        return this.ed;
    }

    [CompilerGenerated]
    public void gi(uint A_0)
    {
        this.dk = A_0;
    }

    public void gj()
    {
        List<byte> list = new List<byte>();
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gu())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gy())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.gr().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.gr()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gp())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.ga())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gt())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.ge())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gl())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gs())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gq())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.go())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f2().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f2()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gx())));
        list.Add(this.gw());
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f4())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f5())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gn())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f3())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f9())));
        list.AddRange(Encoding.ASCII.GetBytes(this.gv()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f1())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.g0())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.g1())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f7())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gd())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gh())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gi())));
        list.Add(this.gf());
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gg())));
        list.Add(this.f6());
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gk())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb())));
        base.f0(list.ToArray());
    }

    [CompilerGenerated]
    public void gj(uint A_0)
    {
        this.@do = A_0;
    }

    [CompilerGenerated]
    public uint gk()
    {
        return this.eh;
    }

    [CompilerGenerated]
    public void gk(uint A_0)
    {
        this.d2 = A_0;
    }

    [CompilerGenerated]
    public uint gl()
    {
        return this.dr;
    }

    [CompilerGenerated]
    public void gl(uint A_0)
    {
        this.dw = A_0;
    }

    [CompilerGenerated]
    public uint gm()
    {
        return this.ek;
    }

    [CompilerGenerated]
    public void gm(uint A_0)
    {
        this.du = A_0;
    }

    [CompilerGenerated]
    public uint gn()
    {
        return this.d2;
    }

    [CompilerGenerated]
    public void gn(uint A_0)
    {
        this.ei = A_0;
    }

    [CompilerGenerated]
    public uint go()
    {
        return this.du;
    }

    [CompilerGenerated]
    public void go(uint A_0)
    {
        this.dt = A_0;
    }

    [CompilerGenerated]
    public uint gp()
    {
        return this.dn;
    }

    [CompilerGenerated]
    public void gp(uint A_0)
    {
        this.ec = A_0;
    }

    [CompilerGenerated]
    public uint gq()
    {
        return this.dt;
    }

    [CompilerGenerated]
    public void gq(uint A_0)
    {
        this.ed = A_0;
    }

    [CompilerGenerated]
    public string gr()
    {
        return this.dm;
    }

    [CompilerGenerated]
    public void gr(uint A_0)
    {
        this.d0 = A_0;
    }

    [CompilerGenerated]
    public uint gs()
    {
        return this.ds;
    }

    [CompilerGenerated]
    public void gs(uint A_0)
    {
        this.d1 = A_0;
    }

    [CompilerGenerated]
    public uint gt()
    {
        return this.dp;
    }

    [CompilerGenerated]
    public void gt(uint A_0)
    {
        this.d8 = A_0;
    }

    [CompilerGenerated]
    public uint gu()
    {
        return this.dk;
    }

    [CompilerGenerated]
    public void gu(uint A_0)
    {
        this.d9 = A_0;
    }

    [CompilerGenerated]
    public string gv()
    {
        return this.d5;
    }

    [CompilerGenerated]
    public byte gw()
    {
        return this.dx;
    }

    [CompilerGenerated]
    public uint gx()
    {
        return this.dw;
    }

    [CompilerGenerated]
    public uint gy()
    {
        return this.dl;
    }

    [CompilerGenerated]
    public uint gz()
    {
        return this.dy;
    }
}

