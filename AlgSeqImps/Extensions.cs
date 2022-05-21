using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgSeqImps
{
    public static class Extensions
    {
        public static int Lcp(this string a, string b)
        {
            int i;
            for (i = 0; i < a.Length && i < b.Length; i++)
            {
                if (a[i] != b[i])
                    break;
            }

            return i;
        }
        public static int Lcpi(this string a, int i)
        {
            return Lcp(a, a[i..]);
        }


        //public static List<int> AllIndexesOf(this string str, string value)
        //{
        //    if (String.IsNullOrEmpty(value))
        //        throw new ArgumentException("the string to find may not be empty", "value");
        //    List<int> indexes = new List<int>();
        //    for (int index = 0; ; index += value.Length)
        //    {
        //        index = str.IndexOf(value, index);
        //        if (index == -1)
        //            return indexes;
        //        indexes.Add(index);
        //    }
        //}
        //public static bool ContainsOneOf(this string str, string[] tests)
        //{
        //    foreach (string s in tests)
        //        if (str.Contains(s))
        //            return true;
        //    return false;
        //}
        //public static bool ContainsAllOf(this string str, string[] tests)
        //{
        //    foreach (string s in tests)
        //        if (!str.Contains(s))
        //            return false;
        //    return true;
        //}
        //public static string GetEverythingBetween(this string str, string left, string right)
        //{
        //    int leftIndex = str.IndexOf(left);
        //    int rightIndex = str.IndexOf(right, leftIndex == -1 ? 0 : leftIndex + left.Length);

        //    if (right == "")
        //        rightIndex = str.Length - 1;

        //    if (left == "")
        //        leftIndex = 0;

        //    if (leftIndex == -1 || rightIndex == -1 || leftIndex + left.Length > rightIndex)
        //    {
        //        //throw new Exception("String doesnt contain left or right borders!");
        //        return "";
        //    }

        //    try
        //    {
        //        string re = str.Remove(0, leftIndex + left.Length);
        //        re = re.Remove(rightIndex - leftIndex - left.Length);
        //        return re;
        //    }
        //    catch
        //    {
        //        return "";
        //    }
        //}
        //public static List<string> GetEverythingBetweenAll(this string str, string left, string right)
        //{
        //    List<string> re = new List<string>();

        //    int leftIndex = str.IndexOf(left);
        //    int rightIndex = str.IndexOf(right, leftIndex == -1 ? 0 : leftIndex + 1);

        //    if (leftIndex == -1 || rightIndex == -1 || leftIndex > rightIndex)
        //    {
        //        return re;
        //    }

        //    while (leftIndex != -1 && rightIndex != -1)
        //    {
        //        try
        //        {
        //            str = str.Remove(0, leftIndex + left.Length);
        //            re.Add(str.Remove(rightIndex - leftIndex - left.Length));
        //            str = str.Remove(0, rightIndex - leftIndex - right.Length - left.Length);
        //        }
        //        catch { break; }

        //        leftIndex = str.IndexOf(left);
        //        rightIndex = str.IndexOf(right, leftIndex == -1 ? 0 : leftIndex + 1);
        //    }

        //    return re;
        //}
        //public static bool StartsWith(this string str, string[] values)
        //{
        //    foreach (string s in values)
        //        if (str.StartsWith(s))
        //            return true;
        //    return false;
        //}
        //public static string Combine(this IEnumerable<string> s, string combinator = "")
        //{
        //    return s.Count() == 0 ? "" : s.Foldl("", (x, y) => x + combinator + y).Remove(0, combinator.Length);
        //}
        //public static string RemoveLastGroup(this string s, char seperator)
        //{
        //    string[] split = s.Split(seperator);
        //    return split.Take(split.Length - 1).Foldl("", (a, b) => a + seperator + b).Remove(0, 1);
        //}

        //public static b Foldl<a, b>(this IEnumerable<a> xs, b y, Func<b, a, b> f)
        //{
        //    foreach (a x in xs)
        //        y = f(y, x);
        //    return y;
        //}
        //public static b Foldl<a, b>(this IEnumerable<a> xs, Func<b, a, b> f)
        //{
        //    return xs.Foldl(default, f);
        //}
        //public static a MaxElement<a>(this IEnumerable<a> xs, Func<a, double> f) { return xs.MaxElement(f, out double _); }
        //public static a MaxElement<a>(this IEnumerable<a> xs, Func<a, double> f, out double max)
        //{
        //    max = double.MinValue; a maxE = default;
        //    foreach (a x in xs)
        //    {
        //        double res = f(x);
        //        if (res > max)
        //        {
        //            max = res;
        //            maxE = x;
        //        }
        //    }
        //    return maxE;
        //}
        //public static a MinElement<a>(this IEnumerable<a> xs, Func<a, double> f) { return xs.MinElement(f, out double _); }
        //public static a MinElement<a>(this IEnumerable<a> xs, Func<a, double> f, out double min)
        //{
        //    min = double.MaxValue; a minE = default;
        //    foreach (a x in xs)
        //    {
        //        double res = f(x);
        //        if (res < min)
        //        {
        //            min = res;
        //            minE = x;
        //        }
        //    }
        //    return minE;
        //}
        //public static bool ContainsAny<a>(this IEnumerable<a> xs, params a[] ys)
        //{
        //    foreach (a y in ys)
        //        if (xs.Contains(y))
        //            return true;
        //    return false;
        //}
    }
}
