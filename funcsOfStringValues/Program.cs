using System;
using System.Collections.Generic;

namespace funcsOfStringValues
{
    class Program
    {

        /// Taylan Can Hardal All String funcs Project
 
        static void Main(string[] args)
        {
            #region AddingInfos

            List<Func> funcs = new List<Func>();

            Func AsMemory = new Func();
            AsMemory.func = "As Memory";
            AsMemory.funcDescription = "Creates a new ReadOnlyMemory<Char> over the portion of the target string.";
            funcs.Add(AsMemory);

            Func AsSpan = new Func();
            AsSpan.func = "As Span";
            AsSpan.funcDescription = "Creates a new read-only span over a portion of the target string from a specified position for a specified number of characters.";
            funcs.Add(AsSpan);

            Func Clone = new Func();
            Clone.func = "Clone";
            Clone.funcDescription = "Make clone of string..";
            funcs.Add(Clone);

            Func CompareTo = new Func();
            CompareTo.func = "Compare To";
            CompareTo.funcDescription = "Compare two strings and returns integer value as output. It returns 0 for true and 1 for false.";
            funcs.Add(CompareTo);

            Func Contains = new Func();
            Contains.func = "Contains";
            Contains.funcDescription = "The C# Contains method checks whether specified character or string is exists or not in the string value.";
            funcs.Add(Contains);

            Func CopyTo = new Func();
            CopyTo.func = "Copy To";
            CopyTo.funcDescription = "Copies a specified number of characters from a specified position in this instance to a specified position in an array of Unicode characters.";
            funcs.Add(CopyTo);

            Func EndsWith = new Func();
            EndsWith.func = "Ends With";
            EndsWith.funcDescription = "This EndsWith Method checks whether specified character is the last character of string or not.";
            funcs.Add(EndsWith);

            Func EnumerateRunes = new Func();
            EnumerateRunes.func = "Enumerate Runes";
            EnumerateRunes.funcDescription = " Returns an enumeration of System.Text.Rune from this string.";
            funcs.Add(EnumerateRunes);

            Func Equals = new Func();
            Equals.func = "Equals";
            Equals.funcDescription = "The Equals Method in C# compares two string and returns Boolean value as output.";
            funcs.Add(Equals);

            Func GetEnumerator = new Func();
            GetEnumerator.func = "Get Enumerator";
            GetEnumerator.funcDescription = " Retrieves an object that can iterate through the individual characters in this string";
            funcs.Add(GetEnumerator);

            Func GetHashCode = new Func();
            GetHashCode.func = "Get Hash Code";
            GetHashCode.funcDescription = "This method returns HashValue of specified string.";
            funcs.Add(GetHashCode);

            Func GetType = new Func();
            GetType.func = "Get Type";
            GetType.funcDescription = "It returns the System.Type of current instance.";
            funcs.Add(GetType);

            Func GetTypeCode = new Func();
            GetTypeCode.func = "Get Type Code";
            GetTypeCode.funcDescription = "It returns the Stystem.TypeCode for class System.String.";
            funcs.Add(GetTypeCode);

            Func IndexOf = new Func();
            IndexOf.func = "Index Of";
            IndexOf.funcDescription = "Returns the index position of first occurrence of specified character.";
            funcs.Add(IndexOf);

            Func IndexOfAny = new Func();
            IndexOfAny.func = "Index Of Any";
            IndexOfAny.funcDescription = "Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters.";
            funcs.Add(IndexOfAny);

            Func Insert = new Func();
            Insert.func = "Insert";
            Insert.funcDescription = "Insert the string or character in the string at the specified position.";
            funcs.Add(Insert);

            Func IsNormalized = new Func();
            IsNormalized.func = "Is Normalized";
            IsNormalized.funcDescription = "This method checks whether this string is in Unicode normalization form C.";
            funcs.Add(IsNormalized);

            Func LastIndexOf = new Func();
            LastIndexOf.func = "Last Index Of";
            LastIndexOf.funcDescription = "Returns the index position of last occurrence of specified character.";
            funcs.Add(LastIndexOf);

            Func LastIndexOfAny = new Func();
            LastIndexOfAny.func = "Last Index Of Any";
            LastIndexOfAny.funcDescription = " Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array.";
            funcs.Add(LastIndexOfAny);

            Func Length = new Func();
            Length.func = "Length";
            Length.funcDescription = "Gets the number of characters in the current System.String object.";
            funcs.Add(Length);

            Func Normalize = new Func();
            Normalize.func = "Normalize";
            Normalize.funcDescription = "Returns a new string whose textual value is the same as this string, but whose binary representation is in Unicode normalization form C.";
            funcs.Add(Normalize);

            Func PadLeft = new Func();
            PadLeft.func = "Pad Left";
            PadLeft.funcDescription = "Returns a new string that right-aligns the characters in this instance by padding them with spaces on the left, for a specified total length.";
            funcs.Add(PadLeft);

            Func PadRight = new Func();
            PadRight.func = "Pad Right";
            PadRight.funcDescription = "Returns a new string that left-aligns the characters in this string by padding them with spaces on the right, for a specified total length.";
            funcs.Add(PadRight);

            Func Remove = new Func();
            Remove.func = "Remove";
            Remove.funcDescription = "Returns a new string in which all the characters in the current instance, beginning at a specified position and continuing through the last position, have been deleted.";
            funcs.Add(Remove);

            Func Replace = new Func();
            Replace.func = "Replace";
            Replace.funcDescription = "Returns a new string in which all occurrences of a specified Unicode character in this instance are replaced with another specified Unicode character.";
            funcs.Add(Replace);

            Func Split = new Func();
            Split.func = "Split";
            Split.funcDescription = "Splits a string into a maximum number of substrings based on a specified delimiting character and, optionally, options. Splits a string into a maximum number of substrings based on the provided character separator, optionally omitting empty substrings from the result.";
            funcs.Add(Split);

            Func StartsWith = new Func();
            StartsWith.func = "Starts With";
            StartsWith.funcDescription = "Determines whether this string instance starts with the specified character.";
            funcs.Add(StartsWith);

            Func Substring = new Func();
            Substring.func = "Substring";
            Substring.funcDescription = "Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.";
            funcs.Add(Substring);

            Func ToCharArray = new Func();
            ToCharArray.func = "To Char Array";
            ToCharArray.funcDescription = "Copies the characters in this instance to a Unicode character array.";
            funcs.Add(ToCharArray);

            Func ToLower = new Func();
            ToLower.func = "To Lower";
            ToLower.funcDescription = "Returns a copy of this string converted to lowercase.";
            funcs.Add(ToLower);

            Func ToLowerInvariant = new Func();
            ToLowerInvariant.func = "To Lower Invariant";
            ToLowerInvariant.funcDescription = "Returns a copy of this String object converted to lowercase using the casing rules of the invariant culture.";
            funcs.Add(ToLowerInvariant);

            Func ToString = new Func();
            ToString.func = "To String";
            ToString.funcDescription = "Returns this instance of String; no actual conversion is performed.";
            funcs.Add(ToString);

            Func ToUpper = new Func();
            ToUpper.func = "To Upper";
            ToUpper.funcDescription = "Returns a copy of this string converted to uppercase.";
            funcs.Add(ToUpper);

            Func ToUpperInvariant = new Func();
            ToUpperInvariant.func = "To Upper Invariant";
            ToUpperInvariant.funcDescription = "Returns a copy of this String object converted to uppercase using the casing rules of the invariant culture.";
            funcs.Add(ToUpperInvariant);

            Func Trim = new Func();
            Trim.func = "Trim";
            Trim.funcDescription = "Removes all leading and trailing white-space characters from the current string.";
            funcs.Add(Trim);

            Func TrimEnd = new Func();
            TrimEnd.func = "Trim End";
            TrimEnd.funcDescription = "Removes all the trailing white-space characters from the current string.";
            funcs.Add(TrimEnd);

            Func TrimStart = new Func();
            TrimStart.func = "Trim Start";
            TrimStart.funcDescription = "Removes all the leading white-space characters from the current string.";
            funcs.Add(TrimStart);

            #endregion

            int selectFunc,counter=0;

            #region Main
           
            foreach (var func in funcs)
            {
                counter++;
                Console.WriteLine($"{counter}-) {func.func}");
            }

            Console.WriteLine("\nPlease select func you want to learn : ");
            selectFunc = Convert.ToInt32(GetVariable());
            Console.Clear();

            Console.WriteLine($"------{funcs[selectFunc - 1].func}------");
            Console.WriteLine($"{funcs[selectFunc - 1].funcDescription}");

            #endregion

            Console.WriteLine("\nPlease enter a sentence: ");
            string tempVariable = GetVariable();

            #region SelectFunc



            switch (selectFunc)
            {
                case 1:

                    AsMemoryFunc(tempVariable);

                    break;
                case 2:

                    AsSpanFunc(tempVariable);

                    break;
                case 3:

                    CloneFunc(tempVariable);

                    break;
                case 4:

                    CompareToFunc(tempVariable);

                    break;
                case 5:

                    ContainsFunc(tempVariable);

                    break;
                case 6:

                    CopyToFunc(tempVariable);

                    break;
                case 7:

                    EndsWithFunc(tempVariable);

                    break;
                case 8:

                    EnumerateRunesFunc(tempVariable);

                    break;
                case 9:

                    EqualsFunc(tempVariable);

                    break;
                case 10:

                    GetEnumeratorFunc(tempVariable);

                    break;
                case 11:

                    GetHashCodeFunc(tempVariable);

                    break;
                case 12:

                    GetTypeFunc(tempVariable);

                    break;
                case 13:

                    GetTypeCodeFunc(tempVariable);

                    break;
                case 14:

                    IndexOfFunc(tempVariable);

                    break;
                case 15:

                    IndexOfAnyFunc(tempVariable);

                    break;
                case 16:

                    InsertFunc(tempVariable);

                    break;
                case 17:

                    IsNormalizedFunc(tempVariable);

                    break;
                case 18:

                    LastIndexOfFunc(tempVariable);

                    break;
                case 19:

                    LastIndexOfAnyFunc(tempVariable);

                    break;
                case 20:

                    LengthFunc(tempVariable);

                    break;
                case 21:

                    NormalizeFunc(tempVariable);

                    break;
                case 22:

                    PadLeftFunc(tempVariable);

                    break;
                case 23:

                    PadRightFunc(tempVariable);

                    break;
                case 24:

                    RemoveFunc(tempVariable);

                    break;
                case 25:

                    ReplaceFunc(tempVariable);

                    break;
                case 26:

                    SplitFunc(tempVariable);

                    break;
                case 27:

                    StartsWithFunc(tempVariable);

                    break;
                case 28:

                    SubstringFunc(tempVariable);

                    break;
                case 29:

                    ToCharArrayFunc(tempVariable);

                    break;
                case 30:

                    ToLowerFunc(tempVariable);

                    break;
                case 31:

                    ToLowerInvariantFunc(tempVariable);

                    break;
                case 32:

                    ToStringFunc(tempVariable);

                    break;
                case 33:

                    ToUpperFunc(tempVariable);

                    break;
                case 34:

                    ToUpperInvariantFunc(tempVariable);

                    break;
                case 35:

                    TrimFunc(tempVariable);

                    break;
                case 36:

                    TrimEndFunc(tempVariable);

                    break;
                case 37:

                    TrimStartFunc(tempVariable);

                    break;
                default:
                    Console.WriteLine("Yanlış bir değer girdiniz lütfen tekrar giriniz");
                    break;
            }
            #endregion


        }


