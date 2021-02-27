namespace Ultrapowa_Clash_Server.Network
{
    using System;
    using System.Net.Sockets;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class SocketRead
    {
        private System.Net.Sockets.Socket a;
        private IncomingReadHandler b;
        private IncomingReadErrorHandler c;
        private byte[] d = new byte[0x100];
        public const int kBufferSize = 0x100;

        private SocketRead(System.Net.Sockets.Socket A_0, IncomingReadHandler A_1, [Optional, DefaultParameterValue(null)] IncomingReadErrorHandler A_2)
        {
            this.a = A_0;
            this.b = A_1;
            this.c = A_2;
            this.a();
        }

        private void a()
        {
            this.a.BeginReceive(this.d, 0, 0x100, SocketFlags.None, new AsyncCallback(this.a), this);
        }

        private void a(IAsyncResult A_0)
        {
            try
            {
                if (A_0.IsCompleted)
                {
                    int length = this.a.EndReceive(A_0);
                    if (length > 0)
                    {
                        byte[] destinationArray = new byte[length];
                        Array.Copy(this.d, 0, destinationArray, 0, length);
                        this.b(this, destinationArray);
                        Begin(this.a, this.b, this.c);
                    }
                }
            }
            catch (Exception exception)
            {
                if (this.c != null)
                {
                    this.c(this, exception);
                }
            }
        }

        public static SocketRead Begin(System.Net.Sockets.Socket socket, IncomingReadHandler readHandler, [Optional, DefaultParameterValue(null)] IncomingReadErrorHandler errorHandler)
        {
            return new SocketRead(socket, readHandler, errorHandler);
        }

        public System.Net.Sockets.Socket Socket
        {
            get
            {
                return this.a;
            }
        }

        public delegate void IncomingReadErrorHandler(SocketRead read, Exception exception);

        public delegate void IncomingReadHandler(SocketRead read, byte[] data);
    }
}

