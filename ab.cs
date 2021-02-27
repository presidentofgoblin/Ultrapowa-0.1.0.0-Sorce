using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Network;

internal class ab
{
    private const int a = 0x247b;
    private const int b = 10;
    private static Socket c;
    private IPAddress d;
    [CompilerGenerated]
    private static Func<IPAddress, bool> e;

    public static Socket a()
    {
        return c;
    }

    private void a(IAsyncResult A_0)
    {
        c = null;
    }

    public bool a(int A_0)
    {
        c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        try
        {
            c.Bind(new IPEndPoint(IPAddress.Any, A_0));
            c.Listen(10);
            c.BeginAccept(new AsyncCallback(this.c), c);
        }
        catch (Exception exception)
        {
            Console.WriteLine(string.Concat(new object[] { "Exception when attempting to host (", A_0, "): ", exception }));
            c = null;
            return false;
        }
        return true;
    }

    [CompilerGenerated]
    private static bool a(IPAddress A_0)
    {
        return (A_0.AddressFamily == AddressFamily.InterNetwork);
    }

    private void a(SocketRead A_0, byte[] A_1)
    {
        af af;
        p p;
        ac.f().TryGetValue(A_0.Socket, ref af);
        af.e().AddRange(A_1);
        while (af.e(out p))
        {
            n.b(p);
        }
    }

    private void a(SocketRead A_0, Exception A_1)
    {
        Console.WriteLine("Error received: " + A_1);
    }

    private void c()
    {
        if (c != null)
        {
            c.BeginDisconnect(false, new AsyncCallback(this.a), c);
        }
    }

    private void c(IAsyncResult A_0)
    {
        try
        {
            Socket socket = c.EndAccept(A_0);
            Console.WriteLine("Client connected (" + ((IPEndPoint) socket.get_RemoteEndPoint()).Address.ToString() + ":" + ((IPEndPoint) socket.get_RemoteEndPoint()).Port.ToString() + ")");
            ac.f().TryAdd(socket, new af(socket));
            SocketRead.Begin(socket, new SocketRead.IncomingReadHandler(this.a), new SocketRead.IncomingReadErrorHandler(this.a));
        }
        catch (Exception exception)
        {
            Console.WriteLine("Exception when accepting incoming connection: " + exception);
        }
        try
        {
            c.BeginAccept(new AsyncCallback(this.c), c);
        }
        catch (Exception exception2)
        {
            Console.WriteLine("Exception when starting new accept process: " + exception2);
        }
    }

    public void d()
    {
        if (this.a(0x247b))
        {
            Console.WriteLine("Gateway started on port " + 0x247b);
        }
    }

    public IPAddress e()
    {
        if (this.d == null)
        {
            if (e == null)
            {
                e = new Func<IPAddress, bool>(null, (IntPtr) a);
            }
            this.d = Enumerable.Where<IPAddress>(Dns.GetHostEntry(Dns.GetHostName()).AddressList, e).FirstOrDefault<IPAddress>();
        }
        return this.d;
    }
}

