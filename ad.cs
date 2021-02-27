using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ultrapowa_Clash_Server.World;

internal class ad : p
{
    [CompilerGenerated]
    private uint e1;
    [CompilerGenerated]
    private uint e2;
    [CompilerGenerated]
    private uint e3;
    [CompilerGenerated]
    private uint e4;
    [CompilerGenerated]
    private string e5;
    [CompilerGenerated]
    private uint e6;
    [CompilerGenerated]
    private uint e7;
    [CompilerGenerated]
    private uint e8;
    [CompilerGenerated]
    private uint e9;
    [CompilerGenerated]
    private uint fa;
    [CompilerGenerated]
    private string fb;
    [CompilerGenerated]
    private uint fc;
    [CompilerGenerated]
    private uint fd;
    [CompilerGenerated]
    private uint fe;
    [CompilerGenerated]
    private string ff;
    [CompilerGenerated]
    private string fg;
    [CompilerGenerated]
    private string fh;
    [CompilerGenerated]
    private uint fi;
    [CompilerGenerated]
    private string fj;

    public ad(af A_0) : base(A_0)
    {
        base.f1(0x4e88);
        base.f0((ushort) 1);
        this.f9(0x2a);
        this.ga(0x15d800);
        this.f8(0x2a);
        this.gb(0x15d800);
        this.f0("somelogin");
        this.f1(uint.MaxValue);
        this.f5(uint.MaxValue);
        this.f0((uint) 6);
        this.f2((uint) 0xba);
        this.f6(3);
        this.f5("prod");
        this.f3((uint) 0x107);
        this.f4((uint) 0x772b);
        this.f7(8);
        this.f4("someid");
        this.f1("1407058146163");
        this.f3("1406320803000");
        this.gc(0);
        this.f2("somedata");
        this.f6();
    }

    public ad(af A_0, Player A_1) : this(A_0)
    {
        this.f0(A_1.Login);
        this.f9(A_1.Region);
        this.ga(A_1.PlayerId);
        this.f8(A_1.Region);
        this.gb(A_1.PlayerId);
        this.f6();
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.fi;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.e5 = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.e8 = A_0;
    }

    [CompilerGenerated]
    public string f1()
    {
        return this.fj;
    }

    [CompilerGenerated]
    public void f1(string A_0)
    {
        this.fg = A_0;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.e6 = A_0;
    }

    [CompilerGenerated]
    public string f2()
    {
        return this.ff;
    }

    [CompilerGenerated]
    public void f2(string A_0)
    {
        this.fj = A_0;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.e9 = A_0;
    }

    [CompilerGenerated]
    public uint f3()
    {
        return this.fe;
    }

    [CompilerGenerated]
    public void f3(string A_0)
    {
        this.fh = A_0;
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.fc = A_0;
    }

    [CompilerGenerated]
    public string f4()
    {
        return this.e5;
    }

    [CompilerGenerated]
    public void f4(string A_0)
    {
        this.ff = A_0;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.fd = A_0;
    }

    [CompilerGenerated]
    public uint f5()
    {
        return this.e3;
    }

    [CompilerGenerated]
    public void f5(string A_0)
    {
        this.fb = A_0;
    }

    [CompilerGenerated]
    public void f5(uint A_0)
    {
        this.e7 = A_0;
    }

    public void f6()
    {
        List<byte> list = new List<byte>();
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f8())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gf())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f5())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gg())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f4().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f4()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f9())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.ge())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gd())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gc())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.ga())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.gh().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.gh()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gi())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f7())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f3())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f2().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f2()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.gb().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.gb()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.gj().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.gj()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f1().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f1()));
        base.f0(list.ToArray());
    }

    [CompilerGenerated]
    public void f6(uint A_0)
    {
        this.fa = A_0;
    }

    [CompilerGenerated]
    public uint f7()
    {
        return this.fd;
    }

    [CompilerGenerated]
    public void f7(uint A_0)
    {
        this.fe = A_0;
    }

    [CompilerGenerated]
    public uint f8()
    {
        return this.e1;
    }

    [CompilerGenerated]
    public void f8(uint A_0)
    {
        this.e3 = A_0;
    }

    [CompilerGenerated]
    public uint f9()
    {
        return this.e6;
    }

    [CompilerGenerated]
    public void f9(uint A_0)
    {
        this.e1 = A_0;
    }

    [CompilerGenerated]
    public uint ga()
    {
        return this.fa;
    }

    [CompilerGenerated]
    public void ga(uint A_0)
    {
        this.e2 = A_0;
    }

    [CompilerGenerated]
    public string gb()
    {
        return this.fg;
    }

    [CompilerGenerated]
    public void gb(uint A_0)
    {
        this.e4 = A_0;
    }

    [CompilerGenerated]
    public uint gc()
    {
        return this.e9;
    }

    [CompilerGenerated]
    public void gc(uint A_0)
    {
        this.fi = A_0;
    }

    [CompilerGenerated]
    public uint gd()
    {
        return this.e8;
    }

    [CompilerGenerated]
    public uint ge()
    {
        return this.e7;
    }

    [CompilerGenerated]
    public uint gf()
    {
        return this.e2;
    }

    [CompilerGenerated]
    public uint gg()
    {
        return this.e4;
    }

    [CompilerGenerated]
    public string gh()
    {
        return this.fb;
    }

    [CompilerGenerated]
    public uint gi()
    {
        return this.fc;
    }

    [CompilerGenerated]
    public string gj()
    {
        return this.fh;
    }
}

