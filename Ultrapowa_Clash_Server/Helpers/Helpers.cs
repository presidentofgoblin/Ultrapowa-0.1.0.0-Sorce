namespace Ultrapowa_Clash_Server.Helpers
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text;

    public static class Helpers
    {
        public static string ReadString(this BinaryReader br, uint count)
        {
            byte[] bytes = br.ReadBytes((int) count);
            return Encoding.ASCII.GetString(bytes);
        }

        public static uint ReadUInt16WithEndian(this BinaryReader br)
        {
            byte[] array = br.ReadBytes(2);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToUInt32(array, 0);
        }

        public static uint ReadUInt32WithEndian(this BinaryReader br)
        {
            byte[] array = br.ReadBytes(4);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(array);
            }
            return BitConverter.ToUInt32(array, 0);
        }
    }
}

