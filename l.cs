using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

internal class l : p
{
    [CompilerGenerated]
    private uint bl;
    [CompilerGenerated]
    private uint bm;
    [CompilerGenerated]
    private uint bn;
    [CompilerGenerated]
    private uint bo;
    [CompilerGenerated]
    private string bp;
    [CompilerGenerated]
    private uint bq;
    [CompilerGenerated]
    private byte br;
    [CompilerGenerated]
    private uint bs;
    [CompilerGenerated]
    private uint bt;

    public l(af A_0) : base(A_0)
    {
        base.f1(0x5e2f);
        base.f0((ushort) 0);
        this.f2(1);
        this.f4(0x2a);
        this.f0((uint) 0x86abe);
        this.f0("Super ClanName");
        this.f5((uint) this.f3().Length);
        this.f1(0xc65d59);
        this.f0((byte) 1);
        this.f6(2);
        this.f3(uint.MaxValue);
        this.f6();
        base.f0(1);
    }

    public l(p A_0) : this(A_0.g9())
    {
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.bt;
    }

    [CompilerGenerated]
    public void f0(byte A_0)
    {
        this.br = A_0;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.bp = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.bn = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.bs;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.bq = A_0;
    }

    [CompilerGenerated]
    public uint f2()
    {
        return this.bn;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.bl = A_0;
    }

    [CompilerGenerated]
    public string f3()
    {
        return this.bp;
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.bt = A_0;
    }

    [CompilerGenerated]
    public uint f4()
    {
        return this.bo;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.bm = A_0;
    }

    [CompilerGenerated]
    public byte f5()
    {
        return this.br;
    }

    [CompilerGenerated]
    public void f5(uint A_0)
    {
        this.bo = A_0;
    }

    public void f6()
    {
        List<byte> list = new List<byte>();
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f7())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f8())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f2())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f4())));
        list.AddRange(Encoding.ASCII.GetBytes(this.f3()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f9())));
        list.Add(this.f5());
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f1())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0())));
        base.f0(list.ToArray());
    }

    [CompilerGenerated]
    public void f6(uint A_0)
    {
        this.bs = A_0;
    }

    [CompilerGenerated]
    public uint f7()
    {
        return this.bl;
    }

    [CompilerGenerated]
    public uint f8()
    {
        return this.bm;
    }

    [CompilerGenerated]
    public uint f9()
    {
        return this.bq;
    }
}

