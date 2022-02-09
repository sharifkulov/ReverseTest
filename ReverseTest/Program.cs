using System;

namespace ReverseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] ByteArray = new byte[] { 7, 2, 3, 4 };            
            Reverse(ByteArray);
        }
        static byte[] Reverse(byte[] ByteArray)
        {
            byte[] reversed = new byte[ByteArray.Length];
            for (int i = 0; i < ByteArray.Length; i++)
            {
                 reversed[i] = (byte)((ByteArray[i] * 0x0202020202 & 0x010884422010) % 1023);
            }
            for (int i = 0; i < reversed.Length; i++)
            {
                Console.WriteLine(reversed[i]);
            }
                return reversed;
        }
    }
}