        private static void AsMemoryFunc(string tempVariable)
        {
            var asMemory = tempVariable.AsMemory();
            Console.WriteLine($"As Memory  : {asMemory}");

        }

        private static void AsSpanFunc(string tempVariable)
        {
            var asSpan = tempVariable.AsSpan();
            Console.WriteLine($"As Span  : {asSpan.Length}");
        }

        private static void CloneFunc(string tempVariable)
        {
            var clone = tempVariable.Clone();
            Console.WriteLine($"Clone : {clone}");
        }

        private static void CompareToFunc(string tempVariable)
        {
            Console.WriteLine("Please enter the word that you compare : ");
            var compareWord = Console.ReadLine();
            var compareTo = tempVariable.CompareTo(compareWord);
            Console.WriteLine($"Compare To : {compareTo}");
        }

        private static void ContainsFunc(string tempVariable)
        {
            Console.WriteLine("Please enter the word that you contain : ");
            var containsValue = Console.ReadLine();
            var contains = tempVariable.Contains(containsValue);
            Console.WriteLine($"Contains : {contains}");
        }

        private static void CopyToFunc(string tempVariable)
        {
            string a;
            char[] b = new char[2];
            //Console.WriteLine(tempVariable.CopyTo(2, b, 1, 1));
        }

        private static void EndsWithFunc(string tempVariable)
        {
            var endWith = tempVariable.EndsWith('a');
            Console.WriteLine($"End With : {endWith}");
        }

