using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Helpers;

internal class f
{
    [CompilerGenerated]
    private uint a;
    [CompilerGenerated]
    private uint b;
    [CompilerGenerated]
    private uint c;
    [CompilerGenerated]
    private uint d;

    public f(BinaryReader A_0)
    {
        this.e(A_0.ReadUInt32WithEndian());
        this.h(A_0.ReadUInt32WithEndian());
        this.f(A_0.ReadUInt32WithEndian());
        this.g(A_0.ReadUInt32WithEndian());
    }

    [CompilerGenerated]
    public uint e()
    {
        return this.b;
    }

    [CompilerGenerated]
    public void e(uint A_0)
    {
        this.a = A_0;
    }

    [CompilerGenerated]
    public uint f()
    {
        return this.a;
    }

    [CompilerGenerated]
    public void f(uint A_0)
    {
        this.c = A_0;
    }

    [CompilerGenerated]
    public uint g()
    {
        return this.d;
    }

    [CompilerGenerated]
    public void g(uint A_0)
    {
        this.d = A_0;
    }

    [CompilerGenerated]
    public uint h()
    {
        return this.c;
    }

    [CompilerGenerated]
    public void h(uint A_0)
    {
        this.b = A_0;
    }
}

