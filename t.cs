using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

internal class t : p
{
    [CompilerGenerated]
    private uint el;
    [CompilerGenerated]
    private string em;
    [CompilerGenerated]
    private uint en;
    [CompilerGenerated]
    private string eo;
    [CompilerGenerated]
    private string ep;
    [CompilerGenerated]
    private uint eq;
    [CompilerGenerated]
    private uint er;

    public t(af A_0, string A_1) : base(A_0)
    {
        base.f1(0x4e87);
        base.f0((ushort) 3);
        this.f2((uint) 7);
        this.f1(A_1);
        this.f0(uint.MaxValue);
        this.f2(ConfigurationManager.AppSettings["patchingServer"]);
        this.f0("market://details?id=com.supercell.clashofclans");
        this.f1(uint.MaxValue);
        this.f3(uint.MaxValue);
        this.f3();
        base.f0(1);
    }

    [CompilerGenerated]
    public uint f0()
    {
        return this.eq;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.ep = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.en = A_0;
    }

    [CompilerGenerated]
    public string f1()
    {
        return this.ep;
    }

    [CompilerGenerated]
    public void f1(string A_0)
    {
        this.em = A_0;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.eq = A_0;
    }

    [CompilerGenerated]
    public uint f2()
    {
        return this.en;
    }

    [CompilerGenerated]
    public void f2(string A_0)
    {
        this.eo = A_0;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.el = A_0;
    }

    public void f3()
    {
        List<byte> list = new List<byte>();
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f4())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f7().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f7()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f2())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f6().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f6()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f1().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f1()));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f5())));
        base.f0(list.ToArray());
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.er = A_0;
    }

    [CompilerGenerated]
    public uint f4()
    {
        return this.el;
    }

    [CompilerGenerated]
    public uint f5()
    {
        return this.er;
    }

    [CompilerGenerated]
    public string f6()
    {
        return this.eo;
    }

    [CompilerGenerated]
    public string f7()
    {
        return this.em;
    }
}

