using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

internal static class w
{
    private static readonly object a = new object();
    private static readonly TextWriter b = TextWriter.Synchronized(File.AppendText("ucslog.txt"));

    public static void a(p A_0, [Optional, DefaultParameterValue(null)] string A_1)
    {
        lock (a)
        {
            b.Write("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            b.Write(";");
            if (A_1 != null)
            {
                b.Write(A_1);
                b.Write(";");
            }
            b.Write(A_0.g7().ToString());
            b.Write("(");
            b.Write(A_0.g8().ToString());
            b.Write(")");
            b.Write(";");
            b.Write(A_0.g3().ToString());
            b.Write(";");
            b.WriteLine(A_0.g4());
            b.WriteLine(Regex.Replace(A_0.ToString(), @"[^\u0020-\u007F]", "."));
            b.Flush();
        }
    }

    public static void a(string A_0, [Optional, DefaultParameterValue(null)] string A_1)
    {
        lock (a)
        {
            b.Write("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            b.Write(";");
            if (A_1 != null)
            {
                b.Write(A_1);
                b.Write(";");
            }
            b.WriteLine(A_0);
            b.Flush();
        }
    }
}

