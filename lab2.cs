using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab2
{

    public struct valKek
    {
        private int post1;
        public valKek(int intValue)
        {
            this.post1 = intValue;
        }
        public void Set(int intValue)
        {
            this.post1 = intValue;
        }
        public int Show()
        {
            return this.post1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ///1a
            sbyte sbyte1 = 4;
            byte byte1 = 5;
            short short1 = 12;
            ushort ushort1 = 14;
            int int1 = 156;
            uint uint1 = 142;
            long long1 = 1111;
            ulong ulong1 = 1890;
            char char1 = 'c';
            float float1 = 12.5f;
            double double1 = 12e-2;
            bool bool1 = true;
            decimal decimal1 = 14245151m;
            ///1b
            int1 = char1;
            long1 = uint1;
            double1 = float1;
            short1 = sbyte1;
            float1 = int1;
            byte1 = (byte)int1;
            long1 = (long)uint1;
            double1 = (double)float1;
            short1 = (short)sbyte1;
            float1 = (float)int1;
            ///1c
            valKek value1 = new valKek(9);
            Object o = (Object)value1;
            valKek value2 = (valKek)o;
            Console.WriteLine(" = {0}", value2.Show());
            ///1d
            var varWtf = 15;
            int int2 = int1 + varWtf;
            ///2a
            string s1 = "this is first string";
            string s2 = " and this is second string";
            bool boolRes = String.Compare(s1, s2) == 0;
            Console.WriteLine("String compare result: {0}", boolRes);
            ///2b
            string s3 = String.Copy(s1);
            Console.WriteLine("Substr: {0}", s1.Substring(5, 3));
            Console.WriteLine("Insert: {0}", s1.Insert(5, "[insert]"));
            Console.WriteLine("Remove: {0}", s1.Remove(5, 8));
            string[] sSeparate = s3.Split(' ');
            Console.Write("Split: ");
            foreach (string sForOut in sSeparate)
                Console.Write($"{sForOut} ");
            Console.Write("\n");
            ///2d
            StringBuilder sb = new StringBuilder();
            string s4 = sb.AppendLine("!his is Jac").Remove(0, 1).Insert(0, "T").Insert(11, "k").ToString();
            Console.Write("StringBuilder: {0}", s4);
            ///3a
            int[,] intarr1 = new int[,] { { 15, 25, 35 }, { 26, 37, 89 } }; int key = 0;
            foreach (int intElem in intarr1)
            {
                Console.Write("{0} ", intElem);
                key++;
                if (key % 3 == 0)
                    Console.WriteLine();
            }
            ///3b
            string[] arrstr1 = new string[] { "qwe", "rty", "asd", "fgh", "zxc" };
            foreach (string strS in arrstr1)
                Console.Write("{0} ", strS);
            Console.WriteLine("\nLength = {0}", arrstr1.Length);
            int intPos;
            string strForChange;
            Console.WriteLine("Input position and value: ");
            intPos = Int32.Parse(Console.ReadLine());
            strForChange = Console.ReadLine();
            arrstr1[intPos] = strForChange;
            foreach (string strS in arrstr1)
                Console.Write("{0} ", strS);
            Console.WriteLine("\nLength = {0}", arrstr1.Length);
            ///3c
            double[][] arrdouble1 = new double[3][];
            arrdouble1[0] = new double[2];
            arrdouble1[1] = new double[3];
            arrdouble1[2] = new double[4];
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("[{0}]... - {1} double", j, j + 2);
                for (int i = 0; i < j + 2; i++)
                    arrdouble1[j][i] = Double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                foreach (double doubleElem in arrdouble1[i])
                {
                    Console.Write("{0} ", doubleElem);
                }
                Console.WriteLine();
            }
            ///3d
            var varArr = new[] { "qwe", "rrr" };
            ///4a
            (int, string, char, string, ulong) tuple1 = (5, "qwe", 'c', "qwe", 12);
            ///4b
            var tuple2 = (one: 5, two: "qwe", three: 'c', four: "qwe", five: 12);
            ///4c
            Console.WriteLine("all: {0} {1} {2} {3} {4} not: {5} {6} {7}", tuple2.one, tuple2.two, tuple2.three,
                tuple2.four, tuple2.five, tuple2.one, tuple2.three, tuple2.four);
            ///4d
            int ti1;
            string ti2;
            char ti3;
            string ti4;
            ulong ti5;
            (ti1, ti2, ti3, ti4, ti5) = tuple1;
            Console.WriteLine($"Tuple1: {ti1} {ti2} {ti3} {ti4} {ti5}");
            ///4e
            (int, string, char, string, ulong) tuple3 = (5, "qwe", 'c', "qwer", 12);
            Console.WriteLine(tuple1.CompareTo(tuple3));
            ///5
            (int first, int last, int sum, char c) Kek(int[] intArr, string strP)
            {
                int maxRe = intArr[0];
                int minRe = intArr[0];
                int sumRe = 0;
                char charRe = strP[0];
                foreach(int i in intArr)
                {
                    if (i > maxRe)
                        maxRe = i;
                    if (i < minRe)
                        minRe = i;
                    sumRe += i;
                }
                return (maxRe, minRe, sumRe, charRe);
            }
            int[] intArrr = new int[] { 12, 24, 45, 667, 0 };
            Console.WriteLine("{0} {1} {2} {3}", Kek(intArrr, "qwe").first, Kek(intArrr, "qwe").last,
                Kek(intArrr, "qwe").sum, Kek(intArrr, "qwe").c);
        }
    }
}
