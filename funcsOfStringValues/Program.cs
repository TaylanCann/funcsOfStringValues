using System;

namespace funcsOfStringValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz lütfen : ");

            string denemeDegiskeni;
            denemeDegiskeni = Console.ReadLine();
            //Console.WriteLine(denemeDegiskeni.AsMemory);
            denemeDegiskeni.AsMemory();
            denemeDegiskeni.AsSpan();
            denemeDegiskeni.Clone();
            //denemeDegiskeni.CompareTo();
            //denemeDegiskeni.Contains();
            //denemeDegiskeni.CopyTo();
            //denemeDegiskeni.EndsWith();
            denemeDegiskeni.EnumerateRunes();
            //denemeDegiskeni.Equals();
            denemeDegiskeni.GetEnumerator();
            denemeDegiskeni.GetHashCode();
            denemeDegiskeni.GetType();
            denemeDegiskeni.GetTypeCode();
            //denemeDegiskeni.IndexOf();
            //denemeDegiskeni.IndexOfAny();
            //denemeDegiskeni.Insert();
            denemeDegiskeni.IsNormalized();
            //denemeDegiskeni.LastIndexOf();
            //denemeDegiskeni.LastIndexOfAny();
            //denemeDegiskeni.Length();
            denemeDegiskeni.Normalize();
            //denemeDegiskeni.PadLeft();
            //denemeDegiskeni.PadRight();
            //denemeDegiskeni.Remove();
            //denemeDegiskeni.Replace();
            denemeDegiskeni.Split();
           // denemeDegiskeni.StartsWith();
           //denemeDegiskeni.Substring();
            denemeDegiskeni.ToCharArray();
            denemeDegiskeni.ToLower();
            denemeDegiskeni.ToLowerInvariant();
            denemeDegiskeni.ToString();
            denemeDegiskeni.ToUpper();
            denemeDegiskeni.ToUpperInvariant();
            denemeDegiskeni.Trim();
            denemeDegiskeni.TrimEnd();
            denemeDegiskeni.TrimStart();
            


            //denemeDegiskeni.IndexOf
            //denemeDegiskeni.Split
            //denemeDegiskeni.Contains
            //denemeDegiskeni.Substring
            //denemeDegiskeni.Substring

            Console.WriteLine($"Girilen kelime : {denemeDegiskeni}");


        }
    }
}