        private static void EnumerateRunesFunc(string tempVariable)
        {
            var enumerateRunes = tempVariable.EnumerateRunes();
            Console.WriteLine($"Enumerate Runes : {enumerateRunes}");
        }

        private static void EqualsFunc(string tempVariable)
        {
            Console.WriteLine("Eşitlik kontrolü sağlanacak kelimeyi giriniz : ");
            var esitMiKontrol = Console.ReadLine();
            var equals = tempVariable.Equals(esitMiKontrol);
            Console.WriteLine($"Equals : {equals}");
        }

        private static void GetEnumeratorFunc(string tempVariable)
        {
            var getEnumerator = tempVariable.GetEnumerator();
            Console.WriteLine($"Get Enumerator : {getEnumerator}");
        }

        private static void GetHashCodeFunc(string tempVariable)
        {
            var getHashCode = tempVariable.GetHashCode();
            Console.WriteLine($"Get Has Code : {getHashCode}");
        }

        private static void GetTypeFunc(string tempVariable)
        {
            var getType = tempVariable.GetType();
            Console.WriteLine($"Get Type : {getType}");
        }

        private static void GetTypeCodeFunc(string tempVariable)
        {
            var getTypeCode = tempVariable.GetTypeCode();
            Console.WriteLine($"Get Type Code : {getTypeCode}");
        }

