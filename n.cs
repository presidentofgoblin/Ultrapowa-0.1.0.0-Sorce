using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Ultrapowa_Clash_Server.World;

internal class n
{
    private static EventWaitHandle a = new AutoResetEvent(false);
    private static EventWaitHandle b = new AutoResetEvent(false);
    private static ConcurrentQueue<p> c = new ConcurrentQueue<p>();
    private static ConcurrentQueue<p> d = new ConcurrentQueue<p>();
    private bool e = false;

    private void a()
    {
        while (this.e)
        {
            p p;
            b.WaitOne();
            while (d.TryDequeue(ref p))
            {
                w.a(p, "S");
                this.a(p.g9().g(), p.g6());
                try
                {
                    p.g9().f().Send(p.g2());
                    Console.WriteLine("S " + p.g7().ToString() + " (" + p.g3().ToString() + ")");
                    continue;
                }
                catch (Exception)
                {
                    af af;
                    Player player;
                    ac.f().TryRemove(p.g9().f(), ref af);
                    ac.i().TryRemove(p.g9(), ref player);
                    continue;
                }
            }
        }
    }

    public static void a(p A_0)
    {
        switch (A_0.g5())
        {
            case 1:
                d.Enqueue(A_0);
                break;

            case 2:
                foreach (KeyValuePair<Socket, af> pair in ac.f())
                {
                    p p = new p(pair.Value, A_0.g2());
                    d.Enqueue(p);
                }
                break;

            case 3:
                d.Enqueue(A_0);
                break;

            case 4:
                d.Enqueue(A_0);
                break;
        }
        b.Set();
    }

    private void a(byte[] A_0, byte[] A_1)
    {
        if (A_1 != null)
        {
            int length = A_1.Length;
            if (length >= 1)
            {
                do
                {
                    length--;
                    byte num2 = (byte) (A_0[0] + 1);
                    A_0[0] = num2;
                    byte num3 = (byte) (A_0[4] + A_0[num2 + 8]);
                    A_0[4] = num3;
                    byte num4 = A_0[num2 + 8];
                    A_0[num2 + 8] = A_0[num3 + 8];
                    A_0[A_0[4] + 8] = num4;
                    byte num5 = A_0[((byte) (A_0[A_0[4] + 8] + A_0[A_0[0] + 8])) + 8];
                    A_1[(A_1.Length - length) - 1] = (byte) (A_1[(A_1.Length - length) - 1] ^ num5);
                }
                while (length > 0);
            }
        }
    }

    private void b()
    {
        while (this.e)
        {
            p p;
            a.WaitOne();
            while (c.TryDequeue(ref p))
            {
                this.a(p.g9().h(), p.g6());
                Console.WriteLine("R " + p.g7().ToString() + " (" + p.g3().ToString() + ")");
                w.a(p, "R");
                aj.a(p);
            }
        }
    }

    public static void b(p A_0)
    {
        c.Enqueue(A_0);
        a.Set();
    }

    public void c()
    {
        new n.b(this.b).BeginInvoke(null, null);
        new n.a(this.a).BeginInvoke(null, null);
        this.e = true;
        Console.WriteLine("PacketHandler started");
    }

    private delegate void a();

    private delegate void b();
}

