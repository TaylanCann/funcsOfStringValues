using System;

namespace funcsOfStringValues
{
    class Program
    {

        /// Taylan Can Hardal Project
 
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence: ");
            string tempVariable = GetVariable();

            AsMemory(tempVariable);
            AsSpan(tempVariable);
            Clone(tempVariable);
            CompareTo(tempVariable);
            Contains(tempVariable);
            EndWith(tempVariable);
            Equals(tempVariable);
            GetHashCode(tempVariable);
            GetType(tempVariable);
            GetTypeCode(tempVariable);
            IndexOf(tempVariable);
            Insert(tempVariable);
            IsNormalized(tempVariable);
            LastIndexOf(tempVariable);
            Length(tempVariable);
            Normalized(tempVariable);
            PadLeft(tempVariable);
            PadRight(tempVariable);
            Remove(tempVariable);
            Replace(tempVariable);
            Split(tempVariable);

            StartsWith(tempVariable);

            Substring(tempVariable);

            ToCharArray(tempVariable);

            ToLower(tempVariable);

            NewMethod(tempVariable);

            tempVariable.Trim();

        }

        private static void Substring(string tempVariable)
        {
            tempVariable.Substring(1);
        }

        private static void NewMethod(string tempVariable)
        {
            tempVariable.ToUpper();
        }

        private static void ToLower(string tempVariable)
        {
            tempVariable.ToLower();
        }

        private static void ToCharArray(string tempVariable)
        {
            var toCharArray = tempVariable.ToCharArray();
            Console.WriteLine($"To Char Array :  {toCharArray}");
        }

        private static void StartsWith(string tempVariable)
        {
            Console.WriteLine("Please enter the char that check you want");
            var startChar = GetVariable();
            var startsWith = tempVariable.StartsWith(startChar);
            Console.WriteLine($"Starts With : {startsWith}");
        }

        private static void Split(string tempVariable)
        {
            tempVariable.Split();
        }

        private static void Replace(string tempVariable)
        {
            tempVariable.Replace('a','b');
        }

        private static void Remove(string tempVariable)
        {
            tempVariable.Remove(2);
        }

        private static void PadRight(string tempVariable)
        {
            var padRight = tempVariable.PadRight(5);
        }

        private static void PadLeft(string tempVariable)
        {
            var padLeft = tempVariable.PadLeft(5);
        }

        private static void Normalized(string tempVariable)
        {
           var normalized = tempVariable.Normalize();
           Console.WriteLine($"Normalized : {normalized}");
        }

        private static void Length(string tempVariable)
        {
            var lengt = tempVariable.Length;
            Console.WriteLine($"Length : {lengt}");
        }

        private static void LastIndexOf(string tempVariable)
        {
            Console.WriteLine("Please enter the character that check you want : ");
            var lastIndexOf = tempVariable.LastIndexOf(GetVariable());
            Console.WriteLine($"Last Index Of : {lastIndexOf}");
        }

        private static void IsNormalized(string tempVariable)
        {
            var isNormalized = tempVariable.IsNormalized();
            Console.WriteLine($"Is Normalized : {isNormalized}");
        }

        private static void Insert(string tempVariable)
        {
            Console.WriteLine("Please enter the character that you want");
            var insertChar = Console.ReadLine();
            Console.WriteLine("Please enter the index that you want");
            var insertIndexString = Console.ReadLine();
            int insertIndex = Convert.ToInt32(insertIndexString);
            var insert = tempVariable.Insert(insertIndex, insertChar);
            Console.WriteLine($"Insert: {insert}");

        }

        private static void IndexOf(string tempVariable)
        {
            Console.WriteLine("IndexOf methodu ile aranacak kelimeyi giriniz : ");
            var indexOf = Console.ReadLine();
            var index = tempVariable.IndexOf(indexOf);
            Console.WriteLine($"IndexOf : {index}");
        }

        private static void GetTypeCode(string tempVariable)
        {
            var getTypeCode = tempVariable.GetTypeCode();
            Console.WriteLine($"Get Type Code : {getTypeCode}");
        }

        private static void GetType(string tempVariable)
        {
            var getType = tempVariable.GetType();
            Console.WriteLine($"Get Type : {getType}");
        }

        private static void GetHashCode(string tempVariable)
        {
            var getHashCode = tempVariable.GetHashCode();
            Console.WriteLine($"Get Has Code : {getHashCode}");
        }

        private static void Equals(string tempVariable)
        {
            Console.WriteLine("Eşitlik kontrolü sağlanacak kelimeyi giriniz : ");
            var esitMiKontrol = Console.ReadLine();
            var equals = tempVariable.Equals(esitMiKontrol);
            Console.WriteLine($"Equals : {equals}");
        }

        private static void EndWith(string tempVariable)
        {
            var endWith = tempVariable.EndsWith('a');
            Console.WriteLine($"End With : {endWith}");
        }

        private static void Contains(string tempVariable)
        {
            Console.WriteLine("İçerde aranacak string değeri giriniz : ");
            var aranacakStringDeger = Console.ReadLine();
            var contains = tempVariable.Contains(aranacakStringDeger);
            Console.WriteLine($"Contains : {contains}");
        }

        private static void CompareTo(string tempVariable)
        {
            Console.WriteLine("Karşılaştırılacak kelimeyi giriniz : ");
            var karsilastirilacakKelime = Console.ReadLine();
            var compareTo = tempVariable.CompareTo(karsilastirilacakKelime);
            Console.WriteLine($"Compare To : {compareTo}");
        }

        private static void Clone(string tempVariable)
        {
            var clone = tempVariable.Clone();
            Console.WriteLine($"Clone : {clone}");
        }

        private static string GetVariable()
        {
            return Console.ReadLine();
        }

        private static void AsMemory(string tempVariable)
        {
            var asMemory = tempVariable.AsMemory();
            Console.WriteLine($"As Memory : {asMemory}");
        }

        private static void AsSpan(string tempVariable)
        {
            var asSpan = tempVariable.AsSpan();
            Console.WriteLine($"As Span: {asSpan.ToString()}");
        }
        
        

       

    }
}
