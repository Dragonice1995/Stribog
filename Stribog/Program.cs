using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stribog
{
    class Program
    {
        static void Main(string[] args)
        {
            Stribog hash = new Stribog(Stribog.lengthHash.Length512);
            byte[] M1 = 
            {
                0x32, 0x31, 0x30, 0x39, 0x38, 0x37, 0x36, 0x35,
                0x34, 0x33, 0x32, 0x31, 0x30, 0x39, 0x38, 0x37, 
                0x36, 0x35, 0x34, 0x33, 0x32, 0x31, 0x30, 0x39, 
                0x38, 0x37, 0x36, 0x35, 0x34, 0x33, 0x32, 0x31, 
                0x30, 0x39, 0x38, 0x37, 0x36, 0x35, 0x34, 0x33, 
                0x32, 0x31, 0x30, 0x39, 0x38, 0x37, 0x36, 0x35, 
                0x34, 0x33, 0x32, 0x31, 0x30, 0x39, 0x38, 0x37, 
                0x36, 0x35, 0x34, 0x33, 0x32, 0x31, 0x30
            };
            byte[] a = hash.GetHash(M1);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i].ToString("x2") + " ");
            }
            Console.WriteLine();
            Console.WriteLine("================================================");
            Stribog hash2 = new Stribog(Stribog.lengthHash.Length256);
            byte[] b = hash2.GetHash(M1);
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i].ToString("x2") + " ");
            }
            Console.WriteLine();
            Console.WriteLine("================================================");
            Stribog hash3 = new Stribog(Stribog.lengthHash.Length512);
            byte[] M2 = 
            {
                0xfb, 0xe2, 0xe5, 0xf0, 0xee, 0xe3, 0xc8, 0x20,
                0xfb, 0xea, 0xfa, 0xeb, 0xef, 0x20, 0xff, 0xfb, 
                0xf0, 0xe1, 0xe0, 0xf0, 0xf5, 0x20, 0xe0, 0xed, 
                0x20, 0xe8, 0xec, 0xe0, 0xeb, 0xe5, 0xf0, 0xf2, 
                0xf1, 0x20, 0xff, 0xf0, 0xee, 0xec, 0x20, 0xf1, 
                0x20, 0xfa, 0xf2, 0xfe, 0xe5, 0xe2, 0x20, 0x2c, 
                0xe8, 0xf6, 0xf3, 0xed, 0xe2, 0x20, 0xe8, 0xe6, 
                0xee, 0xe1, 0xe8, 0xf0, 0xf2, 0xd1, 0x20, 0x2c, 
                0xe8, 0xf0, 0xf2, 0xe5, 0xe2, 0x20, 0xe5, 0xd1
            };
            byte[] c = hash.GetHash(M2);
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i].ToString("x2") + " ");
            }
            Console.WriteLine();
            Console.WriteLine("================================================");
            Stribog hash4 = new Stribog(Stribog.lengthHash.Length256);
            byte[] d = hash2.GetHash(M2);
            for (int i = 0; i < d.Length; i++)
            {
                Console.Write(d[i].ToString("x2") + " ");
            }
            Console.ReadKey();
        }
    }
}
