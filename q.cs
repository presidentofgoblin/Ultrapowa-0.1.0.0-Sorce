using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ultrapowa_Clash_Server.World;

internal class q : p
{
    [CompilerGenerated]
    private uint ce;
    [CompilerGenerated]
    private List<Clan> cf;
    [CompilerGenerated]
    private uint cg;
    [CompilerGenerated]
    private uint ch;
    [CompilerGenerated]
    private uint ci;
    [CompilerGenerated]
    private uint cj;
    [CompilerGenerated]
    private uint ck;
    [CompilerGenerated]
    private uint cl;
    [CompilerGenerated]
    private uint cm;

    public q(af A_0) : base(A_0)
    {
        base.f1(0x5ef0);
        base.f0((ushort) 0);
        this.f0(new List<Clan>());
        this.f2(1);
        this.f6(0x12);
        this.f3(80);
        this.f1(0x29a);
        this.f4(0);
        this.f7(7);
        this.f0((uint) 2);
        this.f5(0);
    }

    public q(af A_0, List<Clan> A_1) : this(A_0)
    {
        this.f2((uint) A_1.Count);
        this.f0(A_1);
        this.f2();
        base.f0(1);
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.ci;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.cl = A_0;
    }

    [CompilerGenerated]
    public void f0(List<Clan> A_0)
    {
        this.cf = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.cl;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.ci = A_0;
    }

    public void f2()
    {
        q.a a = new q.a {
            b = this,
            a = new List<byte>()
        };
        a.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f7())));
        this.f5().ForEach(new Action<Clan>(a.c));
        base.f0(a.a.ToArray());
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.ce = A_0;
    }

    [CompilerGenerated]
    public uint f3()
    {
        return this.cg;
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.ch = A_0;
    }

    [CompilerGenerated]
    public uint f4()
    {
        return this.ck;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.cj = A_0;
    }

    [CompilerGenerated]
    public List<Clan> f5()
    {
        return this.cf;
    }

    [CompilerGenerated]
    public void f5(uint A_0)
    {
        this.cm = A_0;
    }

    [CompilerGenerated]
    public uint f6()
    {
        return this.cj;
    }

    [CompilerGenerated]
    public void f6(uint A_0)
    {
        this.cg = A_0;
    }

    [CompilerGenerated]
    public uint f7()
    {
        return this.ce;
    }

    [CompilerGenerated]
    public void f7(uint A_0)
    {
        this.ck = A_0;
    }

    [CompilerGenerated]
    public uint f8()
    {
        return this.cm;
    }

    [CompilerGenerated]
    public uint f9()
    {
        return this.ch;
    }

    [CompilerGenerated]
    private sealed class a
    {
        public List<byte> a;
        public q b;

        public void c(Clan A_0)
        {
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f3())));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.ClanId)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) A_0.ClanName.Length)));
            this.a.AddRange(Encoding.ASCII.GetBytes(A_0.ClanName));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.Shield)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.ClanStatus)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f9())));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f0())));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f6())));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f4())));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f1())));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f8())));
        }
    }
}

