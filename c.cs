using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ultrapowa_Clash_Server.World;

internal class c : p
{
    [CompilerGenerated]
    private string k;
    [CompilerGenerated]
    private uint l;
    [CompilerGenerated]
    private List<Clan> m;
    [CompilerGenerated]
    private uint n;
    [CompilerGenerated]
    private uint o;
    [CompilerGenerated]
    private uint p;
    [CompilerGenerated]
    private uint q;
    [CompilerGenerated]
    private uint r;
    [CompilerGenerated]
    private uint s;
    [CompilerGenerated]
    private uint t;

    public c(af A_0) : base(A_0)
    {
        this.f0(new List<Clan>());
        this.f6(0x12);
        this.f3(80);
        this.f1(0x29a);
        this.f4(0);
        this.f7(7);
        this.f0((uint) 2);
        this.f5(0);
    }

    public c(af A_0, string A_1, List<Clan> A_2) : this(A_0)
    {
        base.f1(0x5ef6);
        base.f0((ushort) 0);
        this.f0(A_1);
        this.f2((uint) A_2.Count);
        this.f0(A_2);
        this.f3();
        base.f0(1);
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.p;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.s = A_0;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.k = A_0;
    }

    [CompilerGenerated]
    public void f0(List<Clan> A_0)
    {
        this.m = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.s;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.p = A_0;
    }

    [CompilerGenerated]
    public string f2()
    {
        return this.k;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.l = A_0;
    }

    public void f3()
    {
        c.a a = new c.a {
            b = this,
            a = new List<byte>()
        };
        a.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f2().Length)));
        a.a.AddRange(Encoding.ASCII.GetBytes(this.f2()));
        a.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f8())));
        this.f6().ForEach(new Action<Clan>(a.c));
        base.f0(a.a.ToArray());
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.o = A_0;
    }

    [CompilerGenerated]
    public uint f4()
    {
        return this.n;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.q = A_0;
    }

    [CompilerGenerated]
    public uint f5()
    {
        return this.r;
    }

    [CompilerGenerated]
    public void f5(uint A_0)
    {
        this.t = A_0;
    }

    [CompilerGenerated]
    public List<Clan> f6()
    {
        return this.m;
    }

    [CompilerGenerated]
    public void f6(uint A_0)
    {
        this.n = A_0;
    }

    [CompilerGenerated]
    public uint f7()
    {
        return this.q;
    }

    [CompilerGenerated]
    public void f7(uint A_0)
    {
        this.r = A_0;
    }

    [CompilerGenerated]
    public uint f8()
    {
        return this.l;
    }

    [CompilerGenerated]
    public uint f9()
    {
        return this.t;
    }

    [CompilerGenerated]
    public uint ga()
    {
        return this.o;
    }

    [CompilerGenerated]
    private sealed class a
    {
        public List<byte> a;
        public c b;

        public void c(Clan A_0)
        {
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f4())));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.ClanId)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) A_0.ClanName.Length)));
            this.a.AddRange(Encoding.ASCII.GetBytes(A_0.ClanName));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.Shield)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.ClanStatus)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.ga())));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f0())));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f7())));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f5())));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f1())));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.b.f9())));
        }
    }
}