        private static void IndexOfFunc(string tempVariable)
        {
            Console.WriteLine("IndexOf methodu ile aranacak kelimeyi giriniz : ");
            var indexOf = Console.ReadLine();
            var index = tempVariable.IndexOf(indexOf);
            Console.WriteLine($"IndexOf : {index}");
        }

        private static void IndexOfAnyFunc(string tempVariable)
        {
            char[] a = new char[1];
            var indexOfAny = tempVariable.IndexOfAny(a);
            Console.WriteLine($"Index Of Any : {indexOfAny}");
        }

        private static void InsertFunc(string tempVariable)
        {
            Console.WriteLine("Please enter the character that you want");
            var insertChar = Console.ReadLine();
            Console.WriteLine("Please enter the index that you want");
            var insertIndexString = Console.ReadLine();
            int insertIndex = Convert.ToInt32(insertIndexString);
            var insert = tempVariable.Insert(insertIndex, insertChar);
            Console.WriteLine($"Insert: {insert}");
        }

        private static void IsNormalizedFunc(string tempVariable)
        {
            var isNormalized = tempVariable.IsNormalized();
            Console.WriteLine($"Is Normalized : {isNormalized}");
        }

        private static void LastIndexOfFunc(string tempVariable)
        {
            Console.WriteLine("Please enter the character that check you want : ");
            var lastIndexOf = tempVariable.LastIndexOf(GetVariable());
            Console.WriteLine($"Last Index Of : {lastIndexOf}");
        }

        private static void LastIndexOfAnyFunc(string tempVariable)
        {
            char[] a = new char[1];
            var lastIndexOfAny = tempVariable.LastIndexOfAny(a);
            Console.WriteLine($"Last Index Of Any : {lastIndexOfAny}");
        }

        private static void LengthFunc(string tempVariable)
        {
            var lengt = tempVariable.Length;
            Console.WriteLine($"Length : {lengt}");
        }

        private static void NormalizeFunc(string tempVariable)
        {
            var normalized = tempVariable.Normalize();
            Console.WriteLine($"Normalize : {normalized}");
        }

        private static void PadLeftFunc(string tempVariable)
        {
            var padLeft = tempVariable.PadLeft(5);
        }

        private static void PadRightFunc(string tempVariable)
        {
            var padRight = tempVariable.PadRight(5);
        }

        private static void RemoveFunc(string tempVariable)
        {
            tempVariable.Remove(2);
        }

        private static void ReplaceFunc(string tempVariable)
        {
            tempVariable.Replace('a', 'b');
        }

        private static void SplitFunc(string tempVariable)
        {
            tempVariable.Split();
        }

        private static void StartsWithFunc(string tempVariable)
        {
            Console.WriteLine("Please enter the char that check you want");
            var startChar = GetVariable();
            var startsWith = tempVariable.StartsWith(startChar);
            Console.WriteLine($"Starts With : {startsWith}");
        }

        private static void SubstringFunc(string tempVariable)
        {
            tempVariable.Substring(1);
        }

        private static void ToCharArrayFunc(string tempVariable)
        {
            var toCharArray = tempVariable.ToCharArray();
            Console.WriteLine($"To Char Array :  {toCharArray}");
        }

        private static void ToLowerFunc(string tempVariable)
        {
            tempVariable.ToLower();
        }

        private static void ToLowerInvariantFunc(string tempVariable)
        {
            var toLowerInvariant = tempVariable.ToLowerInvariant();
            Console.WriteLine($"To Lower Invariant : {toLowerInvariant}");
        }

        private static void ToStringFunc(string tempVariable)
        {
            var toString = tempVariable.ToString();
            Console.WriteLine($"To String : {toString}");
        }

        private static void ToUpperFunc(string tempVariable)
        {
            tempVariable.ToUpper();
        }

        private static void ToUpperInvariantFunc(string tempVariable)
        {
            var toUpperInvariant = tempVariable.ToUpperInvariant();
            Console.WriteLine($"To Upper Invariant : {toUpperInvariant}");
        }

        private static void TrimFunc(string tempVariable)
        {
            var trim = tempVariable.Trim();
            Console.WriteLine($"Trim : {trim}");
        }

        private static void TrimEndFunc(string tempVariable)
        {
            var trimEnd = tempVariable.TrimEnd();
            Console.WriteLine($"Trim End : {trimEnd}");
        }

        private static void TrimStartFunc(string tempVariable)
        {
            var trimStart = tempVariable.TrimStart();
            Console.WriteLine($"Trim Start : {trimStart}");
        }

        private static string GetVariable()
        {
            return Console.ReadLine();
        }
      
    }
}