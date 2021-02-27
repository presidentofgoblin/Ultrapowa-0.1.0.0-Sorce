using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ultrapowa_Clash_Server.World;

internal class z : p
{
    [CompilerGenerated]
    private uint e0;
    [CompilerGenerated]
    private uint ex;
    [CompilerGenerated]
    private string ey;
    [CompilerGenerated]
    private uint ez;

    public z(af A_0) : base(A_0)
    {
        base.f1(0x5e2f);
        base.f0((ushort) 0);
        this.f0((uint) 3);
        this.f0("Megapumba");
        this.f2(1);
        this.f1(uint.MaxValue);
        this.f2();
        base.f0(1);
    }

    public z(af A_0, Player A_1) : this(A_0)
    {
        this.f0(A_1.PlayerName);
        this.f2();
        base.f0(1);
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.e0;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.ey = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.ex = A_0;
    }

    [CompilerGenerated]
    public string f1()
    {
        return this.ey;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.e0 = A_0;
    }

    public void f2()
    {
        List<byte> list = new List<byte>();
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f4())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f1().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f1()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f3())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0())));
        base.f0(list.ToArray());
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.ez = A_0;
    }

    [CompilerGenerated]
    public uint f3()
    {
        return this.ez;
    }

    [CompilerGenerated]
    public uint f4()
    {
        return this.ex;
    }
}

