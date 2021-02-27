using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ultrapowa_Clash_Server.World;

internal class e : p
{
    [CompilerGenerated]
    private string af;
    [CompilerGenerated]
    private string ag;
    [CompilerGenerated]
    private uint ah;
    [CompilerGenerated]
    private uint ai;
    [CompilerGenerated]
    private uint aj;
    [CompilerGenerated]
    private uint ak;
    [CompilerGenerated]
    private uint al;
    [CompilerGenerated]
    private uint am;
    [CompilerGenerated]
    private byte an;

    public e(af A_0) : base(A_0)
    {
        base.f1(0x608b);
        base.f0((ushort) 0);
        this.f1("hello guys ?");
        this.f0("History");
        this.f3(5);
        this.f4(0);
        this.f2(0x2a);
        this.f5(0x15d800);
        this.f1((uint) 0x2a);
        this.f0((uint) 0x15d800);
        this.f0((byte) 0);
        this.f6();
        base.f0(2);
    }

    public e(af A_0, Player A_1, j A_2) : this(A_0)
    {
        base.f1(0x608b);
        base.f0((ushort) 0);
        this.f1(A_2.f0());
        this.f0(A_1.PlayerName);
        this.f2(A_1.Region);
        this.f5(A_1.PlayerId);
        this.f0(A_1.PlayerId);
        this.f1(A_1.Region);
        this.f6();
        base.f0(2);
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.al;
    }

    [CompilerGenerated]
    public void f0(byte A_0)
    {
        this.an = A_0;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.ag = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.am = A_0;
    }

    [CompilerGenerated]
    public byte f1()
    {
        return this.an;
    }

    [CompilerGenerated]
    public void f1(string A_0)
    {
        this.af = A_0;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.al = A_0;
    }

    [CompilerGenerated]
    public uint f2()
    {
        return this.aj;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.aj = A_0;
    }

    [CompilerGenerated]
    public uint f3()
    {
        return this.am;
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.ah = A_0;
    }

    [CompilerGenerated]
    public string f4()
    {
        return this.ag;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.ai = A_0;
    }

    [CompilerGenerated]
    public uint f5()
    {
        return this.ak;
    }

    [CompilerGenerated]
    public void f5(uint A_0)
    {
        this.ak = A_0;
    }

    public void f6()
    {
        List<byte> list = new List<byte>();
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f7().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f7()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f4().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f4()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f8())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f9())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f2())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f5())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f3())));
        list.Add(this.f1());
        base.f0(list.ToArray());
    }

    [CompilerGenerated]
    public string f7()
    {
        return this.af;
    }

    [CompilerGenerated]
    public uint f8()
    {
        return this.ah;
    }

    [CompilerGenerated]
    public uint f9()
    {
        return this.ai;
    }
}

